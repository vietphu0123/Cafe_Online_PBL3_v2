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
    public partial class Giao_Hàng : Form
    {
        int id_Manager;
        public Giao_Hàng(int id_manager)
        {
            id_Manager = id_manager;
            InitializeComponent();
            load(id_Manager);
        }
        public void load(int id_Manager)
        {
            DAL.Model1 db = new DAL.Model1();
            List<DAL.Order> temp = new List<DAL.Order>();
            int Local = 0;
            DateTime date = DateTime.Now;

            foreach (DAL.Managers i in db.Manager)
            {
                if (i.idManager == id_Manager)
                {
                    Local = i.id_Local_Store;
                }
            }
            foreach (DAL.Order i in db.Order)
            {
                if (i.id_Local_Store == Local && String.Compare(i.Status.ToString(), "Null", true) == 0 && Convert.ToDateTime(i.Ngay_Dat.ToString()).Date == date.Date)
                {
                    temp.Add(i);
                }

            }
            var l = temp.Select(p => new { p.id_Order, p.Name, p.SDT_Nhan, p.Ngay_Dat, p.Dia_Chi, p.FeedBach });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = l.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            DialogResult dialog = MessageBox.Show("Đơn Hàng Này Không Được Nhận ?", "Xác Nhận", MessageBoxButtons.YesNo);
            if(dialog== DialogResult.Yes)
            {
                BLL.BLL_Delivery.Instance.Status_Delivery(Convert.ToInt32(r[0].Cells["id_Order"].Value.ToString()), "Error");
                MessageBox.Show("Thành Công!");
                load(id_Manager);
            }
            else if(dialog == DialogResult.No)
            {
                return;

            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            DialogResult dialog = MessageBox.Show("Đơn Hàng Này Đã Được Nhận ?", "Xác Nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                BLL.BLL_Delivery.Instance.Status_Delivery(Convert.ToInt32(r[0].Cells["id_Order"].Value.ToString()), "Yes");
                MessageBox.Show("Thành Công!");
                load(id_Manager);
            }
            else if (dialog == DialogResult.No)
            {
                return;
            }
        }
    }
}
