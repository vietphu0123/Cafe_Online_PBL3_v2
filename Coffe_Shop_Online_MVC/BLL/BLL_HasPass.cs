using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.BLL
{
    class BLL_HasPass
    {
        public static String HasPass(String pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string haspass = "";
            foreach (byte i in hasData)
            {
                haspass += i;
            }
            return haspass;
        }
    }
}
