
namespace Otto_Cafe_Payroll_App.Employee
{
    partial class frmBrowseEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowseEmployee));
            this.pnlUp = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picBrowse = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJumlahRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new Krypton.Toolkit.KryptonDataGridView();
            this.grpSearch = new Krypton.Toolkit.KryptonGroupBox();
            this.btnRefresh = new RJCodeAdvance.RJControls.RJButton();
            this.btnSearch = new RJCodeAdvance.RJControls.RJButton();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch.Panel)).BeginInit();
            this.grpSearch.Panel.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.LightCyan;
            this.pnlUp.Controls.Add(this.picClose);
            this.pnlUp.Controls.Add(this.picBrowse);
            this.pnlUp.Controls.Add(this.label4);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(559, 47);
            this.pnlUp.TabIndex = 45;
            // 
            // picClose
            // 
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.IconCloseBlue;
            this.picClose.Location = new System.Drawing.Point(523, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.TabIndex = 41;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picBrowse
            // 
            this.picBrowse.BackColor = System.Drawing.Color.Transparent;
            this.picBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBrowse.Image = global::Otto_Cafe_Payroll_App.Properties.Resources.browseBlue;
            this.picBrowse.Location = new System.Drawing.Point(11, 12);
            this.picBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.picBrowse.Name = "picBrowse";
            this.picBrowse.Size = new System.Drawing.Size(31, 24);
            this.picBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrowse.TabIndex = 1;
            this.picBrowse.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "BROWSE EMPLOYEE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJumlahRecord
            // 
            this.lblJumlahRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJumlahRecord.BackColor = System.Drawing.Color.White;
            this.lblJumlahRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumlahRecord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahRecord.Location = new System.Drawing.Point(299, 349);
            this.lblJumlahRecord.Name = "lblJumlahRecord";
            this.lblJumlahRecord.Size = new System.Drawing.Size(46, 27);
            this.lblJumlahRecord.TabIndex = 49;
            this.lblJumlahRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 48;
            this.label1.Text = "Jumlah Record";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvData
            // 
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeight = 36;
            this.dgvData.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgvData.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgvData.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvData.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvData.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvData.Location = new System.Drawing.Point(12, 157);
            this.dgvData.Name = "dgvData";
            this.dgvData.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(535, 178);
            this.dgvData.TabIndex = 47;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // grpSearch
            // 
            this.grpSearch.CaptionStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpSearch.Location = new System.Drawing.Point(12, 57);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlueLightMode;
            // 
            // grpSearch.Panel
            // 
            this.grpSearch.Panel.Controls.Add(this.label7);
            this.grpSearch.Panel.Controls.Add(this.btnRefresh);
            this.grpSearch.Panel.Controls.Add(this.btnSearch);
            this.grpSearch.Panel.Controls.Add(this.txtSearch);
            this.grpSearch.Size = new System.Drawing.Size(535, 94);
            this.grpSearch.TabIndex = 46;
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
            this.btnRefresh.Location = new System.Drawing.Point(298, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 35);
            this.btnRefresh.TabIndex = 33;
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
            this.btnSearch.Location = new System.Drawing.Point(255, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 35);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(19, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 25);
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 2F;
            this.txtSearch.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Employee ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBrowseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 381);
            this.Controls.Add(this.pnlUp);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.lblJumlahRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowseEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrowseEmployee";
            this.Load += new System.EventHandler(this.frmBrowseEmployee_Load);
            this.pnlUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch.Panel)).EndInit();
            this.grpSearch.Panel.ResumeLayout(false);
            this.grpSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblJumlahRecord;
        private System.Windows.Forms.Label label1;
        public Krypton.Toolkit.KryptonDataGridView dgvData;
        private Krypton.Toolkit.KryptonGroupBox grpSearch;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJButton btnRefresh;
        private RJCodeAdvance.RJControls.RJButton btnSearch;
        private System.Windows.Forms.Label label7;
    }
}