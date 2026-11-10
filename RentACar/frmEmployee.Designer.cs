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

            // pnlTabLayoutEmployeeForm
            pnlTabLayoutEmployeeForm.ColumnCount = 2;
            pnlTabLayoutEmployeeForm.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 220F));
            pnlTabLayoutEmployeeForm.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));
            pnlTabLayoutEmployeeForm.Controls.Add(
                pnlEmployeeSidebar, 0, 0);
            pnlTabLayoutEmployeeForm.Controls.Add(
                pnlEmployeeContent, 1, 0);
            pnlTabLayoutEmployeeForm.Dock = DockStyle.Fill;
            pnlTabLayoutEmployeeForm.Name = "pnlTabLayoutEmployeeForm";
            pnlTabLayoutEmployeeForm.RowCount = 1;
            pnlTabLayoutEmployeeForm.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            // pnlEmployeeSidebar
            pnlEmployeeSidebar.ColumnCount = 1;
            pnlEmployeeSidebar.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));
            pnlEmployeeSidebar.Controls.Add(btnFleet, 0, 0);
            pnlEmployeeSidebar.Controls.Add(btnCustomers, 0, 1);
            pnlEmployeeSidebar.Controls.Add(btnDayOverview, 0, 2);
            pnlEmployeeSidebar.Controls.Add(btnOpeningHours, 0, 3);
            pnlEmployeeSidebar.Controls.Add(btnOpenAdminPanel, 0, 4);
            pnlEmployeeSidebar.Controls.Add(btnBack, 0, 5);
            pnlEmployeeSidebar.Dock = DockStyle.Fill;
            pnlEmployeeSidebar.Padding = new Padding(8);
            pnlEmployeeSidebar.RowCount = 6;
            pnlEmployeeSidebar.RowStyles.Add(
                new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(
                new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(
                new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(
                new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(
                new RowStyle(SizeType.Percent, 16.6666F));
            pnlEmployeeSidebar.RowStyles.Add(
                new RowStyle(SizeType.Percent, 16.6666F));

            // btnFleet
            btnFleet.Dock = DockStyle.Fill;
            btnFleet.Margin = new Padding(3);
            btnFleet.Text = "Wagenpark";
            btnFleet.UseVisualStyleBackColor = true;
            btnFleet.Click += btnFleet_Click;

            // btnCustomers
            btnCustomers.Dock = DockStyle.Fill;
            btnCustomers.Margin = new Padding(3);
            btnCustomers.Text = "Klanten";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;

            // btnDayOverview
            btnDayOverview.Dock = DockStyle.Fill;
            btnDayOverview.Margin = new Padding(3);
            btnDayOverview.Text = "Dagoverzicht";
            btnDayOverview.UseVisualStyleBackColor = true;
            btnDayOverview.Click += btnDayOverview_Click;

            // btnOpeningHours
            btnOpeningHours.Dock = DockStyle.Fill;
            btnOpeningHours.Margin = new Padding(3);
            btnOpeningHours.Text = "Openingstijden";
            btnOpeningHours.UseVisualStyleBackColor = true;
            btnOpeningHours.Click += btnOpeningHours_Click;

            // btnOpenAdminPanel
            btnOpenAdminPanel.Dock = DockStyle.Fill;
            btnOpenAdminPanel.Margin = new Padding(3);
            btnOpenAdminPanel.Text = "Admin";
            btnOpenAdminPanel.UseVisualStyleBackColor = true;
            btnOpenAdminPanel.Visible = false;
            btnOpenAdminPanel.Click += btnOpenAdminPanel_Click;

            // btnBack
            btnBack.Dock = DockStyle.Fill;
            btnBack.Margin = new Padding(3);
            btnBack.Text = "Terug";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // pnlEmployeeContent
            pnlEmployeeContent.ColumnCount = 1;
            pnlEmployeeContent.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));
            pnlEmployeeContent.Controls.Add(
                pnlTabTopBarEmployee, 0, 0);
            pnlEmployeeContent.Controls.Add(
                dgvCars, 0, 1);
            pnlEmployeeContent.Dock = DockStyle.Fill;
            pnlEmployeeContent.RowCount = 2;
            pnlEmployeeContent.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 90F));
            pnlEmployeeContent.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            // pnlTabTopBarEmployee
            pnlTabTopBarEmployee.ColumnCount = 8;
            pnlTabTopBarEmployee.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 75F));
            pnlTabTopBarEmployee.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 200F));
            pnlTabTopBarEmployee.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 65F));
            pnlTabTopBarEmployee.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 145F));
            pnlTabTopBarEmployee.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 140F));
            pnlTabTopBarEmployee.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 150F));
            pnlTabTopBarEmployee.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 140F));
            pnlTabTopBarEmployee.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));
            pnlTabTopBarEmployee.Controls.Add(lblSearch, 0, 0);
            pnlTabTopBarEmployee.Controls.Add(txtSearch, 1, 0);
            pnlTabTopBarEmployee.Controls.Add(lblStatusFilter, 2, 0);
            pnlTabTopBarEmployee.Controls.Add(cmbStatusFilter, 3, 0);
            pnlTabTopBarEmployee.Controls.Add(btnAddCar, 4, 0);
            pnlTabTopBarEmployee.Controls.Add(btnEditCar, 5, 0);
            pnlTabTopBarEmployee.Controls.Add(
                btnSetCarOutOfService, 6, 0);
            pnlTabTopBarEmployee.Dock = DockStyle.Fill;
            pnlTabTopBarEmployee.Padding = new Padding(8);
            pnlTabTopBarEmployee.RowCount = 1;
            pnlTabTopBarEmployee.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            // lblSearch
            lblSearch.Anchor = AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.Text = "Zoeken:";

            // txtSearch
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Margin = new Padding(3, 20, 8, 20);
            txtSearch.TextChanged += txtSearch_TextChanged;

            // lblStatusFilter
            lblStatusFilter.Anchor = AnchorStyles.Left;
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Text = "Status:";

            // cmbStatusFilter
            cmbStatusFilter.Dock = DockStyle.Fill;
            cmbStatusFilter.DropDownStyle =
                ComboBoxStyle.DropDownList;
            cmbStatusFilter.Items.AddRange(new object[]
            {
                "Alle statussen",
                "beschikbaar",
                "verhuurd",
                "onderhoud",
                "buiten gebruik"
            });
            cmbStatusFilter.SelectedIndex = 0;
            cmbStatusFilter.SelectedIndexChanged +=
                cmbStatusFilter_SelectedIndexChanged;

            // btnAddCar
            btnAddCar.Dock = DockStyle.Fill;
            btnAddCar.Margin = new Padding(3);
            btnAddCar.Text = "Auto toevoegen";
            btnAddCar.Click += btnAddCar_Click;

            // btnEditCar
            btnEditCar.Dock = DockStyle.Fill;
            btnEditCar.Margin = new Padding(3);
            btnEditCar.Text = "Auto bewerken";
            btnEditCar.Click += btnEditCar_Click;

            // btnSetCarOutOfService
            btnSetCarOutOfService.Dock = DockStyle.Fill;
            btnSetCarOutOfService.Margin = new Padding(3);
            btnSetCarOutOfService.Text = "Buiten gebruik";
            btnSetCarOutOfService.Click +=
                btnSetCarOutOfService_Click;

            // dgvCars
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.BackgroundColor = SystemColors.Window;
            dgvCars.Dock = DockStyle.Fill;
            dgvCars.MultiSelect = false;
            dgvCars.ReadOnly = true;
            dgvCars.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // frmEmployee
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