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
    public partial class QuanLyMenu : Form
    {
        public QuanLyMenu()
        {
            InitializeComponent();
            dataGridView1.DataSource =BLL.BLL_Category.Instance.getCategory().ToList();
            dataGridView2.DataSource = BLL.BLL_Drink.Instance.get_Drink_Dynamic().ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            ThemLoai f = new ThemLoai();
            f.ShowDialog();
            BLL.BLL_Category.Instance.addCategory(ThemLoai.luuthongtin.NameC.ToString());
            dataGridView1.DataSource =BLL.BLL_Category.Instance.getCategory().ToList();

        }

        private void btnDelC_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            //list
            string name = r[0].Cells["Name_Category"].Value.ToString();
            MessageBox.Show(name);

            BLL.BLL_Category.Instance.deleCategory(name);
            dataGridView1.DataSource = BLL.BLL_Category.Instance.getCategory().ToList();
        }

        private void btnAddD_Click(object sender, EventArgs e)
        {
            DAL.Model1 db = new DAL.Model1();
            ThemDoUong f3 = new ThemDoUong();
            f3.ShowDialog();
            try
            {
                db.Drink.Add(new DAL.Drink
                {
                    name = ThemDoUong.luuthongtin.NameD.ToString(),
                    price = (double)Convert.ToInt32(ThemDoUong.luuthongtin.PriceD.ToString()),
                    id_Category = ThemDoUong.luuthongtin.idC
                });

            }
            catch (Exception E)
            {
                MessageBox.Show("chưa có thông tin");
            }
            db.SaveChanges();
            var list = db.Drink.Select(p => new { p.name, p.price, p.Category.Name_Category });
            dataGridView2.DataSource = list.ToList();


        }

        private void btnUpD_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView2.SelectedRows;
            if (r.Count == 1)
            {
                foreach (DTO.Drink i in BLL.BLL_Drink.Instance.get_Drink())
                {
                    if (String.Compare(i.Name.ToString(), r[0].Cells[0].Value.ToString(), false) == 0)
                    {

                        UpdateDoUong f4 = new UpdateDoUong(i.Id_Drink);
                        f4.ShowDialog();
                    }
                }

            }





        }

        private void QuanLyMenu_Load(object sender, EventArgs e)
        {

        }
    }
}