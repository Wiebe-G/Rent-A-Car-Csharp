using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;

namespace RentACar
{
    public partial class frmLogin : Form
    {
        readonly Passwords passwords = new();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister reg = new();
            this.Hide();
            reg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text.Trim();
            string Password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Geen logingegevens ingevuld");
                return;
            }

            using MySqlConnection conn = new(passwords.ConnStr);
            try
            {
                conn.Open();

                string query = $"SELECT * from user WHERE email = @email";

                MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@email", Email);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string PassFromDB = reader["password"].ToString() ?? "Niks";
                    if (PassFromDB == "Niks")
                    {
                        return;
                    }

                    bool CanLogin = IsValidPassword(Password, PassFromDB);
                    if (!CanLogin)
                    {
                        MessageBox.Show("Inloggegevens kloppen niet");
                        return;
                    }

                    MessageBox.Show($"Inloggevens kloppen. Welkom, {reader.GetString("Fname")} {reader.GetString("Lname")}");
                    CurrentUser.LoggedInUser = new User
                    {
                        fname = reader.GetString("fname"),
                        lname = reader.GetString("lname"),
                        email = reader.GetString("email"),
                        role = reader.GetOrdinal("role_id").ToString()
                    };

                    frmMain main = new(CurrentUser.LoggedInUser);
                    this.Hide();
                    main.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}. Stacktrace: {ex.StackTrace}");
            }
        }

        private void LoginWithEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private bool IsValidPassword(string EnteredPass, string DBPass)
        {
            return BC.Verify(EnteredPass, DBPass);
        }
    }
}
