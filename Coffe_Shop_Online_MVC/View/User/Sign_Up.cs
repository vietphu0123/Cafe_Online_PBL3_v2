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
    public partial class ThêmUser : Form
    {
        public ThêmUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string create = BLL.BLL_Account.Instance.Create(But_Name_Login.Text.ToString(), But_Name_Login.Text.ToString(), But_Email.Text.ToString(), BLL.BLL_HasPass.HasPass(But_Your_Pass.Text));
            if(create== "đã tạo thành công")
            {
                MessageBox.Show(create);
                this.Close();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
