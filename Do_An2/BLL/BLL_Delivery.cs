using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.BLL
{
    class BLL_Delivery
    {
        private static BLL_Delivery _Instance;
        public static BLL_Delivery Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Delivery();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_Delivery()
        { }
        public void Status_Delivery(int id,string status)
        {
            DAL.DAL_Delivery.Instance.Status_Delivery(id, status);
        }
        public List<Cart> cart_detail(int id)
        {
            return DAL.DAL_Delivery.Instance.cart_detail(id);
        }
        public List<Cart> cart(int r)
        {
            return DAL.DAL_Delivery.Instance.cart_detail(r);
        }
    }
}
