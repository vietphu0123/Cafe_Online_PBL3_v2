using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An2.User
{
    public partial class Lich_Su_Order : Form
    {
        int id_Taikhoan;    
        public Lich_Su_Order( int id_taikhoan)
        {
            id_Taikhoan = id_taikhoan;
            InitializeComponent();
        }

        public void load(int id_taikhoan)
        {

        }

        private void Lich_Su_Order_Load(object sender, EventArgs e)
        {
         
        }
    }
}
