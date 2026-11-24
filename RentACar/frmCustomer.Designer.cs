namespace RentACar
{
    partial class frmCustomer
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
            pnlMenu = new Panel();
            btnWagenpark = new Button();
            btnReserveringen = new Button();
            btnHuurgeschiedenis = new Button();
            btnFacturen = new Button();
            pnlContent = new Panel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(45, 45, 48);
            pnlMenu.Controls.Add(btnFacturen);
            pnlMenu.Controls.Add(btnHuurgeschiedenis);
            pnlMenu.Controls.Add(btnReserveringen);
            pnlMenu.Controls.Add(btnWagenpark);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(180, 637);
            pnlMenu.TabIndex = 0;
            // 
            // btnWagenpark
            // 
            btnWagenpark.Dock = DockStyle.Top;
            btnWagenpark.FlatStyle = FlatStyle.Flat;
            btnWagenpark.ForeColor = Color.White;
            btnWagenpark.Name = "btnWagenpark";
            btnWagenpark.Size = new Size(180, 50);
            btnWagenpark.TabIndex = 0;
            btnWagenpark.Text = "Wagenpark";
            btnWagenpark.UseVisualStyleBackColor = true;
            btnWagenpark.Click += btnWagenpark_Click;
            // 
            // btnReserveringen
            // 
            btnReserveringen.Dock = DockStyle.Top;
            btnReserveringen.FlatStyle = FlatStyle.Flat;
            btnReserveringen.ForeColor = Color.White;
            btnReserveringen.Name = "btnReserveringen";
            btnReserveringen.Size = new Size(180, 50);
            btnReserveringen.TabIndex = 1;
            btnReserveringen.Text = "Reserveringen";
            btnReserveringen.UseVisualStyleBackColor = true;
            btnReserveringen.Click += btnReserveringen_Click;
            // 
            // btnHuurgeschiedenis
            // 
            btnHuurgeschiedenis.Dock = DockStyle.Top;
            btnHuurgeschiedenis.FlatStyle = FlatStyle.Flat;
            btnHuurgeschiedenis.ForeColor = Color.White;
            btnHuurgeschiedenis.Name = "btnHuurgeschiedenis";
            btnHuurgeschiedenis.Size = new Size(180, 50);
            btnHuurgeschiedenis.TabIndex = 2;
            btnHuurgeschiedenis.Text = "Huurgeschiedenis";
            btnHuurgeschiedenis.UseVisualStyleBackColor = true;
            btnHuurgeschiedenis.Click += btnHuurgeschiedenis_Click;
            // 
            // btnFacturen
            // 
            btnFacturen.Dock = DockStyle.Top;
            btnFacturen.FlatStyle = FlatStyle.Flat;
            btnFacturen.ForeColor = Color.White;
            btnFacturen.Name = "btnFacturen";
            btnFacturen.Size = new Size(180, 50);
            btnFacturen.TabIndex = 3;
            btnFacturen.Text = "Facturen";
            btnFacturen.UseVisualStyleBackColor = true;
            btnFacturen.Click += btnFacturen_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Name = "pnlContent";
            pnlContent.TabIndex = 1;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 637);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Name = "frmCustomer";
            Text = "frmCustomer";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlContent;
        private Button btnWagenpark;
        private Button btnReserveringen;
        private Button btnHuurgeschiedenis;
        private Button btnFacturen;
    }
}