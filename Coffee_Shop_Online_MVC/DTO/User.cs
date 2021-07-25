using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DTO
{
    class User
    {
        private int _id_Name_User;
        private string _Name;
        private string _SDT;
        private string _Dia_Chi;
        private string _Email;
        private DateTime? _Ngay_Sinh;
        private bool? _Gioi_Tinh;
        private int _idTaiKhoan;

        public User(int id_Name_User, string name, string sDT, string dia_Chi, string email, DateTime? ngay_Sinh, bool? gioi_Tinh, int idTaiKhoan)                                                                                                                  
        {
            this._id_Name_User = id_Name_User;
            this._Name = name;
            this._SDT = sDT;
            this._Dia_Chi = dia_Chi;
            this._Email = email;
            this.Ngay_Sinh = ngay_Sinh;
            this.Gioi_Tinh = gioi_Tinh;
            this._idTaiKhoan = idTaiKhoan;
        }

        public int Id_Name_User { get => _id_Name_User; set => _id_Name_User = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Dia_Chi { get => _Dia_Chi; set => _Dia_Chi = value; }
        public string Email { get => _Email; set => _Email = value; }
/*        public DateTime Ngay_Sinh { get => _Ngay_Sinh; set => _Ngay_Sinh = value; }
        public bool Gioi_Tinh { get => _Gioi_Tinh; set => _Gioi_Tinh = value; }*/
        public int IdTaiKhoan { get => _idTaiKhoan; set => _idTaiKhoan = value; }
        public DateTime? Ngay_Sinh { get => _Ngay_Sinh; set => _Ngay_Sinh = value; }
        public bool? Gioi_Tinh { get => _Gioi_Tinh; set => _Gioi_Tinh = value; }
    }
}
