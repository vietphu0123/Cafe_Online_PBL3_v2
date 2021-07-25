using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DTO
{
    class Manager
    {
        private int? _idManager;
        private string _Name;
        private string _SDT;
        private string _CMND;
        private string _Dia_Chi;
        private DateTime? _Ngay_Vo_Lam;
        private DateTime? _Ngay_Sinh;
        private bool? _Gioi_Tinh;
        private int _id_Local_Store;
        private int _idTaiKhoan;

        public Manager(int? idManager, string name, string sDT, string cMND, string dia_Chi, DateTime? ngay_Vo_Lam, DateTime? ngay_Sinh, bool? gioi_Tinh, int id_Local_Store, int idTaiKhoan)
        {
            IdManager = idManager;
            Name = name;
            SDT = sDT;
            CMND = cMND;
            Dia_Chi = dia_Chi;
            this.Ngay_Vo_Lam = ngay_Vo_Lam;
            Ngay_Sinh = ngay_Sinh;
            Gioi_Tinh = gioi_Tinh;
            Id_Local_Store = id_Local_Store;
            IdTaiKhoan = idTaiKhoan;
        }

        public int? IdManager { get => _idManager; set => _idManager = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
        public string Dia_Chi { get => _Dia_Chi; set => _Dia_Chi = value; }
        public DateTime? Ngay_Vo_Lam { get => _Ngay_Vo_Lam; set => _Ngay_Vo_Lam = value; }
        public DateTime? Ngay_Sinh { get => _Ngay_Sinh; set => _Ngay_Sinh = value; }
        public bool? Gioi_Tinh { get => _Gioi_Tinh; set => _Gioi_Tinh = value; }
        public int Id_Local_Store { get => _id_Local_Store; set => _id_Local_Store = value; }
        public int IdTaiKhoan { get => _idTaiKhoan; set => _idTaiKhoan = value; }
    }
}
