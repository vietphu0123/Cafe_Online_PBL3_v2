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
   
    public partial class Delivery_Detail : Form
    {
        int id_Order;
        public Delivery_Detail(int id_order)
        {
            id_Order = id_order;
            InitializeComponent();
            load_data(id_Order);
        }
        public void load_data(int id_Order)
        {
            DAL.Model1 db = new DAL.Model1();
            List<Cart> Cart = new List<Cart>();
            double ThanhTien = 0;
            Cart = BLL.BLL_Delivery.Instance.cart_detail(id_Order);
            foreach(Cart i in Cart)
            {
                ThanhTien += i.Tien;
            }
            textBox1.Text = ThanhTien.ToString();
            dataGridView1.DataSource = Cart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
