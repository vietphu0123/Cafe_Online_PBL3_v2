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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void But_Create_Acc_Click(object sender, EventArgs e)
        {
            ThêmUser f = new ThêmUser();
            f.ShowDialog();
        }

        private void But_Sign_in_Click(object sender, EventArgs e)
        {

            List<DTO.TaiKhoan> user=BLL.BLL_Account.Instance.Login(But_id.Text.ToString(), BLL.BLL_HasPass.HasPass(But_Pass.Text));
            if (user==null)
            {
                MessageBox.Show("sai ten tai khoan hoac mat khau");
                But_id.Text = "";
                But_Pass.Text = "";

            }
            else if(user[0].LoaiTK == "User")
            {
                Login_User f = new Login_User(user[0].idTaiKhoan);
                this.Hide();
                f.ShowDialog();
                this.Dispose();
                this.Close();
            }
            else if (user[0].LoaiTK == "Manager")
            {
                int id_Manager = 0;
                DAL.Model1 db1 = new DAL.Model1();
                foreach (DAL.Managers j in db1.Manager)
                {
                    if (user[0].idTaiKhoan == j.idTaiKhoan)
                    {
                        id_Manager = j.idManager;
                    }
                }
       
                Manager_QL f = new Manager_QL(id_Manager);
                this.Hide();
                f.ShowDialog();
                this.Dispose();
                this.Close();
            }
            else if (user[0].LoaiTK == "Admin")
            {
                Form12 f = new Form12();
                this.Hide();
                f.ShowDialog();
                this.Dispose();
                this.Close();
            }

            /*Model1 db = new Model1();
            bool check = false;
            foreach (TaiKhoan i in db.TaiKhoan)
            {
                if (String.Compare(But_id.Text.ToString(), i.TenTaiKhoan.ToString(), true) == 0 && String.Compare(BLL.BLL_HasPass.HasPass(But_Pass.Text) , i.pass.ToString(),true)==0  && i.LoaiTK == "User")
                {                   
                    check = true;
                    Login_User f = new Login_User(i.idTaiKhoan);
                    this.Hide();
                    f.ShowDialog();
                    this.Dispose();
                    this.Close();
                }
                if (String.Compare(But_id.Text.ToString(), i.TenTaiKhoan.ToString(), true) == 0 && String.Compare(BLL.BLL_HasPass.HasPass(But_Pass.Text), i.pass.ToString(), false) == 0 && i.LoaiTK == "Manager")
                {
                    

                }
                if (String.Compare(But_id.Text.ToString(), i.TenTaiKhoan.ToString(), true) == 0 && String.Compare(BLL.BLL_HasPass.HasPass(But_Pass.Text), i.pass.ToString(), false) == 0 && i.LoaiTK == "Admin")
                {
                    check = true;
                    Form12 f = new Form12();
                    this.Hide();
                    f.ShowDialog();
                    this.Dispose();
                    this.Close();

                }


            }

            if (check == false)
            {
                MessageBox.Show("sai ten tai khoan hoac mat khau");
                But_id.Text = "";
                But_Pass.Text = "";

            }*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Dispose();
            this.Close();

        }
        
    }
}
