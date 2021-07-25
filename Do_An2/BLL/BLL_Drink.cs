using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.BLL
{
    class BLL_Drink
    {
        private static BLL_Drink _Instance;
        public static BLL_Drink Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Drink();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_Drink() { }
        public List<DTO.Drink> get_Drink()
        {
            return DAL.DAL_Drink.Instance.get_Drink();
        }
        public dynamic get_Drink_Dynamic()
        {
            return DAL.DAL_Drink.Instance.get_Drink();
        }
    }
}
