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
    public partial class Delivery : Form
    {
        int id_Manager;
        
        public Delivery(int id_manager)
        {
            id_Manager = id_manager;
            InitializeComponent();
            order();
            addButon();
 
        }       
        public void addButon()
        {
            
        }
        public void order()
        {
            dataGridView1.Columns.Contains("Xử Lý");
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            DAL.Model1 db = new DAL.Model1();
            List<DAL.Order> temp = new List<DAL.Order>();
            int Local = 0;
            DateTime date = DateTime.Now;           
            foreach(DAL.Managers i in db.Manager)
            {
                if(i.idManager==id_Manager)
                {
                    Local = i.id_Local_Store;
                }
            }
            foreach (DAL.Order i in db.Order)
            {
            if (i.id_Local_Store==Local&&String.Compare(i.Status.ToString(),"No",true)==0&&Convert.ToDateTime(i.Ngay_Dat.ToString()).Date==date.Date)
                {
                    temp.Add(i);
                }
            }
            var l = temp.Select(p => new { p.id_Order, p.Name, p.SDT_Nhan, p.Ngay_Dat, p.Dia_Chi, p.FeedBach });           
            dataGridView1.DataSource = null;            
            dataGridView1.DataSource = l.ToList();           
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "";
            edit.Text = "Xử Lý";
            edit.Name = "btnEditCompany";
            edit.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(edit);
            timer1.Start();
            Manager_QL f = new Manager_QL(id_Manager);
            f.C += new Manager_QL.close(Close);

        }
        public void Close()
        {
            this.Dispose();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DAL.Model1 db = new DAL.Model1();
            List<Cart> Cart = new List<Cart>();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;           
            if (r.Count == 1)
            {
                Cart = BLL.BLL_Delivery.Instance.cart(Convert.ToInt32(r[0].Cells[0].Value));
                
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Cart;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    int id_order = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_Order"].Value.ToString());
                    Thanh_Toán f = new Thanh_Toán(id_order);
                    f.D = new Thanh_Toán.load(order);
                    f.ShowDialog();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại! \n Thông tin lỗi:" + ex.Message, "Thông báo lỗi");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                order();
            
              
           
        }
    }
}
