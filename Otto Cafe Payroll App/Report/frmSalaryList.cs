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

namespace Otto_Cafe_Payroll_App.Report
{
    public partial class frmSalaryList : Form
    {
        // Deklarasi Pemanggilan Form //
        Salary.frmSalary salaryFrm;
        // == BATAS == //

        public frmSalaryList(Salary.frmSalary salaryFrm)
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
        DataColumn[] dc = new DataColumn[3];
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

        private void loadDataAll()
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

        private void loadDataFilter()
        {
            ds = new DataSet();
            query = "SELECT * FROM Salary.Salary WHERE SalaryID BETWEEN '" + cboDari.SelectedItem + "' AND '" + cboSampai.SelectedItem + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Salary.Salary");
            dc[0] = ds.Tables["Salary.Salary"].Columns[0];
            dc[1] = ds.Tables["Salary.Salary"].Columns[2];
            dc[2] = ds.Tables["Salary.Salary"].Columns[4];
            ds.Tables["Salary.Salary"].PrimaryKey = dc;
        }
        // == BATAS == //

        // AREA BTN ACTION //
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Report.crSalary cr = new Report.crSalary();
            Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();
            loadDataAll();
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "WEEKLY SHEET SALARY";
            viewer.Show();
        }

        private void btnShowSheet_Click(object sender, EventArgs e)
        {
            Report.crSalary cr = new Report.crSalary();
            Report.frmCrystalReportViewer viewer = new Report.frmCrystalReportViewer();
            loadDataFilter();
            cr.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "WEEKLY SHEET SALARY";
            viewer.Show();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // == BATAS == //

        private void frmSalaryList_Load(object sender, EventArgs e)
        {
            koneksi();
            loadDataAll();
            foreach (DataRow dr in ds.Tables["Salary.Salary"].Rows)
            {
                cboDari.Items.Add(dr[0]);
                cboSampai.Items.Add(dr[0]);
            }
        }
    }
}
