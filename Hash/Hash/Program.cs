using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "Hello";
            byte[] data = new UTF8Encoding().GetBytes(szoveg);

            MD5CryptoServiceProvider hash_md5 = new MD5CryptoServiceProvider();
            SHA1CryptoServiceProvider hash_sha1 = new SHA1CryptoServiceProvider();
            SHA256CryptoServiceProvider hash_sha256 = new SHA256CryptoServiceProvider();
            SHA384CryptoServiceProvider hash_sha384 = new SHA384CryptoServiceProvider();
            SHA512CryptoServiceProvider hash_sha512 = new SHA512CryptoServiceProvider();

            byte[] hash = hash_md5.ComputeHash(data);
            byte[] hashsha1 = hash_sha1.ComputeHash(data);
            byte[] hashsha256 = hash_sha256.ComputeHash(data);
            byte[] hashsha384 = hash_sha384.ComputeHash(data);
            byte[] hashsha512 = hash_sha512.ComputeHash(data);

            //StringBuilder hashString = ByteToHash(hash);

            //Console.WriteLine(ByteToHash(hash));
            //Console.WriteLine(ByteToHash(hashsha1));
            //Console.WriteLine(ByteToHash(hashsha256));
            //Console.WriteLine(ByteToHash(hashsha384));
            //Console.WriteLine(ByteToHash(hashsha512));
            HashMaker hashMaker = new HashMaker();

            var hellohash = hashMaker.CreateHash(HashType.MD5, szoveg);

            var filehash = hashMaker.CreateHash(HashType.SHA256,"nevekGUI.txt");

            Console.WriteLine(hellohash);
            Console.WriteLine(filehash);

            Console.ReadKey();
        }

        private static StringBuilder ByteToHash(byte[] hash)
        {
            StringBuilder hashString = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                hashString.Append(hash[i].ToString("x2"));
            }

            return hashString;
        }
    }
}
