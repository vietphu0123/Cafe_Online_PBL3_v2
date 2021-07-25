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
    public partial class Form11 : Form
    {
        int id_Manager;
        public Form11(int id)
        {
            id_Manager = id;
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            List<DTO.Manager> manager = BLL.BLL_Information.Instance.getManagers(id_Manager);
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
            comboBox1.SelectedIndex = 0;

            textBox1.Text = manager[0].Name.ToString();
            textBox2.Text = manager[0].SDT.ToString();
            textBox3.Text = manager[0].CMND.ToString();
            textBox4.Text = manager[0].Dia_Chi.ToString();
            textBox5.Text = manager[0].Ngay_Vo_Lam.ToString();
            textBox6.Text = manager[0].Ngay_Sinh.ToString();
            if (manager[0].Gioi_Tinh == true)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
        }
    }
}
