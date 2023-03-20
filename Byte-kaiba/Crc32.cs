using System.Security.Cryptography;

namespace Byte_kaiba {
    internal class Crc32 : HashAlgorithm {
        public const uint DefaultPolynomial = 0xedb88320u;
        public const uint DefaultSeed = 0xffffffffu;

        private uint _hash;
        private readonly uint _seed;
        private readonly uint[] _table;

        public Crc32(uint polynomial = DefaultPolynomial, uint seed = DefaultSeed) {
            _seed = seed;
            _table = InitializeTable(polynomial);
            _hash = _seed;
        }

        public static uint Compute(byte[] buffer) {
            return Compute(DefaultSeed, DefaultPolynomial, buffer);
        }

        public static uint Compute(uint seed, uint polynomial, byte[] buffer) {
            return ComputeHash(new Crc32(polynomial, seed), buffer);
        }

        private static uint ComputeHash(HashAlgorithm hashAlgorithm, byte[] buffer) {
            return BitConverter.ToUInt32(hashAlgorithm.ComputeHash(buffer), 0);
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize) {
            _hash = CalculateHash(_table, _hash, array, ibStart, cbSize);
        }

        protected override byte[] HashFinal() {
            var hashBuffer = UInt32ToBigEndianBytes(~_hash);
            HashValue = hashBuffer;
            return hashBuffer;
        }

        public override void Initialize() {
            _hash = _seed;
        }

        private static uint[] InitializeTable(uint polynomial) {
            var table = new uint[256];

            for (uint i = 0; i < 256; i++) {
                var entry = i;
                for (var j = 0; j < 8; j++) {
                    if ((entry & 1) == 1) {
                        entry = (entry >> 1) ^ polynomial;
                    } else {
                        entry >>= 1;
                    }
                }
                table[i] = entry;
            }

            return table;
        }

        private static uint CalculateHash(uint[] table, uint seed, byte[] buffer, int start, int size) {
            var hash = seed;
            for (var i = start; i < start + size; i++) {
                hash = (hash >> 8) ^ table[buffer[i] ^ hash & 0xff];
            }
            return hash;
        }

        private static byte[] UInt32ToBigEndianBytes(uint value) {
            var result = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) {
                Array.Reverse(result);
            }
            return result;
        }
    }
}
