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
    public partial class frmBrowseEmployee : Form
    {
        // Deklarasi Pemanggilan Form //
        Salary.frmSalary salaryFrm;
        // == BATAS == //

        public frmBrowseEmployee(Salary.frmSalary salaryFrm)
        {
            InitializeComponent();
            this.salaryFrm = salaryFrm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Library Deklarasi //
        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataColumn[] dc = new DataColumn[2];
        // == BATAS == //

        // AREA PRIVATE VOID DATABASE //
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
            query = "SELECT Emp.EmployeeID, Emp.EmployeeName, Pos.PositionID, Pos.PositionName, Pos.GajiPokok, Pos.Tunjangan FROM Employee.Employee Emp INNER JOIN Position.Position Pos ON Emp.PositionID = Pos.PositionID";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "vwEmployee");
            dc[0] = ds.Tables["vwEmployee"].Columns[0];
            dc[1] = ds.Tables["vwEmployee"].Columns[2];
            ds.Tables["vwEmployee"].PrimaryKey = dc;
        }

        private void tampilData()
        {
            dgvData.DataSource = ds.Tables["vwEmployee"];
            dgvData.Columns[0].HeaderText = "Employee ID";
            dgvData.Columns[1].HeaderText = "Employee Name";
            dgvData.Columns[2].HeaderText = "Position ID";
            dgvData.Columns[3].HeaderText = "Position Name";
            dgvData.Columns[4].HeaderText = "Salary";
            dgvData.Columns[4].DefaultCellStyle.Format = "$#,##0";
            dgvData.Columns[5].HeaderText = "Allowance";
            dgvData.Columns[5].DefaultCellStyle.Format = "$#,##0";
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;

            dgvData.Columns[0].Width = 80;
            dgvData.Columns[1].Width = 90;
            dgvData.Columns[2].Width = 80;
            dgvData.Columns[3].Width = 80;
            dgvData.Columns[4].Width = 80;

            lblJumlahRecord.Text = dgvData.RowCount.ToString();
        }
        // == BATAS == //

        // AREA PRIVATE VOID MEKANISME //
        private void searchData()
        {
            ds = new DataSet();
            query = "SELECT Emp.EmployeeID, Emp.EmployeeName, Pos.PositionID, Pos.PositionName, Pos.GajiPokok, Pos.Tunjangan FROM Employee.Employee Emp INNER JOIN Position.Position Pos ON Emp.PositionID = Pos.PositionID WHERE Emp.EmployeeID LIKE '%" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "vwEmployee");
            dc[0] = ds.Tables["vwEmployee"].Columns[0];
            dc[1] = ds.Tables["vwEmployee"].Columns[2];
            ds.Tables["vwEmployee"].PrimaryKey = dc;
        }
        // == BATAS == //

        // AREA BUTTON ACTION //
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchData();
            tampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            tampilData();
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;

            salaryFrm.lblEmpID.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
            salaryFrm.lblEmpName.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
            salaryFrm.lblPositionID.Text = dgvData.Rows[baris].Cells[2].Value.ToString();
            salaryFrm.lblPositionName.Text = dgvData.Rows[baris].Cells[3].Value.ToString();
            decimal salaryParse = decimal.Parse(dgvData.Rows[baris].Cells[4].Value.ToString());
            salaryFrm.lblSalary.Text = salaryParse.ToString("#,##0");
            decimal allowanceParse = decimal.Parse(dgvData.Rows[baris].Cells[5].Value.ToString());
            salaryFrm.lblAllowance.Text = allowanceParse.ToString("#,##0");
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // == BATAS == //

        private void frmBrowseEmployee_Load(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            tampilData();
            this.AcceptButton = btnSearch;
            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (col != dgvData.Columns[1])
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }
    }
}
