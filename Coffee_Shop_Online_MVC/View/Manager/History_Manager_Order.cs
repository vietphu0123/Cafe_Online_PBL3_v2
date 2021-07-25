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
    public partial class Order_Manager : Form
    {
        int id_Manager;
        public Order_Manager(int id_manager)
        {
            id_Manager = id_manager;
            InitializeComponent();
            Manager_QL f = new Manager_QL(id_manager);
            f.C += new Manager_QL.close(Close);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dataGridView1.Columns.Contains("Chi Tiết");
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            List<DTO.Manager> mana = BLL.BLL_Account.Instance.get_Manager_by_id(id_Manager);
            DateTime datetime = dateTimePicker1.Value;
            List<DAL.Order> temp =new List<DAL.Order>();
            if(radioButton1.Checked)
            {
                temp = BLL.BLL_Order.Instance.getOrder_Status(mana[0].Id_Local_Store, "Yes", datetime.Date);               
                var l = temp.Select(p => new { p.id_Order, p.Name, p.SDT_Nhan, p.Ngay_Dat, p.Dia_Chi, p.FeedBach });
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = l.ToList();
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                edit.HeaderText = "";
                edit.Text = "Chi Tiết";
                edit.Name = "btnEditCompany";
                edit.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(edit);
            }
            if (radioButton3.Checked)
            {
                temp = BLL.BLL_Order.Instance.getOrder_Status(mana[0].Id_Local_Store, "Yes", datetime.Date);          
                var l = temp.Select(p => new { p.id_Order, p.Name, p.SDT_Nhan, p.Ngay_Dat, p.Dia_Chi, p.FeedBach });
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = l.ToList();
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                edit.HeaderText = "";
                edit.Text = "Chi Tiết";
                edit.Name = "btnEditCompany";
                edit.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(edit);
            }
            if (radioButton4.Checked)
            {
                temp = BLL.BLL_Order.Instance.getOrder_Status(mana[0].Id_Local_Store, null, datetime.Date);             
                var l = temp.Select(p => new { p.id_Order, p.Name, p.SDT_Nhan, p.Ngay_Dat, p.Dia_Chi, p.FeedBach });
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = l.ToList();
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                edit.HeaderText = "";
                edit.Text = "Chi Tiết";
                edit.Name = "btnEditCompany";
                edit.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(edit);
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    int id_order = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_Order"].Value.ToString());
                    Delivery_Detail f = new Delivery_Detail(id_order);
                    
                    f.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại! \n Thông tin lỗi:" + ex.Message, "Thông báo lỗi");
            }
        }
        public void Close()
        {
            this.Dispose();
            this.Close();
        }
    }
}