using System;
using System.Collections.Generic;
using System.Text;

namespace FileHasher
{
    public interface IDataHasher
    {
        string GetHash(byte[] data);
    }
}
