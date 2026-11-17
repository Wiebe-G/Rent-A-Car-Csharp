using MySql.Data.MySqlClient;
using System.Data;
using BC = BCrypt.Net.BCrypt;

namespace RentACar
{
    public partial class userCtrlAdminEmployees : UserControl
    {
        readonly Passwords passwords = new();
        List<User> employees = [];
        public userCtrlAdminEmployees()
        {
            InitializeComponent();
            FetchEmployees();
        }

        internal void FetchEmployees()
        {
            int index = 0;
            using MySqlConnection conn = new(passwords.ConnStr);

            conn.Open();

            string query = "SELECT user.user_id, user.role_id, user.user_address_id, user.fname, user.lname, user.email, user.status, role.name AS role, " +
                "user_address.id, user_address.streetname, user_address.zipcode, user_address.city " +
                "FROM user " +
                "JOIN role ON role.id = user.role_id " +
                "JOIN user_address ON user.user_address_id = user_address.id " +
                "WHERE role.name <> 'customer'";

            using MySqlCommand cmd = new(query, conn);

            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employees.Insert(index, new User
                {
                    id = reader.GetInt32("user_id"),
                    role = reader.GetString("role"),
                    email = reader.GetString("email"),
                    fname = reader.GetString("fname"),
                    lname = reader.GetString("lname"),
                    status = reader.GetInt32("status"),
                    street = reader.GetString("streetname"),
                    city = reader.GetString("city"),
                    zipcode = reader.GetString("zipcode"),
                    user_address_id = reader.GetInt32("user_address_id")
                });
                index++;
            }
            RenderEmployees(employees);
        }

        internal string TranslateRoleName(string input)
        {
            string output = "onbekend";
            switch (input)
            {
                case "employee":
                    output = "medewerker";
                    break;
                case "owner":
                    output = "eigenaar";
                    break;
                default:
                    break;
            }

            return output;
        }

        internal void RenderEmployees(List<User> emps)
        {
            foreach (var e in emps)
            {
                TableLayoutPanel tab = new()
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 5,
                };

                for (int i = 0; i < tab.ColumnCount; i++)
                {
                    tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                }

                Label Lname = new()
                {
                    Dock = DockStyle.Fill,
                    Text = e.lname,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label Fname = new()
                {
                    Dock = DockStyle.Fill,
                    Text = e.fname,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label Status = new()
                {
                    Dock = DockStyle.Fill,
                    Text = e.status == 1
                    ? "Actief"
                    : "Inactief",
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label Role = new()
                {
                    Dock = DockStyle.Fill,
                    Text = TranslateRoleName(e.role),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Button Edit = new()
                {
                    Dock = DockStyle.Fill,
                    Text = "Bewerk",
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Edit.Click += (_, _) =>
                {
                    frmAdminEditUser edit = new(e);
                    edit.Show();
                };

                tab.Controls.Add(Lname);
                tab.Controls.Add(Fname);
                tab.Controls.Add(Status);
                tab.Controls.Add(Role);
                tab.Controls.Add(Edit);

                pnlTabAdminEmployeesLayout.RowCount++;
                pnlTabAdminEmployeesLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                pnlTabAdminEmployeesLayout.Controls.Add(tab);
            }
        }

        private void txtSearchEmployeeByLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmployeeByLastName.Text.Trim().Length < 0)
            {
                pnlTabAdminEmployeesLayout.Controls.Clear();
                RenderEmployees(employees);
                return;
            }
            List<User> filtered = employees.Where(e => e.lname.StartsWith(txtSearchEmployeeByLastName.Text.Trim())).ToList();
            pnlTabAdminEmployeesLayout.Controls.Clear();
            RenderEmployees(filtered);
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            string Fname = txtFname.Text.Trim();
            string Lname = txtLname.Text.Trim();
            string City = txtCity.Text.Trim();
            string Zip = txtZipCode.Text.Trim();
            string Street = txtStreetname.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string Role = cmbRole.SelectedText.ToString().Trim();
            string Password = txtPassword.Text.Trim();
            string PasswordConfirm = txtPassConfirm.Text.Trim();
            if (!ValidateInput(Fname, Lname, City, Zip, Street, Email, Password, PasswordConfirm)) return;

            if (!CreateEmployee(Fname, Lname, City, Zip, Street, Email, Password)) return;

            MessageBox.Show("Medewerker is aangemaakt!");
            txtFname.Clear();
            txtLname.Clear();
            txtCity.Clear();
            txtZipCode.Clear();
            txtStreetname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPassConfirm.Clear();
        }

        private bool ValidateInput(string Fname, string Lname, string City, string Zip, string Street, string Email, string Pass, string PassC)
        {
            if (string.IsNullOrWhiteSpace(Fname)
                           || string.IsNullOrWhiteSpace(Lname)
                           || string.IsNullOrWhiteSpace(City)
                           || string.IsNullOrWhiteSpace(Zip)
                           || string.IsNullOrWhiteSpace(Street)
                           || string.IsNullOrWhiteSpace(Email)
                           || string.IsNullOrWhiteSpace(Pass)
                           || string.IsNullOrWhiteSpace(PassC)
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

            if (Pass != PassC)
            {
                MessageBox.Show("Wachtwoorden komen niet overeen.");
                return false;
            }

            if (Pass.Length > 255 || Pass.Length < 8)
            {
                MessageBox.Show("Wachtwoord mag niet langer dan 255 of korter dan 8 karakters zijn");
                return false;
            }

            if (City.Length > 255 || Zip.Length > 255 || Street.Length > 255)
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

        private bool CreateEmployee(string Fname, string Lname, string City, string Zip, string Street, string Email, string Pass)
        {
            string Hash = BC.HashPassword(Pass, workFactor: 12);

            using MySqlConnection conn = new(passwords.ConnStr);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO user_address (streetname, zipcode, city) VALUES (@StreetName, @ZipCode, @City)";
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@ZipCode", Zip);
            cmd.Parameters.AddWithValue("@StreetName", Street);

            int RowsAffectedForAddress = cmd.ExecuteNonQuery();

            if (RowsAffectedForAddress <= 0)
            {
                MessageBox.Show("Kon account niet aanmaken. Probeer het later opnieuw");
                return false;
            }
            long UserAddressId = cmd.LastInsertedId;
            cmd.CommandText = "INSERT INTO user (role_id, user_address_id, fname, lname, email, password, status, created_at, updated_at) " +
                "VALUES(@role, @UserAddressId, @Fname, @Lname, @Email, @Hash, 1, @TimeNow, @TimeNow)";
            /* 
             * zet dit tijdelijk naar 2 want role kan nog niet worden gemaakt
             * haal alle rollen op uit de db, zit dit in een list bovenaan, zet ze in de combobox (dropdown)
             * en kijk dan hier naar welke waarde het heeft en pak die id, en zet die in de parameter
            */
            cmd.Parameters.AddWithValue("@role", 2);
            cmd.Parameters.AddWithValue("@UserAddressId", UserAddressId);
            cmd.Parameters.AddWithValue("@Fname", Fname);
            cmd.Parameters.AddWithValue("@Lname", Lname);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Hash", Hash);
            cmd.Parameters.AddWithValue("@TimeNow", new DateTime());

            int RowsAffected = cmd.ExecuteNonQuery();

            if (RowsAffected <= 0)
            {
                MessageBox.Show("Kon account niet aanmaken. Probeer het later opnieuw");
                return false;
            }

            return true;
        }
    }
}
