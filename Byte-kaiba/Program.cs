namespace Byte_kaiba {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Converts raw byte length into human readable version.
        /// </summary>
        /// <param name="byt">A raw byte length.</param>
        /// <returns>Returns a human-readable byte length.</returns>
        internal static string CalculateBytes(long byt) {
            double DoubleBytes;
            try {
                switch (byt) {
                    case long n when n >= 1099511627776: {
                        DoubleBytes = Convert.ToDouble(byt / (double)1099511627776);
                        return Math.Round(DoubleBytes, 2).ToString() + " TB";
                    }

                    case long n when 1073741824 <= n && n <= 1099511627775: {
                        DoubleBytes = Convert.ToDouble(byt / (double)1073741824);
                        return Math.Round(DoubleBytes, 2).ToString() + " GB";
                    }

                    case long n when 1048576 <= n && n <= 1073741823: {
                        DoubleBytes = Convert.ToDouble(byt / (double)1048576);
                        return Math.Round(DoubleBytes, 2).ToString() + " MB";
                    }

                    case long n when 1024 <= n && n <= 1048575: {
                        DoubleBytes = Convert.ToDouble(byt / (double)1024);
                        return Math.Round(DoubleBytes, 2).ToString() + " KB";
                    }

                    case long n when 0 <= n && n <= 1023: {
                        DoubleBytes = n;
                        return Math.Round(DoubleBytes, 2).ToString() + " bytes";
                    }

                    default: {
                        return "0 bytes";
                    }
                }
            } catch {
                return "0 bytes";
            }
        }
    }
}