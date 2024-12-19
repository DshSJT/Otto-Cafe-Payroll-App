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
    public partial class frmEmployee : Form
    {
        // Deklarasi Pemanggilan Form //
        frmDashboard dashboardFrm;
        Salary.frmSalary salaryFrm;
        // == BATAS == //

        public frmEmployee(frmDashboard dashboardFrm)
        {
            InitializeComponent();
            this.dashboardFrm = dashboardFrm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmEmployee(Salary.frmSalary salaryFrm)
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
        DataRow dr;
        DataColumn[] dc = new DataColumn[2];
        DataColumn[] dc2 = new DataColumn[2];
        SqlCommandBuilder cb;
        SqlDataReader dl;
        bool sidebarExpand = false;
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
            query = "SELECT * FROM Employee.Employee";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Employee.Employee");
            dc[0] = ds.Tables["Employee.Employee"].Columns[0];
            dc[1] = ds.Tables["Employee.Employee"].Columns[8];
            ds.Tables["Employee.Employee"].PrimaryKey = dc;
        }

        private void tampilData()
        {
            dgvData.DataSource = ds.Tables["Employee.Employee"];
            dgvData.Columns[0].HeaderText = "Employee ID";
            dgvData.Columns[1].HeaderText = "Employee Name";
            dgvData.Columns[2].HeaderText = "Gender";
            dgvData.Columns[3].HeaderText = "Phone";
            dgvData.Columns[4].HeaderText = "Address";
            dgvData.Columns[5].HeaderText = "Email";
            dgvData.Columns[6].HeaderText = "Date In";
            dgvData.Columns[7].HeaderText = "Status";
            dgvData.Columns[8].HeaderText = "Position ID";
            dgvData.Columns[9].HeaderText = "Basic Salary";
            dgvData.Columns[9].DefaultCellStyle.Format = "$#,##0";
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
        }

        private void updateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Employee.Employee"]);
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

        private void kodeAuto()
        {
            long hitung;
            string urut;

            ds = new DataSet();
            query = "SELECT * FROM Employee.Employee WHERE EmployeeID IN (SELECT MAX(EmployeeID) FROM Employee.Employee) ORDER BY EmployeeID DESC";
            cmd = new SqlCommand(query, con);
            dl = cmd.ExecuteReader();
            dl.Read();

            if (dl.HasRows)
            {
                hitung = Convert.ToInt64(dl[0].ToString().Substring(dl["EmployeeID"].ToString().Length - 3, 3)) + 1;
                string joinstr = "00" + hitung;
                urut = "EMP" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "EMP001";
            }
            dl.Close();
            lblEmpID.Text = urut;
        }

        private void kosong()
        {
            kodeAuto();
            dtpTglMasuk.Value = DateTime.Today;
            txtEmpName.Clear();
            lblPositionID.Text = "";
            lblSalary.Text = "";
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();

            cboGender.SelectedIndex = -1;

            rdoActive.Checked = false;
            rdoNonActive.Checked = false;

            txtEmpName.Focus();
        }
        // == BATAS == //

        // AREA BUTTON ACTION & PEMANGGILAN FORM //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] cari = { lblEmpID.Text, lblPositionID.Text };
            if (!string.IsNullOrWhiteSpace(lblEmpID.Text) && !string.IsNullOrWhiteSpace(txtEmpName.Text) && !string.IsNullOrWhiteSpace(lblPositionID.Text) && !string.IsNullOrWhiteSpace(lblSalary.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) && !string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                loadData();
                dr = ds.Tables["Employee.Employee"].Rows.Find(cari);
             
                if (dr == null)
                {
                    dr = ds.Tables["Employee.Employee"].NewRow();
                    dr[0] = lblEmpID.Text;
                    dr[1] = txtEmpName.Text;
                    dr[2] = cboGender.Text;
                    dr[3] = txtPhone.Text;
                    dr[4] = txtAddress.Text;
                    dr[5] = txtEmail.Text;
                    dr[6] = dtpTglMasuk.Value;
                    if (rdoActive.Checked)
                    {
                        dr[7] = true;
                    }
                    else if (rdoNonActive.Checked)
                    {
                        dr[7] = false;
                    }
                    dr[8] = lblPositionID.Text;
                    dr[9] = decimal.Parse(lblSalary.Text);
                    ds.Tables["Employee.Employee"].Rows.Add(dr);
                    updateData();

                    MessageBox.Show("Employee ID " + lblEmpID.Text + " has been inserted.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kosong();
                }
                else
                {
                    MessageBox.Show("Employee ID " + lblEmpID.Text + " exists in database.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete the data.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            koneksi();
            loadData();
            tampilData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string[] cari = { lblEmpID.Text, lblPositionID.Text };
            if (!string.IsNullOrWhiteSpace(lblEmpID.Text) && !string.IsNullOrWhiteSpace(txtEmpName.Text) && !string.IsNullOrWhiteSpace(lblPositionID.Text) && !string.IsNullOrWhiteSpace(lblSalary.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) && !string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                loadData();
                dr = ds.Tables["Employee.Employee"].Rows.Find(cari);

                if (dr != null)
                {
                    dr[1] = txtEmpName.Text;
                    dr[2] = cboGender.Text;
                    dr[3] = txtPhone.Text;
                    dr[4] = txtAddress.Text;
                    dr[5] = txtEmail.Text;
                    dr[6] = dtpTglMasuk.Value;
                    if (rdoActive.Checked)
                    {
                        dr[7] = true;
                    }
                    else if (rdoNonActive.Checked)
                    {
                        dr[7] = false;
                    }
                    dr[8] = lblPositionID.Text;
                    dr[9] = decimal.Parse(lblSalary.Text);
                    updateData();
                    MessageBox.Show("Employee ID " + lblEmpID.Text + " has been Edited.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kosong();
                }
                else
                {
                    MessageBox.Show("Employee ID " + lblEmpID.Text + " does not exists in database.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete the data.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            koneksi();
            loadData();
            tampilData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] cari = { lblEmpID.Text, lblPositionID.Text };
            if (!string.IsNullOrWhiteSpace(lblEmpID.Text) && !string.IsNullOrWhiteSpace(txtEmpName.Text) && !string.IsNullOrWhiteSpace(lblPositionID.Text) && !string.IsNullOrWhiteSpace(lblSalary.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) && !string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                loadData();
                dr = ds.Tables["Employee.Employee"].Rows.Find(cari);

                if (dr != null)
                {
                    dr.Delete();
                    updateData();
                    MessageBox.Show("Employee ID " + lblEmpID.Text + " has been Deleted.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kosong();
                }
                else
                {
                    MessageBox.Show("Employee ID " + lblEmpID.Text + " exists in database.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete the data.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            koneksi();
            loadData();
            tampilData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            kosong();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;

            lblEmpID.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
            txtEmpName.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
            cboGender.Text = dgvData.Rows[baris].Cells[2].Value.ToString();
            txtPhone.Text = dgvData.Rows[baris].Cells[3].Value.ToString();
            txtAddress.Text = dgvData.Rows[baris].Cells[4].Value.ToString();
            txtEmail.Text = dgvData.Rows[baris].Cells[5].Value.ToString();
            dtpTglMasuk.Text = dgvData.Rows[baris].Cells[6].Value.ToString();
            if (bool.Parse(dgvData.Rows[baris].Cells[7].Value.ToString()) == true)
            {
                rdoActive.Checked = true;
                rdoNonActive.Checked = false;
            }
            else if (bool.Parse(dgvData.Rows[baris].Cells[7].Value.ToString()) == false)
            {
                rdoActive.Checked = false;
                rdoNonActive.Checked = true;
            }
            lblPositionID.Text = dgvData.Rows[baris].Cells[8].Value.ToString();
            decimal salaryParse = decimal.Parse(dgvData.Rows[baris].Cells[9].Value.ToString());
            lblSalary.Text = salaryParse.ToString("#,##0");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();

            if (rdoEmpID.Checked)
            {
                query = "SELECT * FROM Employee.Employee WHERE EmployeeID LIKE '%" + txtSearch.Text + "%'";
            }
            else if (rdoEmpName.Checked)
            {
                query = "SELECT * FROM Employee.Employee WHERE EmployeeName LIKE '%" + txtSearch.Text + "%'";
            }

            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Employee.Employee");
            dc[0] = ds.Tables["Employee.Employee"].Columns[0];
            dc[1] = ds.Tables["Employee.Employee"].Columns[2];
            ds.Tables["Employee.Employee"].PrimaryKey = dc;
            tampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            tampilData();
            rdoEmpID.Checked = false;
            rdoEmpName.Checked = false;
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnBrowsePosition_Click(object sender, EventArgs e)
        {
            Employee.frmBrowseProduct browsePositionFrm = new Employee.frmBrowseProduct(this);
            browsePositionFrm.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard dashboardFrm = new frmDashboard(this);
            this.Hide();
            dashboardFrm.ShowDialog();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary.frmSalary salaryFrm = new Salary.frmSalary(this);
            this.Hide();
            salaryFrm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.frmLogin loginFrm = new Login.frmLogin(this);
            this.Hide();
            loginFrm.ShowDialog();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // == BATAS == //

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            tampilData();
            kodeAuto();

            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (col != dgvData.Columns[1] && col != dgvData.Columns[3] && col != dgvData.Columns[4] && col != dgvData.Columns[5])
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            txtEmpName.MaxLength = 30;
            txtPhone.MaxLength = 15;
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Items.Add("Men");
            cboGender.Items.Add("Women");
        }
    }
}