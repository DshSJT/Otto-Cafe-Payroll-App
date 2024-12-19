
namespace Otto_Cafe_Payroll_App
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
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
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAvaEmp = new Krypton.Toolkit.KryptonGroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvaEmp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpInActiveEmp = new Krypton.Toolkit.KryptonGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInActiveEmp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpTotalEmp = new Krypton.Toolkit.KryptonGroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalEmp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvData = new Krypton.Toolkit.KryptonDataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAvaEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAvaEmp.Panel)).BeginInit();
            this.grpAvaEmp.Panel.SuspendLayout();
            this.grpAvaEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInActiveEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInActiveEmp.Panel)).BeginInit();
            this.grpInActiveEmp.Panel.SuspendLayout();
            this.grpInActiveEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalEmp.Panel)).BeginInit();
            this.grpTotalEmp.Panel.SuspendLayout();
            this.grpTotalEmp.SuspendLayout();
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
            this.pnlUp.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1467, 58);
            this.pnlUp.TabIndex = 1;
            // 
            // picClose
            // 
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.IconCloseBlue;
            this.picClose.Location = new System.Drawing.Point(1419, 15);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 30);
            this.picClose.TabIndex = 11;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMenu
            // 
            this.picMenu.BackColor = System.Drawing.Color.Transparent;
            this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenu.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.menuBlue;
            this.picMenu.Location = new System.Drawing.Point(12, 11);
            this.picMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(41, 30);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 1;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "DASHBOARD";
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
            this.pnlSidebar.Location = new System.Drawing.Point(0, 58);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(67, 619);
            this.pnlSidebar.TabIndex = 2;
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
            this.btnLogout.Location = new System.Drawing.Point(15, 555);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(195, 49);
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
            this.btnSalary.Location = new System.Drawing.Point(16, 234);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(201, 49);
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
            this.btnEmployee.Location = new System.Drawing.Point(16, 159);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(195, 49);
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
            this.btnDashboard.Location = new System.Drawing.Point(16, 90);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(195, 49);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "   DASHBOARD";
            this.btnDashboard.TextColor = System.Drawing.Color.White;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // sidebarTransisi
            // 
            this.sidebarTransisi.Interval = 5;
            this.sidebarTransisi.Tick += new System.EventHandler(this.sidebarTransisi_Tick);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlWelcome.Controls.Add(this.label1);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcome.Location = new System.Drawing.Point(67, 58);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(1400, 82);
            this.pnlWelcome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "WELCOME TO OTTO CAFE PAYROLL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpAvaEmp
            // 
            this.grpAvaEmp.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpAvaEmp.Location = new System.Drawing.Point(219, 197);
            this.grpAvaEmp.Margin = new System.Windows.Forms.Padding(4);
            this.grpAvaEmp.Name = "grpAvaEmp";
            this.grpAvaEmp.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            // 
            // grpAvaEmp.Panel
            // 
            this.grpAvaEmp.Panel.Controls.Add(this.label6);
            this.grpAvaEmp.Panel.Controls.Add(this.lblAvaEmp);
            this.grpAvaEmp.Panel.Controls.Add(this.label5);
            this.grpAvaEmp.Size = new System.Drawing.Size(265, 209);
            this.grpAvaEmp.TabIndex = 10;
            this.grpAvaEmp.Values.Heading = "AVAILABLE EMPLOYEE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "EMPLOYEE(S)\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvaEmp
            // 
            this.lblAvaEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblAvaEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvaEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaEmp.Location = new System.Drawing.Point(23, 44);
            this.lblAvaEmp.Name = "lblAvaEmp";
            this.lblAvaEmp.Size = new System.Drawing.Size(123, 97);
            this.lblAvaEmp.TabIndex = 11;
            this.lblAvaEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "YOU HAVE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInActiveEmp
            // 
            this.grpInActiveEmp.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpInActiveEmp.Location = new System.Drawing.Point(608, 197);
            this.grpInActiveEmp.Margin = new System.Windows.Forms.Padding(4);
            this.grpInActiveEmp.Name = "grpInActiveEmp";
            this.grpInActiveEmp.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            // 
            // grpInActiveEmp.Panel
            // 
            this.grpInActiveEmp.Panel.Controls.Add(this.label2);
            this.grpInActiveEmp.Panel.Controls.Add(this.lblInActiveEmp);
            this.grpInActiveEmp.Panel.Controls.Add(this.label7);
            this.grpInActiveEmp.Size = new System.Drawing.Size(265, 209);
            this.grpInActiveEmp.TabIndex = 11;
            this.grpInActiveEmp.Values.Heading = "INACTIVE EMPLOYEE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "EMPLOYEE(S)\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInActiveEmp
            // 
            this.lblInActiveEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblInActiveEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInActiveEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInActiveEmp.Location = new System.Drawing.Point(23, 44);
            this.lblInActiveEmp.Name = "lblInActiveEmp";
            this.lblInActiveEmp.Size = new System.Drawing.Size(123, 97);
            this.lblInActiveEmp.TabIndex = 11;
            this.lblInActiveEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "YOU HAVE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTotalEmp
            // 
            this.grpTotalEmp.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpTotalEmp.Location = new System.Drawing.Point(983, 197);
            this.grpTotalEmp.Margin = new System.Windows.Forms.Padding(4);
            this.grpTotalEmp.Name = "grpTotalEmp";
            this.grpTotalEmp.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            // 
            // grpTotalEmp.Panel
            // 
            this.grpTotalEmp.Panel.Controls.Add(this.label8);
            this.grpTotalEmp.Panel.Controls.Add(this.lblTotalEmp);
            this.grpTotalEmp.Panel.Controls.Add(this.label10);
            this.grpTotalEmp.Size = new System.Drawing.Size(265, 209);
            this.grpTotalEmp.TabIndex = 12;
            this.grpTotalEmp.Values.Heading = "TOTAL EMPLOYEE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "EMPLOYEE(S)\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalEmp
            // 
            this.lblTotalEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmp.Location = new System.Drawing.Point(23, 44);
            this.lblTotalEmp.Name = "lblTotalEmp";
            this.lblTotalEmp.Size = new System.Drawing.Size(123, 97);
            this.lblTotalEmp.TabIndex = 11;
            this.lblTotalEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "YOU HAVE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgvData.Location = new System.Drawing.Point(67, 539);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(1400, 138);
            this.dgvData.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(266, 32);
            this.label11.TabIndex = 14;
            this.label11.Text = "OVERVIEW EMPLOYEE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1467, 677);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.grpTotalEmp);
            this.Controls.Add(this.grpInActiveEmp);
            this.Controls.Add(this.grpAvaEmp);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAvaEmp.Panel)).EndInit();
            this.grpAvaEmp.Panel.ResumeLayout(false);
            this.grpAvaEmp.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAvaEmp)).EndInit();
            this.grpAvaEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpInActiveEmp.Panel)).EndInit();
            this.grpInActiveEmp.Panel.ResumeLayout(false);
            this.grpInActiveEmp.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInActiveEmp)).EndInit();
            this.grpInActiveEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalEmp.Panel)).EndInit();
            this.grpTotalEmp.Panel.ResumeLayout(false);
            this.grpTotalEmp.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalEmp)).EndInit();
            this.grpTotalEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonGroupBox grpAvaEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAvaEmp;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonGroupBox grpInActiveEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInActiveEmp;
        private System.Windows.Forms.Label label7;
        private Krypton.Toolkit.KryptonGroupBox grpTotalEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalEmp;
        private System.Windows.Forms.Label label10;
        private Krypton.Toolkit.KryptonDataGridView dgvData;
        private System.Windows.Forms.Label label11;
    }
}