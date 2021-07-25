using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.BLL
{
    class BLL_Order
    {
        private static BLL_Order _Instance;
        public static BLL_Order Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Order();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_Order()
        { }
        public bool insert_Order(DTO.Order or,List<Cart> lca)
        {
            DAL.DAL_Order.Instance.insert_Order(or,lca);
        }
        public dynamic getOrder_Status(int id, string status, DateTime date)
        {
            return DAL.DAL_Order.Instance.getOrder_Status(id, status, date);
        }
        public List<DTO.Order> get_Order()
        {
            return DAL.DAL_Order.Instance.get_Order();
        }
    }
}
