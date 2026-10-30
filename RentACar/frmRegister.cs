using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using BC = BCrypt.Net.BCrypt;

namespace RentACar
{
    public partial class frmRegister : Form
    {
        readonly Passwords passwords = new();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Fname = txtFname.Text.Trim();
            string Lname = txtLname.Text.Trim();

            string City = txtCity.Text.Trim();
            string ZipCode = txtZipCode.Text.Trim();
            string StreetName = txtStreetname.Text.Trim();

            string Email = txtEmail.Text.Trim();

            string Password = txtPassword.Text.Trim();
            string PassConfirm = txtPasswordConfirm.Text.Trim();

            if (!ValidateInputs(Fname, Lname, City, ZipCode, StreetName, Email, Password, PassConfirm))
            {
                return;
            }

            if (!CreateUser(Fname, Lname, City, ZipCode, StreetName, Email, Password))
            {
                return;
            }
            MessageBox.Show("Account aangemaakt!");
            frmLogin login = new();
            this.Hide();
            login.Show();
        }

        private bool CreateUser(string Fname, string Lname, string City, string ZipCode, string StreetName, string Email, string Password)
        {
            string Hash = BC.HashPassword(Password, workFactor: 12);

            using MySqlConnection Conn = new(passwords.ConnStr);
            Conn.Open();

            using var Cmd = Conn.CreateCommand();
            // Maak gebruiker address gegevens entry aan
            Cmd.CommandText = "INSERT INTO user_address (streetname, zipcode, city) VALUES (@City, @ZipCode, @StreetName)";
            Cmd.Parameters.AddWithValue("@City", City);
            Cmd.Parameters.AddWithValue("@ZipCode", ZipCode);
            Cmd.Parameters.AddWithValue("@StreetName", StreetName);


            int RowsAffectedForAddress = Cmd.ExecuteNonQuery();

            if (RowsAffectedForAddress <= 0)
            {
                MessageBox.Show("Kon account niet aanmaken. Probeer het later opnieuw");
                return false;
            }
            long UserAddressId = Cmd.LastInsertedId;
            Cmd.CommandText = "INSERT INTO user (role_id, user_address_id, fname, lname, email, password, status, created_at, updated_at) " +
                "VALUES(1, @UserAddressId, @Fname, @Lname, @Email, @Hash, 1, @TimeNow, @TimeNow)";
            Cmd.Parameters.AddWithValue("@UserAddressId", UserAddressId);
            Cmd.Parameters.AddWithValue("@Fname", Fname);
            Cmd.Parameters.AddWithValue("@Lname", Lname);
            Cmd.Parameters.AddWithValue("@Email", Email);
            Cmd.Parameters.AddWithValue("@Hash", Hash);
            Cmd.Parameters.AddWithValue("@TimeNow", new DateTime());

            int RowsAffected = Cmd.ExecuteNonQuery();

            if (RowsAffected <= 0)
            {
                MessageBox.Show("Kon account niet aanmaken. Probeer het later opnieuw");
                return false;
            }

            return true;
        }

        private static bool ValidateInputs(string Fname, string Lname, string City, string ZipCode, string StreetName, string Email, string Password, string PassConfirm)
        {
            if (string.IsNullOrWhiteSpace(Fname)
                || string.IsNullOrWhiteSpace(Lname)
                || string.IsNullOrWhiteSpace(City)
                || string.IsNullOrWhiteSpace(ZipCode)
                || string.IsNullOrWhiteSpace(StreetName)
                || string.IsNullOrWhiteSpace(Email)
                || string.IsNullOrWhiteSpace(Password)
                || string.IsNullOrWhiteSpace(PassConfirm)
                )
            {
                MessageBox.Show("Niet alle gegevens zijn ingevuld");
                return false;
            }
            if (Fname.Length > 255 || Lname.Length > 255)
            {
                MessageBox.Show("Naam mag niet langer dan 255 karakters zijn.");
                return false;
            }

            if (Password != PassConfirm)
            {
                MessageBox.Show("Wachtwoorden komen niet overeen.");
                return false;
            }

            if (Password.Length > 255 || Password.Length < 8)
            {
                MessageBox.Show("Wachtwoord mag niet langer dan 255 of korter dan 8 karakters zijn");
                return false;
            }

            if (City.Length > 255 || ZipCode.Length > 255 || StreetName.Length > 255)
            {
                MessageBox.Show("Adresgegevens zijn te lang. Probeer alles onder 255 karakters te krijgen.");
                return false;
            }

            if (Email.Length > 255)
            {
                MessageBox.Show("Email is te lang. Mag maximaal 255 karakters zijn");
                return false;
            }

            return true;
        }
    }
}
