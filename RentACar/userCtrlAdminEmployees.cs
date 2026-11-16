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

            string query = "SELECT user.user_id, user.role_id, user.user_address_id, user.fname, user.lname, user.email, user.status, role.name " +
                "FROM user " +
                "JOIN role ON role.id = user.role_id";

            using MySqlCommand cmd = new(query, conn);

            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                if (reader.GetString("name") == "customer")
                {
                    continue;
                }
                // hier adresgegvens ophalen en dan in de user instance zetten
                employees.Insert(index, new User
                {
                    id = reader.GetInt32("user_id"),
                    role = TranslateRoleName(reader.GetString("name")),
                    email = reader.GetString("email"),
                    fname = reader.GetString("fname"),
                    lname = reader.GetString("lname"),
                    status = reader.GetInt32("status"),
                    user_address_id = reader.GetInt32("user_address_id")
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
