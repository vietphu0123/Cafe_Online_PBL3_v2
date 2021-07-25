using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.BLL
{
    class BLL_Information
    {
        private static BLL_Information _Instance;
        public static BLL_Information Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Information();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_Information()
        { }
        public List<DTO.User> getUsers(int id)
        {
            return DAL.DAL_Information.Instance.GetUsers(id);
        }
        public List<DTO.Manager> getManagers(int id)
        {
            return DAL.DAL_Information.Instance.getManagers(id);
        }
        public bool updateUsers(DTO.User id)
        {
            return DAL.DAL_Information.Instance.updateUsers(id);
        }
    }
}
