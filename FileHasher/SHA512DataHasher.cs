using System;
using System.Security.Cryptography;

namespace FileHasher
{
    public class SHA512DataHasher : IDataHasher
    {
        public string GetHash(byte[] data)
        {
            var sha = SHA512.Create();
            byte[] digest = sha.ComputeHash(data);
            string base64digest = Convert.ToBase64String(digest);
            return base64digest.Substring(0, base64digest.Length - 2);
        }
    }
}
