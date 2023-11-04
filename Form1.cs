using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamThiPhuongVy_2121110056_Buoi04
{
    public partial class Form1 : Form
    {
        int chon = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên chưa nhập");
                }
                string hoten = txtHoTen.Text;
                lbDSSV.Items.Add(hoten);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDSSV.Items.Add("Phương Vi");
            lbDSSV.Items.Add("Phan Hiển");
            lbDSSV.Items.Add("Trà Mi");
            lbDSSV.Items.Add("Trúc Li");
            lbDSSV.Items.Add("Thúy Nga");
            lbDSSV.Items.Add("Thái Tiên");
            cbKhoa.SelectedIndex = 0;
        }

        private void lbDSSV_Click(object sender, EventArgs e)
        {

        }

        private void btnChonSV(object sender, EventArgs e)
        {
            if(chon!=-1)
            {
                string hoten = lbDSSV.SelectedItem.ToString();
                string khoa = cbKhoa.SelectedItem.ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvLop.Items.Add(item);
                lbDSSV.Items.RemoveAt(lbDSSV.SelectedIndex);
                chon = -1;
            }    
        }

        private void btnThemAll_Click(object sender, EventArgs e)
        {
            int count = lbDSSV.Items.Count;
            for(int vt = 0; vt < count; vt++)
            {
                string khoa = cbKhoa.SelectedItem.ToString();
                string hoten = lbDSSV.Items[vt].ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvLop.Items.Add(item);
            }
            lbDSSV.Items.Clear();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvLop.Items)
            {
                if (item.Selected)
                {
                    lvLop.Items.Remove(item);
                    lbDSSV.Items.Add(item.Text);
                }
            }
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvLop.Items)
            {
                lvLop.Items.Add(item.Text);
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
