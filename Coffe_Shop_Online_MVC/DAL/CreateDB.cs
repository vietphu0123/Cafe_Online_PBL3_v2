using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DAL
{
    class CreateDB : CreateDatabaseIfNotExists<Model1>
    {
        protected override void Seed(Model1 context)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes("Admin");
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string haspass = "";
            foreach (byte i in hasData)
            {
                haspass += i;
            }
            context.TaiKhoan.Add(new TaiKhoan
            {
                TenTaiKhoan = "Admin",
                pass=haspass,
                LoaiTK="Admin",
            });

        }
    }
}
