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
            pnlTabLabels = new TableLayoutPanel();
            lblMerk = new Label();
            lblModel = new Label();
            lblKenteken = new Label();
            lblType = new Label();
            lblDagprijs = new Label();
            lblStatus = new Label();
            pnlTabPicture = new TableLayoutPanel();
            picCarPhoto = new PictureBox();
            btnEditCar = new Button();
            pnlTabCarListingLayout.SuspendLayout();
            pnlTabLabels.SuspendLayout();
            pnlTabPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCarPhoto).BeginInit();
            SuspendLayout();
            // 
            // pnlTabCarListingLayout
            // 
            pnlTabCarListingLayout.ColumnCount = 1;
            pnlTabCarListingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabCarListingLayout.Controls.Add(pnlTabLabels, 0, 1);
            pnlTabCarListingLayout.Controls.Add(pnlTabPicture, 0, 0);
            pnlTabCarListingLayout.Dock = DockStyle.Fill;
            pnlTabCarListingLayout.Location = new Point(0, 0);
            pnlTabCarListingLayout.Name = "pnlTabCarListingLayout";
            pnlTabCarListingLayout.RowCount = 2;
            pnlTabCarListingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            pnlTabCarListingLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            pnlTabCarListingLayout.Size = new Size(1199, 526);
            pnlTabCarListingLayout.TabIndex = 0;
            // 
            // pnlTabLabels
            // 
            pnlTabLabels.ColumnCount = 3;
            pnlTabLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTabLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTabLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTabLabels.Controls.Add(lblMerk, 0, 0);
            pnlTabLabels.Controls.Add(lblModel, 0, 1);
            pnlTabLabels.Controls.Add(lblKenteken, 1, 0);
            pnlTabLabels.Controls.Add(lblType, 1, 1);
            pnlTabLabels.Controls.Add(lblDagprijs, 2, 0);
            pnlTabLabels.Controls.Add(lblStatus, 2, 1);
            pnlTabLabels.Dock = DockStyle.Fill;
            pnlTabLabels.Location = new Point(3, 344);
            pnlTabLabels.Name = "pnlTabLabels";
            pnlTabLabels.RowCount = 2;
            pnlTabLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabLabels.Size = new Size(1193, 179);
            pnlTabLabels.TabIndex = 1;
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
            // pnlTabPicture
            // 
            pnlTabPicture.ColumnCount = 3;
            pnlTabPicture.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabPicture.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTabPicture.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabPicture.Controls.Add(picCarPhoto, 1, 0);
            pnlTabPicture.Controls.Add(btnEditCar, 2, 0);
            pnlTabPicture.Dock = DockStyle.Fill;
            pnlTabPicture.Location = new Point(3, 3);
            pnlTabPicture.Name = "pnlTabPicture";
            pnlTabPicture.RowCount = 1;
            pnlTabPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabPicture.Size = new Size(1193, 335);
            pnlTabPicture.TabIndex = 2;
            // 
            // picCarPhoto
            // 
            picCarPhoto.Dock = DockStyle.Fill;
            picCarPhoto.Location = new Point(241, 3);
            picCarPhoto.Name = "picCarPhoto";
            picCarPhoto.Size = new Size(709, 329);
            picCarPhoto.TabIndex = 1;
            picCarPhoto.TabStop = false;
            // 
            // btnEditCar
            // 
            btnEditCar.Dock = DockStyle.Fill;
            btnEditCar.Location = new Point(956, 3);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(234, 329);
            btnEditCar.TabIndex = 2;
            btnEditCar.Text = "Bewerk (niet voor klanten)";
            btnEditCar.UseVisualStyleBackColor = true;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // userCtrlCarListing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlTabCarListingLayout);
            Name = "userCtrlCarListing";
            Size = new Size(1199, 526);
            pnlTabCarListingLayout.ResumeLayout(false);
            pnlTabLabels.ResumeLayout(false);
            pnlTabLabels.PerformLayout();
            pnlTabPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCarPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabCarListingLayout;
        private TableLayoutPanel pnlTabLabels;
        private Label lblMerk;
        private Label lblModel;
        private Label lblKenteken;
        private Label lblType;
        private Label lblDagprijs;
        private Label lblStatus;
        private TableLayoutPanel pnlTabPicture;
        private PictureBox picCarPhoto;
        private Button btnEditCar;
    }
}
