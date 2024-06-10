using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Hinhtron1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double TinhDienTich(double bk) { return bk * bk * Math.PI; }
        double TinhChuVi(double bk) { return bk *2*Math.PI; }
        private void btndientich_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double dientich = TinhDienTich(bankinh);
            lblkq.Text = "-Diện tích " + Convert.ToString(dientich);
            lblkq.Text = dientich.ToString();
        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double dientich = TinhChuVi(bankinh);
            lblkq.Text = "-Chu vi " + Convert.ToString(dientich);
            lblkq.Text = dientich.ToString();
        }

        private void btbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnloai1_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            if (rdbdientich.Checked)
            {
                double dientich = bankinh * bankinh * Math.PI;
                string thongbao = "-Diện tích " + Convert.ToString(dientich);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbchuvi.Checked)
            {
                double chuvi = bankinh * 2 * Math.PI;
                string thongbao = "-Chu vi " + Convert.ToString(chuvi);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnloai2_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            string thongbao = "";
            if (cbdientich.Checked)
            {
                double dientich = bankinh * bankinh * Math.PI;
                thongbao = thongbao + "-Diện tích " + Convert.ToString(dientich) + Environment.NewLine;
            }
            if (cbchuvi.Checked)
            {
                double chuvi = bankinh * 2 * Math.PI;
                thongbao = thongbao + "-Chu vi " + Convert.ToString(chuvi) + Environment.NewLine;
            }
            if (thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
