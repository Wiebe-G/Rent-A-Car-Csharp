namespace RentACar
{
    partial class userCtrlAdminCars
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
            tabAdminCars = new TabControl();
            tabAdminAllCars = new TabPage();
            pnlAdminAllCars = new Panel();
            pnlTabAdminAllCars = new TableLayoutPanel();
            tabAdminAddCar = new TabPage();
            pnlTabCarsLayoutAdmin = new TableLayoutPanel();
            pnlTabAdminCarsSideInputs = new TableLayoutPanel();
            lblMerk = new Label();
            lblModel = new Label();
            lblKenteken = new Label();
            lblType = new Label();
            lblDagprijs = new Label();
            lblStatus = new Label();
            txtMerk = new TextBox();
            txtModel = new TextBox();
            txtKenteken = new TextBox();
            txtType = new TextBox();
            numDagprijs = new NumericUpDown();
            txtStatus = new TextBox();
            lblUitlegFoto = new Label();
            pnlTabCenterSaveButtonToCenterOfView = new TableLayoutPanel();
            btnSaveCar = new Button();
            cmbStatus = new ComboBox();
            tabAdminCars.SuspendLayout();
            tabAdminAllCars.SuspendLayout();
            pnlAdminAllCars.SuspendLayout();
            tabAdminAddCar.SuspendLayout();
            pnlTabCarsLayoutAdmin.SuspendLayout();
            pnlTabAdminCarsSideInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDagprijs).BeginInit();
            pnlTabCenterSaveButtonToCenterOfView.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdminCars
            // 
            tabAdminCars.Controls.Add(tabAdminAllCars);
            tabAdminCars.Controls.Add(tabAdminAddCar);
            tabAdminCars.Dock = DockStyle.Fill;
            tabAdminCars.Location = new Point(0, 0);
            tabAdminCars.Name = "tabAdminCars";
            tabAdminCars.SelectedIndex = 0;
            tabAdminCars.Size = new Size(1195, 529);
            tabAdminCars.TabIndex = 0;
            // 
            // tabAdminAllCars
            // 
            tabAdminAllCars.Controls.Add(pnlAdminAllCars);
            tabAdminAllCars.Location = new Point(4, 29);
            tabAdminAllCars.Name = "tabAdminAllCars";
            tabAdminAllCars.Padding = new Padding(3);
            tabAdminAllCars.Size = new Size(1187, 496);
            tabAdminAllCars.TabIndex = 0;
            tabAdminAllCars.Text = "Alle auto's";
            tabAdminAllCars.UseVisualStyleBackColor = true;
            // 
            // pnlAdminAllCars
            // 
            pnlAdminAllCars.BackColor = SystemColors.ControlLight;
            pnlAdminAllCars.Controls.Add(pnlTabAdminAllCars);
            pnlAdminAllCars.Dock = DockStyle.Fill;
            pnlAdminAllCars.Location = new Point(3, 3);
            pnlAdminAllCars.Name = "pnlAdminAllCars";
            pnlAdminAllCars.Size = new Size(1181, 490);
            pnlAdminAllCars.TabIndex = 0;
            // 
            // pnlTabAdminAllCars
            // 
            pnlTabAdminAllCars.AutoScroll = true;
            pnlTabAdminAllCars.ColumnCount = 3;
            pnlTabAdminAllCars.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnlTabAdminAllCars.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnlTabAdminAllCars.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pnlTabAdminAllCars.Dock = DockStyle.Fill;
            pnlTabAdminAllCars.Location = new Point(0, 0);
            pnlTabAdminAllCars.Name = "pnlTabAdminAllCars";
            pnlTabAdminAllCars.RowCount = 2;
            pnlTabAdminAllCars.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminAllCars.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminAllCars.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabAdminAllCars.Size = new Size(1181, 490);
            pnlTabAdminAllCars.TabIndex = 0;
            // 
            // tabAdminAddCar
            // 
            tabAdminAddCar.Controls.Add(pnlTabCarsLayoutAdmin);
            tabAdminAddCar.Location = new Point(4, 29);
            tabAdminAddCar.Name = "tabAdminAddCar";
            tabAdminAddCar.Padding = new Padding(3);
            tabAdminAddCar.Size = new Size(1187, 496);
            tabAdminAddCar.TabIndex = 1;
            tabAdminAddCar.Text = "Nieuwe auto toevoegen";
            tabAdminAddCar.UseVisualStyleBackColor = true;
            // 
            // pnlTabCarsLayoutAdmin
            // 
            pnlTabCarsLayoutAdmin.ColumnCount = 2;
            pnlTabCarsLayoutAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTabCarsLayoutAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabCarsLayoutAdmin.Controls.Add(pnlTabAdminCarsSideInputs, 0, 0);
            pnlTabCarsLayoutAdmin.Controls.Add(lblUitlegFoto, 1, 0);
            pnlTabCarsLayoutAdmin.Controls.Add(pnlTabCenterSaveButtonToCenterOfView, 0, 1);
            pnlTabCarsLayoutAdmin.Dock = DockStyle.Fill;
            pnlTabCarsLayoutAdmin.Location = new Point(3, 3);
            pnlTabCarsLayoutAdmin.Name = "pnlTabCarsLayoutAdmin";
            pnlTabCarsLayoutAdmin.RowCount = 2;
            pnlTabCarsLayoutAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            pnlTabCarsLayoutAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabCarsLayoutAdmin.Size = new Size(1181, 490);
            pnlTabCarsLayoutAdmin.TabIndex = 0;
            // 
            // pnlTabAdminCarsSideInputs
            // 
            pnlTabAdminCarsSideInputs.ColumnCount = 2;
            pnlTabAdminCarsSideInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAdminCarsSideInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAdminCarsSideInputs.Controls.Add(lblMerk, 0, 0);
            pnlTabAdminCarsSideInputs.Controls.Add(lblModel, 1, 0);
            pnlTabAdminCarsSideInputs.Controls.Add(lblKenteken, 0, 2);
            pnlTabAdminCarsSideInputs.Controls.Add(lblType, 1, 2);
            pnlTabAdminCarsSideInputs.Controls.Add(lblDagprijs, 0, 4);
            pnlTabAdminCarsSideInputs.Controls.Add(lblStatus, 1, 4);
            pnlTabAdminCarsSideInputs.Controls.Add(txtMerk, 0, 1);
            pnlTabAdminCarsSideInputs.Controls.Add(txtModel, 1, 1);
            pnlTabAdminCarsSideInputs.Controls.Add(txtKenteken, 0, 3);
            pnlTabAdminCarsSideInputs.Controls.Add(txtType, 1, 3);
            pnlTabAdminCarsSideInputs.Controls.Add(numDagprijs, 0, 5);
            pnlTabAdminCarsSideInputs.Controls.Add(cmbStatus, 1, 5);
            pnlTabAdminCarsSideInputs.Dock = DockStyle.Fill;
            pnlTabAdminCarsSideInputs.Location = new Point(3, 3);
            pnlTabAdminCarsSideInputs.Name = "pnlTabAdminCarsSideInputs";
            pnlTabAdminCarsSideInputs.RowCount = 6;
            pnlTabAdminCarsSideInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 10.10101F));
            pnlTabAdminCarsSideInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 23.23232F));
            pnlTabAdminCarsSideInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 10.10101F));
            pnlTabAdminCarsSideInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 23.2323227F));
            pnlTabAdminCarsSideInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 10.10101F));
            pnlTabAdminCarsSideInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 23.23232F));
            pnlTabAdminCarsSideInputs.Size = new Size(702, 410);
            pnlTabAdminCarsSideInputs.TabIndex = 0;
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.BackColor = SystemColors.ActiveCaption;
            lblMerk.Dock = DockStyle.Fill;
            lblMerk.Location = new Point(3, 0);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(345, 41);
            lblMerk.TabIndex = 0;
            lblMerk.Text = "Merk";
            lblMerk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.BackColor = SystemColors.ActiveCaption;
            lblModel.Dock = DockStyle.Fill;
            lblModel.Location = new Point(354, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(345, 41);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model";
            lblModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKenteken
            // 
            lblKenteken.AutoSize = true;
            lblKenteken.BackColor = SystemColors.ActiveCaption;
            lblKenteken.Dock = DockStyle.Fill;
            lblKenteken.Location = new Point(3, 136);
            lblKenteken.Name = "lblKenteken";
            lblKenteken.Size = new Size(345, 41);
            lblKenteken.TabIndex = 2;
            lblKenteken.Text = "Kenteken";
            lblKenteken.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = SystemColors.ActiveCaption;
            lblType.Dock = DockStyle.Fill;
            lblType.Location = new Point(354, 136);
            lblType.Name = "lblType";
            lblType.Size = new Size(345, 41);
            lblType.TabIndex = 3;
            lblType.Text = "Type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDagprijs
            // 
            lblDagprijs.AutoSize = true;
            lblDagprijs.BackColor = SystemColors.ActiveCaption;
            lblDagprijs.Dock = DockStyle.Fill;
            lblDagprijs.Location = new Point(3, 272);
            lblDagprijs.Name = "lblDagprijs";
            lblDagprijs.Size = new Size(345, 41);
            lblDagprijs.TabIndex = 4;
            lblDagprijs.Text = "Dagprijs";
            lblDagprijs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(354, 272);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(345, 41);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMerk
            // 
            txtMerk.BackColor = SystemColors.ScrollBar;
            txtMerk.Dock = DockStyle.Fill;
            txtMerk.Location = new Point(3, 44);
            txtMerk.Multiline = true;
            txtMerk.Name = "txtMerk";
            txtMerk.PlaceholderText = "Vul het merk in (audi, bmw, etc)";
            txtMerk.Size = new Size(345, 89);
            txtMerk.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.BackColor = SystemColors.ScrollBar;
            txtModel.Dock = DockStyle.Fill;
            txtModel.Location = new Point(354, 44);
            txtModel.Multiline = true;
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = "Vul het model in";
            txtModel.Size = new Size(345, 89);
            txtModel.TabIndex = 7;
            // 
            // txtKenteken
            // 
            txtKenteken.BackColor = SystemColors.ScrollBar;
            txtKenteken.Dock = DockStyle.Fill;
            txtKenteken.Location = new Point(3, 180);
            txtKenteken.Multiline = true;
            txtKenteken.Name = "txtKenteken";
            txtKenteken.PlaceholderText = "Vul het kenteken in";
            txtKenteken.Size = new Size(345, 89);
            txtKenteken.TabIndex = 8;
            // 
            // txtType
            // 
            txtType.BackColor = SystemColors.ScrollBar;
            txtType.Dock = DockStyle.Fill;
            txtType.Location = new Point(354, 180);
            txtType.Multiline = true;
            txtType.Name = "txtType";
            txtType.PlaceholderText = "Vul hier het type in (suv, etc)";
            txtType.Size = new Size(345, 89);
            txtType.TabIndex = 9;
            // 
            // numDagprijs
            // 
            numDagprijs.BackColor = SystemColors.ScrollBar;
            numDagprijs.Dock = DockStyle.Fill;
            numDagprijs.Location = new Point(3, 316);
            numDagprijs.Name = "numDagprijs";
            numDagprijs.Size = new Size(345, 27);
            numDagprijs.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = SystemColors.ScrollBar;
            txtStatus.Dock = DockStyle.Fill;
            txtStatus.Location = new Point(354, 316);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = "Status (beschikbaar, verhuurd, etc)";
            txtStatus.Size = new Size(345, 91);
            txtStatus.TabIndex = 11;
            // 
            // lblUitlegFoto
            // 
            lblUitlegFoto.AutoSize = true;
            lblUitlegFoto.Dock = DockStyle.Fill;
            lblUitlegFoto.Location = new Point(711, 0);
            lblUitlegFoto.Name = "lblUitlegFoto";
            lblUitlegFoto.Size = new Size(467, 416);
            lblUitlegFoto.TabIndex = 1;
            lblUitlegFoto.Text = "Hier afbeelding input, dat komt wanneer afbeeldingen worden toegevoegd\r\n";
            // 
            // pnlTabCenterSaveButtonToCenterOfView
            // 
            pnlTabCenterSaveButtonToCenterOfView.ColumnCount = 2;
            pnlTabCenterSaveButtonToCenterOfView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabCenterSaveButtonToCenterOfView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabCenterSaveButtonToCenterOfView.Controls.Add(btnSaveCar, 1, 0);
            pnlTabCenterSaveButtonToCenterOfView.Dock = DockStyle.Fill;
            pnlTabCenterSaveButtonToCenterOfView.Location = new Point(3, 419);
            pnlTabCenterSaveButtonToCenterOfView.Name = "pnlTabCenterSaveButtonToCenterOfView";
            pnlTabCenterSaveButtonToCenterOfView.RowCount = 1;
            pnlTabCenterSaveButtonToCenterOfView.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabCenterSaveButtonToCenterOfView.Size = new Size(702, 68);
            pnlTabCenterSaveButtonToCenterOfView.TabIndex = 2;
            // 
            // btnSaveCar
            // 
            btnSaveCar.BackColor = Color.LimeGreen;
            btnSaveCar.Dock = DockStyle.Fill;
            btnSaveCar.Location = new Point(354, 3);
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.Size = new Size(345, 62);
            btnSaveCar.TabIndex = 0;
            btnSaveCar.Text = "Sla auto op";
            btnSaveCar.UseVisualStyleBackColor = false;
            btnSaveCar.Click += btnSaveCar_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = SystemColors.ScrollBar;
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[]
            {
                "beschikbaar",
                "verhuurd",
                "onderhoud",
                "buiten gebruik"
            });
            cmbStatus.Location = new Point(354, 316);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(345, 28);
            cmbStatus.TabIndex = 11;
            cmbStatus.SelectedIndex = 0;
            // 
            // userCtrlAdminCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tabAdminCars);
            Name = "userCtrlAdminCars";
            Size = new Size(1195, 529);
            tabAdminCars.ResumeLayout(false);
            tabAdminAllCars.ResumeLayout(false);
            pnlAdminAllCars.ResumeLayout(false);
            tabAdminAddCar.ResumeLayout(false);
            pnlTabCarsLayoutAdmin.ResumeLayout(false);
            pnlTabCarsLayoutAdmin.PerformLayout();
            pnlTabAdminCarsSideInputs.ResumeLayout(false);
            pnlTabAdminCarsSideInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDagprijs).EndInit();
            pnlTabCenterSaveButtonToCenterOfView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdminCars;
        private TabPage tabAdminAllCars;
        private TabPage tabAdminAddCar;
        private Panel pnlAdminAllCars;
        private TableLayoutPanel pnlTabAdminAllCars;
        private TableLayoutPanel pnlTabCarsLayoutAdmin;
        private TableLayoutPanel pnlTabAdminCarsSideInputs;
        private Label lblMerk;
        private Label lblModel;
        private Label lblKenteken;
        private Label lblType;
        private Label lblDagprijs;
        private Label lblStatus;
        private TextBox txtMerk;
        private TextBox txtModel;
        private TextBox txtKenteken;
        private TextBox txtType;
        private NumericUpDown numDagprijs;
        private TextBox txtStatus;
        private Label lblUitlegFoto;
        private TableLayoutPanel pnlTabCenterSaveButtonToCenterOfView;
        private Button btnSaveCar;
        private ComboBox cmbStatus;
    }
}
