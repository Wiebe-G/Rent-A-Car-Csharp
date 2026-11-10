using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmAdminEditUser : Form
    {
        readonly User _user;
        Passwords passwords = new();
        internal frmAdminEditUser(User user)
        {
            InitializeComponent();
            _user = user;
            if (user == null)
            {
                MessageBox.Show("Geen gebruiker gevonden.");
                return;
            }

            FetchAddressData();
            RenderDataInTextboxes();
        }

        internal void FetchAddressData()
        {
            using MySqlConnection conn = new(passwords.ConnStr);
            conn.Open();

            string query = "SELECT * FROM user_address where id=@user_address_id";
            using MySqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@user_address_id", _user.user_address_id);

            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                _user.street = reader.GetString("streetname");
                _user.zipcode = reader.GetString("zipcode");
                _user.city = reader.GetString("city");
            }
        }

        internal void RenderDataInTextboxes()
        {
            txtFname.Text = _user.fname;
            txtLname.Text = _user.lname;
            txtCity.Text = _user.city;
            txtZipCode.Text = _user.zipcode;
            txtStreetname.Text = _user.street;
            txtEmail.Text = _user.email;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string Fname = txtFname.Text.Trim();
            string Lname = txtLname.Text.Trim();
            string City = txtCity.Text.Trim();
            string Zipcode = txtZipCode.Text.Trim();
            string Street = txtStreetname.Text.Trim();
            string Email = txtEmail.Text.Trim();
            if (!ValidateInputs(Fname, Lname, City, Zipcode, Street, Email)) return;

            if (!UpdateUser(Fname, Lname, City, Zipcode, Street, Email)) return;

            MessageBox.Show("Gebruiker bewerkt!");
        }

        private bool ValidateInputs(string Fname, string Lname, string City, string Zipcode, string Street, string Email)
        {
            if (Fname.Length > 255
                            || Lname.Length > 255
                            || City.Length > 255
                            || Zipcode.Length > 255
                            || Street.Length > 255
                            || Email.Length > 255)
            {
                MessageBox.Show("Input mag max 255 karakters zijn.");
                return false;
            }

            if (Fname.Length < 1
                            || Lname.Length < 1
                            || City.Length < 1
                            || Zipcode.Length < 1
                            || Street.Length < 1
                            || Email.Length < 1)
            {
                MessageBox.Show("Niet alle vereiste gegevens zijn ingevuld.");
                return false;
            }

            return true;
        }

        private bool UpdateUser(string Fname, string Lname, string City, string Zipcode, string Street, string Email)
        {
            using MySqlConnection conn = new(passwords.ConnStr);
            conn.Open();

            using MySqlTransaction transaction = conn.BeginTransaction();

            string query = "UPDATE user SET fname=@fname, lname=@lname, email=@email WHERE user_id=@id";
            using MySqlCommand cmd = new(query, conn);

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
            MySqlCommand NewCMD = new(query, conn);
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

            transaction.Commit();

            return true;
        }
    }
}
