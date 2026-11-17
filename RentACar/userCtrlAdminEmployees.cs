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

            //string query = "SELECT user.user_id, user.role_id, user.user_address_id, user.fname, user.lname, user.email, user.status, " +
            //    "role.name as role, " +
            //    "user_address.id, user_address.streetname, user_address.zipcode, user_address.city " +
            //    "FROM user " +
            //    "JOIN role ON role.id = user.role_id " +
            //    "JOIN user_address ON user.user_address_id = user_address.id " +
            //    "WHERE role <> 'customer'";

            string query = "SELECT user.user_id, user.role_id, user.user_address_id, user.fname, user.lname, user.email, user.status, role.name as role,\r\nuser_address.id, user_address.streetname, user_address.zipcode, user_address.city\r\nfrom user \r\njoin role on role.id = user.role_id\r\njoin user_address on user.user_address_id = user_address.id\r\nwhere role.name <> 'customer'";

            using MySqlCommand cmd = new(query, conn);

            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employees.Insert(index, new User
                {
                    id = reader.GetInt32("user_id"),
                    role = TranslateRoleName(reader.GetString("role")),
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
    }
}
