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
    public partial class Manager_QL : Form
    {
        public delegate void close();
        private close _c;
        int id_manager;

        public close C { get => _c; set => _c = value; }

        public Manager_QL(int id)
        {
            id_manager = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form11 f = new Form11(id_manager);
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Xử_Lý_Giao_Hàng f = new Xử_Lý_Giao_Hàng(id_manager);
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Order_Manager f = new Order_Manager(id_manager);
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Dispose();
            this.Close();

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

  
    }
}
