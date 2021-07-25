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
    public partial class Thêm_Cửa_Hàng : Form
    {
        public delegate void show();
        private show _show;

        public show Show1 { get => _show; set => _show = value; }

        public Thêm_Cửa_Hàng()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO.Local_Store LC = new DTO.Local_Store(0, textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString());
            bool turn = BLL.BLL_Store.Instance.create_Store(LC);
            if (turn)
            {
                MessageBox.Show("Thêm thành công");
                Show1();
                this.Dispose();
                this.Close();

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }



        }
    }
}
