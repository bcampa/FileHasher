using System;
using System.Security.Cryptography;

namespace FileHasher
{
    public class MD5DataHasher : IDataHasher
    {
        public string GetHash(byte[] data)
        {
            var md5 = MD5.Create();
            byte[] digest = md5.ComputeHash(data);
            string base64digest = Convert.ToBase64String(digest);
            return base64digest.Substring(0, base64digest.Length - 2);
        }
    }
}
