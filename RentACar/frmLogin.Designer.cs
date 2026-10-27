namespace RentACar
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTabLogin = new TableLayoutPanel();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            pnlTabLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabLogin
            // 
            pnlTabLogin.ColumnCount = 3;
            pnlTabLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnlTabLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnlTabLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnlTabLogin.Controls.Add(lblEmail, 1, 0);
            pnlTabLogin.Controls.Add(txtEmail, 1, 1);
            pnlTabLogin.Controls.Add(lblPassword, 1, 2);
            pnlTabLogin.Controls.Add(txtPassword, 1, 3);
            pnlTabLogin.Controls.Add(btnLogin, 1, 4);
            pnlTabLogin.Controls.Add(btnRegister, 2, 4);
            pnlTabLogin.Dock = DockStyle.Fill;
            pnlTabLogin.Location = new Point(0, 0);
            pnlTabLogin.Name = "pnlTabLogin";
            pnlTabLogin.RowCount = 5;
            pnlTabLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabLogin.Size = new Size(1190, 525);
            pnlTabLogin.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(399, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(390, 105);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(406, 115);
            txtEmail.Margin = new Padding(10);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 85);
            txtEmail.TabIndex = 2;
            txtEmail.KeyDown += LoginWithEnter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Location = new Point(399, 210);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(390, 105);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Wachtwoord:";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(406, 325);
            txtPassword.Margin = new Padding(10);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(376, 85);
            txtPassword.TabIndex = 3;
            txtPassword.KeyDown += LoginWithEnter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkOrchid;
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.Location = new Point(411, 435);
            btnLogin.Margin = new Padding(15);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(366, 75);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.CadetBlue;
            btnRegister.Dock = DockStyle.Fill;
            btnRegister.Location = new Point(807, 435);
            btnRegister.Margin = new Padding(15);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(368, 75);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Geen account? Registreer";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1190, 525);
            Controls.Add(pnlTabLogin);
            Name = "frmLogin";
            Text = "Log in";
            pnlTabLogin.ResumeLayout(false);
            pnlTabLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabLogin;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}
