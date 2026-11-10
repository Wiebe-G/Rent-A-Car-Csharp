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
                        id = reader.GetInt32("user_id"),
                        role = "customer",
                        email = reader.GetString("email"),
                        fname = reader.GetString("fname"),
                        lname = reader.GetString("lname"),
                        status = reader.GetInt32("status"),
                        user_address_id = reader.GetInt32("user_address_id")
                    });
                    index++;
                }

                DisplayAllCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message} \nStacktrace: {ex.StackTrace}");
            }
        }

        private void DisplayAllCustomers()
        {
            int count = 0;
            foreach (var c in Customers)
            {
                Label LastName = new()
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Label FirstName = new()
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Label Status = new()
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Button EditButton = new()
                {
                    Dock = DockStyle.Fill
                };

                LastName.Text = c.lname;
                FirstName.Text = c.fname;

                Status.Text = c.status == 1
                    ? "Actief"
                    : "Inactief";

                EditButton.Text = "Bewerk";

                EditButton.Click += (sender, e) =>
                {
                    frmAdminEditUser edit = new(c);
                    edit.Show();
                };

                pnlTabAdminAllCustomers.Controls.Add(LastName);
                pnlTabAdminAllCustomers.Controls.Add(FirstName);
                pnlTabAdminAllCustomers.Controls.Add(Status);
                pnlTabAdminAllCustomers.Controls.Add(EditButton);

                if (count % 3 == 0)
                {
                    pnlTabAdminAllCustomers.RowCount++;
                    pnlTabAdminAllCustomers.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }
                count++;
            }
        }

        private void txtSearchByLastName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo o/");
        }
    }
}
