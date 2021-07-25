using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DTO
{
    class Order_detail
    {
        private int _id;

        private int _id_Name_SP;

        private int _So_Luong;

        private int _id_Order;

        public Order_detail(int id, int id_Name_SP, int so_Luong, int id_Order)
        {
            Id = id;
            Id_Name_SP = id_Name_SP;
            So_Luong = so_Luong;
            Id_Order = id_Order;
        }

        public int Id { get => _id; set => _id = value; }
        public int Id_Name_SP { get => _id_Name_SP; set => _id_Name_SP = value; }
        public int So_Luong { get => _So_Luong; set => _So_Luong = value; }
        public int Id_Order { get => _id_Order; set => _id_Order = value; }
    }
}
