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
        }

        internal void FetchEmployees()
        {
            int index = 0;
            using MySqlConnection conn = new(passwords.ConnStr);

            conn.Open();

            string query = "SELECT * FROM user WHERE role_id <> 1";

            using MySqlCommand cmd = new(query, conn);

            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employees.Insert(index, new User
                {

                });
                index++;
            }
        }
    }
}
