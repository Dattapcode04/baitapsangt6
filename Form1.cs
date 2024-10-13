using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3vn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MSNV", "MSNV");
            dataGridView1.Columns.Add("TenNV", "Tên NV");
            dataGridView1.Columns.Add("LuongCB", "Lương CB");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(form.MSNV, form.TenNV, form.LuongCB);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Form2 form = new Form2();

                form.MSNV = row.Cells[0].Value.ToString();
                form.TenNV = row.Cells[1].Value.ToString();
                form.LuongCB = row.Cells[2].Value.ToString();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    row.Cells[0].Value = form.MSNV;
                    row.Cells[1].Value = form.TenNV;
                    row.Cells[2].Value = form.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
