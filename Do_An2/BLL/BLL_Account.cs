using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An2.DAL;
using Do_An2.DTO;
namespace Do_An2.BLL
{
    class BLL_Account
    {
        private static BLL_Account _Instance;
        public static BLL_Account Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Account();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_Account()
        { }
        public List<DTO.TaiKhoan> Login(string id, string pass)
        {
            return DAL.DAL_Account.Instance.Login(id, pass);
        }
        public string Create(string id,string name,string email,string pass)
        {
            return DAL.DAL_Account.Instance.Create(id, name, email,pass);
        }
        public bool check_Account_Manager(string name)
        {
            return DAL.DAL_Account.Instance.check_Account_Manager(name);
        }
        public List<Manager> get_Manager_by_id(int id)
        {
            return DAL.DAL_Account.Instance.get_Manager_by_id(id);
        }
        public bool change(int id_TaiKhoan, string pass_old, string pass_new)
        {
            return DAL.DAL_Account.Instance.change(id_TaiKhoan,pass_old,pass_new);
        }
        public void Create_Manager(DTO.TaiKhoan mana)
        {
            DAL.DAL_Account.Instance.create_Manager(mana);
        }
        public void Add_Manager(int idLC)
        {
            DAL.DAL_Account.Instance.Add_Manager(idLC);
        }
        public void dele_Manager(int id)
        {
            DAL.DAL_Account.Instance.dele_Manager(id);
        }
        public List<DTO.Manager> get_Manager()
        {
            return DAL.DAL_Account.Instance.get_Manager();
        }
        public List<DTO.TaiKhoan> get_Account()
        {
            return DAL.DAL_Account.Instance.get_Account();
        }
    }
}
