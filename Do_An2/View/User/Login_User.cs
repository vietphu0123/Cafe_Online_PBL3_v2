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
    public partial class Login_User : Form
    {
        
        int id_Taikhoan;
        public Login_User(int id)
        {
            id_Taikhoan = id;
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            DAL.Model1 db = new DAL.Model1();                 
            foreach (DAL.Local_Store i in db.Local_Store)
            {
                comboBox1.Items.Add(new CBBstore
                {
                    Id= i.id_Local_Store,
                    Name=i.Name.ToString(),
                });
            }
            comboBox1.SelectedIndex = 0;
            int id_User = 0;
            foreach (DAL.Users i in db.User)
            {
                if (i.idTaiKhoan == id_Taikhoan)
                {
                    id_User = i.id_Name_User;
                }
            }
            foreach (DAL.Users i in db.User)
            {
                if (i.id_Name_User.ToString() == id_User.ToString())
                {
                    label1.Text = i.Name.ToString();
                }
            }
            comboBox2.Text = "information";
            comboBox2.Items.Add("information");
            comboBox2.Items.Add("Pass");
            comboBox2.Items.Add("out");
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_User = 0;
            DAL.Model1 db = new DAL.Model1();
            foreach (DAL.Users i in db.User)
            {
                if (i.idTaiKhoan == id_Taikhoan)
                {
                    id_User = i.id_Name_User;
                }
            }
            if (comboBox2.SelectedItem == "out")
            {
                Login f = new Login();
                
                this.Hide();
                this.Dispose();
                f.ShowDialog();
                this.Close();
            }
            if (comboBox2.SelectedItem == "information")
            {
                Information_User f = new Information_User(id_Taikhoan);
                f.D += new Information_User.load(Form7_Load);
                f.ShowDialog();
               
            }
            if (comboBox2.SelectedItem == "Pass")
            {
                Đổi_pass  f = new Đổi_pass(id_Taikhoan);
         
                f.ShowDialog();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            Menu f = new Menu(id_Taikhoan, ((CBBstore)comboBox1.SelectedItem).Id);
            this.Hide();
            f.ShowDialog();
            this.Dispose();
            this.Close();

        }

  
    }
}
