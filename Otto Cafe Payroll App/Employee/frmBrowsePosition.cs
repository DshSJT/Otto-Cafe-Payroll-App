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

namespace Otto_Cafe_Payroll_App.Employee
{
    public partial class frmBrowseProduct : Form
    {
        // Deklarasi Pemanggilan Form //
        frmEmployee employeeFrm;
        // == BATAS == //

        public frmBrowseProduct(frmEmployee employeeFrm)
        {
            InitializeComponent();
            this.employeeFrm = employeeFrm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Library Deklarasi //
        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc = new DataColumn[1];
        // == BATAS == //

        // AREA PRIVATE VOID MEKANISME //
        private void koneksi()
        {
            try
            {
                constr = "Data Source = localhost; Initial Catalog = Otto Cafe Payroll; Integrated Security = true";
                con = new SqlConnection(constr);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Position.Position";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Position.Position");
            dc[0] = ds.Tables["Position.Position"].Columns[0];
            ds.Tables["Position.Position"].PrimaryKey = dc;
        }

        private void tampilData()
        {
            dgvData.DataSource = ds.Tables["Position.Position"];
            dgvData.Columns[0].HeaderText = "Position ID";
            dgvData.Columns[1].HeaderText = "Position Name";
            dgvData.Columns[2].HeaderText = "Basic Salary";
            dgvData.Columns[2].DefaultCellStyle.Format = "$#,##0";
            dgvData.Columns[3].HeaderText = "Allowance";
            dgvData.Columns[3].DefaultCellStyle.Format = "$#,##0";
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            lblJumlahRecord.Text = dgvData.RowCount.ToString();
        }
        // == BATAS == //

        // AREA PRIVATE VOID MEKANISME //
        private void searchData()
        {
            ds = new DataSet();

            if (rdoPositionID.Checked)
            {
                query = "SELECT * FROM Position.Position WHERE PositionID LIKE '%" + txtSearch.Text + "%'";
            }
            else if (rdoPositionName.Checked)
            {
                query = "SELECT * FROM Position.Position WHERE PositionName LIKE '%" + txtSearch.Text + "%'";
            }

            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Position.Position");
            dc[0] = ds.Tables["Position.Position"].Columns[0];
            ds.Tables["Position.Position"].PrimaryKey = dc;
            tampilData();
        }
        // == BATAS == //

        // AREA BUTTON PERFORM //
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;

            employeeFrm.lblPositionID.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
            decimal salaryParse = decimal.Parse(dgvData.Rows[baris].Cells[2].Value.ToString());
            employeeFrm.lblSalary.Text = salaryParse.ToString("#,##0");
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchData();
            tampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            tampilData();
            rdoPositionID.Checked = false;
            rdoPositionName.Checked = false;
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // == BATAS == //

        private void frmBrowseProduct_Load(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            tampilData();
            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
