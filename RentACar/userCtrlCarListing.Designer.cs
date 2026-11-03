namespace RentACar
{
    partial class userCtrlCarListing
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
            pnlTabCarListingLayout = new TableLayoutPanel();
            picCarPhoto = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMerk = new Label();
            lblModel = new Label();
            lblKenteken = new Label();
            lblType = new Label();
            lblDagprijs = new Label();
            lblStatus = new Label();
            pnlTabCarListingLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCarPhoto).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabCarListingLayout
            // 
            pnlTabCarListingLayout.ColumnCount = 1;
            pnlTabCarListingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabCarListingLayout.Controls.Add(picCarPhoto, 0, 0);
            pnlTabCarListingLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            pnlTabCarListingLayout.Dock = DockStyle.Fill;
            pnlTabCarListingLayout.Location = new Point(0, 0);
            pnlTabCarListingLayout.Name = "pnlTabCarListingLayout";
            pnlTabCarListingLayout.RowCount = 2;
            pnlTabCarListingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            pnlTabCarListingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            pnlTabCarListingLayout.Size = new Size(1199, 526);
            pnlTabCarListingLayout.TabIndex = 0;
            // 
            // picCarPhoto
            // 
            picCarPhoto.Dock = DockStyle.Fill;
            picCarPhoto.Location = new Point(3, 3);
            picCarPhoto.Name = "picCarPhoto";
            picCarPhoto.Size = new Size(1193, 335);
            picCarPhoto.TabIndex = 0;
            picCarPhoto.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(lblMerk, 0, 0);
            tableLayoutPanel1.Controls.Add(lblModel, 0, 1);
            tableLayoutPanel1.Controls.Add(lblKenteken, 1, 0);
            tableLayoutPanel1.Controls.Add(lblType, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDagprijs, 2, 0);
            tableLayoutPanel1.Controls.Add(lblStatus, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 344);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1193, 179);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Dock = DockStyle.Fill;
            lblMerk.Location = new Point(3, 0);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(391, 89);
            lblMerk.TabIndex = 0;
            lblMerk.Text = "Merk";
            lblMerk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Dock = DockStyle.Fill;
            lblModel.Location = new Point(3, 89);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(391, 90);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model";
            lblModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKenteken
            // 
            lblKenteken.AutoSize = true;
            lblKenteken.Dock = DockStyle.Fill;
            lblKenteken.Location = new Point(400, 0);
            lblKenteken.Name = "lblKenteken";
            lblKenteken.Size = new Size(391, 89);
            lblKenteken.TabIndex = 2;
            lblKenteken.Text = "Kenteken";
            lblKenteken.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Dock = DockStyle.Fill;
            lblType.Location = new Point(400, 89);
            lblType.Name = "lblType";
            lblType.Size = new Size(391, 90);
            lblType.TabIndex = 3;
            lblType.Text = "Type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDagprijs
            // 
            lblDagprijs.AutoSize = true;
            lblDagprijs.Dock = DockStyle.Fill;
            lblDagprijs.Location = new Point(797, 0);
            lblDagprijs.Name = "lblDagprijs";
            lblDagprijs.Size = new Size(393, 89);
            lblDagprijs.TabIndex = 4;
            lblDagprijs.Text = "Dagprijs";
            lblDagprijs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(797, 89);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(393, 90);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userCtrlCarListing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlTabCarListingLayout);
            Name = "userCtrlCarListing";
            Size = new Size(1199, 526);
            pnlTabCarListingLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCarPhoto).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabCarListingLayout;
        private PictureBox picCarPhoto;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMerk;
        private Label lblModel;
        private Label lblKenteken;
        private Label lblType;
        private Label lblDagprijs;
        private Label lblStatus;
    }
}
