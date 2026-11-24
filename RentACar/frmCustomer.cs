namespace RentACar
{
    public partial class frmCustomer : Form
    {
        User _user;

        internal frmCustomer(User user)
        {
            InitializeComponent();
            _user = user;

            // standaard het wagenpark tonen
            btnWagenpark.PerformClick();
        }

        private void btnWagenpark_Click(object sender, EventArgs e)
        {
            ShowSection("Wagenpark");
        }

        private void btnReserveringen_Click(object sender, EventArgs e)
        {
            ShowSection("Reserveringen");
        }

        private void btnHuurgeschiedenis_Click(object sender, EventArgs e)
        {
            ShowSection("Huurgeschiedenis");
        }

        private void btnFacturen_Click(object sender, EventArgs e)
        {
            ShowSection("Facturen");
        }

        // tijdelijke invulling: een titel in het inhoudsgebied
        private void ShowSection(string title)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 20)
            });
        }
    }
}