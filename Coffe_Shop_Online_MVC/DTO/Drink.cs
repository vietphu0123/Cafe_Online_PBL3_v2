using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DTO
{
    class Drink
    {
        private int _id_Drink;
        private string _name;
        private double _price;
        private int _id_Category;

        public Drink(int id_Drink, string name, double price, int id_Category)
        {
            this.Id_Drink = id_Drink;
            this.Name = name;
            this.Price = price;
            this.Id_Category = id_Category;
        }

        public int Id_Drink { get => _id_Drink; set => _id_Drink = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public int Id_Category { get => _id_Category; set => _id_Category = value; }
    }
}
