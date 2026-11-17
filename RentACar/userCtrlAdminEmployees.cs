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
                    zipcode = reader.GetString("zipcode")
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
                FetchEmployees();
                return;
            }
            List<User> filtered = employees.Where(e => e.lname.StartsWith(txtSearchEmployeeByLastName.Text.Trim())).ToList();
            pnlTabAdminEmployeesLayout.Controls.Clear();
            RenderEmployees(filtered);
        }
    }
}
