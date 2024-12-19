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
    public partial class frmChangePassword : Form
    {
        frmLogin loginFrm;

        public frmChangePassword()
        {
            InitializeComponent();
        }

        public frmChangePassword(frmLogin loginFrm)
        {
            InitializeComponent();
            this.loginFrm = loginFrm;
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
        SqlCommandBuilder cb;
        SqlDataReader dl;
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

        private void updateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Login.Login"]);
        }
        // == BATAS == //

        private void kosong()
        {
            txtUserID.Clear();
            txtPassword.Clear();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            txtPassword.PasswordChar = '*';
            txtUserID.MaxLength = 6;
            txtPassword.MaxLength = 50;
        }
        
        // AREA BUTTON PERFORM //
        private void btnSave_Click(object sender, EventArgs e)
        {
            loadData();
            dr = ds.Tables["Login.Login"].Rows.Find(txtUserID.Text);

            if (!string.IsNullOrWhiteSpace(txtUserID.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (dr != null)
                {
                    dr[1] = txtPassword.Text;
                    updateData();
                    MessageBox.Show("Password for" + txtUserID.Text + " has been Changed.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kosong();

                    MessageBox.Show("Back to Login?", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin loginFrm = new frmLogin(this);
                    this.Hide();
                    loginFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User ID " + txtUserID.Text + " does not exists in database.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete the data.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                btnSave.PerformClick();
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
            this.Close();
        }
        // == BATAS == //
    }
}
