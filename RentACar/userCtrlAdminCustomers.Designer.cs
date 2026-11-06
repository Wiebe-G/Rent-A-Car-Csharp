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
            pnlTabAdminAllCustomers = new TableLayoutPanel();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblStatus = new Label();
            lblEdit = new Label();
            txtSearchByLastName = new TextBox();
            tabAdminAddCustomer = new TabPage();
            tabAdminCustomers.SuspendLayout();
            tabAdminAllCustomers.SuspendLayout();
            pnlTabAdminAllCustomers.SuspendLayout();
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
            tabAdminAllCustomers.Controls.Add(pnlTabAdminAllCustomers);
            tabAdminAllCustomers.Location = new Point(4, 29);
            tabAdminAllCustomers.Name = "tabAdminAllCustomers";
            tabAdminAllCustomers.Padding = new Padding(3);
            tabAdminAllCustomers.Size = new Size(1092, 506);
            tabAdminAllCustomers.TabIndex = 0;
            tabAdminAllCustomers.Text = "Alle klanten";
            tabAdminAllCustomers.UseVisualStyleBackColor = true;
            // 
            // pnlTabAdminAllCustomers
            // 
            pnlTabAdminAllCustomers.BackColor = SystemColors.ControlLight;
            pnlTabAdminAllCustomers.ColumnCount = 4;
            pnlTabAdminAllCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminAllCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminAllCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminAllCustomers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTabAdminAllCustomers.Controls.Add(lblLastName, 0, 1);
            pnlTabAdminAllCustomers.Controls.Add(lblFirstName, 1, 1);
            pnlTabAdminAllCustomers.Controls.Add(lblStatus, 2, 1);
            pnlTabAdminAllCustomers.Controls.Add(lblEdit, 3, 1);
            pnlTabAdminAllCustomers.Controls.Add(txtSearchByLastName, 1, 0);
            pnlTabAdminAllCustomers.Dock = DockStyle.Fill;
            pnlTabAdminAllCustomers.Location = new Point(3, 3);
            pnlTabAdminAllCustomers.Name = "pnlTabAdminAllCustomers";
            pnlTabAdminAllCustomers.RowCount = 3;
            pnlTabAdminAllCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabAdminAllCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabAdminAllCustomers.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabAdminAllCustomers.Size = new Size(1086, 500);
            pnlTabAdminAllCustomers.TabIndex = 0;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Dock = DockStyle.Fill;
            lblLastName.Location = new Point(3, 50);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(265, 50);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Achternaam";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Dock = DockStyle.Fill;
            lblFirstName.Location = new Point(274, 50);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(265, 50);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Voornaam";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(545, 50);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(265, 50);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Dock = DockStyle.Fill;
            lblEdit.Location = new Point(816, 50);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(267, 50);
            lblEdit.TabIndex = 3;
            lblEdit.Text = "Bewerk";
            lblEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearchByLastName
            // 
            txtSearchByLastName.BackColor = SystemColors.ControlDark;
            txtSearchByLastName.Dock = DockStyle.Fill;
            txtSearchByLastName.Location = new Point(274, 3);
            txtSearchByLastName.Multiline = true;
            txtSearchByLastName.Name = "txtSearchByLastName";
            txtSearchByLastName.PlaceholderText = "Zoek op achternaam...";
            txtSearchByLastName.Size = new Size(265, 44);
            txtSearchByLastName.TabIndex = 4;
            txtSearchByLastName.TextChanged += txtSearchByLastName_TextChanged;
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
            pnlTabAdminAllCustomers.ResumeLayout(false);
            pnlTabAdminAllCustomers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdminCustomers;
        private TabPage tabAdminAllCustomers;
        private TabPage tabAdminAddCustomer;
        private TableLayoutPanel pnlTabAdminAllCustomers;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblStatus;
        private Label lblEdit;
        private TextBox txtSearchByLastName;
    }
}
