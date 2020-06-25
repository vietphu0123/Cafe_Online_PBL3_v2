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
    public partial class Form10 : Form
    {
        int id_manager;
        public Form10(int id)
        {
            id_manager = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11(id_manager);
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
