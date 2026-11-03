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
            pnlTabLayoutEmployeeForm.SuspendLayout();
            pnlTabTopBarEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabLayoutEmployeeForm
            // 
            pnlTabLayoutEmployeeForm.ColumnCount = 1;
            pnlTabLayoutEmployeeForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabLayoutEmployeeForm.Controls.Add(pnlTabTopBarEmployee, 0, 0);
            pnlTabLayoutEmployeeForm.Dock = DockStyle.Fill;
            pnlTabLayoutEmployeeForm.Location = new Point(0, 0);
            pnlTabLayoutEmployeeForm.Name = "pnlTabLayoutEmployeeForm";
            pnlTabLayoutEmployeeForm.RowCount = 2;
            pnlTabLayoutEmployeeForm.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabLayoutEmployeeForm.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            pnlTabLayoutEmployeeForm.Size = new Size(1168, 455);
            pnlTabLayoutEmployeeForm.TabIndex = 0;
            // 
            // pnlTabTopBarEmployee
            // 
            pnlTabTopBarEmployee.ColumnCount = 3;
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTabTopBarEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabTopBarEmployee.Controls.Add(btnOpenAdminPanel, 0, 0);
            pnlTabTopBarEmployee.Dock = DockStyle.Fill;
            pnlTabTopBarEmployee.Location = new Point(3, 3);
            pnlTabTopBarEmployee.Name = "pnlTabTopBarEmployee";
            pnlTabTopBarEmployee.RowCount = 1;
            pnlTabTopBarEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabTopBarEmployee.Size = new Size(1162, 62);
            pnlTabTopBarEmployee.TabIndex = 0;
            // 
            // btnOpenAdminPanel
            // 
            btnOpenAdminPanel.BackColor = SystemColors.ActiveBorder;
            btnOpenAdminPanel.Dock = DockStyle.Fill;
            btnOpenAdminPanel.Location = new Point(3, 3);
            btnOpenAdminPanel.Name = "btnOpenAdminPanel";
            btnOpenAdminPanel.Size = new Size(226, 56);
            btnOpenAdminPanel.TabIndex = 0;
            btnOpenAdminPanel.Text = "Admin (voor admins)";
            btnOpenAdminPanel.UseVisualStyleBackColor = false;
            btnOpenAdminPanel.Click += btnOpenAdminPanel_Click;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1168, 455);
            Controls.Add(pnlTabLayoutEmployeeForm);
            Name = "frmEmployee";
            Text = "Medewerkers's form";
            pnlTabLayoutEmployeeForm.ResumeLayout(false);
            pnlTabTopBarEmployee.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabLayoutEmployeeForm;
        private TableLayoutPanel pnlTabTopBarEmployee;
        private Button btnOpenAdminPanel;
    }
}