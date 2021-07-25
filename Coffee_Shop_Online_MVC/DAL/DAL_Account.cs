using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An2.DTO;


namespace Do_An2.DAL
{
    class DAL_Account
    {
        private static DAL_Account _Instance;
        public static DAL_Account Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Account();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private DAL_Account()
        { }
        public List<DTO.TaiKhoan> Login(string id,string pass)
        {
            Model1 db = new Model1();
            List<DTO.TaiKhoan> data = new List<DTO.TaiKhoan>();
            var user = db.TaiKhoan.Where(p => p.TenTaiKhoan == id && p.pass==pass).FirstOrDefault();
            if(user==null)
            {
                return null;
            }
            DTO.TaiKhoan tk = new DTO.TaiKhoan(user.idTaiKhoan, user.TenTaiKhoan, user.pass, user.LoaiTK);
            data.Add(tk);
            return data;
        }
        public string Create(string id, string name,string email,string pass)
        {
            try
            {
                Model1 db = new Model1();
                bool a = true;
                bool b = true;

                foreach (TaiKhoan i in db.TaiKhoan)
                {
                    if (String.Compare(i.TenTaiKhoan.ToString(), id, true) == 0)
                    {
                        a = false;
                        /*MessageBox.Show("tên tài khoản đã có");*/
                    }

                }

                foreach (Users i in db.User)
                {
                    if (String.Compare(i.Email.ToString(), email, true) == 0)
                    {

                        b = false;
                        /* MessageBox.Show("email đã đăng ký");*/
                    }

                }
                if (a == false)
                {
                    return "tên tài khoản đã có";
                }
                if (b == false)
                {
                    return "email đã đăng ký";
                }
                if (a == true && b == true)
                {
                    TaiKhoan tk = new TaiKhoan();
                    tk.TenTaiKhoan = name;
                    tk.pass = pass;
                    tk.LoaiTK = "User";
                    db.TaiKhoan.Add(tk);
                    db.SaveChanges();
                    Users us = new Users();
                    us.Email = email;
                    us.Name = name;
                    us.idTaiKhoan = db.TaiKhoan.Max(p => p.idTaiKhoan);
                    db.User.Add(us);
                    db.SaveChanges();
                    return "đã tạo thành công";
                }
                return "không thành công";
            }
            catch (Exception e)
            {
                return "không thành công"+e.Message;
            }
        }
        public bool check_Account_Manager(string name)
        {
            Model1 db = new Model1();
            var tk = db.TaiKhoan.Where(p => String.Compare(p.TenTaiKhoan, name.ToString(), true) == 0).FirstOrDefault();
            if (tk == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Manager> get_Manager_by_id(int id)
        {
            Model1 db = new Model1();
            List<Manager> data = new List<Manager>();
            var tk = db.Manager.Where(p => p.idManager == id).FirstOrDefault();
            DTO.Manager mana = new DTO.Manager(tk.idManager, tk.Name, tk.SDT, tk.CMND, tk.Dia_Chi, tk.Ngay_Vo_Lam, tk.Ngay_Sinh, tk.Gioi_Tinh, tk.id_Local_Store, tk.idTaiKhoan);
            data.Add(mana);
            return data;

        }
        public bool change(int id, string pass_old, string pass_new)
        {
            Model1 db = new Model1();
            var tk = db.TaiKhoan.Where(p => p.idTaiKhoan == id).FirstOrDefault();
            if (String.Compare(tk.pass, pass_old, true) == 0)
            {
                tk.pass = pass_new;
                db.SaveChanges();
                return true;
            }
            else return false;
        }
        public void create_Manager(DTO.TaiKhoan mana)
        {
            Model1 db = new Model1();
            db.TaiKhoan.Add(new TaiKhoan
            {
                TenTaiKhoan = mana.TenTaiKhoan,
                pass=mana.Pass,
                LoaiTK=mana.LoaiTK

            });
            db.SaveChanges();
        }
        public void Add_Manager(int idLC )
        {
            Model1 db = new Model1();
            db.Manager.Add(new DAL.Managers
            {
                id_Local_Store = idLC,
                idTaiKhoan = db.TaiKhoan.Max(p => (p.idTaiKhoan)),

            });
        }
        public void dele_Manager(int id)
        {
            Model1 db = new Model1();
            var dele = db.Manager.Where(p => p.idTaiKhoan == id).FirstOrDefault();
            db.Manager.Remove(dele);
            db.SaveChanges();
        }
        public List<DTO.Manager> get_Manager()
        {
            Model1 db = new Model1();
            List<DTO.Manager> data = new List<DTO.Manager>();
            foreach (DAL.Managers i in db.Manager)
            {
                DTO.Manager dr = new DTO.Manager(i.idManager,i.Name,i.SDT,i.CMND,i.Dia_Chi,i.Ngay_Vo_Lam,i.Ngay_Sinh,i.Gioi_Tinh,i.id_Local_Store,i.idTaiKhoan);
                data.Add(dr);
            }
            return data;

        }
        public List<DTO.TaiKhoan> get_Account()
        {
            Model1 db = new Model1();
            List<DTO.TaiKhoan> data = new List<DTO.TaiKhoan>();
            foreach (DAL.TaiKhoan i in db.TaiKhoan)
            {
                DTO.TaiKhoan dr = new DTO.TaiKhoan(i.idTaiKhoan,i.TenTaiKhoan,i.pass,i.LoaiTK);
                data.Add(dr);
            }
            return data;
        }
    }
}
