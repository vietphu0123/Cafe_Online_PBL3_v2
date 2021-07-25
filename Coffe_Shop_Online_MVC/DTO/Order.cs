using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DTO
{
    class Order
    {
        private int? _id_Order;
        private string _name;
        private string _SDT_Nhan;
        private string _Dia_Chi;
        private DateTime _Ngay_Dat;
        private string _Status;
        private string _FeedBach;
        private int? _id_Local_Store;
        private int? _id_Name_User;

        public Order(int? id_Order, string name, string sDT_Nhan, string dia_Chi, DateTime ngay_Dat, string status, string feedBach, int? id_Local_Store=null, int? id_Name_User=null)
        {
            this._id_Order = id_Order;
            this._name = name;
            this._SDT_Nhan = sDT_Nhan;
            this._Dia_Chi = dia_Chi;
            this._Ngay_Dat = ngay_Dat;
            this._Status = status;
            this._FeedBach = feedBach;
            this._id_Local_Store = id_Local_Store;
            this._id_Name_User = id_Name_User;
        }

        public int? Id_Order { get => _id_Order; set => _id_Order = value; }
        public string Name { get => _name; set => _name = value; }
        public string SDT_Nhan { get => _SDT_Nhan; set => _SDT_Nhan = value; }
        public string Dia_Chi { get => _Dia_Chi; set => _Dia_Chi = value; }
        public DateTime Ngay_Dat { get => _Ngay_Dat; set => _Ngay_Dat = value; }
        public string Status { get => _Status; set => _Status = value; }
        public string FeedBach { get => _FeedBach; set => _FeedBach = value; }
        public int? Id_Local_Store { get => _id_Local_Store; set => _id_Local_Store = value; }
        public int? Id_Name_User { get => _id_Name_User; set => _id_Name_User = value; }
    }
}
