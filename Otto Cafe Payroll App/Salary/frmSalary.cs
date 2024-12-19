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

namespace Otto_Cafe_Payroll_App.Salary
{
    public partial class frmSalary : Form
    {
        // Deklarasi Pemanggilan Form //
        frmDashboard dashboardFrm;
        Employee.frmEmployee employeeFrm;
        // == BATAS == //

        public frmSalary(frmDashboard dashboardFrm)
        {
            InitializeComponent();
            this.dashboardFrm = dashboardFrm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmSalary(Employee.frmEmployee employeeFrm)
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
        DataColumn[] dc = new DataColumn[3];
        SqlCommandBuilder cb;
        SqlDataReader dl;
        bool sidebarExpand = false;
        decimal salaryLbl, allowanceLbl, txtPotGajiValue, potGaji;
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
            query = "SELECT * FROM Salary.Salary";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Salary.Salary");
            dc[0] = ds.Tables["Salary.Salary"].Columns[0];
            dc[1] = ds.Tables["Salary.Salary"].Columns[2];
            dc[2] = ds.Tables["Salary.Salary"].Columns[4];
            ds.Tables["Salary.Salary"].PrimaryKey = dc;
        }

        private void tampilData()
        {
            dgvData.DataSource = ds.Tables["Salary.Salary"];
            dgvData.Columns[0].HeaderText = "Salary ID";
            dgvData.Columns[1].HeaderText = "Date";
            dgvData.Columns[2].HeaderText = "EMP ID";
            dgvData.Columns[3].HeaderText = "Name";
            dgvData.Columns[4].HeaderText = "PST ID";
            dgvData.Columns[5].HeaderText = "Position";
            dgvData.Columns[6].HeaderText = "Salary";
            dgvData.Columns[6].DefaultCellStyle.Format = "$#,##0";
            dgvData.Columns[7].HeaderText = "Allowance";
            dgvData.Columns[7].DefaultCellStyle.Format = "$#,##0";
            dgvData.Columns[8].HeaderText = "Reduction";
            dgvData.Columns[8].DefaultCellStyle.Format = "$#,##0";
            dgvData.Columns[9].HeaderText = "On Duty";
            dgvData.Columns[10].HeaderText = "Basic Salary";
            dgvData.Columns[10].DefaultCellStyle.Format = "$#,##0";
            dgvData.Columns[11].HeaderText = "Net Salary";
            dgvData.Columns[11].DefaultCellStyle.Format = "$#,##0";
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;

            dgvData.Columns[0].Width = 70;
            dgvData.Columns[1].Width = 70;
            dgvData.Columns[2].Width = 70;
            dgvData.Columns[4].Width = 70;
            dgvData.Columns[6].Width = 70;
            dgvData.Columns[7].Width = 70;
            dgvData.Columns[8].Width = 70;
            dgvData.Columns[9].Width = 70;
            dgvData.Columns[10].Width = 90;
            dgvData.Columns[11].Width = 90;
        }

        private void updateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Salary.Salary"]);
        }
        // == BATAS == //

