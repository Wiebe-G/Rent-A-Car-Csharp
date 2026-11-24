namespace RentACar
{
    partial class userCtrlAdminInvoices
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
            pnlTabAdminInvoices = new TableLayoutPanel();
            lblCustomerName = new Label();
            lblCar = new Label();
            lblTotalPrice = new Label();
            lblPaidOrNot = new Label();
            lblSendInvoice = new Label();
            pnlTabAdminInvoices.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabAdminInvoices
            // 
            pnlTabAdminInvoices.ColumnCount = 5;
            pnlTabAdminInvoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.Controls.Add(lblCustomerName, 0, 0);
            pnlTabAdminInvoices.Controls.Add(lblCar, 1, 0);
            pnlTabAdminInvoices.Controls.Add(lblTotalPrice, 2, 0);
            pnlTabAdminInvoices.Controls.Add(lblPaidOrNot, 3, 0);
            pnlTabAdminInvoices.Controls.Add(lblSendInvoice, 4, 0);
            pnlTabAdminInvoices.Dock = DockStyle.Fill;
            pnlTabAdminInvoices.Location = new Point(0, 0);
            pnlTabAdminInvoices.Name = "pnlTabAdminInvoices";
            pnlTabAdminInvoices.RowCount = 5;
            pnlTabAdminInvoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabAdminInvoices.Size = new Size(1108, 453);
            pnlTabAdminInvoices.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Dock = DockStyle.Fill;
            lblCustomerName.Location = new Point(3, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(215, 90);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Klantnaam";
            lblCustomerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Dock = DockStyle.Fill;
            lblCar.Location = new Point(224, 0);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(215, 90);
            lblCar.TabIndex = 1;
            lblCar.Text = "Auto";
            lblCar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Dock = DockStyle.Fill;
            lblTotalPrice.Location = new Point(445, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(215, 90);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "Totaalprijs";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPaidOrNot
            // 
            lblPaidOrNot.AutoSize = true;
            lblPaidOrNot.Dock = DockStyle.Fill;
            lblPaidOrNot.Location = new Point(666, 0);
            lblPaidOrNot.Name = "lblPaidOrNot";
            lblPaidOrNot.Size = new Size(215, 90);
            lblPaidOrNot.TabIndex = 3;
            lblPaidOrNot.Text = "Betaald";
            lblPaidOrNot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSendInvoice
            // 
            lblSendInvoice.AutoSize = true;
            lblSendInvoice.Dock = DockStyle.Fill;
            lblSendInvoice.Location = new Point(887, 0);
            lblSendInvoice.Name = "lblSendInvoice";
            lblSendInvoice.Size = new Size(218, 90);
            lblSendInvoice.TabIndex = 4;
            lblSendInvoice.Text = "Verstuur factuur";
            lblSendInvoice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userCtrlAdminInvoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(pnlTabAdminInvoices);
            Name = "userCtrlAdminInvoices";
            Size = new Size(1108, 453);
            pnlTabAdminInvoices.ResumeLayout(false);
            pnlTabAdminInvoices.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabAdminInvoices;
        private Label lblCustomerName;
        private Label lblCar;
        private Label lblTotalPrice;
        private Label lblPaidOrNot;
        private Label lblSendInvoice;
    }
}
