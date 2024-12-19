
namespace Otto_Cafe_Payroll_App.Salary
{
    partial class frmSalary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalary));
            this.pnlUp = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new RJCodeAdvance.RJControls.RJButton();
            this.btnSalary = new RJCodeAdvance.RJControls.RJButton();
            this.btnEmployee = new RJCodeAdvance.RJControls.RJButton();
            this.btnDashboard = new RJCodeAdvance.RJControls.RJButton();
            this.sidebarTransisi = new System.Windows.Forms.Timer(this.components);
            this.grpEmployee = new Krypton.Toolkit.KryptonGroupBox();
            this.btnPrint = new RJCodeAdvance.RJControls.RJButton();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.lblSalaryID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudOnDuty = new Krypton.Toolkit.KryptonNumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new RJCodeAdvance.RJControls.RJButton();
            this.dtpTgl = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnDelete = new RJCodeAdvance.RJControls.RJButton();
            this.btnEdit = new RJCodeAdvance.RJControls.RJButton();
            this.btnAdd = new RJCodeAdvance.RJControls.RJButton();
            this.lblGajiBersih = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGajiPokok = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpotGaji = new Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPositionID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPositionName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnBrowseEmployee = new RJCodeAdvance.RJControls.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvData = new Krypton.Toolkit.KryptonDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEmployee.Panel)).BeginInit();
            this.grpEmployee.Panel.SuspendLayout();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.LightCyan;
            this.pnlUp.Controls.Add(this.picClose);
            this.pnlUp.Controls.Add(this.picMenu);
            this.pnlUp.Controls.Add(this.label4);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1100, 47);
            this.pnlUp.TabIndex = 3;
            // 
            // picClose
            // 
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.IconCloseBlue;
            this.picClose.Location = new System.Drawing.Point(1064, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.TabIndex = 11;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMenu
            // 
            this.picMenu.BackColor = System.Drawing.Color.Transparent;
            this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenu.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.menuBlue;
            this.picMenu.Location = new System.Drawing.Point(11, 12);
            this.picMenu.Margin = new System.Windows.Forms.Padding(2);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(31, 24);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 1;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "SALARY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnSalary);
            this.pnlSidebar.Controls.Add(this.btnEmployee);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 47);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(50, 653);
            this.pnlSidebar.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogout.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.logoutWhite;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(11, 601);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "  LOG OUT";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSalary.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnSalary.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalary.BorderRadius = 0;
            this.btnSalary.BorderSize = 0;
            this.btnSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.Color.White;
            this.btnSalary.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.salaryWhite;
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(11, 146);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(151, 40);
            this.btnSalary.TabIndex = 4;
            this.btnSalary.Text = "SALARY\r\n";
            this.btnSalary.TextColor = System.Drawing.Color.White;
            this.btnSalary.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEmployee.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnEmployee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEmployee.BorderRadius = 0;
            this.btnEmployee.BorderSize = 0;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.icons8_employee_25;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(11, 85);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(146, 40);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "  EMPLOYEE\r\n";
            this.btnEmployee.TextColor = System.Drawing.Color.White;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDashboard.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnDashboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.BorderSize = 0;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.icons8_laptop_metrics_25;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(11, 29);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(146, 40);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "   DASHBOARD";
            this.btnDashboard.TextColor = System.Drawing.Color.White;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // sidebarTransisi
            // 
            this.sidebarTransisi.Interval = 5;
            this.sidebarTransisi.Tick += new System.EventHandler(this.sidebarTransisi_Tick);
            // 
            // grpEmployee
            // 
            this.grpEmployee.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEmployee.Location = new System.Drawing.Point(50, 47);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            // 
            // grpEmployee.Panel
            // 
            this.grpEmployee.Panel.Controls.Add(this.label3);
            this.grpEmployee.Panel.Controls.Add(this.btnPrint);
            this.grpEmployee.Panel.Controls.Add(this.lblAllowance);
            this.grpEmployee.Panel.Controls.Add(this.lblSalaryID);
            this.grpEmployee.Panel.Controls.Add(this.label12);
            this.grpEmployee.Panel.Controls.Add(this.nudOnDuty);
            this.grpEmployee.Panel.Controls.Add(this.label1);
            this.grpEmployee.Panel.Controls.Add(this.btnCancel);
            this.grpEmployee.Panel.Controls.Add(this.dtpTgl);
            this.grpEmployee.Panel.Controls.Add(this.btnDelete);
            this.grpEmployee.Panel.Controls.Add(this.btnEdit);
            this.grpEmployee.Panel.Controls.Add(this.btnAdd);
            this.grpEmployee.Panel.Controls.Add(this.lblGajiBersih);
            this.grpEmployee.Panel.Controls.Add(this.label15);
            this.grpEmployee.Panel.Controls.Add(this.lblGajiPokok);
            this.grpEmployee.Panel.Controls.Add(this.label13);
            this.grpEmployee.Panel.Controls.Add(this.label11);
            this.grpEmployee.Panel.Controls.Add(this.txtpotGaji);
            this.grpEmployee.Panel.Controls.Add(this.label6);
            this.grpEmployee.Panel.Controls.Add(this.label10);
            this.grpEmployee.Panel.Controls.Add(this.lblSalary);
            this.grpEmployee.Panel.Controls.Add(this.label9);
            this.grpEmployee.Panel.Controls.Add(this.lblPositionID);
            this.grpEmployee.Panel.Controls.Add(this.label2);
            this.grpEmployee.Panel.Controls.Add(this.lblPositionName);
            this.grpEmployee.Panel.Controls.Add(this.label5);
            this.grpEmployee.Panel.Controls.Add(this.lblEmpID);
            this.grpEmployee.Panel.Controls.Add(this.btnBrowseEmployee);
            this.grpEmployee.Panel.Controls.Add(this.label7);
            this.grpEmployee.Panel.Controls.Add(this.lblEmpName);
            this.grpEmployee.Panel.Controls.Add(this.label8);
            this.grpEmployee.Size = new System.Drawing.Size(1050, 331);
            this.grpEmployee.TabIndex = 19;
            this.grpEmployee.Values.Heading = "DATA SALARY";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(729, 265);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(33, 35);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblAllowance
            // 
            this.lblAllowance.BackColor = System.Drawing.Color.White;
            this.lblAllowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllowance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAllowance.Location = new System.Drawing.Point(694, 107);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(119, 25);
            this.lblAllowance.TabIndex = 70;
            this.lblAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalaryID
            // 
            this.lblSalaryID.BackColor = System.Drawing.Color.White;
            this.lblSalaryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalaryID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryID.Location = new System.Drawing.Point(134, 9);
            this.lblSalaryID.Name = "lblSalaryID";
            this.lblSalaryID.Size = new System.Drawing.Size(106, 25);
            this.lblSalaryID.TabIndex = 69;
            this.lblSalaryID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 25);
            this.label12.TabIndex = 68;
            this.label12.Text = "Salary ID";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudOnDuty
            // 
            this.nudOnDuty.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOnDuty.Location = new System.Drawing.Point(134, 204);
            this.nudOnDuty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudOnDuty.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOnDuty.Name = "nudOnDuty";
            this.nudOnDuty.Size = new System.Drawing.Size(75, 22);
            this.nudOnDuty.TabIndex = 66;
            this.nudOnDuty.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOnDuty.ValueChanged += new System.EventHandler(this.nudOnDuty_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Date Salary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.btnCancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.Location = new System.Drawing.Point(495, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(33, 35);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpTgl
            // 
            this.dtpTgl.CustomFormat = "dd MMMM yyyy";
            this.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTgl.Location = new System.Drawing.Point(422, 13);
            this.dtpTgl.Name = "dtpTgl";
            this.dtpTgl.Size = new System.Drawing.Size(119, 21);
            this.dtpTgl.TabIndex = 43;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.btnWaste;
            this.btnDelete.Location = new System.Drawing.Point(439, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(24, 35);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.btnCreate;
            this.btnEdit.Location = new System.Drawing.Point(376, 265);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(33, 35);
            this.btnEdit.TabIndex = 62;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.btnAddBlack;
            this.btnAdd.Location = new System.Drawing.Point(318, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 35);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblGajiBersih
            // 
            this.lblGajiBersih.BackColor = System.Drawing.Color.White;
            this.lblGajiBersih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGajiBersih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGajiBersih.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGajiBersih.Location = new System.Drawing.Point(422, 201);
            this.lblGajiBersih.Name = "lblGajiBersih";
            this.lblGajiBersih.Size = new System.Drawing.Size(154, 25);
            this.lblGajiBersih.TabIndex = 60;
            this.lblGajiBersih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(316, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 25);
            this.label15.TabIndex = 59;
            this.label15.Text = "Total Net Salary";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGajiPokok
            // 
            this.lblGajiPokok.BackColor = System.Drawing.Color.White;
            this.lblGajiPokok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGajiPokok.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGajiPokok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGajiPokok.Location = new System.Drawing.Point(422, 170);
            this.lblGajiPokok.Name = "lblGajiPokok";
            this.lblGajiPokok.Size = new System.Drawing.Size(154, 25);
            this.lblGajiPokok.TabIndex = 58;
            this.lblGajiPokok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(316, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 25);
            this.label13.TabIndex = 57;
            this.label13.Text = "Total Basic Salary";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 22);
            this.label11.TabIndex = 55;
            this.label11.Text = "Total On Duty";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpotGaji
            // 
            this.txtpotGaji.Location = new System.Drawing.Point(134, 170);
            this.txtpotGaji.Name = "txtpotGaji";
            this.txtpotGaji.Size = new System.Drawing.Size(154, 25);
            this.txtpotGaji.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpotGaji.StateCommon.Border.Rounding = 2F;
            this.txtpotGaji.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Salary Deduction";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(590, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 52;
            this.label10.Text = "Allowance";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalary
            // 
            this.lblSalary.BackColor = System.Drawing.Color.White;
            this.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSalary.Location = new System.Drawing.Point(694, 60);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(119, 25);
            this.lblSalary.TabIndex = 51;
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(590, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Salary";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPositionID
            // 
            this.lblPositionID.BackColor = System.Drawing.Color.White;
            this.lblPositionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPositionID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionID.Location = new System.Drawing.Point(422, 60);
            this.lblPositionID.Name = "lblPositionID";
            this.lblPositionID.Size = new System.Drawing.Size(96, 25);
            this.lblPositionID.TabIndex = 49;
            this.lblPositionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Position ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPositionName
            // 
            this.lblPositionName.BackColor = System.Drawing.Color.White;
            this.lblPositionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPositionName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionName.Location = new System.Drawing.Point(422, 107);
            this.lblPositionName.Name = "lblPositionName";
            this.lblPositionName.Size = new System.Drawing.Size(154, 25);
            this.lblPositionName.TabIndex = 48;
            this.lblPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Position Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.White;
            this.lblEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(134, 60);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(96, 25);
            this.lblEmpID.TabIndex = 44;
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseEmployee
            // 
            this.btnBrowseEmployee.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBrowseEmployee.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnBrowseEmployee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBrowseEmployee.BorderRadius = 0;
            this.btnBrowseEmployee.BorderSize = 0;
            this.btnBrowseEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseEmployee.FlatAppearance.BorderSize = 0;
            this.btnBrowseEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseEmployee.ForeColor = System.Drawing.Color.White;
            this.btnBrowseEmployee.Location = new System.Drawing.Point(237, 60);
            this.btnBrowseEmployee.Name = "btnBrowseEmployee";
            this.btnBrowseEmployee.Size = new System.Drawing.Size(51, 25);
            this.btnBrowseEmployee.TabIndex = 40;
            this.btnBrowseEmployee.Text = "---";
            this.btnBrowseEmployee.TextColor = System.Drawing.Color.White;
            this.btnBrowseEmployee.UseVisualStyleBackColor = false;
            this.btnBrowseEmployee.Click += new System.EventHandler(this.btnBrowseEmployee_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Employee ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpName
            // 
            this.lblEmpName.BackColor = System.Drawing.Color.White;
            this.lblEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(134, 107);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(154, 25);
            this.lblEmpName.TabIndex = 43;
            this.lblEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Employee Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvData
            // 
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeight = 36;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvData.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgvData.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgvData.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvData.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvData.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvData.Location = new System.Drawing.Point(50, 407);
            this.dgvData.Name = "dgvData";
            this.dgvData.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(1050, 293);
            this.dgvData.TabIndex = 21;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "Menit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.frmSalary_Load);
            this.pnlUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpEmployee.Panel)).EndInit();
            this.grpEmployee.Panel.ResumeLayout(false);
            this.grpEmployee.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpEmployee)).EndInit();
            this.grpEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSidebar;
        private RJCodeAdvance.RJControls.RJButton btnLogout;
        private RJCodeAdvance.RJControls.RJButton btnSalary;
        private RJCodeAdvance.RJControls.RJButton btnEmployee;
        private RJCodeAdvance.RJControls.RJButton btnDashboard;
        private System.Windows.Forms.Timer sidebarTransisi;
        public Krypton.Toolkit.KryptonGroupBox grpEmployee;
        private Krypton.Toolkit.KryptonNumericUpDown nudOnDuty;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton btnCancel;
        private Krypton.Toolkit.KryptonDateTimePicker dtpTgl;
        private RJCodeAdvance.RJControls.RJButton btnDelete;
        private RJCodeAdvance.RJControls.RJButton btnEdit;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        public System.Windows.Forms.Label lblGajiBersih;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lblGajiPokok;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private Krypton.Toolkit.KryptonTextBox txtpotGaji;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblPositionID;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblPositionName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblEmpID;
        private RJCodeAdvance.RJControls.RJButton btnBrowseEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSalaryID;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblEmpName;
        public System.Windows.Forms.Label lblAllowance;
        private RJCodeAdvance.RJControls.RJButton btnPrint;
        public Krypton.Toolkit.KryptonDataGridView dgvData;
        private System.Windows.Forms.Label label3;
    }
}