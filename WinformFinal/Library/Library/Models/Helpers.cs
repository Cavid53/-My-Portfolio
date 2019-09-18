using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public static class Helpers
    {
        public static string HashPassword(string str)
        {
            byte[] passHashCode = Encoding.ASCII.GetBytes(str);
            byte[] pass = new SHA256Managed().ComputeHash(passHashCode);

            return Encoding.ASCII.GetString(pass);
        }
    }
}
