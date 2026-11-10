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
        User _user;
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
                MessageBox.Show(reader.GetString("streetname"));
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
    }
}
