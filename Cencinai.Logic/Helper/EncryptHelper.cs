using System;
using System.Security.Cryptography;
using System.Text;

namespace Cencinai.Logic.Helper
{
    public class EncryptHelper
    {
        public static string GetHashPassword(string password)
        {
            byte[] hash;
            using (MD5 md5 = MD5.Create())
            {
                md5.Initialize();
                md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                hash = md5.Hash;
            }

            string bitString = BitConverter.ToString(hash);
            return bitString;
        }
    }
}
