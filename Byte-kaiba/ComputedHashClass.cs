using System.ComponentModel;
using System.Security.Cryptography;

namespace Byte_kaiba {

    /// <summary>
    /// A class containing computed hashed of a provided <see cref="FileInfo"/>.
    /// </summary>
    internal class ComputedHashClass {

        /// <summary>
        /// Instantiate a new <see cref="ComputedHashClass"/> object, with computed hashes.
        /// </summary>
        /// <param name="f">A <see cref="FileInfo"/> object to be computed.</param>
        /// <remarks>
        /// Must instantiate this class inside the thread to prevent GUI freezing while calculating.
        /// </remarks>
        internal ComputedHashClass(FileInfo f) {
            File = f;
            using FileStream fs = f.OpenRead();
            SHA1Result = ComputeHash(fs, SHA1.Create(), 0, 5);
            SHA256Result = ComputeHash(fs, SHA256.Create(), 1, 5);
            SHA512Result = ComputeHash(fs, SHA512.Create(), 2, 5);
            MD5Result = ComputeHash(fs, MD5.Create(), 3, 5);
            CRC32Result = ComputeHash(fs, new Crc32(), 4, 5);
        }

        /// <summary>
        /// Gets the current <see cref="FileInfo"/>.
        /// </summary>
        internal FileInfo File { get; private set; }

        /// <summary>
        /// Gets the SHA1 computed result.
        /// </summary>
        internal string? SHA1Result { get; private set; }

        /// <summary>
        /// Gets the SHA256 computed result.
        /// </summary>
        internal string? SHA256Result { get; private set; }

        /// <summary>
        /// Gets the SHA512 computed result.
        /// </summary>
        internal string? SHA512Result { get; private set; }

        /// <summary>
        /// Gets the MD5 computed result.
        /// </summary>
        internal string? MD5Result { get; private set; }

        /// <summary>
        /// Gets the CRC32 computed result.
        /// </summary>
        internal string? CRC32Result { get; private set; }

        /// <summary>
        /// Performs a computation hash, based on <see cref="HashAlgorithm"/> provider.
        /// </summary>
        /// <param name="fs">A current <see cref="FileStream"/>.</param>
        /// <param name="hash">A <see cref="HashAlgorithm"/>-related object.</param>
        /// <param name="value">A value where the current progress is ongoing.</param>
        /// <param name="goal">A value determines the maximum progress.</param>
        /// <returns>Returns a <seealso cref="string"/> containing computed hash, or 'Invalid' if error occurs.</returns>
        /// <remarks>
        /// This method never closes the stream after computation, and it resets the position back to zero.
        /// </remarks>
        private string ComputeHash(FileStream fs, HashAlgorithm hash, int value = 0, int goal = 0) {
            string result;
            try {
                if (hash == null) throw new ArgumentNullException(nameof(hash));
                string? name = TypeDescriptor.GetClassName(hash);
                if (string.IsNullOrEmpty(name)) name = "unknown";
                int index = name.LastIndexOf('.');
                name = index >= 0 ? name[(index + 1)..] : name;

                Comparator.PassThroughComparisonOngoing("Computing hash of " + File.Name + " (" + name + " Compute)...", value, goal);
                result = BitConverter.ToString(hash.ComputeHash(fs)).Replace("-", "");
                hash.Dispose();
            } catch { result = "Invalid"; }
            fs.Position = 0;
            return result;
        }
    }
}
