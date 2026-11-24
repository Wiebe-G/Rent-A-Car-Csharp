namespace RentACar
{
    partial class frmEmployee
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTabLayoutEmployeeForm = new TableLayoutPanel();
            pnlEmployeeSidebar = new TableLayoutPanel();
            btnFleet = new Button();
            btnCustomers = new Button();
            btnDayOverview = new Button();
            btnOpeningHours = new Button();
            btnOpenAdminPanel = new Button();
            btnBack = new Button();
            pnlEmployeeContent = new TableLayoutPanel();
            pnlTabTopBarEmployee = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblStatusFilter = new Label();
            cmbStatusFilter = new ComboBox();
            btnAddCar = new Button();
            btnEditCar = new Button();
            btnSetCarOutOfService = new Button();
            dgvCars = new DataGridView();
            pnlTabLayoutEmployeeForm.SuspendLayout();
            pnlEmployeeSidebar.SuspendLayout();
            pnlEmployeeContent.SuspendLayout();
            pnlTabTopBarEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // pnlTabLayoutEmployeeForm
            // 
            pnlTabLayoutEmployeeForm.ColumnCount = 2;
            pnlTabLayoutEmployeeForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            pnlTabLayoutEmployeeForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabLayoutEmployeeForm.Controls.Add(pnlEmployeeSidebar, 0, 0);
            pnlTabLayoutEmployeeForm.Controls.Add(pnlEmployeeContent, 1, 0);
            pnlTabLayoutEmployeeForm.Dock = DockStyle.Fill;
            pnlTabLayoutEmployeeForm.Location = new Point(0, 0);
            pnlTabLayoutEmployeeForm.Name = "pnlTabLayoutEmployeeForm";
            pnlTabLayoutEmployeeForm.RowCount = 1;
            pnlTabLayoutEmployeeForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabLayoutEmployeeForm.Size = new Size(1400, 700);
            pnlTabLayoutEmployeeForm.TabIndex = 0;
            // 
            // pnlEmployeeSidebar
            // 
            pnlEmployeeSidebar.ColumnCount = 1;
            pnlEmployeeSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlEmployeeSidebar.Controls.Add(btnFleet, 0, 0);
            pnlEmployeeSidebar.Controls.Add(btnCustomers, 0, 1);
            pnlEmployeeSidebar.Controls.Add(btnDayOverview, 0, 2);
            pnlEmployeeSidebar.Controls.Add(btnOpeningHours, 0, 3);
            pnlEmployeeSidebar.Controls.Add(btnOpenAdminPanel, 0, 4);
            pnlEmployeeSidebar.Controls.Add(btnBack, 0, 5);
            pnlEmployeeSidebar.Dock = DockStyle.Fill;
            pnlEmployeeSidebar.Location = new Point(3, 3);
            pnlEmployeeSidebar.Name = "pnlEmployeeSidebar";
            pnlEmployeeSidebar.Padding = new Padding(8);
            pnlEmployeeSidebar.RowCount = 6;
            pnlEmployeeSidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.Size = new Size(214, 694);
            pnlEmployeeSidebar.TabIndex = 0;
            // 
            // btnFleet
            // 
            btnFleet.Dock = DockStyle.Fill;
            btnFleet.Location = new Point(11, 11);
            btnFleet.Name = "btnFleet";
            btnFleet.Size = new Size(192, 107);
            btnFleet.TabIndex = 0;
            btnFleet.Text = "Wagenpark";
            btnFleet.UseVisualStyleBackColor = true;
            btnFleet.Click += btnFleet_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = DockStyle.Fill;
            btnCustomers.Location = new Point(11, 124);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(192, 107);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Klanten";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnDayOverview
            // 
            btnDayOverview.Dock = DockStyle.Fill;
            btnDayOverview.Location = new Point(11, 237);
            btnDayOverview.Name = "btnDayOverview";
            btnDayOverview.Size = new Size(192, 107);
            btnDayOverview.TabIndex = 2;
            btnDayOverview.Text = "Dagoverzicht";
            btnDayOverview.UseVisualStyleBackColor = true;
            btnDayOverview.Click += btnDayOverview_Click;
            // 
            // btnOpeningHours
            // 
            btnOpeningHours.Dock = DockStyle.Fill;
            btnOpeningHours.Location = new Point(11, 350);
            btnOpeningHours.Name = "btnOpeningHours";
            btnOpeningHours.Size = new Size(192, 107);
            btnOpeningHours.TabIndex = 3;
            btnOpeningHours.Text = "Openingstijden";
            btnOpeningHours.UseVisualStyleBackColor = true;
            btnOpeningHours.Click += btnOpeningHours_Click;
            // 
            // btnOpenAdminPanel
            // 
            btnOpenAdminPanel.Dock = DockStyle.Fill;
            btnOpenAdminPanel.Location = new Point(11, 463);
            btnOpenAdminPanel.Name = "btnOpenAdminPanel";
            btnOpenAdminPanel.Size = new Size(192, 107);
            btnOpenAdminPanel.TabIndex = 4;
            btnOpenAdminPanel.Text = "Admin";
            btnOpenAdminPanel.UseVisualStyleBackColor = true;
            btnOpenAdminPanel.Visible = false;
            btnOpenAdminPanel.Click += btnOpenAdminPanel_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(11, 576);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(192, 107);
            btnBack.TabIndex = 5;
            btnBack.Text = "Terug";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pnlEmployeeContent
            // 
            pnlEmployeeContent.ColumnCount = 1;
            pnlEmployeeContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlEmployeeContent.Controls.Add(pnlTabTopBarEmployee, 0, 0);
            pnlEmployeeContent.Controls.Add(dgvCars, 0, 1);
            pnlEmployeeContent.Dock = DockStyle.Fill;
            pnlEmployeeContent.Location = new Point(223, 3);
            pnlEmployeeContent.Name = "pnlEmployeeContent";
            pnlEmployeeContent.RowCount = 2;
            pnlEmployeeContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            pnlEmployeeContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlEmployeeContent.Size = new Size(1174, 694);
            pnlEmployeeContent.TabIndex = 1;
            // 
            // pnlTabTopBarEmployee
            // 
            pnlTabTopBarEmployee.ColumnCount = 8;
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabTopBarEmployee.Controls.Add(lblSearch, 0, 0);
            pnlTabTopBarEmployee.Controls.Add(txtSearch, 1, 0);
            pnlTabTopBarEmployee.Controls.Add(lblStatusFilter, 2, 0);
            pnlTabTopBarEmployee.Controls.Add(cmbStatusFilter, 3, 0);
            pnlTabTopBarEmployee.Controls.Add(btnAddCar, 4, 0);
            pnlTabTopBarEmployee.Controls.Add(btnEditCar, 5, 0);
            pnlTabTopBarEmployee.Controls.Add(btnSetCarOutOfService, 6, 0);
            pnlTabTopBarEmployee.Dock = DockStyle.Fill;
            pnlTabTopBarEmployee.Location = new Point(3, 3);
            pnlTabTopBarEmployee.Name = "pnlTabTopBarEmployee";
            pnlTabTopBarEmployee.Padding = new Padding(8);
            pnlTabTopBarEmployee.RowCount = 1;
            pnlTabTopBarEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabTopBarEmployee.Size = new Size(1168, 84);
            pnlTabTopBarEmployee.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(11, 32);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Zoeken:";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(86, 28);
            txtSearch.Margin = new Padding(3, 20, 8, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(189, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.Anchor = AnchorStyles.Left;
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Location = new Point(286, 32);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(52, 20);
            lblStatusFilter.TabIndex = 2;
            lblStatusFilter.Text = "Status:";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.Dock = DockStyle.Fill;
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.Items.AddRange(new object[] { "Alle statussen", "beschikbaar", "verhuurd", "onderhoud", "buiten gebruik" });
            cmbStatusFilter.Location = new Point(351, 11);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(139, 28);
            cmbStatusFilter.TabIndex = 3;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // btnAddCar
            // 
            btnAddCar.Dock = DockStyle.Fill;
            btnAddCar.Location = new Point(496, 11);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(134, 62);
            btnAddCar.TabIndex = 4;
            btnAddCar.Text = "Auto toevoegen";
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.Dock = DockStyle.Fill;
            btnEditCar.Location = new Point(636, 11);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(144, 62);
            btnEditCar.TabIndex = 5;
            btnEditCar.Text = "Auto bewerken";
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnSetCarOutOfService
            // 
            btnSetCarOutOfService.Dock = DockStyle.Fill;
            btnSetCarOutOfService.Location = new Point(786, 11);
            btnSetCarOutOfService.Name = "btnSetCarOutOfService";
            btnSetCarOutOfService.Size = new Size(134, 62);
            btnSetCarOutOfService.TabIndex = 6;
            btnSetCarOutOfService.Text = "Buiten gebruik";
            btnSetCarOutOfService.Click += btnSetCarOutOfService_Click;
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.BackgroundColor = SystemColors.Window;
            dgvCars.ColumnHeadersHeight = 29;
            dgvCars.Dock = DockStyle.Fill;
            dgvCars.Location = new Point(3, 93);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersWidth = 51;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(1168, 598);
            dgvCars.TabIndex = 1;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 700);
            Controls.Add(pnlTabLayoutEmployeeForm);
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medewerkers - Wagenpark";
            pnlTabLayoutEmployeeForm.ResumeLayout(false);
            pnlEmployeeSidebar.ResumeLayout(false);
            pnlEmployeeContent.ResumeLayout(false);
            pnlTabTopBarEmployee.ResumeLayout(false);
            pnlTabTopBarEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabLayoutEmployeeForm;
        private TableLayoutPanel pnlEmployeeSidebar;
        private TableLayoutPanel pnlEmployeeContent;
        private TableLayoutPanel pnlTabTopBarEmployee;

        private Button btnFleet;
        private Button btnCustomers;
        private Button btnDayOverview;
        private Button btnOpeningHours;
        private Button btnOpenAdminPanel;
        private Button btnBack;

        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblStatusFilter;
        private ComboBox cmbStatusFilter;
        private Button btnAddCar;
        private Button btnEditCar;
        private Button btnSetCarOutOfService;
        private DataGridView dgvCars;
    }
}