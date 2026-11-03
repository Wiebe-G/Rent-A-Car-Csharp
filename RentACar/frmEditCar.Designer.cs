namespace RentACar
{
    partial class frmEditCar
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
            pnlTabAdminEditCar = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblMerkEdit = new Label();
            lblModelEdit = new Label();
            lblKentekenEdit = new Label();
            lblTypeEdit = new Label();
            lblDagprijsEdit = new Label();
            lblStatusEdit = new Label();
            txtMerkEdit = new TextBox();
            txtModelEdit = new TextBox();
            txtKentekenEdit = new TextBox();
            txtTypeEdit = new TextBox();
            numDagprijsEdit = new NumericUpDown();
            txtStatusEdit = new TextBox();
            label7 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSaveChanges = new Button();
            btnCancelEdit = new Button();
            pnlTabAdminEditCar.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDagprijsEdit).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabAdminEditCar
            // 
            pnlTabAdminEditCar.ColumnCount = 2;
            pnlTabAdminEditCar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTabAdminEditCar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabAdminEditCar.Controls.Add(tableLayoutPanel2, 0, 0);
            pnlTabAdminEditCar.Controls.Add(label7, 1, 0);
            pnlTabAdminEditCar.Controls.Add(tableLayoutPanel3, 0, 1);
            pnlTabAdminEditCar.Dock = DockStyle.Fill;
            pnlTabAdminEditCar.Location = new Point(0, 0);
            pnlTabAdminEditCar.Name = "pnlTabAdminEditCar";
            pnlTabAdminEditCar.RowCount = 2;
            pnlTabAdminEditCar.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            pnlTabAdminEditCar.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabAdminEditCar.Size = new Size(1153, 526);
            pnlTabAdminEditCar.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblMerkEdit, 0, 0);
            tableLayoutPanel2.Controls.Add(lblModelEdit, 1, 0);
            tableLayoutPanel2.Controls.Add(lblKentekenEdit, 0, 2);
            tableLayoutPanel2.Controls.Add(lblTypeEdit, 1, 2);
            tableLayoutPanel2.Controls.Add(lblDagprijsEdit, 0, 4);
            tableLayoutPanel2.Controls.Add(lblStatusEdit, 1, 4);
            tableLayoutPanel2.Controls.Add(txtMerkEdit, 0, 1);
            tableLayoutPanel2.Controls.Add(txtModelEdit, 1, 1);
            tableLayoutPanel2.Controls.Add(txtKentekenEdit, 0, 3);
            tableLayoutPanel2.Controls.Add(txtTypeEdit, 1, 3);
            tableLayoutPanel2.Controls.Add(numDagprijsEdit, 0, 5);
            tableLayoutPanel2.Controls.Add(txtStatusEdit, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.23232F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.2323227F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.23232F));
            tableLayoutPanel2.Size = new Size(685, 441);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblMerkEdit
            // 
            lblMerkEdit.AutoSize = true;
            lblMerkEdit.BackColor = SystemColors.ActiveCaption;
            lblMerkEdit.Dock = DockStyle.Fill;
            lblMerkEdit.Location = new Point(3, 0);
            lblMerkEdit.Name = "lblMerkEdit";
            lblMerkEdit.Size = new Size(336, 44);
            lblMerkEdit.TabIndex = 0;
            lblMerkEdit.Text = "Merk";
            lblMerkEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblModelEdit
            // 
            lblModelEdit.AutoSize = true;
            lblModelEdit.BackColor = SystemColors.ActiveCaption;
            lblModelEdit.Dock = DockStyle.Fill;
            lblModelEdit.Location = new Point(345, 0);
            lblModelEdit.Name = "lblModelEdit";
            lblModelEdit.Size = new Size(337, 44);
            lblModelEdit.TabIndex = 1;
            lblModelEdit.Text = "Model";
            lblModelEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKentekenEdit
            // 
            lblKentekenEdit.AutoSize = true;
            lblKentekenEdit.BackColor = SystemColors.ActiveCaption;
            lblKentekenEdit.Dock = DockStyle.Fill;
            lblKentekenEdit.Location = new Point(3, 146);
            lblKentekenEdit.Name = "lblKentekenEdit";
            lblKentekenEdit.Size = new Size(336, 44);
            lblKentekenEdit.TabIndex = 2;
            lblKentekenEdit.Text = "Kenteken";
            lblKentekenEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTypeEdit
            // 
            lblTypeEdit.AutoSize = true;
            lblTypeEdit.BackColor = SystemColors.ActiveCaption;
            lblTypeEdit.Dock = DockStyle.Fill;
            lblTypeEdit.Location = new Point(345, 146);
            lblTypeEdit.Name = "lblTypeEdit";
            lblTypeEdit.Size = new Size(337, 44);
            lblTypeEdit.TabIndex = 3;
            lblTypeEdit.Text = "Type";
            lblTypeEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDagprijsEdit
            // 
            lblDagprijsEdit.AutoSize = true;
            lblDagprijsEdit.BackColor = SystemColors.ActiveCaption;
            lblDagprijsEdit.Dock = DockStyle.Fill;
            lblDagprijsEdit.Location = new Point(3, 292);
            lblDagprijsEdit.Name = "lblDagprijsEdit";
            lblDagprijsEdit.Size = new Size(336, 44);
            lblDagprijsEdit.TabIndex = 4;
            lblDagprijsEdit.Text = "Dagprijs";
            lblDagprijsEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusEdit
            // 
            lblStatusEdit.AutoSize = true;
            lblStatusEdit.BackColor = SystemColors.ActiveCaption;
            lblStatusEdit.Dock = DockStyle.Fill;
            lblStatusEdit.Location = new Point(345, 292);
            lblStatusEdit.Name = "lblStatusEdit";
            lblStatusEdit.Size = new Size(337, 44);
            lblStatusEdit.TabIndex = 5;
            lblStatusEdit.Text = "Status";
            lblStatusEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMerkEdit
            // 
            txtMerkEdit.BackColor = SystemColors.ScrollBar;
            txtMerkEdit.Dock = DockStyle.Fill;
            txtMerkEdit.Location = new Point(3, 47);
            txtMerkEdit.Multiline = true;
            txtMerkEdit.Name = "txtMerkEdit";
            txtMerkEdit.PlaceholderText = "Vul het merk in (audi, bmw, etc)";
            txtMerkEdit.Size = new Size(336, 96);
            txtMerkEdit.TabIndex = 6;
            // 
            // txtModelEdit
            // 
            txtModelEdit.BackColor = SystemColors.ScrollBar;
            txtModelEdit.Dock = DockStyle.Fill;
            txtModelEdit.Location = new Point(345, 47);
            txtModelEdit.Multiline = true;
            txtModelEdit.Name = "txtModelEdit";
            txtModelEdit.PlaceholderText = "Vul het model in";
            txtModelEdit.Size = new Size(337, 96);
            txtModelEdit.TabIndex = 7;
            // 
            // txtKentekenEdit
            // 
            txtKentekenEdit.BackColor = SystemColors.ScrollBar;
            txtKentekenEdit.Dock = DockStyle.Fill;
            txtKentekenEdit.Location = new Point(3, 193);
            txtKentekenEdit.Multiline = true;
            txtKentekenEdit.Name = "txtKentekenEdit";
            txtKentekenEdit.PlaceholderText = "Vul het kenteken in";
            txtKentekenEdit.Size = new Size(336, 96);
            txtKentekenEdit.TabIndex = 8;
            // 
            // txtTypeEdit
            // 
            txtTypeEdit.BackColor = SystemColors.ScrollBar;
            txtTypeEdit.Dock = DockStyle.Fill;
            txtTypeEdit.Location = new Point(345, 193);
            txtTypeEdit.Multiline = true;
            txtTypeEdit.Name = "txtTypeEdit";
            txtTypeEdit.PlaceholderText = "Vul hier het type in (suv, etc)";
            txtTypeEdit.Size = new Size(337, 96);
            txtTypeEdit.TabIndex = 9;
            // 
            // numDagprijsEdit
            // 
            numDagprijsEdit.BackColor = SystemColors.ScrollBar;
            numDagprijsEdit.Dock = DockStyle.Fill;
            numDagprijsEdit.Location = new Point(3, 339);
            numDagprijsEdit.Name = "numDagprijsEdit";
            numDagprijsEdit.Size = new Size(336, 27);
            numDagprijsEdit.TabIndex = 10;
            // 
            // txtStatusEdit
            // 
            txtStatusEdit.BackColor = SystemColors.ScrollBar;
            txtStatusEdit.Dock = DockStyle.Fill;
            txtStatusEdit.Location = new Point(345, 339);
            txtStatusEdit.Multiline = true;
            txtStatusEdit.Name = "txtStatusEdit";
            txtStatusEdit.PlaceholderText = "Status (beschikbaar, verhuurd, etc)";
            txtStatusEdit.Size = new Size(337, 99);
            txtStatusEdit.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(694, 0);
            label7.Name = "label7";
            label7.Size = new Size(456, 447);
            label7.TabIndex = 1;
            label7.Text = "Hier afbeelding input, dat komt wanneer afbeeldingen worden toegevoegd\r\n";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnSaveChanges, 1, 0);
            tableLayoutPanel3.Controls.Add(btnCancelEdit, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 450);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(685, 73);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.LimeGreen;
            btnSaveChanges.Dock = DockStyle.Fill;
            btnSaveChanges.Location = new Point(345, 3);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(337, 67);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Sla wijzigingen op";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.Silver;
            btnCancelEdit.Dock = DockStyle.Fill;
            btnCancelEdit.Location = new Point(3, 3);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(336, 67);
            btnCancelEdit.TabIndex = 1;
            btnCancelEdit.Text = "Annuleer";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // frmEditCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 526);
            Controls.Add(pnlTabAdminEditCar);
            Name = "frmEditCar";
            Text = "Bewerk auto";
            pnlTabAdminEditCar.ResumeLayout(false);
            pnlTabAdminEditCar.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDagprijsEdit).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabAdminEditCar;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblMerkEdit;
        private Label lblModelEdit;
        private Label lblKentekenEdit;
        private Label lblTypeEdit;
        private Label lblDagprijsEdit;
        private Label lblStatusEdit;
        private TextBox txtMerkEdit;
        private TextBox txtModelEdit;
        private TextBox txtKentekenEdit;
        private TextBox txtTypeEdit;
        private NumericUpDown numDagprijsEdit;
        private TextBox txtStatusEdit;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSaveChanges;
        private Button btnCancelEdit;
    }
}