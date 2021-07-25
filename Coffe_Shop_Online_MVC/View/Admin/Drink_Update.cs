using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An2
{
    public partial class UpdateDoUong : Form
    {

        int id_drink;
        public UpdateDoUong(int id)
        {
            id_drink = id;
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {

            foreach (DTO.Category i in BLL.BLL_Category.Instance.getCategory())
            {
                comboBox1.Items.Add(new CBBCategory
                {
                    IdC = i.Id_Category,
                    NameC = i.Name_Category
                });
            }
            comboBox1.SelectedIndex = 0;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (DTO.Drink i in BLL.BLL_Drink.Instance.get_Drink())
            {
                if (i.Id_Drink == id_drink)
                {

                    textBox1.Text = i.Name;
                    textBox2.Text = i.Price.ToString();
                    CBBCategory temp = new CBBCategory();
                    foreach (CBBCategory j in comboBox1.Items)
                    {
                        if (j.IdC == i.Id_Category)
                        {
                            temp = j;
                        }
                    }
                    int index = comboBox1.Items.IndexOf(temp);
                    comboBox1.SelectedIndex = index;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
