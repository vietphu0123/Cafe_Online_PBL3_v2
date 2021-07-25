using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.BLL
{
    class BLL_Category
    {
        private static BLL_Category _Instance;
        public static BLL_Category Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Category();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_Category() { }
        public List<DTO.Category> getCategory()
        {
            return DAL.DAL_Category.Instance.getCategory();
        }
        public void addCategory(string name)
        {
             DAL.DAL_Category.Instance.addCategory(name);
        }
        public void deleCategory(string name)
        {
            DAL.DAL_Category.Instance.deleCategory(name);
        }

    }
}
