using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DTO
{
    class TaiKhoan  
    {
        private int _idTaiKhoan;
        private string _TenTaiKhoan;
        private string _pass;
        private string _LoaiTK;

        public TaiKhoan(int idTaiKhoan, string tenTaiKhoan, string pass, string loaiTK)
        {
            _idTaiKhoan = idTaiKhoan;
            _TenTaiKhoan = tenTaiKhoan;
            _pass = pass;
            _LoaiTK = loaiTK;
        }

        public int idTaiKhoan { get=> _idTaiKhoan;set => _idTaiKhoan=value; }
        public string TenTaiKhoan { get => _TenTaiKhoan; set => _TenTaiKhoan = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string LoaiTK { get => _LoaiTK; set => _LoaiTK = value; }

    }
}
