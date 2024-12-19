
namespace Otto_Cafe_Payroll_App.Employee
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
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
            this.S = new Krypton.Toolkit.KryptonGroupBox();
            this.cboGender = new Krypton.Toolkit.KryptonComboBox();
            this.btnCancel = new RJCodeAdvance.RJControls.RJButton();
            this.btnDelete = new RJCodeAdvance.RJControls.RJButton();
            this.btnEdit = new RJCodeAdvance.RJControls.RJButton();
            this.btnAdd = new RJCodeAdvance.RJControls.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTglMasuk = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblPositionID = new System.Windows.Forms.Label();
            this.btnBrowsePosition = new RJCodeAdvance.RJControls.RJButton();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.rdoNonActive = new Krypton.Toolkit.KryptonRadioButton();
            this.rdoActive = new Krypton.Toolkit.KryptonRadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpName = new Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearch = new Krypton.Toolkit.KryptonGroupBox();
            this.btnRefresh = new RJCodeAdvance.RJControls.RJButton();
            this.btnSearch = new RJCodeAdvance.RJControls.RJButton();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.rdoEmpName = new Krypton.Toolkit.KryptonRadioButton();
            this.rdoEmpID = new Krypton.Toolkit.KryptonRadioButton();
            this.dgvData = new Krypton.Toolkit.KryptonDataGridView();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S.Panel)).BeginInit();
            this.S.Panel.SuspendLayout();
            this.S.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch.Panel)).BeginInit();
            this.grpSearch.Panel.SuspendLayout();
            this.grpSearch.SuspendLayout();
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
            this.pnlUp.TabIndex = 2;
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
            this.label4.Text = "EMPLOYEE";
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
            this.pnlSidebar.TabIndex = 3;
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
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
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
            // S
            // 
            this.S.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.S.Dock = System.Windows.Forms.DockStyle.Top;
            this.S.Location = new System.Drawing.Point(50, 47);
            this.S.Name = "S";
            this.S.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            // 
            // S.Panel
            // 
            this.S.Panel.Controls.Add(this.cboGender);
            this.S.Panel.Controls.Add(this.btnCancel);
            this.S.Panel.Controls.Add(this.btnDelete);
            this.S.Panel.Controls.Add(this.btnEdit);
            this.S.Panel.Controls.Add(this.btnAdd);
            this.S.Panel.Controls.Add(this.label10);
            this.S.Panel.Controls.Add(this.label11);
            this.S.Panel.Controls.Add(this.dtpTglMasuk);
            this.S.Panel.Controls.Add(this.lblPositionID);
            this.S.Panel.Controls.Add(this.btnBrowsePosition);
            this.S.Panel.Controls.Add(this.lblEmpID);
            this.S.Panel.Controls.Add(this.rdoNonActive);
            this.S.Panel.Controls.Add(this.rdoActive);
            this.S.Panel.Controls.Add(this.label9);
            this.S.Panel.Controls.Add(this.lblSalary);
            this.S.Panel.Controls.Add(this.label8);
            this.S.Panel.Controls.Add(this.label7);
            this.S.Panel.Controls.Add(this.txtEmail);
            this.S.Panel.Controls.Add(this.label6);
            this.S.Panel.Controls.Add(this.txtAddress);
            this.S.Panel.Controls.Add(this.label5);
            this.S.Panel.Controls.Add(this.txtPhone);
            this.S.Panel.Controls.Add(this.label3);
            this.S.Panel.Controls.Add(this.txtEmpName);
            this.S.Panel.Controls.Add(this.label2);
            this.S.Panel.Controls.Add(this.label1);
            this.S.Size = new System.Drawing.Size(1050, 318);
            this.S.TabIndex = 18;
            this.S.Values.Heading = "EMPLOYEE\'S";
            // 
            // cboGender
            // 
            this.cboGender.DropDownWidth = 154;
            this.cboGender.IntegralHeight = false;
            this.cboGender.Location = new System.Drawing.Point(125, 91);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(154, 21);
            this.cboGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboGender.TabIndex = 21;
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
            this.btnCancel.Location = new System.Drawing.Point(472, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(33, 35);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(416, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(33, 35);
            this.btnDelete.TabIndex = 47;
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
            this.btnEdit.Location = new System.Drawing.Point(363, 248);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(33, 35);
            this.btnEdit.TabIndex = 46;
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
            this.btnAdd.Location = new System.Drawing.Point(315, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 35);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "Gender";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(431, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Date In";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpTglMasuk
            // 
            this.dtpTglMasuk.CalendarTodayDate = new System.DateTime(2024, 1, 15, 0, 0, 0, 0);
            this.dtpTglMasuk.CustomFormat = "dd MMMM yyyy";
            this.dtpTglMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTglMasuk.Location = new System.Drawing.Point(537, 16);
            this.dtpTglMasuk.Name = "dtpTglMasuk";
            this.dtpTglMasuk.Size = new System.Drawing.Size(209, 21);
            this.dtpTglMasuk.TabIndex = 40;
            // 
            // lblPositionID
            // 
            this.lblPositionID.BackColor = System.Drawing.Color.White;
            this.lblPositionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPositionID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionID.Location = new System.Drawing.Point(125, 134);
            this.lblPositionID.Name = "lblPositionID";
            this.lblPositionID.Size = new System.Drawing.Size(106, 25);
            this.lblPositionID.TabIndex = 39;
            this.lblPositionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowsePosition
            // 
            this.btnBrowsePosition.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBrowsePosition.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnBrowsePosition.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBrowsePosition.BorderRadius = 0;
            this.btnBrowsePosition.BorderSize = 0;
            this.btnBrowsePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowsePosition.FlatAppearance.BorderSize = 0;
            this.btnBrowsePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowsePosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePosition.ForeColor = System.Drawing.Color.White;
            this.btnBrowsePosition.Location = new System.Drawing.Point(237, 134);
            this.btnBrowsePosition.Name = "btnBrowsePosition";
            this.btnBrowsePosition.Size = new System.Drawing.Size(42, 25);
            this.btnBrowsePosition.TabIndex = 18;
            this.btnBrowsePosition.Text = "---";
            this.btnBrowsePosition.TextColor = System.Drawing.Color.White;
            this.btnBrowsePosition.UseVisualStyleBackColor = false;
            this.btnBrowsePosition.Click += new System.EventHandler(this.btnBrowsePosition_Click);
            // 
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.White;
            this.lblEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(125, 14);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(106, 25);
            this.lblEmpID.TabIndex = 35;
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoNonActive
            // 
            this.rdoNonActive.Location = new System.Drawing.Point(623, 182);
            this.rdoNonActive.Name = "rdoNonActive";
            this.rdoNonActive.Size = new System.Drawing.Size(84, 20);
            this.rdoNonActive.TabIndex = 34;
            this.rdoNonActive.Values.Text = "Non-Active";
            // 
            // rdoActive
            // 
            this.rdoActive.Location = new System.Drawing.Point(534, 182);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(56, 20);
            this.rdoActive.TabIndex = 33;
            this.rdoActive.Values.Text = "Active";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Status";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalary
            // 
            this.lblSalary.BackColor = System.Drawing.Color.White;
            this.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(125, 177);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(154, 25);
            this.lblSalary.TabIndex = 26;
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Salary";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Position ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(537, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 25);
            this.txtEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 2F;
            this.txtEmail.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(537, 96);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(209, 25);
            this.txtAddress.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.Rounding = 2F;
            this.txtAddress.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(537, 55);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(209, 25);
            this.txtPhone.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhone.StateCommon.Border.Rounding = 2F;
            this.txtPhone.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(125, 55);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(210, 25);
            this.txtEmpName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmpName.StateCommon.Border.Rounding = 2F;
            this.txtEmpName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Employee Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSearch
            // 
            this.grpSearch.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(50, 365);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            // 
            // grpSearch.Panel
            // 
            this.grpSearch.Panel.Controls.Add(this.btnRefresh);
            this.grpSearch.Panel.Controls.Add(this.btnSearch);
            this.grpSearch.Panel.Controls.Add(this.txtSearch);
            this.grpSearch.Panel.Controls.Add(this.rdoEmpName);
            this.grpSearch.Panel.Controls.Add(this.rdoEmpID);
            this.grpSearch.Size = new System.Drawing.Size(1050, 108);
            this.grpSearch.TabIndex = 19;
            this.grpSearch.Values.Heading = "SEARCH";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.refreshblue;
            this.btnRefresh.Location = new System.Drawing.Point(273, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 35);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.searchblue;
            this.btnSearch.Location = new System.Drawing.Point(234, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 35);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(19, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 25);
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 2F;
            this.txtSearch.TabIndex = 29;
            // 
            // rdoEmpName
            // 
            this.rdoEmpName.Location = new System.Drawing.Point(116, 17);
            this.rdoEmpName.Name = "rdoEmpName";
            this.rdoEmpName.Size = new System.Drawing.Size(112, 20);
            this.rdoEmpName.TabIndex = 18;
            this.rdoEmpName.Values.Text = "Employee Name";
            // 
            // rdoEmpID
            // 
            this.rdoEmpID.Location = new System.Drawing.Point(19, 17);
            this.rdoEmpID.Name = "rdoEmpID";
            this.rdoEmpID.Size = new System.Drawing.Size(91, 20);
            this.rdoEmpID.TabIndex = 17;
            this.rdoEmpID.Values.Text = "Employee ID";
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
            this.dgvData.Location = new System.Drawing.Point(50, 493);
            this.dgvData.Name = "dgvData";
            this.dgvData.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(1050, 207);
            this.dgvData.TabIndex = 20;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.S);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.pnlUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.S.Panel)).EndInit();
            this.S.Panel.ResumeLayout(false);
            this.S.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S)).EndInit();
            this.S.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch.Panel)).EndInit();
            this.grpSearch.Panel.ResumeLayout(false);
            this.grpSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
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
        public Krypton.Toolkit.KryptonGroupBox S;
        private System.Windows.Forms.Label label11;
        private Krypton.Toolkit.KryptonDateTimePicker dtpTglMasuk;
        public System.Windows.Forms.Label lblPositionID;
        private RJCodeAdvance.RJControls.RJButton btnBrowsePosition;
        private System.Windows.Forms.Label lblEmpID;
        private Krypton.Toolkit.KryptonRadioButton rdoNonActive;
        private Krypton.Toolkit.KryptonRadioButton rdoActive;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonTextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox txtEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private RJCodeAdvance.RJControls.RJButton btnEdit;
        private RJCodeAdvance.RJControls.RJButton btnDelete;
        private RJCodeAdvance.RJControls.RJButton btnCancel;
        private Krypton.Toolkit.KryptonGroupBox grpSearch;
        private RJCodeAdvance.RJControls.RJButton btnRefresh;
        private RJCodeAdvance.RJControls.RJButton btnSearch;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonRadioButton rdoEmpName;
        private Krypton.Toolkit.KryptonRadioButton rdoEmpID;
        private Krypton.Toolkit.KryptonDataGridView dgvData;
        private Krypton.Toolkit.KryptonComboBox cboGender;
    }
}