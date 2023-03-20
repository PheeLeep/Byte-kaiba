using System.Text;

namespace Byte_kaiba {

    /*
     * Dev's note:
     * 
     *      Apologize for the cringe code in this class I made of. But it
     * should be note that it works somehow, but it depends on what computer
     * that a program is running on or the current conditions. If some 
     * mishaps occur, please let me know on the Issues tab of this repo.
     * 
     * Thanks
     * 
     * - PheeLeep
     */

    /// <summary>
    /// A class containing file and byte comparison methods.
    /// </summary>
    internal static class Comparator {

        /// <summary>
        /// A method used on passing an exception of the event, instead of throwing inside the <see cref="Comparator"/>.
        /// </summary>
        /// <param name="ex"></param>
        internal delegate void ExceptionOccurredDelegate(Exception ex);

        /// <summary>
        /// A method used on invoking event when <see cref="IsOngoingChanged"/>
        /// </summary>
        internal delegate void IsOngoingChangedDelegate();

        /// <summary>
        /// A method used on passing a status text during file comparison.
        /// </summary>
        /// <param name="text">A status text.</param>
        /// <param name="current">The current progress.</param>
        /// <param name="goal">A goal progress value.</param>
        internal delegate void ComparisonOngoingDelegate(string text, int current = 0, int goal = 0);

        /// <summary>
        /// A method used on passing result when comparison is completed.
        /// </summary>
        /// <param name="similarPerce">A percentage of the similarities of a two files.</param>
        /// <param name="lenDifference">
        /// A value that measures the differences of two files in length. (Calculation: <see cref="File1"/>'s length - <see cref="File2"/>'s length)
        /// </param>
        /// <param name="bytesDiffered">A value that measures the differences of two files in bytes.</param>
        internal delegate void ComparisonCompletedDelegate(decimal similarPerce, decimal lenDifference, decimal bytesDiffered);

        /// <summary>
        /// A method used when passing results on two files' when <see cref="PageReadFiles(decimal)"/> finishes.
        /// </summary>
        /// <param name="result1">An object that was read from <see cref="File1"/>, and its difference.</param>
        /// <param name="result2">An object that was read from <see cref="File2"/>, and its difference.</param>
        internal delegate void LoadHexValuesDelegate(PagingFileResult result1, PagingFileResult result2);

        private static bool _isOngoing = false;
        private static FileInfo? _f1;
        private static FileInfo? _f2;
        private static FileStream? fs1;
        private static FileStream? fs2;

        /// <summary>
        /// Fires an event when an <see cref="Exception"/> occurs inside the thread of this class.
        /// </summary>
        internal static event ExceptionOccurredDelegate? ExceptionOccurred;

        /// <summary>
        /// Occurs when <see cref="IsOngoing"/> changed.
        /// </summary>
        internal static event IsOngoingChangedDelegate? IsOngoingChanged;

        /// <summary>
        /// Occurs during the process in <see cref="Compare(FileInfo, FileInfo)"/> method.
        /// </summary>
        internal static event ComparisonOngoingDelegate? ComparisonOngoing;

        /// <summary>
        /// Occurs when <see cref="Compare(FileInfo, FileInfo)"/>'s process completes, with provided results.
        /// </summary>
        internal static event ComparisonCompletedDelegate? ComparisonCompleted;

        /// <summary>
        /// Occurs when reading a files' chunk and comparison completes.
        /// </summary>
        internal static event LoadHexValuesDelegate? LoadHexValues;

        /// <summary>
        /// Gets the value when the process is completed or not.
        /// </summary>
        internal static bool IsOngoing {
            get => _isOngoing;
            private set {
                if (_isOngoing == value) return;
                _isOngoing = value;
                IsOngoingChanged?.Invoke();
            }
        }

        /// <summary>
        /// Gets the first file.
        /// </summary>
        internal static FileInfo? File1 => _f1;

        /// <summary>
        /// Gets the second file.
        /// </summary>
        internal static FileInfo? File2 => _f2;

        /// <summary>
        /// Gets the computed hashes from <see cref="File1"/>.
        /// </summary>
        internal static ComputedHashClass? Computed1 { get; private set; }

