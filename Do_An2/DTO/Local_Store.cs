using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DTO
{
    class Local_Store
    {
        private int _id_Local_Store;
        private string _Name;
        private string _Dia_Chi;
        private string _SDT;

        public Local_Store(int id_Local_Store, string name, string dia_Chi, string sDT)
        {
            this._id_Local_Store = id_Local_Store;
            this._Name = name;
            this._Dia_Chi = dia_Chi;
            this._SDT = sDT;
        }

        public int Id_Local_Store { get => _id_Local_Store; set => _id_Local_Store = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Dia_Chi { get => _Dia_Chi; set => _Dia_Chi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}
