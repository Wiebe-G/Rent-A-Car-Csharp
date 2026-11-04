namespace RentACar
{
    partial class frmAdmin
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
            pnlTabLayoutAdmin = new TableLayoutPanel();
            pnlTabTopBarAdmin = new TableLayoutPanel();
            btnLogout = new Button();
            btnBack = new Button();
            spltAdminLayout = new SplitContainer();
            pnlTabSideBarAdmin = new TableLayoutPanel();
            btnMenuCars = new Button();
            btnMenuInvoices = new Button();
            btnMenuCustomers = new Button();
            btnMenuEmployees = new Button();
            btnMenuStock = new Button();
            btnMenuPlanning = new Button();
            btnMenuDashboard = new Button();
            btnMenuOpeningTimes = new Button();
            btnMenuLogs = new Button();
            pnlTabLayoutAdmin.SuspendLayout();
            pnlTabTopBarAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spltAdminLayout).BeginInit();
            spltAdminLayout.Panel1.SuspendLayout();
            spltAdminLayout.Panel2.SuspendLayout();
            spltAdminLayout.SuspendLayout();
            pnlTabSideBarAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabLayoutAdmin
            // 
            pnlTabLayoutAdmin.BackColor = SystemColors.ControlLight;
            pnlTabLayoutAdmin.ColumnCount = 1;
            pnlTabLayoutAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabLayoutAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlTabLayoutAdmin.Controls.Add(pnlTabTopBarAdmin, 0, 0);
            pnlTabLayoutAdmin.Controls.Add(spltAdminLayout, 0, 1);
            pnlTabLayoutAdmin.Dock = DockStyle.Fill;
            pnlTabLayoutAdmin.Location = new Point(0, 0);
            pnlTabLayoutAdmin.Name = "pnlTabLayoutAdmin";
            pnlTabLayoutAdmin.RowCount = 2;
            pnlTabLayoutAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabLayoutAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            pnlTabLayoutAdmin.Size = new Size(1162, 478);
            pnlTabLayoutAdmin.TabIndex = 0;
            // 
            // pnlTabTopBarAdmin
            // 
            pnlTabTopBarAdmin.ColumnCount = 3;
            pnlTabTopBarAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabTopBarAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTabTopBarAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabTopBarAdmin.Controls.Add(btnLogout, 2, 0);
            pnlTabTopBarAdmin.Controls.Add(btnBack, 0, 0);
            pnlTabTopBarAdmin.Dock = DockStyle.Fill;
            pnlTabTopBarAdmin.Location = new Point(3, 3);
            pnlTabTopBarAdmin.Name = "pnlTabTopBarAdmin";
            pnlTabTopBarAdmin.RowCount = 1;
            pnlTabTopBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabTopBarAdmin.Size = new Size(1156, 65);
            pnlTabTopBarAdmin.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.Location = new Point(927, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(226, 59);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Log uit";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveBorder;
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(225, 59);
            btnBack.TabIndex = 1;
            btnBack.Text = "Terug naar medewerkers paneel";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // spltAdminLayout
            // 
            spltAdminLayout.Dock = DockStyle.Fill;
            spltAdminLayout.Location = new Point(3, 74);
            spltAdminLayout.Name = "spltAdminLayout";
            // 
            // spltAdminLayout.Panel1
            // 
            spltAdminLayout.Panel1.Controls.Add(pnlTabSideBarAdmin);
            spltAdminLayout.Panel1MinSize = 15;
            // 
            // spltAdminLayout.Panel2
            // 
            spltAdminLayout.Panel2MinSize = 35;
            spltAdminLayout.Size = new Size(1156, 401);
            spltAdminLayout.SplitterDistance = 333;
            spltAdminLayout.TabIndex = 1;
            // 
            // pnlTabSideBarAdmin
            // 
            pnlTabSideBarAdmin.ColumnCount = 1;
            pnlTabSideBarAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabSideBarAdmin.Controls.Add(btnMenuCars, 0, 0);
            pnlTabSideBarAdmin.Controls.Add(btnMenuInvoices, 0, 1);
            pnlTabSideBarAdmin.Controls.Add(btnMenuCustomers, 0, 2);
            pnlTabSideBarAdmin.Controls.Add(btnMenuEmployees, 0, 3);
            pnlTabSideBarAdmin.Controls.Add(btnMenuStock, 0, 4);
            pnlTabSideBarAdmin.Controls.Add(btnMenuPlanning, 0, 5);
            pnlTabSideBarAdmin.Controls.Add(btnMenuDashboard, 0, 6);
            pnlTabSideBarAdmin.Controls.Add(btnMenuOpeningTimes, 0, 7);
            pnlTabSideBarAdmin.Controls.Add(btnMenuLogs, 0, 8);
            pnlTabSideBarAdmin.Dock = DockStyle.Fill;
            pnlTabSideBarAdmin.Location = new Point(0, 0);
            pnlTabSideBarAdmin.Name = "pnlTabSideBarAdmin";
            pnlTabSideBarAdmin.RowCount = 9;
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabSideBarAdmin.Size = new Size(333, 401);
            pnlTabSideBarAdmin.TabIndex = 0;
            // 
            // btnMenuCars
            // 
            btnMenuCars.BackColor = SystemColors.ActiveBorder;
            btnMenuCars.Dock = DockStyle.Fill;
            btnMenuCars.Location = new Point(3, 3);
            btnMenuCars.Name = "btnMenuCars";
            btnMenuCars.Size = new Size(327, 38);
            btnMenuCars.TabIndex = 0;
            btnMenuCars.Text = "Auto's ";
            btnMenuCars.UseVisualStyleBackColor = false;
            btnMenuCars.Click += ShowCorrectMenu;
            // 
            // btnMenuInvoices
            // 
            btnMenuInvoices.BackColor = SystemColors.ActiveBorder;
            btnMenuInvoices.Dock = DockStyle.Fill;
            btnMenuInvoices.Location = new Point(3, 47);
            btnMenuInvoices.Name = "btnMenuInvoices";
            btnMenuInvoices.Size = new Size(327, 38);
            btnMenuInvoices.TabIndex = 1;
            btnMenuInvoices.Text = "Facturen";
            btnMenuInvoices.UseVisualStyleBackColor = false;
            btnMenuInvoices.Click += ShowCorrectMenu;
            // 
            // btnMenuCustomers
            // 
            btnMenuCustomers.BackColor = SystemColors.ActiveBorder;
            btnMenuCustomers.Dock = DockStyle.Fill;
            btnMenuCustomers.Location = new Point(3, 91);
            btnMenuCustomers.Name = "btnMenuCustomers";
            btnMenuCustomers.Size = new Size(327, 38);
            btnMenuCustomers.TabIndex = 2;
            btnMenuCustomers.Text = "Klanten";
            btnMenuCustomers.UseVisualStyleBackColor = false;
            btnMenuCustomers.Click += ShowCorrectMenu;
            // 
            // btnMenuEmployees
            // 
            btnMenuEmployees.BackColor = SystemColors.ActiveBorder;
            btnMenuEmployees.Dock = DockStyle.Fill;
            btnMenuEmployees.Location = new Point(3, 135);
            btnMenuEmployees.Name = "btnMenuEmployees";
            btnMenuEmployees.Size = new Size(327, 38);
            btnMenuEmployees.TabIndex = 3;
            btnMenuEmployees.Text = "Medewerkers";
            btnMenuEmployees.UseVisualStyleBackColor = false;
            btnMenuEmployees.Click += ShowCorrectMenu;
            // 
            // btnMenuStock
            // 
            btnMenuStock.BackColor = SystemColors.ActiveBorder;
            btnMenuStock.Dock = DockStyle.Fill;
            btnMenuStock.Location = new Point(3, 179);
            btnMenuStock.Name = "btnMenuStock";
            btnMenuStock.Size = new Size(327, 38);
            btnMenuStock.TabIndex = 4;
            btnMenuStock.Text = "Voorraad en reserveringen";
            btnMenuStock.UseVisualStyleBackColor = false;
            btnMenuStock.Click += ShowCorrectMenu;
            // 
            // btnMenuPlanning
            // 
            btnMenuPlanning.BackColor = SystemColors.ActiveBorder;
            btnMenuPlanning.Dock = DockStyle.Fill;
            btnMenuPlanning.Location = new Point(3, 223);
            btnMenuPlanning.Name = "btnMenuPlanning";
            btnMenuPlanning.Size = new Size(327, 38);
            btnMenuPlanning.TabIndex = 5;
            btnMenuPlanning.Text = "Roosters";
            btnMenuPlanning.UseVisualStyleBackColor = false;
            btnMenuPlanning.Click += ShowCorrectMenu;
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.BackColor = SystemColors.ActiveBorder;
            btnMenuDashboard.Dock = DockStyle.Fill;
            btnMenuDashboard.Location = new Point(3, 267);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(327, 38);
            btnMenuDashboard.TabIndex = 6;
            btnMenuDashboard.Text = "Prestatie dashboard";
            btnMenuDashboard.UseVisualStyleBackColor = false;
            btnMenuDashboard.Click += ShowCorrectMenu;
            // 
            // btnMenuOpeningTimes
            // 
            btnMenuOpeningTimes.BackColor = SystemColors.ActiveBorder;
            btnMenuOpeningTimes.Dock = DockStyle.Fill;
            btnMenuOpeningTimes.Location = new Point(3, 311);
            btnMenuOpeningTimes.Name = "btnMenuOpeningTimes";
            btnMenuOpeningTimes.Size = new Size(327, 38);
            btnMenuOpeningTimes.TabIndex = 7;
            btnMenuOpeningTimes.Text = "Openingstijden";
            btnMenuOpeningTimes.UseVisualStyleBackColor = false;
            btnMenuOpeningTimes.Click += ShowCorrectMenu;
            // 
            // btnMenuLogs
            // 
            btnMenuLogs.BackColor = SystemColors.ActiveBorder;
            btnMenuLogs.Dock = DockStyle.Fill;
            btnMenuLogs.Location = new Point(3, 355);
            btnMenuLogs.Name = "btnMenuLogs";
            btnMenuLogs.Size = new Size(327, 43);
            btnMenuLogs.TabIndex = 8;
            btnMenuLogs.Text = "Logs";
            btnMenuLogs.UseVisualStyleBackColor = false;
            btnMenuLogs.Click += ShowCorrectMenu;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 478);
            Controls.Add(pnlTabLayoutAdmin);
            Name = "frmAdmin";
            Text = "Admin paneel";
            pnlTabLayoutAdmin.ResumeLayout(false);
            pnlTabTopBarAdmin.ResumeLayout(false);
            spltAdminLayout.Panel1.ResumeLayout(false);
            spltAdminLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spltAdminLayout).EndInit();
            spltAdminLayout.ResumeLayout(false);
            pnlTabSideBarAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabLayoutAdmin;
        private TableLayoutPanel pnlTabTopBarAdmin;
        private Button btnLogout;
        private Button btnBack;
        private SplitContainer spltAdminLayout;
        private TableLayoutPanel pnlTabSideBarAdmin;
        private Button btnMenuCars;
        private Button btnMenuInvoices;
        private Button btnMenuCustomers;
        private Button btnMenuEmployees;
        private Button btnMenuStock;
        private Button btnMenuPlanning;
        private Button btnMenuDashboard;
        private Button btnMenuOpeningTimes;
        private Button btnMenuLogs;
    }
}