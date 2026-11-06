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
    public partial class userCtrlAdminCustomers : UserControl
    {
        readonly Passwords passwords = new();
        List<User> Customers = [];
        internal userCtrlAdminCustomers()
        {
            InitializeComponent();
            FetchCustomers();
        }

        private void FetchCustomers()
        {
            int index = 0;
            using MySqlConnection conn = new(passwords.ConnStr);

            try
            {
                conn.Open();

                // hard codeed role_id, niet al te handig maar wie boeit :shrug:
                string query = "SELECT * FROM user WHERE role_id = 1";

                using MySqlCommand cmd = new(query, conn);

                using MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customers.Insert(index, new User
                    {
                        id = reader.GetInt32("id"),
                        role = "customer",
                        email = reader.GetString("email"),
                        fname = reader.GetString("fname"),
                        lname = reader.GetString("lname"),
                        status = reader.GetInt32("status")
                    });
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message} \nStacktrace: {ex.StackTrace}");
            }
        }

        private void txtSearchByLastName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo o/");
        }
    }
}
