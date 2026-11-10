using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RentACar
{
    public partial class frmUserProfile : Form
    {
        private const string ConnStr = "Server=127.0.0.1;Port=3306;Database=rentacar;Uid=root;Pwd=;";

        User _user;
        bool _editing;

        internal frmUserProfile(User user)
        {
            InitializeComponent();
            _user = user;

            LoadUser();
            SetEditMode(false);
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
            if (string.IsNullOrWhiteSpace(txtFname.Text) ||
                string.IsNullOrWhiteSpace(txtLname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtStreetname.Text) ||
                string.IsNullOrWhiteSpace(txtZipCode.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Vul alle gegevens in.", "Ontbrekende gegevens",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool changePassword = !string.IsNullOrEmpty(txtPassword.Text);
            if (changePassword && txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("De wachtwoorden komen niet overeen.", "Wachtwoord",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        using (var cmd = new MySqlCommand(
                            @"UPDATE user_address
                              SET streetname = @street, zipcode = @zip, city = @city
                              WHERE id = @addressId", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@street", txtStreetname.Text.Trim());
                            cmd.Parameters.AddWithValue("@zip", txtZipCode.Text.Trim());
                            cmd.Parameters.AddWithValue("@city", txtCity.Text.Trim());
                            cmd.Parameters.AddWithValue("@addressId", _user.user_address_id);
                            cmd.ExecuteNonQuery();
                        }

                        using (var cmd = new MySqlCommand(
                            @"UPDATE user
                              SET fname = @fname, lname = @lname, email = @email,
                                  updated_at = NOW(6)
                              WHERE user_id = @userId", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@fname", txtFname.Text.Trim());
                            cmd.Parameters.AddWithValue("@lname", txtLname.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@userId", _user.user_id);
                            cmd.ExecuteNonQuery();
                        }

                        if (changePassword)
                        {
                            using (var cmd = new MySqlCommand(
                                "UPDATE user SET password = @pw WHERE user_id = @userId", conn, tx))
                            {
                                cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                                cmd.Parameters.AddWithValue("@userId", _user.user_id);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tx.Commit();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Opslaan mislukt:\n" + ex.Message, "Databasefout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _user.fname = txtFname.Text.Trim();
            _user.lname = txtLname.Text.Trim();
            _user.email = txtEmail.Text.Trim();
            _user.street = txtStreetname.Text.Trim();
            _user.zipcode = txtZipCode.Text.Trim();
            _user.city = txtCity.Text.Trim();

            LoadUser();
            SetEditMode(false);
        }
    }
}