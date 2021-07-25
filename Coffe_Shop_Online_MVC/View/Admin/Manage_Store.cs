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
    public partial class Quản_Lý_Các_Cửa_Hàng : Form
    {
        public Quản_Lý_Các_Cửa_Hàng()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thêm_Cửa_Hàng f = new Thêm_Cửa_Hàng();
            f.Show1 += new Thêm_Cửa_Hàng.show(show);
            f.ShowDialog();
           
        }
        public void show ()
        {         
            dataGridView1.DataSource = BLL.BLL_Store.Instance.get_Store_Dynamic().ToList();
        }
        private void Quản_Lý_Các_Cửa_Hàng_Load(object sender, EventArgs e)
        {
            show();
        }
        private void button3_Click(object sender, EventArgs e)
        {           
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            bool check = false;
            if (r.Count == 1)
            {
                foreach (DTO.Manager i in BLL.BLL_Account.Instance.get_Manager())
                {
                    if (Convert.ToInt32(r[0].Cells[0].Value.ToString()) == i.Id_Local_Store)
                    {
                        check = true;
                    }              
                }                
            }
            if(check==true)
            {
                ThongTinManager f = new ThongTinManager(Convert.ToInt32(r[0].Cells[0].Value.ToString()));
                f.ShowDialog();
            }
            else
            {
                TaoTKManager f = new TaoTKManager(Convert.ToInt32(r[0].Cells[0].Value.ToString()));
                f.ShowDialog();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DAL.Model1 db = new DAL.Model1();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            int id_tk = 0;
            foreach(DTO.Local_Store i in BLL.BLL_Store.Instance.get_Store())
            {
                if(Convert.ToInt32(r[0].Cells[0].Value.ToString())==i.Id_Local_Store)
                {
                    BLL.BLL_Store.Instance.dele_Store(i.Id_Local_Store);                
                }
                foreach(DAL.Managers j in db.Manager)
                {
                    if(i.Id_Local_Store==j.id_Local_Store)
                    {
                        id_tk = j.idTaiKhoan;
                    }
                }
            }        
            foreach(DAL.TaiKhoan i in db.TaiKhoan)
            {
                if(i.idTaiKhoan==id_tk)
                {
                    BLL.BLL_Account.Instance.dele_Manager(i.idTaiKhoan);
                }
            }
            dataGridView1.DataSource = BLL.BLL_Store.Instance.get_Store_Dynamic1().ToList();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
