namespace RentACar
{
    partial class userCtrlAdminPlanning
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
            tabAdminPlanning = new TabControl();
            tabPageAllPlanning = new TabPage();
            pnlTabAdminPlanningLayout = new TableLayoutPanel();
            pnlTabSelectWeekLayout = new TableLayoutPanel();
            pnlTabSelectWeek = new TableLayoutPanel();
            pnlTabAdminPlanningLayout2 = new TableLayoutPanel();
            pnlTabAdminPlanning = new TableLayoutPanel();
            lblMon = new Label();
            lblTue = new Label();
            lblWed = new Label();
            lblThu = new Label();
            lblFri = new Label();
            lblSat = new Label();
            lblSun = new Label();
            pnlTabSelectEmployee = new TableLayoutPanel();
            lblSelectEmp = new Label();
            cmbSelectEmployee = new ComboBox();
            pnlTabPlanningTemp = new TableLayoutPanel();
            tabPageNewPlanning = new TabPage();
            pnlTabAdminLayoutMakePlanning = new TableLayoutPanel();
            pnlTabSavePlanningButton = new TableLayoutPanel();
            btnSavePlanning = new Button();
            pnlTabAdminMakePlanning = new TableLayoutPanel();
            cmbWhoToPlanIn = new ComboBox();
            dateTimeMakePlanning = new DateTimePicker();
            dateTimeStart = new DateTimePicker();
            dateTimeEnd = new DateTimePicker();
            tabAdminPlanning.SuspendLayout();
            tabPageAllPlanning.SuspendLayout();
            pnlTabAdminPlanningLayout.SuspendLayout();
            pnlTabSelectWeekLayout.SuspendLayout();
            pnlTabAdminPlanningLayout2.SuspendLayout();
            pnlTabAdminPlanning.SuspendLayout();
            pnlTabSelectEmployee.SuspendLayout();
            tabPageNewPlanning.SuspendLayout();
            pnlTabAdminLayoutMakePlanning.SuspendLayout();
            pnlTabSavePlanningButton.SuspendLayout();
            pnlTabAdminMakePlanning.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdminPlanning
            // 
            tabAdminPlanning.Controls.Add(tabPageAllPlanning);
            tabAdminPlanning.Controls.Add(tabPageNewPlanning);
            tabAdminPlanning.Dock = DockStyle.Fill;
            tabAdminPlanning.Location = new Point(0, 0);
            tabAdminPlanning.Name = "tabAdminPlanning";
            tabAdminPlanning.SelectedIndex = 0;
            tabAdminPlanning.Size = new Size(1214, 512);
            tabAdminPlanning.TabIndex = 0;
            // 
            // tabPageAllPlanning
            // 
            tabPageAllPlanning.BackColor = SystemColors.ControlLight;
            tabPageAllPlanning.Controls.Add(pnlTabAdminPlanningLayout);
            tabPageAllPlanning.Location = new Point(4, 29);
            tabPageAllPlanning.Name = "tabPageAllPlanning";
            tabPageAllPlanning.Padding = new Padding(3);
            tabPageAllPlanning.Size = new Size(1206, 479);
            tabPageAllPlanning.TabIndex = 0;
            tabPageAllPlanning.Text = "Alle planningen";
            // 
            // pnlTabAdminPlanningLayout
            // 
            pnlTabAdminPlanningLayout.ColumnCount = 1;
            pnlTabAdminPlanningLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabAdminPlanningLayout.Controls.Add(pnlTabSelectWeekLayout, 0, 0);
            pnlTabAdminPlanningLayout.Controls.Add(pnlTabAdminPlanningLayout2, 0, 1);
            pnlTabAdminPlanningLayout.Dock = DockStyle.Fill;
            pnlTabAdminPlanningLayout.Location = new Point(3, 3);
            pnlTabAdminPlanningLayout.Name = "pnlTabAdminPlanningLayout";
            pnlTabAdminPlanningLayout.RowCount = 2;
            pnlTabAdminPlanningLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabAdminPlanningLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            pnlTabAdminPlanningLayout.Size = new Size(1200, 473);
            pnlTabAdminPlanningLayout.TabIndex = 1;
            // 
            // pnlTabSelectWeekLayout
            // 
            pnlTabSelectWeekLayout.ColumnCount = 3;
            pnlTabSelectWeekLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabSelectWeekLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTabSelectWeekLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabSelectWeekLayout.Controls.Add(pnlTabSelectWeek, 1, 0);
            pnlTabSelectWeekLayout.Dock = DockStyle.Fill;
            pnlTabSelectWeekLayout.Location = new Point(3, 3);
            pnlTabSelectWeekLayout.Name = "pnlTabSelectWeekLayout";
            pnlTabSelectWeekLayout.RowCount = 1;
            pnlTabSelectWeekLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabSelectWeekLayout.Size = new Size(1194, 41);
            pnlTabSelectWeekLayout.TabIndex = 2;
            // 
            // pnlTabSelectWeek
            // 
            pnlTabSelectWeek.ColumnCount = 3;
            pnlTabSelectWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabSelectWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabSelectWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabSelectWeek.Dock = DockStyle.Fill;
            pnlTabSelectWeek.Location = new Point(241, 3);
            pnlTabSelectWeek.Name = "pnlTabSelectWeek";
            pnlTabSelectWeek.RowCount = 1;
            pnlTabSelectWeek.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabSelectWeek.Size = new Size(710, 35);
            pnlTabSelectWeek.TabIndex = 0;
            // 
            // pnlTabAdminPlanningLayout2
            // 
            pnlTabAdminPlanningLayout2.ColumnCount = 2;
            pnlTabAdminPlanningLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            pnlTabAdminPlanningLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84F));
            pnlTabAdminPlanningLayout2.Controls.Add(pnlTabAdminPlanning, 1, 0);
            pnlTabAdminPlanningLayout2.Controls.Add(pnlTabSelectEmployee, 0, 0);
            pnlTabAdminPlanningLayout2.Dock = DockStyle.Fill;
            pnlTabAdminPlanningLayout2.Location = new Point(3, 50);
            pnlTabAdminPlanningLayout2.Name = "pnlTabAdminPlanningLayout2";
            pnlTabAdminPlanningLayout2.RowCount = 1;
            pnlTabAdminPlanningLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabAdminPlanningLayout2.Size = new Size(1194, 420);
            pnlTabAdminPlanningLayout2.TabIndex = 3;
            // 
            // pnlTabAdminPlanning
            // 
            pnlTabAdminPlanning.ColumnCount = 7;
            pnlTabAdminPlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            pnlTabAdminPlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            pnlTabAdminPlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            pnlTabAdminPlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            pnlTabAdminPlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            pnlTabAdminPlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            pnlTabAdminPlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            pnlTabAdminPlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlTabAdminPlanning.Controls.Add(lblMon, 0, 0);
            pnlTabAdminPlanning.Controls.Add(lblTue, 1, 0);
            pnlTabAdminPlanning.Controls.Add(lblWed, 2, 0);
            pnlTabAdminPlanning.Controls.Add(lblThu, 3, 0);
            pnlTabAdminPlanning.Controls.Add(lblFri, 4, 0);
            pnlTabAdminPlanning.Controls.Add(lblSat, 5, 0);
            pnlTabAdminPlanning.Controls.Add(lblSun, 6, 0);
            pnlTabAdminPlanning.Dock = DockStyle.Fill;
            pnlTabAdminPlanning.Location = new Point(194, 3);
            pnlTabAdminPlanning.Name = "pnlTabAdminPlanning";
            pnlTabAdminPlanning.RowCount = 3;
            pnlTabAdminPlanning.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabAdminPlanning.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlTabAdminPlanning.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabAdminPlanning.Size = new Size(997, 414);
            pnlTabAdminPlanning.TabIndex = 2;
            // 
            // lblMon
            // 
            lblMon.AutoSize = true;
            lblMon.Dock = DockStyle.Fill;
            lblMon.Location = new Point(3, 0);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(136, 41);
            lblMon.TabIndex = 1;
            lblMon.Text = "Maandag";
            lblMon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTue
            // 
            lblTue.AutoSize = true;
            lblTue.Dock = DockStyle.Fill;
            lblTue.Location = new Point(145, 0);
            lblTue.Name = "lblTue";
            lblTue.Size = new Size(136, 41);
            lblTue.TabIndex = 2;
            lblTue.Text = "Dinsdag";
            lblTue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWed
            // 
            lblWed.AutoSize = true;
            lblWed.Dock = DockStyle.Fill;
            lblWed.Location = new Point(287, 0);
            lblWed.Name = "lblWed";
            lblWed.Size = new Size(136, 41);
            lblWed.TabIndex = 3;
            lblWed.Text = "Woensdag";
            lblWed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThu
            // 
            lblThu.AutoSize = true;
            lblThu.Dock = DockStyle.Fill;
            lblThu.Location = new Point(429, 0);
            lblThu.Name = "lblThu";
            lblThu.Size = new Size(136, 41);
            lblThu.TabIndex = 4;
            lblThu.Text = "Donderdag";
            lblThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFri
            // 
            lblFri.AutoSize = true;
            lblFri.Dock = DockStyle.Fill;
            lblFri.Location = new Point(571, 0);
            lblFri.Name = "lblFri";
            lblFri.Size = new Size(136, 41);
            lblFri.TabIndex = 5;
            lblFri.Text = "Vrijdag";
            lblFri.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSat
            // 
            lblSat.AutoSize = true;
            lblSat.Dock = DockStyle.Fill;
            lblSat.Location = new Point(713, 0);
            lblSat.Name = "lblSat";
            lblSat.Size = new Size(136, 41);
            lblSat.TabIndex = 6;
            lblSat.Text = "Zaterdag";
            lblSat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSun
            // 
            lblSun.AutoSize = true;
            lblSun.Dock = DockStyle.Fill;
            lblSun.Location = new Point(855, 0);
            lblSun.Name = "lblSun";
            lblSun.Size = new Size(139, 41);
            lblSun.TabIndex = 7;
            lblSun.Text = "Zondag";
            lblSun.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTabSelectEmployee
            // 
            pnlTabSelectEmployee.ColumnCount = 1;
            pnlTabSelectEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabSelectEmployee.Controls.Add(lblSelectEmp, 0, 0);
            pnlTabSelectEmployee.Controls.Add(cmbSelectEmployee, 0, 1);
            pnlTabSelectEmployee.Controls.Add(pnlTabPlanningTemp, 0, 2);
            pnlTabSelectEmployee.Dock = DockStyle.Fill;
            pnlTabSelectEmployee.Location = new Point(3, 3);
            pnlTabSelectEmployee.Name = "pnlTabSelectEmployee";
            pnlTabSelectEmployee.RowCount = 3;
            pnlTabSelectEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabSelectEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabSelectEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlTabSelectEmployee.Size = new Size(185, 414);
            pnlTabSelectEmployee.TabIndex = 3;
            // 
            // lblSelectEmp
            // 
            lblSelectEmp.AutoSize = true;
            lblSelectEmp.Dock = DockStyle.Fill;
            lblSelectEmp.Location = new Point(3, 0);
            lblSelectEmp.Name = "lblSelectEmp";
            lblSelectEmp.Size = new Size(179, 62);
            lblSelectEmp.TabIndex = 0;
            lblSelectEmp.Text = "Selecteer medewerker";
            lblSelectEmp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSelectEmployee
            // 
            cmbSelectEmployee.Dock = DockStyle.Fill;
            cmbSelectEmployee.FormattingEnabled = true;
            cmbSelectEmployee.Location = new Point(3, 65);
            cmbSelectEmployee.Name = "cmbSelectEmployee";
            cmbSelectEmployee.Size = new Size(179, 28);
            cmbSelectEmployee.TabIndex = 1;
            cmbSelectEmployee.SelectedIndexChanged += cmbSelectEmployee_SelectedIndexChanged;
            // 
            // pnlTabPlanningTemp
            // 
            pnlTabPlanningTemp.ColumnCount = 1;
            pnlTabPlanningTemp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabPlanningTemp.Dock = DockStyle.Fill;
            pnlTabPlanningTemp.Location = new Point(3, 127);
            pnlTabPlanningTemp.Name = "pnlTabPlanningTemp";
            pnlTabPlanningTemp.RowCount = 1;
            pnlTabPlanningTemp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabPlanningTemp.Size = new Size(179, 284);
            pnlTabPlanningTemp.TabIndex = 2;
            // 
            // tabPageNewPlanning
            // 
            tabPageNewPlanning.Controls.Add(pnlTabAdminLayoutMakePlanning);
            tabPageNewPlanning.Location = new Point(4, 29);
            tabPageNewPlanning.Name = "tabPageNewPlanning";
            tabPageNewPlanning.Padding = new Padding(3);
            tabPageNewPlanning.Size = new Size(1206, 479);
            tabPageNewPlanning.TabIndex = 1;
            tabPageNewPlanning.Text = "Maak planning aan";
            tabPageNewPlanning.UseVisualStyleBackColor = true;
            // 
            // pnlTabAdminLayoutMakePlanning
            // 
            pnlTabAdminLayoutMakePlanning.BackColor = SystemColors.ControlLight;
            pnlTabAdminLayoutMakePlanning.ColumnCount = 1;
            pnlTabAdminLayoutMakePlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabAdminLayoutMakePlanning.Controls.Add(pnlTabSavePlanningButton, 0, 1);
            pnlTabAdminLayoutMakePlanning.Controls.Add(pnlTabAdminMakePlanning, 0, 0);
            pnlTabAdminLayoutMakePlanning.Dock = DockStyle.Fill;
            pnlTabAdminLayoutMakePlanning.Location = new Point(3, 3);
            pnlTabAdminLayoutMakePlanning.Name = "pnlTabAdminLayoutMakePlanning";
            pnlTabAdminLayoutMakePlanning.RowCount = 2;
            pnlTabAdminLayoutMakePlanning.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabAdminLayoutMakePlanning.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabAdminLayoutMakePlanning.Size = new Size(1200, 473);
            pnlTabAdminLayoutMakePlanning.TabIndex = 0;
            // 
            // pnlTabSavePlanningButton
            // 
            pnlTabSavePlanningButton.ColumnCount = 3;
            pnlTabSavePlanningButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabSavePlanningButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTabSavePlanningButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabSavePlanningButton.Controls.Add(btnSavePlanning, 1, 0);
            pnlTabSavePlanningButton.Dock = DockStyle.Fill;
            pnlTabSavePlanningButton.Location = new Point(3, 381);
            pnlTabSavePlanningButton.Name = "pnlTabSavePlanningButton";
            pnlTabSavePlanningButton.RowCount = 1;
            pnlTabSavePlanningButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabSavePlanningButton.Size = new Size(1194, 89);
            pnlTabSavePlanningButton.TabIndex = 0;
            // 
            // btnSavePlanning
            // 
            btnSavePlanning.BackColor = Color.LimeGreen;
            btnSavePlanning.Dock = DockStyle.Fill;
            btnSavePlanning.Location = new Point(241, 3);
            btnSavePlanning.Name = "btnSavePlanning";
            btnSavePlanning.Size = new Size(710, 83);
            btnSavePlanning.TabIndex = 0;
            btnSavePlanning.Text = "Sla op";
            btnSavePlanning.UseVisualStyleBackColor = false;
            btnSavePlanning.Click += btnSavePlanning_Click;
            // 
            // pnlTabAdminMakePlanning
            // 
            pnlTabAdminMakePlanning.ColumnCount = 2;
            pnlTabAdminMakePlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAdminMakePlanning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAdminMakePlanning.Controls.Add(cmbWhoToPlanIn, 0, 0);
            pnlTabAdminMakePlanning.Controls.Add(dateTimeMakePlanning, 1, 0);
            pnlTabAdminMakePlanning.Controls.Add(dateTimeStart, 0, 1);
            pnlTabAdminMakePlanning.Controls.Add(dateTimeEnd, 1, 1);
            pnlTabAdminMakePlanning.Dock = DockStyle.Fill;
            pnlTabAdminMakePlanning.Location = new Point(3, 3);
            pnlTabAdminMakePlanning.Name = "pnlTabAdminMakePlanning";
            pnlTabAdminMakePlanning.RowCount = 2;
            pnlTabAdminMakePlanning.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminMakePlanning.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminMakePlanning.Size = new Size(1194, 372);
            pnlTabAdminMakePlanning.TabIndex = 1;
            // 
            // cmbWhoToPlanIn
            // 
            cmbWhoToPlanIn.FormattingEnabled = true;
            cmbWhoToPlanIn.Location = new Point(3, 3);
            cmbWhoToPlanIn.Name = "cmbWhoToPlanIn";
            cmbWhoToPlanIn.Size = new Size(151, 28);
            cmbWhoToPlanIn.TabIndex = 0;
            // 
            // dateTimeMakePlanning
            // 
            dateTimeMakePlanning.Format = DateTimePickerFormat.Short;
            dateTimeMakePlanning.Location = new Point(600, 3);
            dateTimeMakePlanning.Name = "dateTimeMakePlanning";
            dateTimeMakePlanning.Size = new Size(250, 27);
            dateTimeMakePlanning.TabIndex = 1;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Format = DateTimePickerFormat.Time;
            dateTimeStart.Location = new Point(3, 189);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.ShowUpDown = true;
            dateTimeStart.Size = new Size(250, 27);
            dateTimeStart.TabIndex = 2;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Format = DateTimePickerFormat.Time;
            dateTimeEnd.Location = new Point(600, 189);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.ShowUpDown = true;
            dateTimeEnd.Size = new Size(250, 27);
            dateTimeEnd.TabIndex = 3;
            // 
            // userCtrlAdminPlanning
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tabAdminPlanning);
            Name = "userCtrlAdminPlanning";
            Size = new Size(1214, 512);
            tabAdminPlanning.ResumeLayout(false);
            tabPageAllPlanning.ResumeLayout(false);
            pnlTabAdminPlanningLayout.ResumeLayout(false);
            pnlTabSelectWeekLayout.ResumeLayout(false);
            pnlTabAdminPlanningLayout2.ResumeLayout(false);
            pnlTabAdminPlanning.ResumeLayout(false);
            pnlTabAdminPlanning.PerformLayout();
            pnlTabSelectEmployee.ResumeLayout(false);
            pnlTabSelectEmployee.PerformLayout();
            tabPageNewPlanning.ResumeLayout(false);
            pnlTabAdminLayoutMakePlanning.ResumeLayout(false);
            pnlTabSavePlanningButton.ResumeLayout(false);
            pnlTabAdminMakePlanning.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdminPlanning;
        private TabPage tabPageAllPlanning;
        private TableLayoutPanel pnlTabAdminPlanningLayout;
        private TableLayoutPanel pnlTabSelectWeekLayout;
        private TableLayoutPanel pnlTabSelectWeek;
        private TableLayoutPanel pnlTabAdminPlanningLayout2;
        private TableLayoutPanel pnlTabAdminPlanning;
        private Label lblMon;
        private Label lblTue;
        private Label lblWed;
        private Label lblThu;
        private Label lblFri;
        private Label lblSat;
        private Label lblSun;
        private TableLayoutPanel pnlTabSelectEmployee;
        private Label lblSelectEmp;
        private ComboBox cmbSelectEmployee;
        private TableLayoutPanel pnlTabPlanningTemp;
        private TabPage tabPageNewPlanning;
        private TableLayoutPanel pnlTabAdminLayoutMakePlanning;
        private TableLayoutPanel pnlTabSavePlanningButton;
        private Button btnSavePlanning;
        private TableLayoutPanel pnlTabAdminMakePlanning;
        private ComboBox cmbWhoToPlanIn;
        private DateTimePicker dateTimeMakePlanning;
        private DateTimePicker dateTimeStart;
        private DateTimePicker dateTimeEnd;
    }
}
