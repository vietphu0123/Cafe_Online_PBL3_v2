using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.BLL
{
    class BLL_Store
    {
        private static BLL_Store _Instance;
        public static BLL_Store Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Store();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_Store() { }
        public bool create_Store(DTO.Local_Store LC)
        {
            return DAL.DAL_Store.Instance.create_Store(LC);
        }
        public dynamic get_Store_Dynamic()
        {
            return DAL.DAL_Store.Instance.get_Store_Dynamic();
        }
        public dynamic get_Store_Dynamic1()
        {
            return DAL.DAL_Store.Instance.get_Store_Dynamic();
        }
        public List<DTO.Local_Store> get_Store()
        {
            return DAL.DAL_Store.Instance.get_Store();
        }
        public void dele_Store(int id)
        {
             DAL.DAL_Store.Instance.dele_Store(id);
        }
    }
}
