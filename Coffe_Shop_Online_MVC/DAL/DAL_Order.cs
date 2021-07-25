using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DAL
{
    class DAL_Order
    {

        private static DAL_Order _Instance;
        public static DAL_Order Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Order();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private DAL_Order()
        { }
        public bool insert_Order(DTO.Order or,List<Cart> lca)
        {
            try
            {
                Model1 db = new Model1();
                db.Order.Add(new Order
                {
                    Name = or.Name,
                    SDT_Nhan = or.SDT_Nhan,
                    Dia_Chi = or.Dia_Chi,
                    Ngay_Dat = or.Ngay_Dat,
                    Status = or.Status,
                    FeedBach = or.FeedBach,
                    id_Local_Store = or.Id_Local_Store,
                    id_Name_User = or.Id_Name_User

                });
                db.SaveChanges();
                foreach (Cart i in lca)
                {
                    db.Order_Detail.Add(new Order_detail
                    {
                        id_Name_SP = i.Id,
                        So_Luong = i.SoLuong,
                        id_Order = db.Order.Max(p => p.id_Order),

                    });


                }
                db.SaveChanges();

                foreach (Order_detail i in db.Order_Detail)
                {
                    double total = 0;
                    foreach (Drink j in db.Drink)
                    {
                        if (i.id_Name_SP == j.id_Drink)
                        {
                            total = j.price * Convert.ToDouble(i.So_Luong);
                            db.ThanhTien.Add(new ThanhTien
                            {
                                id_Order_Detail = i.id,
                                Total = total,
                            });
                        }
                    }

                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public dynamic getOrder_Status(int id,string status,DateTime date)
        {
            Model1 db = new Model1();
            List<Order> temp = new List<Order>();

            if(status!=null)
            {
                foreach (Order i in db.Order)
                {
                    if (i.id_Local_Store == id && String.Compare(i.Status.ToString(), status, true) == 0 && Convert.ToDateTime(i.Ngay_Dat.ToString()).Date == date)
                    {
                        temp.Add(i);
                    }
                }
                return temp;
            }
            else
            {
                foreach (Order i in db.Order)
                {
                    if (i.id_Local_Store == id && Convert.ToDateTime(i.Ngay_Dat.ToString()).Date == date)
                    {
                        temp.Add(i);
                    }
                }
                return temp;
            }
            
        }
        public List<DTO.Order> get_Order()
        {
            Model1 db = new Model1();
            List<DTO.Order> data = new List<DTO.Order>();
            foreach (Order i in db.Order)
            {
                DTO.Order dr = new DTO.Order(i.id_Order,i.Name,i.SDT_Nhan,i.Dia_Chi,i.Ngay_Dat,i.Status,i.FeedBach,i.id_Local_Store,i.id_Name_User);
                data.Add(dr);
            }
            return data;

        }
    }
}
