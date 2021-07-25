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
    public partial class Information_User : Form
    {
        public delegate void load(object sender, EventArgs e);
        private load _d;
        int id_TaiKhoan;
        public Information_User(int id)
        {
            id_TaiKhoan = id;
            InitializeComponent();
        }
        public load D { get => _d; set => _d = value; }
        private void Form8_Load(object sender, EventArgs e)
        {
            List<DTO.User> user = BLL.BLL_Information.Instance.getUsers(id_TaiKhoan);
           
            /*int id_User = 0;
            Model1 db = new Model1();
            foreach (Users i in db.User)
            {
                if (i.idTaiKhoan == id_TaiKhoan)
                {
                    id_User = i.id_Name_User;
                }
            }           */
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
            comboBox1.SelectedIndex = 0;

            if (user[0].Name == null)
            {
                But_Name.Text = "";
            }
            else 
            {
                But_Name.Text = user[0].Name;
            }
            if(user[0].SDT== null)
            {
                But_SDT.Text = "";
            }
            else
            {
                But_SDT.Text = user[0].SDT;
            }
            if (user[0].Dia_Chi == null)
            {
                But_Dia_Chi.Text = "";
            }
            else
            {
                But_Dia_Chi.Text = user[0].Dia_Chi;
            }
            if (user[0].Ngay_Sinh== null)
            {
                textBox5.Text = "";
            }
            else
            {
                textBox5.Text = user[0].Ngay_Sinh.ToString();
            }
            if (user[0].Email == null)
            {
                But_Email.Text = "";
            }
            else
            {
                But_Email.Text = user[0].Email.ToString();
            }
            if (user[0].Gioi_Tinh == null)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                if (user[0].Gioi_Tinh == true)
                {
                    comboBox1.SelectedIndex = 0;

                }
                else
                {
                    comboBox1.SelectedIndex = 1;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            bool GT = true;
            if(But_SDT.Text==""||But_Dia_Chi.Text==""||textBox5.Text=="")
            {
                MessageBox.Show("Mời Bạn Nhập Đầy Đủ Thông Tin");
                check = false;
            }
            if (check == true)
            {

                try
                    {
                        Convert.ToDateTime(textBox5.Text.ToString());

                    }
                catch (Exception E)
                    {
                        MessageBox.Show("ngày sinh nhập sai");
                        check = false;
                    }
                if (comboBox1.SelectedItem == "Nam")
                    {
                        GT = true;
                    }
                else
                    {
                        GT = false;
                    }
                if (check == true)
                {
                    List<DTO.User> user =BLL.BLL_Information.Instance.getUsers(id_TaiKhoan  );
                    DTO.User updateuser = new DTO.User(user[0].Id_Name_User, But_Name.Text.ToString(), But_SDT.Text.ToString(), But_Dia_Chi.Text.ToString(), But_Email.Text.ToString(), Convert.ToDateTime(textBox5.Text.ToString()), GT, id_TaiKhoan);
                    bool turn = BLL.BLL_Information.Instance.updateUsers(updateuser);
                    if (turn)
                    {
                        MessageBox.Show("lưu thông tin thành công");
                        D(sender, e);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("lưu thông thất bại");
                    }
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void But_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
