namespace RentACar
{
    partial class frmEmployeeCustomers
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlMain = new TableLayoutPanel();
            pnlSearch = new TableLayoutPanel();
            lblSearch = new Label();
            txtCustomerSearch = new TextBox();
            btnRefreshCustomers = new Button();
            dgvCustomers = new DataGridView();
            grpAddCustomer = new GroupBox();
            pnlAddCustomer = new TableLayoutPanel();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblStreetname = new Label();
            txtStreetname = new TextBox();
            lblZipcode = new Label();
            txtZipcode = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            btnAddCustomer = new Button();

            pnlMain.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            grpAddCustomer.SuspendLayout();
            pnlAddCustomer.SuspendLayout();
            SuspendLayout();

            pnlMain.ColumnCount = 1;
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlMain.RowCount = 3;
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 285F));
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Padding = new Padding(10);
            pnlMain.Controls.Add(pnlSearch, 0, 0);
            pnlMain.Controls.Add(dgvCustomers, 0, 1);
            pnlMain.Controls.Add(grpAddCustomer, 0, 2);

            pnlSearch.ColumnCount = 3;
            pnlSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            pnlSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            pnlSearch.Dock = DockStyle.Fill;
            pnlSearch.Controls.Add(lblSearch, 0, 0);
            pnlSearch.Controls.Add(txtCustomerSearch, 1, 0);
            pnlSearch.Controls.Add(btnRefreshCustomers, 2, 0);

            lblSearch.Text = "Zoeken:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            lblSearch.Dock = DockStyle.Fill;

            txtCustomerSearch.Dock = DockStyle.Fill;
            txtCustomerSearch.Margin = new Padding(3, 10, 10, 10);
            txtCustomerSearch.TextChanged += txtCustomerSearch_TextChanged;

            btnRefreshCustomers.Text = "Vernieuwen";
            btnRefreshCustomers.Dock = DockStyle.Fill;
            btnRefreshCustomers.Click += btnRefreshCustomers_Click;

            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.ColumnHeadersHeight = 36;
            dgvCustomers.RowTemplate.Height = 32;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvCustomers.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            grpAddCustomer.Text = "Nieuwe klant";
            grpAddCustomer.Dock = DockStyle.Fill;
            grpAddCustomer.Controls.Add(pnlAddCustomer);

            pnlAddCustomer.ColumnCount = 4;
            pnlAddCustomer.RowCount = 4;
            pnlAddCustomer.Dock = DockStyle.Fill;
            pnlAddCustomer.Padding = new Padding(8);
            pnlAddCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            pnlAddCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlAddCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            pnlAddCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlAddCustomer.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));
            pnlAddCustomer.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));
            pnlAddCustomer.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));
            pnlAddCustomer.RowStyles.Add(
                new RowStyle(SizeType.Percent, 25F));

            AddField(lblFirstName, "Voornaam", txtFirstName, 0, 0);
            AddField(lblLastName, "Achternaam", txtLastName, 2, 0);
            AddField(lblEmail, "E-mail", txtEmail, 0, 1);
            AddField(lblPassword, "Wachtwoord", txtPassword, 2, 1);
            AddField(lblStreetname, "Straat", txtStreetname, 0, 2);
            AddField(lblZipcode, "Postcode", txtZipcode, 2, 2);
            AddField(lblCity, "Plaats", txtCity, 0, 3);

            txtPassword.UseSystemPasswordChar = true;

            btnAddCustomer.Text = "Klant toevoegen";
            btnAddCustomer.Dock = DockStyle.Fill;
            btnAddCustomer.Click += btnAddCustomer_Click;
            pnlAddCustomer.Controls.Add(btnAddCustomer, 2, 3);
            pnlAddCustomer.SetColumnSpan(btnAddCustomer, 2);

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 850);
            MinimumSize = new Size(1100, 700);
            Controls.Add(pnlMain);
            Load += frmEmployeeCustomers_Load;

            pnlMain.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            grpAddCustomer.ResumeLayout(false);
            pnlAddCustomer.ResumeLayout(false);
            pnlAddCustomer.PerformLayout();
            ResumeLayout(false);
        }

        private void AddField(
            Label label,
            string labelText,
            TextBox textBox,
            int column,
            int row)
        {
            label.Text = labelText;
            label.Dock = DockStyle.Fill;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Margin = new Padding(3, 3, 8, 3);

            textBox.Dock = DockStyle.Fill;
            textBox.Margin = new Padding(3, 8, 12, 8);

            pnlAddCustomer.Controls.Add(label, column, row);
            pnlAddCustomer.Controls.Add(textBox, column + 1, row);
        }

        private TableLayoutPanel pnlMain;
        private TableLayoutPanel pnlSearch;
        private Label lblSearch;
        private TextBox txtCustomerSearch;
        private Button btnRefreshCustomers;
        private DataGridView dgvCustomers;
        private GroupBox grpAddCustomer;
        private TableLayoutPanel pnlAddCustomer;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblStreetname;
        private TextBox txtStreetname;
        private Label lblZipcode;
        private TextBox txtZipcode;
        private Label lblCity;
        private TextBox txtCity;
        private Button btnAddCustomer;
    }
}