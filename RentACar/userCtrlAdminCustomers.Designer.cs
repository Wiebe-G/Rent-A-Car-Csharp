namespace RentACar
{
    partial class userCtrlAdminCustomers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabAdminCustomers = new TabControl();
            tabAdminAllCustomers = new TabPage();
            pnlTabAdminLayoutCustomers = new TableLayoutPanel();
            pnlTabAdminSearch = new TableLayoutPanel();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblStatus = new Label();
            lblEdit = new Label();
            txtSearchByLastName = new TextBox();
            pnlTabAdminAllCustomers = new TableLayoutPanel();
            tabAdminAddCustomer = new TabPage();
            tabAdminCustomers.SuspendLayout();
            tabAdminAllCustomers.SuspendLayout();
            pnlTabAdminLayoutCustomers.SuspendLayout();
            pnlTabAdminSearch.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdminCustomers
            // 
            tabAdminCustomers.Controls.Add(tabAdminAllCustomers);
            tabAdminCustomers.Controls.Add(tabAdminAddCustomer);
            tabAdminCustomers.Dock = DockStyle.Fill;
            tabAdminCustomers.Location = new Point(0, 0);
            tabAdminCustomers.Name = "tabAdminCustomers";
            tabAdminCustomers.SelectedIndex = 0;
            tabAdminCustomers.Size = new Size(1100, 539);
            tabAdminCustomers.TabIndex = 0;
            // 
            // tabAdminAllCustomers
            // 
            tabAdminAllCustomers.Controls.Add(pnlTabAdminLayoutCustomers);
            tabAdminAllCustomers.Location = new Point(4, 29);
            tabAdminAllCustomers.Name = "tabAdminAllCustomers";
            tabAdminAllCustomers.Padding = new Padding(3);
            tabAdminAllCustomers.Size = new Size(1092, 506);
            tabAdminAllCustomers.TabIndex = 0;
            tabAdminAllCustomers.Text = "Alle klanten";
            tabAdminAllCustomers.UseVisualStyleBackColor = true;
            // 
            // pnlTabAdminLayoutCustomers
            // 
            pnlTabAdminLayoutCustomers.BackColor = SystemColors.ControlLight;
            pnlTabAdminLayoutCustomers.ColumnCount = 1;
            pnlTabAdminLayoutCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabAdminLayoutCustomers.Controls.Add(pnlTabAdminSearch, 0, 0);
            pnlTabAdminLayoutCustomers.Controls.Add(pnlTabAdminAllCustomers, 0, 1);
            pnlTabAdminLayoutCustomers.Dock = DockStyle.Fill;
            pnlTabAdminLayoutCustomers.Location = new Point(3, 3);
            pnlTabAdminLayoutCustomers.Name = "pnlTabAdminLayoutCustomers";
            pnlTabAdminLayoutCustomers.RowCount = 2;
            pnlTabAdminLayoutCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabAdminLayoutCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabAdminLayoutCustomers.Size = new Size(1086, 500);
            pnlTabAdminLayoutCustomers.TabIndex = 0;
            // 
            // pnlTabAdminSearch
            // 
            pnlTabAdminSearch.BackColor = SystemColors.ControlLight;
            pnlTabAdminSearch.ColumnCount = 4;
            pnlTabAdminSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminSearch.Controls.Add(lblLastName, 0, 1);
            pnlTabAdminSearch.Controls.Add(lblFirstName, 1, 1);
            pnlTabAdminSearch.Controls.Add(lblStatus, 2, 1);
            pnlTabAdminSearch.Controls.Add(lblEdit, 3, 1);
            pnlTabAdminSearch.Controls.Add(txtSearchByLastName, 1, 0);
            pnlTabAdminSearch.Dock = DockStyle.Fill;
            pnlTabAdminSearch.Location = new Point(3, 3);
            pnlTabAdminSearch.Name = "pnlTabAdminSearch";
            pnlTabAdminSearch.RowCount = 2;
            pnlTabAdminSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabAdminSearch.Size = new Size(1080, 94);
            pnlTabAdminSearch.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Dock = DockStyle.Fill;
            lblLastName.Location = new Point(3, 47);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(264, 47);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Achternaam";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Dock = DockStyle.Fill;
            lblFirstName.Location = new Point(273, 47);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(264, 47);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Voornaam";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(543, 47);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(264, 47);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Dock = DockStyle.Fill;
            lblEdit.Location = new Point(813, 47);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(264, 47);
            lblEdit.TabIndex = 3;
            lblEdit.Text = "Bewerk";
            lblEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearchByLastName
            // 
            txtSearchByLastName.BackColor = SystemColors.ControlDark;
            txtSearchByLastName.Dock = DockStyle.Fill;
            txtSearchByLastName.Location = new Point(273, 3);
            txtSearchByLastName.Multiline = true;
            txtSearchByLastName.Name = "txtSearchByLastName";
            txtSearchByLastName.PlaceholderText = "Zoek op achternaam...";
            txtSearchByLastName.Size = new Size(264, 41);
            txtSearchByLastName.TabIndex = 4;
            txtSearchByLastName.TextChanged += txtSearchByLastName_TextChanged;
            // 
            // pnlTabAdminAllCustomers
            // 
            pnlTabAdminAllCustomers.ColumnCount = 4;
            pnlTabAdminAllCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminAllCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminAllCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminAllCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminAllCustomers.Dock = DockStyle.Fill;
            pnlTabAdminAllCustomers.Location = new Point(3, 103);
            pnlTabAdminAllCustomers.Name = "pnlTabAdminAllCustomers";
            pnlTabAdminAllCustomers.RowCount = 2;
            pnlTabAdminAllCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminAllCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminAllCustomers.Size = new Size(1080, 394);
            pnlTabAdminAllCustomers.TabIndex = 2;
            // 
            // tabAdminAddCustomer
            // 
            tabAdminAddCustomer.Location = new Point(4, 29);
            tabAdminAddCustomer.Name = "tabAdminAddCustomer";
            tabAdminAddCustomer.Padding = new Padding(3);
            tabAdminAddCustomer.Size = new Size(1092, 506);
            tabAdminAddCustomer.TabIndex = 1;
            tabAdminAddCustomer.Text = "Voeg klant toe";
            tabAdminAddCustomer.UseVisualStyleBackColor = true;
            // 
            // userCtrlAdminCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabAdminCustomers);
            Name = "userCtrlAdminCustomers";
            Size = new Size(1100, 539);
            tabAdminCustomers.ResumeLayout(false);
            tabAdminAllCustomers.ResumeLayout(false);
            pnlTabAdminLayoutCustomers.ResumeLayout(false);
            pnlTabAdminSearch.ResumeLayout(false);
            pnlTabAdminSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdminCustomers;
        private TabPage tabAdminAllCustomers;
        private TabPage tabAdminAddCustomer;
        private TableLayoutPanel pnlTabAdminLayoutCustomers;
        private TableLayoutPanel pnlTabAdminSearch;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblStatus;
        private Label lblEdit;
        private TextBox txtSearchByLastName;
        private TableLayoutPanel pnlTabAdminAllCustomers;
    }
}
