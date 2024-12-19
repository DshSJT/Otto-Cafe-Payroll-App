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

namespace Otto_Cafe_Payroll_App
{
    public partial class frmDashboard : Form
    {
        // Deklarasi Pemanggilan Form //
        Login.frmLogin loginForm;
        Employee.frmEmployee employeeFrm;
        Salary.frmSalary salaryFrm;
        // == BATAS == //

        public frmDashboard(Login.frmLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmDashboard(Employee.frmEmployee employeeFrm)
        {
            InitializeComponent();
            this.employeeFrm = employeeFrm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmDashboard(Salary.frmSalary salaryFrm)
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
        DataColumn[] dc = new DataColumn[1];
        bool sidebarExpand = false;
        int aktif = 0;
        int nonAktif = 0;
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

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if ((bool)row.Cells["Status"].Value)
                {
                    aktif++;
                }
                else
                {
                    nonAktif++;
                }
            }
            lblAvaEmp.Text = aktif.ToString();
            lblInActiveEmp.Text = nonAktif.ToString();
            lblTotalEmp.Text = dgvData.RowCount.ToString();
        }
        // == BATAS == //

        // AREA PRIVATE VOID MEKANISME SIDEBAR //
        private void sidebarTransisi_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSidebar.Width -= 10;
                if (pnlSidebar.Width <= 50)
                {
                    sidebarExpand = false;
                    sidebarTransisi.Stop();
                    grpAvaEmp.Location = new Point(164, 160); //Sblm di expand
                    grpInActiveEmp.Location = new Point(456, 160); //Sblm di expand
                    grpTotalEmp.Location = new Point(737, 160); //Sblm di expand
                }
            }
            else
            {
                pnlSidebar.Width += 10;
                if (pnlSidebar.Width >= 165)
                {
                    sidebarExpand = true;
                    sidebarTransisi.Stop();
                    grpAvaEmp.Location = new Point(223, 160); //sesdh di expand
                    grpInActiveEmp.Location = new Point(536, 160); //sesdh di expand
                    grpTotalEmp.Location = new Point(830, 160); //sesdh di expand
                }
            }
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            sidebarTransisi.Start();
        }
        // == BATAS == //

        // AREA BUTTON PERFORM & PEMANGGILAN FORM //
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee.frmEmployee employeeFrm = new Employee.frmEmployee(this);
            this.Hide();
            employeeFrm.ShowDialog();
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

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            tampilData();
            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                if (col != dgvData.Columns[1] && col != dgvData.Columns[3] && col != dgvData.Columns[4] && col != dgvData.Columns[5])
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }
    }
}
