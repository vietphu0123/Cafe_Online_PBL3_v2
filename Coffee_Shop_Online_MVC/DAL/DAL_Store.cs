using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DAL
{
    class DAL_Store
    {
        private static DAL_Store _Instance;
        public static DAL_Store Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Store();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private DAL_Store()
        { }
        public bool create_Store(DTO.Local_Store LC)
        {
            try
            {
                Model1 db = new Model1();
                db.Local_Store.Add(new Local_Store
                {
                    Name = LC.Name,
                    Dia_Chi = LC.Dia_Chi,
                    SDT = LC.SDT
                });
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public dynamic get_Store_Dynamic()
        {
            Model1 db = new Model1();
            return db.Local_Store.Select(p => new { p.id_Local_Store, p.Name, p.Dia_Chi, p.SDT });
        }
        public dynamic get_Store_Dynamic1()
        {
            Model1 db = new Model1();
            return db.Local_Store.Select(p => new { p.id_Local_Store, p.Name, p.SDT });
        }
        public List<DTO.Local_Store> get_Store()
        {
            Model1 db = new Model1();
            List<DTO.Local_Store> data = new List<DTO.Local_Store>();
            foreach (DAL.Local_Store i in db.Local_Store)
            {
                DTO.Local_Store dr = new DTO.Local_Store(i.id_Local_Store,i.Name,i.Dia_Chi,i.SDT);
                data.Add(dr);
            }
            return data;
        }
        public void dele_Store(int id)
        {
            Model1 db = new Model1();
            var dele = db.Local_Store.Where(p => p.id_Local_Store == id).FirstOrDefault();
            db.Local_Store.Remove(dele);
            db.SaveChanges();
        }
    }
}
