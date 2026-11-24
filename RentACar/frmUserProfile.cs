using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmUserProfile : Form
    {
        readonly User _user;
        Passwords passwords = new();
        bool _editing;

        internal frmUserProfile(User user)
        {
            InitializeComponent();
            _user = user;

            FetchAddressData();
            LoadUser();
            SetEditMode(false);
        }

        private void FetchAddressData()
        {
            try
            {
                using MySqlConnection conn = new(passwords.ConnStr);
                conn.Open();

                string query = @"SELECT a.streetname, a.zipcode, a.city
                                 FROM user_address a
                                 JOIN user u ON u.user_address_id = a.id
                                 WHERE u.user_id=@id";
                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@id", _user.id);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    _user.street = reader.GetString("streetname");
                    _user.zipcode = reader.GetString("zipcode");
                    _user.city = reader.GetString("city");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Adresgegevens laden mislukt:\n" + ex.Message, "Databasefout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUser()
        {
            txtFname.Text = _user.fname;
            txtLname.Text = _user.lname;
            txtEmail.Text = _user.email;
            txtStreetname.Text = _user.street;
            txtZipCode.Text = _user.zipcode;
            txtCity.Text = _user.city;
            txtPassword.Clear();
            txtPasswordConfirm.Clear();
        }

        private void SetEditMode(bool editing)
        {
            _editing = editing;

            foreach (var tb in new[] { txtFname, txtLname, txtEmail, txtStreetname,
                                       txtZipCode, txtCity, txtPassword, txtPasswordConfirm })
                tb.ReadOnly = !editing;

            btnEdit.Text = editing ? "Opslaan" : "Bewerken";
            btnCancel.Visible = editing;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!_editing)
                SetEditMode(true);
            else
                SaveProfile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadUser();
            SetEditMode(false);
        }

        private void SaveProfile()
        {
            string Fname = txtFname.Text.Trim();
            string Lname = txtLname.Text.Trim();
            string City = txtCity.Text.Trim();
            string Zipcode = txtZipCode.Text.Trim();
            string Street = txtStreetname.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string Password = txtPassword.Text;

            if (Fname.Length < 1
                || Lname.Length < 1
                || City.Length < 1
                || Zipcode.Length < 1
                || Street.Length < 1
                || Email.Length < 1)
            {
                MessageBox.Show("Vul alle gegevens in.", "Ontbrekende gegevens",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ChangePassword = !string.IsNullOrEmpty(Password);
            if (ChangePassword && Password != txtPasswordConfirm.Text)
            {
                MessageBox.Show("De wachtwoorden komen niet overeen.", "Wachtwoord",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!UpdateUser(Fname, Lname, City, Zipcode, Street, Email, Password, ChangePassword)) return;

            _user.fname = Fname;
            _user.lname = Lname;
            _user.email = Email;
            _user.street = Street;
            _user.zipcode = Zipcode;
            _user.city = City;

            LoadUser();
            SetEditMode(false);
            MessageBox.Show("Profiel bijgewerkt!");
        }

        private bool UpdateUser(string Fname, string Lname, string City, string Zipcode, string Street, string Email, string Password, bool ChangePassword)
        {
            try
            {
                using MySqlConnection conn = new(passwords.ConnStr);
                conn.Open();

                using MySqlTransaction transaction = conn.BeginTransaction();

                string query = "UPDATE user SET fname=@fname, lname=@lname, email=@email, updated_at=NOW(6) WHERE user_id=@id";
                using MySqlCommand cmd = new(query, conn, transaction);

                cmd.Parameters.AddWithValue("@fname", Fname);
                cmd.Parameters.AddWithValue("@lname", Lname);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@id", _user.id);

                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected <= 0)
                {
                    MessageBox.Show("Er was een fout bij het updaten van de gebruiker. Probeer het later opnieuw.");
                    return false;
                }

                query = "UPDATE user_address SET streetname=@streetname, zipcode=@zipcode, city=@city WHERE id=@address_id";
                using MySqlCommand NewCMD = new(query, conn, transaction);
                NewCMD.Parameters.AddWithValue("@streetname", Street);
                NewCMD.Parameters.AddWithValue("@zipcode", Zipcode);
                NewCMD.Parameters.AddWithValue("@city", City);
                NewCMD.Parameters.AddWithValue("@address_id", _user.user_address_id);

                int AddressRowsAffected = NewCMD.ExecuteNonQuery();
                if (AddressRowsAffected <= 0)
                {
                    MessageBox.Show("Adresgegevens konden niet worden bijgewerkt. Probeer het later opnieuw");
                    return false;
                }

                if (ChangePassword)
                {
                    query = "UPDATE user SET password=@password WHERE user_id=@id";
                    using MySqlCommand PasswordCMD = new(query, conn, transaction);
                    PasswordCMD.Parameters.AddWithValue("@password", Password);
                    PasswordCMD.Parameters.AddWithValue("@id", _user.id);
                    PasswordCMD.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Opslaan mislukt:\n" + ex.Message, "Databasefout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}