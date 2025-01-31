using System;

namespace apesa_test.Utils
{
    public class GenericUtils
    {
        private static readonly Random _random = new Random();
        public static string GenerateUniqueId(int length = 6)
        {
            if (length < 6) throw new ArgumentException("El minimo de caracteres es 6", nameof(length));

            var timestamp = DateTime.UtcNow.ToString("yyyyMMdd");
            var randomPartLength = length - 6;

            var randomPart = new char[randomPartLength];
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            for (int i = 0; i < randomPart.Length; i++)
            {
                randomPart[i] = chars[_random.Next(chars.Length)];
            }

            return timestamp.Substring(timestamp.Length - 6) + new string(randomPart);
        }
    }
}
