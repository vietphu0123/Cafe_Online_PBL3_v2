using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DAL
{
    class DAL_Category
    {
        private static DAL_Category _Instance;
        public static DAL_Category Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Category();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private DAL_Category() { }
        public List<DTO.Category> getCategory()
        {
            Model1 db = new Model1();
            List<DTO.Category> data = new List<DTO.Category>();
            foreach (DAL.Category i in db.Category)
            {
                DTO.Category dr = new DTO.Category(i.id_Category,i.Name_Category);
                data.Add(dr);
            }
            return data;

        }
        public void addCategory(string name)
        {
            Model1 db = new Model1();
            db.Category.Add(new Category
            {
                Name_Category = name
            });
            db.SaveChanges();
        }
        public void deleCategory(string name)
        {
            Model1 db = new Model1();
            foreach (DAL.Category i in db.Category)
            {
                if (String.Compare(name, i.Name_Category.ToString(), true) == 0)
                {
                    foreach (DAL.Drink j in db.Drink)
                    {
                        if (j.id_Category == i.id_Category)
                        {
                            db.Drink.Remove(j);
                        }
                    }
                    db.Category.Remove(i);
                }
            }
            db.SaveChanges();
        }
    }
}
