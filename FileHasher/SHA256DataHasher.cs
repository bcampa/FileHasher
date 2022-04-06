using System;
using System.Security.Cryptography;

namespace FileHasher
{
    public class SHA256DataHasher : IDataHasher
    {
        public string GetHash(byte[] data)
        {
            var sha = SHA256.Create();
            byte[] digest = sha.ComputeHash(data);
            string base64digest = Convert.ToBase64String(digest);
            return base64digest.Substring(0, base64digest.Length - 2);
        }
    }
}
