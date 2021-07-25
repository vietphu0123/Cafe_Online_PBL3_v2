﻿using System;
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
    public partial class QuanLyOrder : Form
    {
        
        public QuanLyOrder()
        {            
            InitializeComponent();
            menu();
        }
        int Local;
        private void menu()
        {

            foreach (DTO.Local_Store i in BLL.BLL_Store.Instance.get_Store())
            {
                Button But = new Button();
                But.Name = string.Format(i.Name.ToString());
                But.Tag = string.Format(i.ToString());
                But.Text = string.Format(i.Name.ToString());
                But.Size = new Size(165, 50);
                But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                flowLayoutPanel2.Controls.Add(But);
                But.Click += new EventHandler(But_Click);
            }
        }
        private void But_Click(object sender, EventArgs e)
        {

            Local = Convert.ToInt32(((Button)sender).Tag.ToString());
            label2.Text = ((Button)sender).Text.ToString();

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dataGridView1.Columns.Contains("Chi Tiết");
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            List<DAL.Order> temp = new List<DAL.Order>();
            DateTime datetime = dateTimePicker1.Value;
            if (radioButton1.Checked)
            {               
                temp = BLL.BLL_Order.Instance.getOrder_Status(Local, "Yes", datetime.Date);
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
                temp = BLL.BLL_Order.Instance.getOrder_Status(Local, "Error", datetime.Date);
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
                temp = BLL.BLL_Order.Instance.getOrder_Status(Local, "null", datetime.Date);
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
        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
    }
}
