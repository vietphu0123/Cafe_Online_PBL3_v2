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
    public partial class TaoTKManager : Form
    {
        int id_Local = 0;
        public TaoTKManager(int id)
        {
            id_Local = id;
            InitializeComponent();
        }

        private void TaoTKManager_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            bool check = true;
            check = BLL.BLL_Account.Instance.check_Account_Manager(textBox1.Text.ToString());
            if (check == false)
            {
                MessageBox.Show("tài khoản đã có");
                textBox1.Clear();
                textBox2.Clear();
            }
            if (check)
            {
                DTO.TaiKhoan tk = new DTO.TaiKhoan(0, textBox1.Text.ToString(), BLL.BLL_HasPass.HasPass(textBox1.Text.ToString()), "Manager");
                BLL.BLL_Account.Instance.Add_Manager(id_Local);
                MessageBox.Show("Tạo Thanh công");
                this.Dispose();
                this.Close();
            }
        }
    }
}
