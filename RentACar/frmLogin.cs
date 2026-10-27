using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;

namespace RentACar
{
    public partial class frmLogin : Form
    {
        Passwords passwords = new();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text.Trim();
            string Password = txtPassword.Text.Trim();

            using (MySqlConnection conn = new(passwords.ConnStr))
            {
                try
                {
                    conn.Open();

                    string query = $"SELECT * from user WHERE email = {Email}";

                    MySqlCommand cmd = new(query, conn);

                    cmd.Parameters.AddWithValue("@email", Email);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show($"{reader}");
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

                        CurrentUser.LoggedInUser = new User
                        {
                            email = Email,
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}. Stacktrace: {ex.StackTrace}");
                }
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
