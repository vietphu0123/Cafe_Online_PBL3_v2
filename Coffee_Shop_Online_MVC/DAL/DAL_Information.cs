using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DAL
{
    class DAL_Information
    {
        private static DAL_Information _Instance;
        public static DAL_Information Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Information();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private DAL_Information()
        { }
        public List<DTO.User> GetUsers(int id)
        {
            Model1 db = new Model1();
            List<DTO.User> data = new List<DTO.User>();
            var user = db.User.Where(p => p.idTaiKhoan == id).FirstOrDefault();
            if(user.Ngay_Sinh==null && user.Gioi_Tinh==null)
            {
                DTO.User tk = new DTO.User(user.id_Name_User, user.Name, user.SDT, user.Dia_Chi, user.Email, null, null, user.idTaiKhoan);
                data.Add(tk);
                return data;
            }
            if(user.Gioi_Tinh==null)
            {
                DTO.User tk = new DTO.User(user.id_Name_User, user.Name, user.SDT, user.Dia_Chi, user.Email, user.Ngay_Sinh, null, user.idTaiKhoan);
                data.Add(tk);
                return data;
            }
            if (user.Ngay_Sinh == null)
            {
                DTO.User tk = new DTO.User(user.id_Name_User, user.Name, user.SDT, user.Dia_Chi, user.Email, null, user.Gioi_Tinh, user.idTaiKhoan);
                data.Add(tk);
                return data;
            }
            DTO.User tks = new DTO.User(user.id_Name_User, user.Name, user.SDT, user.Dia_Chi, user.Email, user.Ngay_Sinh, user.Gioi_Tinh, user.idTaiKhoan);
            data.Add(tks);
            return data;

        }
        public List<DTO.Manager> getManagers(int id)
        {
    
            Model1 db = new Model1();
            List<DTO.Manager> data = new List<DTO.Manager>();
            var manager = db.Manager.Where(p => p.idManager == id).FirstOrDefault();
            DTO.Manager tk = new DTO.Manager(manager.idManager, manager.Name, manager.SDT, manager.CMND, manager.Dia_Chi, manager.Ngay_Vo_Lam, manager.Ngay_Sinh, manager.Gioi_Tinh, manager.id_Local_Store, manager.idTaiKhoan);
            data.Add(tk);
            return data;

        }
        public bool updateUsers(DTO.User id)
        {
            try
            {
                Model1 db = new Model1();
                var user = db.User.Where(p => p.id_Name_User == id.Id_Name_User).FirstOrDefault();
                user.Name = id.Name;
                user.SDT = id.SDT;
                user.Dia_Chi = id.Dia_Chi;
                user.Gioi_Tinh = id.Gioi_Tinh;
                user.Ngay_Sinh = id.Ngay_Sinh;
                user.Email = id.Email;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
