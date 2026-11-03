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
            btnCarsMenu = new Button();
            btnInvoicesMenu = new Button();
            btnCustomersMenu = new Button();
            btnEmployeesMenu = new Button();
            btnStockMenu = new Button();
            btnPlanningMenu = new Button();
            btnDashboardMenu = new Button();
            btnOpeningsTimesMenu = new Button();
            button9 = new Button();
            button10 = new Button();
            pnlTabLayoutAdmin.SuspendLayout();
            pnlTabTopBarAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spltAdminLayout).BeginInit();
            spltAdminLayout.Panel1.SuspendLayout();
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
            spltAdminLayout.Panel2MinSize = 35;
            spltAdminLayout.Size = new Size(1156, 401);
            spltAdminLayout.SplitterDistance = 333;
            spltAdminLayout.TabIndex = 1;
            // 
            // pnlTabSideBarAdmin
            // 
            pnlTabSideBarAdmin.ColumnCount = 1;
            pnlTabSideBarAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabSideBarAdmin.Controls.Add(btnCarsMenu, 0, 0);
            pnlTabSideBarAdmin.Controls.Add(btnInvoicesMenu, 0, 1);
            pnlTabSideBarAdmin.Controls.Add(btnCustomersMenu, 0, 2);
            pnlTabSideBarAdmin.Controls.Add(btnEmployeesMenu, 0, 3);
            pnlTabSideBarAdmin.Controls.Add(btnStockMenu, 0, 4);
            pnlTabSideBarAdmin.Controls.Add(btnPlanningMenu, 0, 5);
            pnlTabSideBarAdmin.Controls.Add(btnDashboardMenu, 0, 6);
            pnlTabSideBarAdmin.Controls.Add(btnOpeningsTimesMenu, 0, 7);
            pnlTabSideBarAdmin.Controls.Add(button9, 0, 8);
            pnlTabSideBarAdmin.Controls.Add(button10, 0, 9);
            pnlTabSideBarAdmin.Dock = DockStyle.Fill;
            pnlTabSideBarAdmin.Location = new Point(0, 0);
            pnlTabSideBarAdmin.Name = "pnlTabSideBarAdmin";
            pnlTabSideBarAdmin.RowCount = 10;
            pnlTabSideBarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
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
            // btnCarsMenu
            // 
            btnCarsMenu.BackColor = SystemColors.ActiveBorder;
            btnCarsMenu.Dock = DockStyle.Fill;
            btnCarsMenu.Location = new Point(3, 3);
            btnCarsMenu.Name = "btnCarsMenu";
            btnCarsMenu.Size = new Size(327, 34);
            btnCarsMenu.TabIndex = 0;
            btnCarsMenu.Text = "Auto's ";
            btnCarsMenu.UseVisualStyleBackColor = false;
            // 
            // btnInvoicesMenu
            // 
            btnInvoicesMenu.BackColor = SystemColors.ActiveBorder;
            btnInvoicesMenu.Dock = DockStyle.Fill;
            btnInvoicesMenu.Location = new Point(3, 43);
            btnInvoicesMenu.Name = "btnInvoicesMenu";
            btnInvoicesMenu.Size = new Size(327, 34);
            btnInvoicesMenu.TabIndex = 1;
            btnInvoicesMenu.Text = "Facturen";
            btnInvoicesMenu.UseVisualStyleBackColor = false;
            // 
            // btnCustomersMenu
            // 
            btnCustomersMenu.BackColor = SystemColors.ActiveBorder;
            btnCustomersMenu.Dock = DockStyle.Fill;
            btnCustomersMenu.Location = new Point(3, 83);
            btnCustomersMenu.Name = "btnCustomersMenu";
            btnCustomersMenu.Size = new Size(327, 34);
            btnCustomersMenu.TabIndex = 2;
            btnCustomersMenu.Text = "Klanten";
            btnCustomersMenu.UseVisualStyleBackColor = false;
            // 
            // btnEmployeesMenu
            // 
            btnEmployeesMenu.BackColor = SystemColors.ActiveBorder;
            btnEmployeesMenu.Dock = DockStyle.Fill;
            btnEmployeesMenu.Location = new Point(3, 123);
            btnEmployeesMenu.Name = "btnEmployeesMenu";
            btnEmployeesMenu.Size = new Size(327, 34);
            btnEmployeesMenu.TabIndex = 3;
            btnEmployeesMenu.Text = "Medewerkers";
            btnEmployeesMenu.UseVisualStyleBackColor = false;
            // 
            // btnStockMenu
            // 
            btnStockMenu.BackColor = SystemColors.ActiveBorder;
            btnStockMenu.Dock = DockStyle.Fill;
            btnStockMenu.Location = new Point(3, 163);
            btnStockMenu.Name = "btnStockMenu";
            btnStockMenu.Size = new Size(327, 34);
            btnStockMenu.TabIndex = 4;
            btnStockMenu.Text = "Voorraad en reserveringen";
            btnStockMenu.UseVisualStyleBackColor = false;
            // 
            // btnPlanningMenu
            // 
            btnPlanningMenu.BackColor = SystemColors.ActiveBorder;
            btnPlanningMenu.Dock = DockStyle.Fill;
            btnPlanningMenu.Location = new Point(3, 203);
            btnPlanningMenu.Name = "btnPlanningMenu";
            btnPlanningMenu.Size = new Size(327, 34);
            btnPlanningMenu.TabIndex = 5;
            btnPlanningMenu.Text = "Roosters";
            btnPlanningMenu.UseVisualStyleBackColor = false;
            // 
            // btnDashboardMenu
            // 
            btnDashboardMenu.BackColor = SystemColors.ActiveBorder;
            btnDashboardMenu.Dock = DockStyle.Fill;
            btnDashboardMenu.Location = new Point(3, 243);
            btnDashboardMenu.Name = "btnDashboardMenu";
            btnDashboardMenu.Size = new Size(327, 34);
            btnDashboardMenu.TabIndex = 6;
            btnDashboardMenu.Text = "Prestatie dashboard";
            btnDashboardMenu.UseVisualStyleBackColor = false;
            // 
            // btnOpeningsTimesMenu
            // 
            btnOpeningsTimesMenu.Dock = DockStyle.Fill;
            btnOpeningsTimesMenu.Location = new Point(3, 283);
            btnOpeningsTimesMenu.Name = "btnOpeningsTimesMenu";
            btnOpeningsTimesMenu.Size = new Size(327, 34);
            btnOpeningsTimesMenu.TabIndex = 7;
            btnOpeningsTimesMenu.Text = "Openingstijden";
            btnOpeningsTimesMenu.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(3, 323);
            button9.Name = "button9";
            button9.Size = new Size(327, 34);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(3, 363);
            button10.Name = "button10";
            button10.Size = new Size(327, 35);
            button10.TabIndex = 9;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
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
        private Button btnCarsMenu;
        private Button btnInvoicesMenu;
        private Button btnCustomersMenu;
        private Button btnEmployeesMenu;
        private Button btnStockMenu;
        private Button btnPlanningMenu;
        private Button btnDashboardMenu;
        private Button btnOpeningsTimesMenu;
        private Button button9;
        private Button button10;
    }
}