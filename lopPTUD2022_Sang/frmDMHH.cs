using Microsoft.Build.BuildEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lopPTUD2022_Sang
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comDt = new DataTable();
        string sql, constr;
        int i;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-F0TSIU3S;Initial Catalog=DMHH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "Select Manhom,MaHH,TenHH,dvt,DgVnd,SanXuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void txtSx_Click(object sender, EventArgs e)
        {

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i == grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, 0];
            }
            else
            {
                grdData.CurrentCell = grdData[0, i+1];
            }
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i - 1];
            NapCT();
        }

        private void btnPrc_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i == 0)
            {
                grdData.CurrentCell = grdData[0, grdData.RowCount-1];
            }
            else
            {
                grdData.CurrentCell = grdData[0,i -1];
            }
            NapCT();
        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select distinct " + comTenTruong.Text + " from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            //comDt = new DataTable();
            comDt.Clear();
            da.Fill(comDt);
            comGT.DataSource = comDt;
            comGT.DisplayMember = comTenTruong.Text;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            sql = "Select Manhom,MaHH,TenHH,dvt,DgVnd,SanXuat from tblDMHH" +
                " Where " + comTenTruong.Text + " ='" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtManhom.Text = grdData.Rows[i].Cells["manhom"].Value.ToString();
            txtMaHH.Text = grdData.Rows[i].Cells["Mahh"].Value.ToString();
            txtTenHH.Text = grdData.Rows[i].Cells["tenhh"].Value.ToString();
            txtDVT.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtDG.Text = grdData.Rows[i].Cells["dgvnd"].Value.ToString();
            txtSx.Text = grdData.Rows[i].Cells["sanxuat"].Value.ToString();
        }
    }
}
