using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An2
{
    public partial class Đổi_pass : Form
    {
        int id_TaiKhoan;
        public Đổi_pass(int id_taikhoan)
        {
            id_TaiKhoan = id_taikhoan;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.Compare(textBox2.Text,textBox3.Text,false)==0)
            {
                bool turn = BLL.BLL_Account.Instance.change(id_TaiKhoan, BLL.BLL_HasPass.HasPass(textBox1.Text).ToString(), BLL.BLL_HasPass.HasPass(textBox2.Text).ToString());
                if (turn)
                {
                    MessageBox.Show("Thành Công");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("sai mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Mật Khẩu Không Trùng Nhau");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Dispose();
            this.Close();
        }
    }
}