        // AREA PRIVATE VOID MEKANISME //
        private void sidebarTransisi_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSidebar.Width -= 10;
                if (pnlSidebar.Width <= 50)
                {
                    sidebarExpand = false;
                    sidebarTransisi.Stop();
                }
            }
            else
            {
                pnlSidebar.Width += 10;
                if (pnlSidebar.Width >= 165)
                {
                    sidebarExpand = true;
                    sidebarTransisi.Stop();
                }
            }
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            sidebarTransisi.Start();
        }

        private void hitungGaji()
        {
            // Menghitung Gaji Pokok //
            decimal salaryPokok;
            bool decimalSalary = decimal.TryParse(lblSalary.Text, out salaryLbl);
            decimal nudOnDutyValue = Convert.ToDecimal(nudOnDuty.Value);

            if (nudOnDutyValue <= 420)
            {
                salaryPokok = (nudOnDutyValue / 420) * salaryLbl;
            }
            else
            {
                salaryPokok = salaryLbl + (((nudOnDutyValue - 420) / 60) * 1000);
            }
            lblGajiPokok.Text = salaryPokok.ToString("#,##0");

            // Menghitung Gaji Bersih //
            bool desimalAllowance = decimal.TryParse(lblAllowance.Text, out allowanceLbl);
            decimal txtPotGajiValue = string.IsNullOrWhiteSpace(txtpotGaji.Text) ? 0 : Convert.ToDecimal(txtpotGaji.Text);
            decimal gajiBersih = salaryPokok + allowanceLbl - txtPotGajiValue;

            lblGajiBersih.Text = gajiBersih.ToString("#,##0");
        }

        private void kodeAuto()
        {
            long hitung;
            string urut;

            ds = new DataSet();
            query = "SELECT * FROM Salary.Salary WHERE SalaryID IN (SELECT MAX(SalaryID) FROM Salary.Salary) ORDER BY SalaryID DESC";
            cmd = new SqlCommand(query, con);
            dl = cmd.ExecuteReader();
            dl.Read();

            if (dl.HasRows)
            {
                hitung = Convert.ToInt64(dl[0].ToString().Substring(dl["SalaryID"].ToString().Length - 3, 3)) + 1;
                string joinstr = "00" + hitung;
                urut = "SLY" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "SLY001";
            }
            dl.Close();
            lblSalaryID.Text = urut;
        }

        private void nudOnDuty_ValueChanged(object sender, EventArgs e)
        {
            hitungGaji();
        }

        private void kosong()
        {
            kodeAuto();
            dtpTgl.Value = DateTime.Today;
            lblEmpID.Text = "";
            lblEmpName.Text = "";
            lblPositionID.Text = "";
            lblPositionName.Text = "";
            lblSalary.Text = "";

            lblAllowance.Text = "";
            txtpotGaji.Clear();
            nudOnDuty.Value = 0;

            lblGajiPokok.Text = "";
            lblGajiBersih.Text = "";
        }
        // == BATAS == //

        // AREA BTN ACTION //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isDecimal = decimal.TryParse(txtpotGaji.Text, out potGaji);
            string[] cari = { lblSalaryID.Text, lblEmpID.Text, lblPositionID.Text };
            loadData();

            dr = ds.Tables["Salary.Salary"].Rows.Find(cari);
            if (dr == null)
            {
                dr = ds.Tables["Salary.Salary"].NewRow();
                dr[0] = lblSalaryID.Text;
                dr[1] = dtpTgl.Value;
                dr[2] = lblEmpID.Text;
                dr[3] = lblEmpName.Text;
                dr[4] = lblPositionID.Text;
                dr[5] = lblPositionName.Text;
                dr[6] = decimal.Parse(lblSalary.Text);
                dr[7] = decimal.Parse(lblAllowance.Text);
                dr[8] = potGaji;
                dr[9] = nudOnDuty.Text;
                dr[10] = decimal.Parse(lblGajiPokok.Text);
                dr[11] = decimal.Parse(lblGajiBersih.Text);
                ds.Tables["Salary.Salary"].Rows.Add(dr);
                updateData();
                MessageBox.Show("Salary ID " + lblSalaryID.Text + " has been added.", "Add Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kosong();
            }
            else
            {
                MessageBox.Show("Salary ID " + lblSalaryID.Text + " exists in database.", "Add Salary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            koneksi();
            loadData();
            tampilData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string[] cari = { lblSalaryID.Text, lblEmpID.Text, lblPositionID.Text };
            loadData();

            dr = ds.Tables["Salary.Salary"].Rows.Find(cari);
            if (dr != null)
            {
                dr[1] = dtpTgl.Value;
                dr[2] = lblEmpID.Text;
                dr[3] = lblEmpName.Text;
                dr[4] = lblPositionID.Text;
                dr[5] = lblPositionName.Text;
                dr[6] = decimal.Parse(lblSalary.Text);
                dr[7] = decimal.Parse(lblAllowance.Text);
                dr[8] = potGaji;
                dr[9] = nudOnDuty.Text;
                dr[10] = decimal.Parse(lblGajiPokok.Text);
                dr[11] = decimal.Parse(lblGajiBersih.Text);
                updateData();
                MessageBox.Show("Salary ID " + lblSalaryID.Text + " has been edited.", "Edit Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kosong();
            }
            else
            {
                MessageBox.Show("Salary ID " + lblSalaryID.Text + " exists in database.", "Edit Salary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            koneksi();
            loadData();
            tampilData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] cari = { lblSalaryID.Text, lblEmpID.Text, lblPositionID.Text };
            loadData();

            dr = ds.Tables["Salary.Salary"].Rows.Find(cari);
            if (dr != null)
            {
                dr.Delete();
                updateData();
                MessageBox.Show("Salary ID " + lblSalaryID.Text + " has been deleted.", "Delete Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kosong();
            }
            else
            {
                MessageBox.Show("Salary ID " + lblSalaryID.Text + " exists in database.", "Delete Salary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            koneksi();
            loadData();
            tampilData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.frmSalaryList salaryLstFrm = new Report.frmSalaryList(this);
            salaryLstFrm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            kosong();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;

            lblSalaryID.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
            dtpTgl.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
            lblEmpID.Text = dgvData.Rows[baris].Cells[2].Value.ToString();
            lblEmpName.Text = dgvData.Rows[baris].Cells[3].Value.ToString();
            lblPositionID.Text = dgvData.Rows[baris].Cells[4].Value.ToString();
            lblPositionName.Text = dgvData.Rows[baris].Cells[5].Value.ToString();
            lblSalary.Text = dgvData.Rows[baris].Cells[6].Value.ToString();
            lblAllowance.Text = dgvData.Rows[baris].Cells[7].Value.ToString();
            txtpotGaji.Text = dgvData.Rows[baris].Cells[8].Value.ToString();
            nudOnDuty.Text = dgvData.Rows[baris].Cells[9].Value.ToString();
            lblGajiPokok.Text = dgvData.Rows[baris].Cells[10].Value.ToString();
            lblGajiBersih.Text = dgvData.Rows[baris].Cells[11].Value.ToString();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // == BATAS == //

        // ARAEA PEMANGGILAN FORM-FORM //
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard dashboardFrm = new frmDashboard(this);
            this.Hide();
            dashboardFrm.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee.frmEmployee employeeFrm = new Employee.frmEmployee(this);
            this.Hide();
            employeeFrm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.frmLogin loginFrm = new Login.frmLogin(this);
            this.Hide();
            loginFrm.ShowDialog();
        }

        private void btnBrowseEmployee_Click(object sender, EventArgs e)
        {
            Employee.frmBrowseEmployee browseEmployeeFrm = new Employee.frmBrowseEmployee(this);
            browseEmployeeFrm.ShowDialog();
        }
        // == BATAS == //

        private void frmSalary_Load(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            tampilData();
            kodeAuto();
            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (col != dgvData.Columns[3])
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }
    }
}
