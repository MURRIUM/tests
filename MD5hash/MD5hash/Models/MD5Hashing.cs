using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace MD5hash.Models
{
    public class MD5Hashing
    {
        public static string CalculateMD5Hash(string input)
        {
            byte[] hash = Encoding.ASCII.GetBytes(input);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hashenc = md5.ComputeHash(hash);
            string result = "";
            foreach(var b in hashenc)
            {
                result += b.ToString("x2");
            }
            return result;
        }
    }
}