        /// <summary>
        /// Gets the computed hashes from <see cref="File2"/>.
        /// </summary>
        internal static ComputedHashClass? Computed2 { get; private set; }

        /// <summary>
        /// Gets the number of pages per 1kb (1024 bytes), in index.
        /// </summary>
        internal static long TotalPagesIndex { get; private set; }

        /// <summary>
        /// Performs a file comparison of a two provided files.
        /// </summary>
        /// <param name="varF1">A first file to compare.</param>
        /// <param name="varF2">A second file to differentiate against the first file.</param>
        /// <param name="requireComputeHash">A value determine if the program should perform compute hash.</param>
        internal static void Compare(FileInfo varF1, FileInfo varF2, bool requireComputeHash = true) {
            if (_isOngoing) return;
            new Thread(() => TaskCompare(varF1, varF2, requireComputeHash)).Start();
        }

        /// <summary>
        /// Clears the current properties attached to this class.
        /// </summary>
        internal static void Clear() {
            if (_isOngoing) return;
            IsOngoing = true;

            if (_f1 == null || _f2 == null) {
                IsOngoing = false;
                return;
            }
            try {
                Computed1 = null;
                Computed2 = null;
                fs1?.Close();
                fs2?.Close();
                _f1 = null;
                _f2 = null;
                TotalPagesIndex = 0;
            } catch (Exception ex) {
                ExceptionOccurred?.Invoke(ex);
            }
            IsOngoing = false;
        }

        /// <summary>
        /// Performs a file comparison in thread operation.
        /// </summary>
        /// <param name="varF1">A first file to compare.</param>
        /// <param name="varF2">A second file to differentiate against the first file.</param>
        /// <param name="requireComputeHash">A value determine if the program should perform compute hash.</param>
        /// <exception cref="InvalidOperationException"></exception>
        private static void TaskCompare(FileInfo varF1, FileInfo varF2, bool requireComputeHash = true) {
            IsOngoing = true;
            try {
                Thread.Sleep(500); // Wait for a while for the sake of the GUI.
                ComparisonOngoing?.Invoke("Checking files...");
                if (varF1 == null || varF2 == null)
                    throw new InvalidOperationException("No file selected.");

                if (_f1 != null || _f2 == null) {
                    ComparisonOngoing?.Invoke("Clearing up the previous result...");
                    fs1?.Close();
                    fs2?.Close();
                }

                _f1 = varF1;
                _f2 = varF2;
                Computed1 = null;
                Computed2 = null;

                if (requireComputeHash) {
                    ComparisonOngoing?.Invoke("Computing hash of " + _f1.Name + "...");
                    Computed1 = new(_f1);
                    ComparisonOngoing?.Invoke("Computing hash of " + _f2.Name + "...");
                    Computed2 = new(_f2);
                }

                ComparisonOngoing?.Invoke("Comparing file size length...");
                long lengthDiff = _f1.Length - _f2.Length;
                decimal bytDiffs = 0;
                TotalPagesIndex = (long)Math.Ceiling((decimal)(_f1.Length >= _f2.Length ? _f1.Length : _f2.Length) / 1024) - 1;

                ComparisonOngoing?.Invoke("Opening file streams...");
                fs1 = _f1.Open(FileMode.Open, FileAccess.Read, FileShare.None);
                fs2 = _f2.Open(FileMode.Open, FileAccess.Read, FileShare.None);

                decimal sameBytes = 0;
                decimal totalLen = 0;
                long pages = 0;
                while (fs1.Position != fs1.Length || fs2.Position != fs2.Length) {
                    byte[] b1 = ReadStream(fs1, 1024);
                    byte[] b2 = ReadStream(fs2, 1024);
                    for (int i = 0; i < 1024; i++) {
                        if (i >= b1.Length && 1 >= b2.Length) break;
                        int bit1 = -1;
                        int bit2 = -1;
                        if (i < b1.Length) bit1 = b1[i];
                        if (i < b2.Length) bit2 = b2[i];
                        if (bit1 == bit2) sameBytes++;
                        totalLen++;
                    }
                    pages++;
                    int progress = (int)(TotalPagesIndex == 0 ? 0 : pages * 100 / TotalPagesIndex);
                    if (progress > 100) progress = 100;
                    ComparisonOngoing?.Invoke("Start file comparison... This may take a while.", progress, 100);
                }

                bytDiffs = totalLen - sameBytes;
                decimal totalPercentage = Math.Round(sameBytes / totalLen * 100, 2);
                ComparisonOngoing?.Invoke("Comparison Completed.");
                ComparisonCompleted?.Invoke(totalPercentage, lengthDiff, bytDiffs); // Pass the result.
            } catch (Exception ex) {
                ComparisonOngoing?.Invoke("Comparison failed! (" + ex.Message + ")");
                ExceptionOccurred?.Invoke(ex);
            }
            ComparisonOngoing?.Invoke("Done.");
            IsOngoing = false;
        }

