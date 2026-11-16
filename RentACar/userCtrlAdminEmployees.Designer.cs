namespace RentACar
{
    partial class userCtrlAdminEmployees
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
            pnlTabGioIsEenTeringlijer = new TableLayoutPanel();
            SuspendLayout();
            // 
            // pnlTabGioIsEenTeringlijer
            // 
            pnlTabGioIsEenTeringlijer.ColumnCount = 2;
            pnlTabGioIsEenTeringlijer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabGioIsEenTeringlijer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabGioIsEenTeringlijer.Dock = DockStyle.Fill;
            pnlTabGioIsEenTeringlijer.Location = new Point(0, 0);
            pnlTabGioIsEenTeringlijer.Name = "pnlTabGioIsEenTeringlijer";
            pnlTabGioIsEenTeringlijer.RowCount = 2;
            pnlTabGioIsEenTeringlijer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabGioIsEenTeringlijer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabGioIsEenTeringlijer.Size = new Size(1212, 512);
            pnlTabGioIsEenTeringlijer.TabIndex = 0;
            // 
            // userCtrlAdminEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(pnlTabGioIsEenTeringlijer);
            Name = "userCtrlAdminEmployees";
            Size = new Size(1212, 512);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabGioIsEenTeringlijer;
    }
}
