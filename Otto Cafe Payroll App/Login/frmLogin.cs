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

namespace Otto_Cafe_Payroll_App.Login
{
    public partial class frmLogin : Form
    {
        // Deklarasi Pemanggilan Form //
        frmDashboard dashboardFrm;
        frmChangePassword changePassFrm;
        Employee.frmEmployee employeeFrm;
        Salary.frmSalary salaryFrm;
        // == BATAS == //

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(frmDashboard dashboardFrm)
        {
            InitializeComponent();
            this.dashboardFrm = dashboardFrm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmLogin(frmChangePassword changePassFrm)
        {
            InitializeComponent();
            this.changePassFrm = changePassFrm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmLogin(Employee.frmEmployee employeeFrm)
        {
            InitializeComponent();
            this.employeeFrm = employeeFrm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmLogin(Salary.frmSalary salaryFrm)
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
        DataColumn[] dc = new DataColumn[1];
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
            query = "SELECT * FROM Login.Login";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Login.Login");
            dc[0] = ds.Tables["Login.Login"].Columns[0];
            ds.Tables["Login.Login"].PrimaryKey = dc;
        }
        // == BATAS == //

        private void frmLogin_Load(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            txtPassword.PasswordChar = '*';
            txtUserID.MaxLength = 6;
            txtPassword.MaxLength = 50;
        }

        // AREA BUTTON PERFORM //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            dr = ds.Tables["Login.Login"].Rows.Find(txtUserID.Text);

            if (dr != null)
            {
                if (dr[1].ToString() == txtPassword.Text)
                {
                    MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDashboard dashboardForm = new frmDashboard(this);
                    this.Hide();
                    dashboardForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your Password is Wrong", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Clear();
                    txtPassword.Clear();
                    txtUserID.Focus();
                }
            }
            else
            {
                MessageBox.Show("User ID " + txtUserID.Text + " not found", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Clear();
                txtPassword.Clear();
                txtUserID.Focus();
            }
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;  // Menghindari suara bip
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;  // Menghindari suara bip
            }
        }

        private void toogleShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (toogleShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword changePassFrm = new frmChangePassword(this);
            changePassFrm.ShowDialog();
        }

        // Note: txtUserID & txtPassword KeyDown untuk ketika user selesain mengetik di Username dan menekan ENTER, maka focus beralih ke txtPassword, demikian juga ketika user sudah selesai memasukkan Password, user tinggal menekan ENTER dan btnLogin akan trigger
        // == BATAS == //
    }
}
