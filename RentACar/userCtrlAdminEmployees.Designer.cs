namespace RentACar
{
    partial class userCtrlAdminEmployees
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
            tabAdminEmployees = new TabControl();
            tabAdminAllEmployees = new TabPage();
            pnlTabGioIsEenTeringlijer = new TableLayoutPanel();
            pnlTabAdminSearchEmployee = new TableLayoutPanel();
            txtSearchEmployeeByLastName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblStatus = new Label();
            lblEditButton = new Label();
            lblRole = new Label();
            pnlTabAdminEmployeesLayout = new TableLayoutPanel();
            tabAdminMakeEmployee = new TabPage();
            tabAdminEmployees.SuspendLayout();
            tabAdminAllEmployees.SuspendLayout();
            pnlTabGioIsEenTeringlijer.SuspendLayout();
            pnlTabAdminSearchEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdminEmployees
            // 
            tabAdminEmployees.Controls.Add(tabAdminAllEmployees);
            tabAdminEmployees.Controls.Add(tabAdminMakeEmployee);
            tabAdminEmployees.Dock = DockStyle.Fill;
            tabAdminEmployees.Location = new Point(0, 0);
            tabAdminEmployees.Name = "tabAdminEmployees";
            tabAdminEmployees.SelectedIndex = 0;
            tabAdminEmployees.Size = new Size(1212, 512);
            tabAdminEmployees.TabIndex = 0;
            // 
            // tabAdminAllEmployees
            // 
            tabAdminAllEmployees.BackColor = SystemColors.ControlLight;
            tabAdminAllEmployees.Controls.Add(pnlTabGioIsEenTeringlijer);
            tabAdminAllEmployees.Location = new Point(4, 29);
            tabAdminAllEmployees.Name = "tabAdminAllEmployees";
            tabAdminAllEmployees.Padding = new Padding(3);
            tabAdminAllEmployees.Size = new Size(1204, 479);
            tabAdminAllEmployees.TabIndex = 0;
            tabAdminAllEmployees.Text = "Alle medewerkers";
            // 
            // pnlTabGioIsEenTeringlijer
            // 
            pnlTabGioIsEenTeringlijer.ColumnCount = 1;
            pnlTabGioIsEenTeringlijer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabGioIsEenTeringlijer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlTabGioIsEenTeringlijer.Controls.Add(pnlTabAdminSearchEmployee, 0, 0);
            pnlTabGioIsEenTeringlijer.Controls.Add(pnlTabAdminEmployeesLayout, 0, 1);
            pnlTabGioIsEenTeringlijer.Dock = DockStyle.Fill;
            pnlTabGioIsEenTeringlijer.Location = new Point(3, 3);
            pnlTabGioIsEenTeringlijer.Name = "pnlTabGioIsEenTeringlijer";
            pnlTabGioIsEenTeringlijer.RowCount = 2;
            pnlTabGioIsEenTeringlijer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabGioIsEenTeringlijer.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabGioIsEenTeringlijer.Size = new Size(1198, 473);
            pnlTabGioIsEenTeringlijer.TabIndex = 1;
            // 
            // pnlTabAdminSearchEmployee
            // 
            pnlTabAdminSearchEmployee.ColumnCount = 5;
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.Controls.Add(txtSearchEmployeeByLastName, 1, 0);
            pnlTabAdminSearchEmployee.Controls.Add(lblLastName, 0, 1);
            pnlTabAdminSearchEmployee.Controls.Add(lblFirstName, 1, 1);
            pnlTabAdminSearchEmployee.Controls.Add(lblStatus, 2, 1);
            pnlTabAdminSearchEmployee.Controls.Add(lblEditButton, 4, 1);
            pnlTabAdminSearchEmployee.Controls.Add(lblRole, 3, 1);
            pnlTabAdminSearchEmployee.Dock = DockStyle.Fill;
            pnlTabAdminSearchEmployee.Location = new Point(3, 3);
            pnlTabAdminSearchEmployee.Name = "pnlTabAdminSearchEmployee";
            pnlTabAdminSearchEmployee.RowCount = 2;
            pnlTabAdminSearchEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminSearchEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminSearchEmployee.Size = new Size(1192, 88);
            pnlTabAdminSearchEmployee.TabIndex = 0;
            // 
            // txtSearchEmployeeByLastName
            // 
            txtSearchEmployeeByLastName.BackColor = SystemColors.ControlDark;
            txtSearchEmployeeByLastName.Dock = DockStyle.Fill;
            txtSearchEmployeeByLastName.Location = new Point(241, 3);
            txtSearchEmployeeByLastName.Multiline = true;
            txtSearchEmployeeByLastName.Name = "txtSearchEmployeeByLastName";
            txtSearchEmployeeByLastName.PlaceholderText = "Zoek op achternaam...";
            txtSearchEmployeeByLastName.Size = new Size(232, 38);
            txtSearchEmployeeByLastName.TabIndex = 0;
            txtSearchEmployeeByLastName.TextChanged += txtSearchEmployeeByLastName_TextChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Dock = DockStyle.Fill;
            lblLastName.Location = new Point(3, 44);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(232, 44);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Achternaam";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Dock = DockStyle.Fill;
            lblFirstName.Location = new Point(241, 44);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(232, 44);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "Voornaam";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(479, 44);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(232, 44);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEditButton
            // 
            lblEditButton.AutoSize = true;
            lblEditButton.Dock = DockStyle.Fill;
            lblEditButton.Location = new Point(955, 44);
            lblEditButton.Name = "lblEditButton";
            lblEditButton.Size = new Size(234, 44);
            lblEditButton.TabIndex = 4;
            lblEditButton.Text = "Bewerk";
            lblEditButton.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Fill;
            lblRole.Location = new Point(717, 44);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(232, 44);
            lblRole.TabIndex = 5;
            lblRole.Text = "Rol";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTabAdminEmployeesLayout
            // 
            pnlTabAdminEmployeesLayout.ColumnCount = 1;
            pnlTabAdminEmployeesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminEmployeesLayout.Dock = DockStyle.Fill;
            pnlTabAdminEmployeesLayout.Location = new Point(3, 97);
            pnlTabAdminEmployeesLayout.Name = "pnlTabAdminEmployeesLayout";
            pnlTabAdminEmployeesLayout.RowCount = 1;
            pnlTabAdminEmployeesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminEmployeesLayout.Size = new Size(1192, 373);
            pnlTabAdminEmployeesLayout.TabIndex = 1;
            // 
            // tabAdminMakeEmployee
            // 
            tabAdminMakeEmployee.BackColor = SystemColors.ControlLight;
            tabAdminMakeEmployee.Location = new Point(4, 29);
            tabAdminMakeEmployee.Name = "tabAdminMakeEmployee";
            tabAdminMakeEmployee.Padding = new Padding(3);
            tabAdminMakeEmployee.Size = new Size(1204, 479);
            tabAdminMakeEmployee.TabIndex = 1;
            tabAdminMakeEmployee.Text = "Maak medewerker aan";
            // 
            // userCtrlAdminEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tabAdminEmployees);
            Name = "userCtrlAdminEmployees";
            Size = new Size(1212, 512);
            tabAdminEmployees.ResumeLayout(false);
            tabAdminAllEmployees.ResumeLayout(false);
            pnlTabGioIsEenTeringlijer.ResumeLayout(false);
            pnlTabAdminSearchEmployee.ResumeLayout(false);
            pnlTabAdminSearchEmployee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdminEmployees;
        private TabPage tabAdminAllEmployees;
        private TableLayoutPanel pnlTabGioIsEenTeringlijer;
        private TableLayoutPanel pnlTabAdminSearchEmployee;
        private TextBox txtSearchEmployeeByLastName;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblStatus;
        private Label lblEditButton;
        private TableLayoutPanel pnlTabAdminEmployeesLayout;
        private TabPage tabAdminMakeEmployee;
        private Label lblRole;
    }
}
