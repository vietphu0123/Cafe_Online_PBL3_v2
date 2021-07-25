using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DTO
{
    class Category
    {
        private int _id_Category;
        private string _Name_Category;

        public Category(int id_Category, string name_Category)
        {
            this._id_Category = id_Category;
            this._Name_Category = name_Category;
        }

        public int Id_Category { get => _id_Category; set => _id_Category = value; }
        public string Name_Category { get => _Name_Category; set => _Name_Category = value; }
    }
}
