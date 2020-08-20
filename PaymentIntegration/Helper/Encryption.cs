using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PaymentIntegration.Helper
{
    public class Encryption
    {
        public static string Encrypt(string data, string keyword)
        {
            if (string.IsNullOrEmpty(data))
                return string.Empty;

            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(keyword));
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.Key = TDESKey;
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(data);
            try
            {
                ICryptoTransform Encryptor = aes.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                aes.Clear();
                HashProvider.Clear();
            }
            return Convert.ToBase64String(Results);
        }
    }
}
