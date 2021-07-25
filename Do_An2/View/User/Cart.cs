using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An2.BLL;

namespace Do_An2
{
    public partial class Giỏ_Hàng : Form
    {
        List<Cart> lca = new List<Cart>();
        int id_TaiKhoan;
        int id_Store;
        public Giỏ_Hàng(List<Cart> list,int id_t,int id_s)
        {
            id_TaiKhoan = id_t;
            id_Store = id_s;
            lca = list;
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lca;
            double total = 0;
            foreach (Cart i in lca)
            {
                total += i.Tien;
            }
            textBox6.Text = total.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            List<DTO.User> user = BLL.BLL_Information.Instance.getUsers(id_TaiKhoan);
            DTO.Order or = new DTO.Order(null, textBox3.Text.ToString(), textBox4.Text.ToString(), textBox2.Text.ToString(), now, "No", textBox5.Text.ToString(), id_Store, user[0].Id_Name_User);
            bool turn=BLL.BLL_Order.Instance.insert_Order(or,lca);
            if (turn)
            {
                MessageBox.Show("thành công");
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("thất bại");
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            this.Close();
        }
    }
}