        /// <summary>
        /// Reads two files' chunk (1024 bytes) in paging mechanism.
        /// </summary>
        /// <param name="page">A page number to be read in index.</param>
        internal static void PageReadFiles(long pageIndex) {
            if (_isOngoing) return;
            new Thread(() => ThreadPageReadFiles(pageIndex)).Start();
        }

        /// <summary>
        /// Reads two files' chunk (1024 bytes) in paging mechanism, compare, and convert as ASCII.
        /// </summary>
        /// <param name="pageIndex">A page number to be read in index.</param>
        private static void ThreadPageReadFiles(long pageIndex) {
            try {
                _isOngoing = true;
                if (fs1 == null || fs2 == null) {
                    ExceptionOccurred?.Invoke(new InvalidOperationException("No streams found."));
                    return;
                }

                // Checks if the provided page index was out of bounds
                // If found, it will set on either end, depending on the provided pageIndex.
                if (pageIndex < 0) pageIndex = 0;
                if (pageIndex > TotalPagesIndex) pageIndex = TotalPagesIndex;

                // Set position of two files, based on setPos. If it's greater than or
                // equal to the length, decrement into 1kb.
                long setPos = 1024 * pageIndex;
                ReseatPosition(fs1, setPos);
                ReseatPosition(fs2, setPos);
                bool isFirstFS = fs1.Length >= fs2.Length;
                // Dirty initializations.
                List<string> buffer1 = new();
                List<string> buffer2 = new();
                List<bool> bytDiffs = new();
                List<string> asciis1 = new();
                List<string> asciis2 = new();
                List<string> offsets = new();

                for (int i = 0; i < 64; i++) {
                    StringBuilder sb1 = new();
                    StringBuilder sb2 = new();
                    List<int> b1Array = new();
                    List<int> b2Array = new();

                    bool isSame = true;

                    // Loop 16 times or breaks if EOF.
                    for (int j = 0; j < 16; j++) {
                        int b1 = fs1.ReadByte();
                        int b2 = fs2.ReadByte();

                        if (b1 == -1 && b2 == -1) break; // Break if both are EOF (End of File)
                        b1Array.Add(b1);
                        b2Array.Add(b2);
                        sb1.Append(b1 != -1 ? b1.ToString("X2").PadLeft(2, '0') : "XX");
                        sb2.Append(b2 != -1 ? b2.ToString("X2").PadLeft(2, '0') : "XX");
                        if (j < 15) {
                            sb1.Append(' ');
                            sb2.Append(' ');
                        }
                        if (isSame && b1 != b2) isSame = false;
                    }

                    if (b1Array.Count > 0 && b2Array.Count > 0) {
                        buffer1.Add(sb1.ToString());
                        buffer2.Add(sb2.ToString());
                        bytDiffs.Add(isSame);
                        asciis1.Add(ConvertToAscii(b1Array.ToArray()));
                        asciis2.Add(ConvertToAscii(b2Array.ToArray()));

                        long offset = (isFirstFS ? fs1 : fs2).Position - 16;
                        if (offset < 0) offset = 0;
                        offsets.Add(offset.ToString("X2").PadLeft(10, '0'));
                    }
                }
                string[] offArray = offsets.ToArray();

                // Store results to PagingFileResults.
                PagingFileResult p1 = new() {
                    ByteDifferenceValue = bytDiffs.ToArray(),
                    Offset = offArray,
                    ByteArrayValue = buffer1.ToArray(),
                    ASCIIResult = asciis1.ToArray()
                };
                PagingFileResult p2 = new() {
                    ByteDifferenceValue = bytDiffs.ToArray(),
                    Offset = offArray,
                    ByteArrayValue = buffer2.ToArray(),
                    ASCIIResult = asciis2.ToArray()
                };

                // Pass the result, and clear it out to free resources.
                LoadHexValues?.Invoke(p1, p2);
                asciis1.Clear();
                asciis2.Clear();
                offsets.Clear();
                bytDiffs.Clear();
                buffer1.Clear();
                buffer2.Clear();

            } catch (Exception ex) {
                ExceptionOccurred?.Invoke(ex);
            }
            _isOngoing = false;
        }

