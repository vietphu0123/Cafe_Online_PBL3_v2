using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DAL
{
    class DAL_Delivery
    {
        private static DAL_Delivery _Instance;
        public static DAL_Delivery Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Delivery();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private DAL_Delivery()
        { }
        public void Status_Delivery(int id, string status)
        {
            Model1 db = new Model1();
            var deli = db.Order.Where(p => p.id_Order == id).FirstOrDefault();
            deli.Status = status;
            db.SaveChanges();
        }
        public List<Cart> cart_detail(int id)
        {
            Model1 db = new Model1();
            List<Cart> cart = new List<Cart>();
            foreach (Order_detail i in db.Order_Detail)
            {
                if (i.id_Order == id)
                {
                    string Name = "";
                    double total = 0;
                    foreach (Drink p in db.Drink)
                    {
                        if (i.id_Name_SP == p.id_Drink)
                        {
                            Name = p.name;
                        }
                    }
                    foreach (ThanhTien q in db.ThanhTien)
                    {
                        if (i.id == q.id_Order_Detail)
                        {
                            total = q.Total;
                        }
                    }
                    cart.Add(new Cart
                    {
                        Id = i.id,
                        NameSp = Name,
                        SoLuong = Convert.ToInt32(i.So_Luong.ToString()),
                        Tien = total,
                    });
                }
            }
            return cart;
        }
        public List<Cart> cart(int r)
        {
            Model1 db = new Model1();
            List<Cart> Cart = new List<Cart>();
            foreach (Order_detail i in db.Order_Detail)
            {
                if (i.id_Order == r)
                {
                    string Name = "";
                    double total = 0;
                    foreach (Drink p in db.Drink)
                    {
                        if (i.id_Name_SP == p.id_Drink)
                        {
                            Name = p.name;
                        }
                    }
                    foreach (ThanhTien q in db.ThanhTien)
                    {
                        if (i.id == q.id_Order_Detail)
                        {
                            total = q.Total;
                        }
                    }
                    Cart.Add(new Cart
                    {
                        Id = i.id,
                        NameSp = Name,
                        SoLuong = Convert.ToInt32(i.So_Luong.ToString()),
                        Tien = total,
                    });
                }
            }
            return Cart;
        }
    }
}
