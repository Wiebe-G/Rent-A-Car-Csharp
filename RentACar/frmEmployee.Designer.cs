namespace RentACar
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
            pnlTabLayoutEmployeeForm = new TableLayoutPanel();
            pnlTabTopBarEmployee = new TableLayoutPanel();
            btnOpenAdminPanel = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblStatusFilter = new Label();
            cmbStatusFilter = new ComboBox();
            btnAddCar = new Button();
            btnEditCar = new Button();
            btnSetCarOutOfService = new Button();
            btnBack = new Button();
            dgvCars = new DataGridView();
            pnlTabLayoutEmployeeForm.SuspendLayout();
            pnlTabTopBarEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // pnlTabLayoutEmployeeForm
            // 
            pnlTabLayoutEmployeeForm.ColumnCount = 1;
            pnlTabLayoutEmployeeForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabLayoutEmployeeForm.Controls.Add(pnlTabTopBarEmployee, 0, 0);
            pnlTabLayoutEmployeeForm.Controls.Add(dgvCars, 0, 1);
            pnlTabLayoutEmployeeForm.Dock = DockStyle.Fill;
            pnlTabLayoutEmployeeForm.Location = new Point(0, 0);
            pnlTabLayoutEmployeeForm.Name = "pnlTabLayoutEmployeeForm";
            pnlTabLayoutEmployeeForm.RowCount = 2;
            pnlTabLayoutEmployeeForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            pnlTabLayoutEmployeeForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabLayoutEmployeeForm.Size = new Size(1400, 700);
            pnlTabLayoutEmployeeForm.TabIndex = 0;
            // 
            // pnlTabTopBarEmployee
            // 
            pnlTabTopBarEmployee.ColumnCount = 9;
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabTopBarEmployee.Controls.Add(btnOpenAdminPanel, 0, 0);
            pnlTabTopBarEmployee.Controls.Add(lblSearch, 1, 0);
            pnlTabTopBarEmployee.Controls.Add(txtSearch, 2, 0);
            pnlTabTopBarEmployee.Controls.Add(lblStatusFilter, 3, 0);
            pnlTabTopBarEmployee.Controls.Add(cmbStatusFilter, 4, 0);
            pnlTabTopBarEmployee.Controls.Add(btnAddCar, 5, 0);
            pnlTabTopBarEmployee.Controls.Add(btnEditCar, 6, 0);
            pnlTabTopBarEmployee.Controls.Add(btnSetCarOutOfService, 7, 0);
            pnlTabTopBarEmployee.Controls.Add(btnBack, 8, 0);
            pnlTabTopBarEmployee.Dock = DockStyle.Fill;
            pnlTabTopBarEmployee.Location = new Point(3, 3);
            pnlTabTopBarEmployee.Name = "pnlTabTopBarEmployee";
            pnlTabTopBarEmployee.Padding = new Padding(8);
            pnlTabTopBarEmployee.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabTopBarEmployee.Size = new Size(1394, 84);
            pnlTabTopBarEmployee.TabIndex = 0;
            // 
            // btnOpenAdminPanel
            // 
            btnOpenAdminPanel.Dock = DockStyle.Fill;
            btnOpenAdminPanel.Location = new Point(11, 11);
            btnOpenAdminPanel.Name = "btnOpenAdminPanel";
            btnOpenAdminPanel.Size = new Size(144, 62);
            btnOpenAdminPanel.TabIndex = 7;
            btnOpenAdminPanel.Text = "Admin";
            btnOpenAdminPanel.Visible = false;
            btnOpenAdminPanel.Click += btnOpenAdminPanel_Click;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(161, 32);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Zoeken:";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(411, 16);
            txtSearch.Margin = new Padding(3, 8, 8, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(69, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.Anchor = AnchorStyles.Left;
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Location = new Point(491, 32);
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
            cmbStatusFilter.Location = new Point(671, 11);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(114, 28);
            cmbStatusFilter.TabIndex = 3;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // btnAddCar
            // 
            btnAddCar.Dock = DockStyle.Fill;
            btnAddCar.Location = new Point(791, 11);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(114, 62);
            btnAddCar.TabIndex = 4;
            btnAddCar.Text = "Auto toevoegen";
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.Dock = DockStyle.Fill;
            btnEditCar.Location = new Point(911, 11);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(174, 62);
            btnEditCar.TabIndex = 5;
            btnEditCar.Text = "Auto bewerken";
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnSetCarOutOfService
            // 
            btnSetCarOutOfService.Dock = DockStyle.Fill;
            btnSetCarOutOfService.Location = new Point(1091, 11);
            btnSetCarOutOfService.Name = "btnSetCarOutOfService";
            btnSetCarOutOfService.Size = new Size(94, 62);
            btnSetCarOutOfService.TabIndex = 6;
            btnSetCarOutOfService.Text = "Buiten gebruik";
            btnSetCarOutOfService.Click += btnSetCarOutOfService_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(1191, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(192, 62);
            btnBack.TabIndex = 7;
            btnBack.Text = "Terug";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
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
            dgvCars.Size = new Size(1394, 604);
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
            pnlTabTopBarEmployee.ResumeLayout(false);
            pnlTabTopBarEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabLayoutEmployeeForm;
        private TableLayoutPanel pnlTabTopBarEmployee;
        private Button btnOpenAdminPanel;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblStatusFilter;
        private ComboBox cmbStatusFilter;
        private Button btnAddCar;
        private Button btnEditCar;
        private Button btnSetCarOutOfService;
        private DataGridView dgvCars;
        private Button btnBack;
    }
}