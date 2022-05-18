using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Hash
{
    public enum HashType
    {
        MD5,
        SHA1,
        SHA256,
        SHA384,
        SHA512
    }

    public class HashMaker
    {
        public string CreateHash(HashType type,string szoveg,bool up=false)
        {
            string hash = "";

            if (type==HashType.MD5)
            {
                byte[] data;
                MD5CryptoServiceProvider hashdata = new MD5CryptoServiceProvider();
                if (File.Exists(szoveg))
                {
                    data = File.ReadAllBytes(szoveg);

                } else
                {
                    data = new UTF8Encoding().GetBytes(szoveg);
                }
                hash = ByteToHash(hashdata.ComputeHash(data));

            } else if (type==HashType.SHA1)
            {
                byte[] data;
                SHA1CryptoServiceProvider hashdata = new SHA1CryptoServiceProvider();
                if (File.Exists(szoveg))
                {
                    data = File.ReadAllBytes(szoveg);

                }
                else
                {
                    data = new UTF8Encoding().GetBytes(szoveg);
                }
                hash = ByteToHash(hashdata.ComputeHash(data));

            } else if (type == HashType.SHA256)
            {
                byte[] data;
                SHA256CryptoServiceProvider hashdata = new SHA256CryptoServiceProvider();
                if (File.Exists(szoveg))
                {
                    data = File.ReadAllBytes(szoveg);

                }
                else
                {
                    data = new UTF8Encoding().GetBytes(szoveg);
                }
                hash = ByteToHash(hashdata.ComputeHash(data));
            } else if (type == HashType.SHA384)
            {
                byte[] data;
                SHA384CryptoServiceProvider hashdata = new SHA384CryptoServiceProvider();
                if (File.Exists(szoveg))
                {
                    data = File.ReadAllBytes(szoveg);

                }
                else
                {
                    data = new UTF8Encoding().GetBytes(szoveg);
                }
                hash = ByteToHash(hashdata.ComputeHash(data));
            } else
            {
                byte[] data;
                SHA512CryptoServiceProvider hashdata = new SHA512CryptoServiceProvider();
                if (File.Exists(szoveg))
                {
                    data = File.ReadAllBytes(szoveg);

                }
                else
                {
                    data = new UTF8Encoding().GetBytes(szoveg);
                }
                hash = ByteToHash(hashdata.ComputeHash(data));
            }

            if (up)
            {
                hash = hash.ToUpper();
            }

            return hash;
        }

        private String ByteToHash(byte[] hash)
        {
            StringBuilder hashString = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                hashString.Append(hash[i].ToString("x2"));
            }

            return hashString.ToString();
        }
    }
}