        /// <summary>
        /// Pass the arguments to invoke <see cref="ComparisonOngoing"/> from the outside of this class.
        /// </summary>
        /// <param name="progress">A status text.</param>
        /// <param name="value">The current progress.</param>
        /// <param name="goal">A goal progress value.</param>
        internal static void PassThroughComparisonOngoing(string progress, int value = 0, int goal = 0) {
            ComparisonOngoing?.Invoke(progress, value, goal);
        }

        /// <summary>
        /// Setting a new position of <see cref="FileStream"/>.
        /// </summary>
        /// <param name="fs">A current <see cref="FileStream"/>.</param>
        /// <param name="position">
        /// A position to be set. If the provided value is greater than or equal to provided <see cref="FileStream"/>,
        /// it will decrement to 1kb.
        /// </param>
        private static void ReseatPosition(FileStream fs, long position) {
            fs.Position = position >= fs.Length ? position - 1024 : position;
        }

        /// <summary>
        /// Reads a stream in specified byte length.
        /// </summary>
        /// <param name="fs">A current <see cref="FileStream"/>.</param>
        /// <param name="length">A specified byte length.</param>
        /// <returns>Returns a byte array with less than or equal to size provided in <paramref name="length"/>.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static byte[] ReadStream(FileStream fs, int length) {
            if (fs == null) throw new ArgumentNullException(nameof(fs));
            if (fs.Length == fs.Position) return Array.Empty<byte>();
            long len = fs.Length - fs.Position;
            if (len >= length) len = length;
            byte[] buffer = new byte[len];
            fs.Read(buffer, 0, buffer.Length);
            return buffer;
        }

        /// <summary>
        /// Converts an array of integer, into an ASCII string.
        /// </summary>
        /// <param name="ints">An array of integer.</param>
        /// <returns>Returns the ASCII string.</returns>
        private static string ConvertToAscii(int[] ints) {
            StringBuilder sb = new();
            foreach (int i in ints) {
                if (i < 0) {
                    sb.Append('x');
                    continue;
                }
                sb.Append(i >= 32 && i <= 126 ? Convert.ToChar(i) : '.');
            }
            return sb.ToString();
        }

        /// <summary>
        /// A class that handles the current result from <see cref="PageReadFiles(long)"/>.
        /// </summary>
        internal class PagingFileResult {

            /// <summary>
            /// Instantiate a new <see cref="PagingFileResult"/> object.
            /// </summary>
            internal PagingFileResult() {
                Offset = Array.Empty<string>();
                ByteArrayValue = Array.Empty<string>();
                ByteDifferenceValue = Array.Empty<bool>();
                ASCIIResult = Array.Empty<string>();
            }

            /// <summary>
            /// An array of offset string in hexadecimal.
            /// </summary>
            internal string[] Offset { get; set; }

            /// <summary>
            /// A 2-dimensional array of integers of a specified file.
            /// </summary>
            internal string[] ByteArrayValue { get; set; }

            /// <summary>
            /// A 2-dimensional array of values denoting the differences, after comparing two files.
            /// </summary>
            internal bool[] ByteDifferenceValue { get; set; }

            /// <summary>
            /// An array of ASCII strings.
            /// </summary>
            internal string[] ASCIIResult { get; set; }
        }
    }
}
