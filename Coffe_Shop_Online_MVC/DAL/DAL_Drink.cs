using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DAL
{
    class DAL_Drink
    {
        private static DAL_Drink _Instance;
        public static DAL_Drink Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Drink();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private DAL_Drink()
        { }
        public List<DTO.Drink> get_Drink()
        {
            Model1 db = new Model1();
            List<DTO.Drink> data = new List<DTO.Drink>();
            foreach(DAL.Drink i in db.Drink)
            {
                DTO.Drink dr = new DTO.Drink(i.id_Drink,i.name,i.price,i.id_Category);
                data.Add(dr);
            }
            return data;

        }
        public dynamic get_Drink_Dynamic()
        {
            DAL.Model1 db = new DAL.Model1();
            return db.Drink.Select(p => new { p.name, p.price, p.Category.Name_Category });
        }
    }
}
