namespace RentACar
{
    partial class frmMain
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
            pnlTabLayoutMainForm = new TableLayoutPanel();
            pnlTabTopBarMain = new TableLayoutPanel();
            btnOpenProfileForm = new Button();
            btnOpenEmployeePanel = new Button();
            pnlTabLayoutMainForm.SuspendLayout();
            pnlTabTopBarMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabLayoutMainForm
            // 
            pnlTabLayoutMainForm.BackColor = SystemColors.ControlLight;
            pnlTabLayoutMainForm.ColumnCount = 1;
            pnlTabLayoutMainForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabLayoutMainForm.Controls.Add(pnlTabTopBarMain, 0, 0);
            pnlTabLayoutMainForm.Dock = DockStyle.Fill;
            pnlTabLayoutMainForm.Location = new Point(0, 0);
            pnlTabLayoutMainForm.Name = "pnlTabLayoutMainForm";
            pnlTabLayoutMainForm.RowCount = 2;
            pnlTabLayoutMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabLayoutMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            pnlTabLayoutMainForm.Size = new Size(1134, 467);
            pnlTabLayoutMainForm.TabIndex = 0;
            // 
            // pnlTabTopBarMain
            // 
            pnlTabTopBarMain.ColumnCount = 3;
            pnlTabTopBarMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabTopBarMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTabTopBarMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabTopBarMain.Controls.Add(btnOpenProfileForm, 2, 0);
            pnlTabTopBarMain.Controls.Add(btnOpenEmployeePanel, 0, 0);
            pnlTabTopBarMain.Dock = DockStyle.Fill;
            pnlTabTopBarMain.Location = new Point(3, 3);
            pnlTabTopBarMain.Name = "pnlTabTopBarMain";
            pnlTabTopBarMain.RowCount = 1;
            pnlTabTopBarMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabTopBarMain.Size = new Size(1128, 64);
            pnlTabTopBarMain.TabIndex = 0;
            // 
            // btnOpenProfileForm
            // 
            btnOpenProfileForm.BackColor = SystemColors.ActiveBorder;
            btnOpenProfileForm.Dock = DockStyle.Fill;
            btnOpenProfileForm.Location = new Point(904, 3);
            btnOpenProfileForm.Name = "btnOpenProfileForm";
            btnOpenProfileForm.Size = new Size(221, 58);
            btnOpenProfileForm.TabIndex = 0;
            btnOpenProfileForm.Text = "Naam van gebruiker";
            btnOpenProfileForm.UseVisualStyleBackColor = false;
            btnOpenProfileForm.Click += btnOpenProfileForm_Click;
            // 
            // btnOpenEmployeePanel
            // 
            btnOpenEmployeePanel.BackColor = SystemColors.ActiveBorder;
            btnOpenEmployeePanel.Dock = DockStyle.Fill;
            btnOpenEmployeePanel.Location = new Point(3, 3);
            btnOpenEmployeePanel.Name = "btnOpenEmployeePanel";
            btnOpenEmployeePanel.Size = new Size(219, 58);
            btnOpenEmployeePanel.TabIndex = 1;
            btnOpenEmployeePanel.Text = "Medewerkers paneel";
            btnOpenEmployeePanel.UseVisualStyleBackColor = false;
            btnOpenEmployeePanel.Click += btnOpenEmployeePanel_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 467);
            Controls.Add(pnlTabLayoutMainForm);
            Name = "frmMain";
            Text = "Alle auto's";
            pnlTabLayoutMainForm.ResumeLayout(false);
            pnlTabTopBarMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabLayoutMainForm;
        private TableLayoutPanel pnlTabTopBarMain;
        private Button btnOpenProfileForm;
        private Button btnOpenEmployeePanel;
    }
}