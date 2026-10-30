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
    public partial class frmMain : Form
    {
        User _user;
        Passwords passwords = new();
        internal frmMain(User user)
        {
            InitializeComponent();
            _user = user;
            // hier de role pakken omdat het te lastig was om in login te doen 
            GetCorrectRole();
        }

        internal void GetCorrectRole()
        {
            using MySqlConnection conn = new(passwords.ConnStr);
            try
            {
                conn.Open();

                string query = "SELECT * FROM role WHERE id = @id";

                MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@id", _user.role);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Role = reader.GetString("name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden. {ex.Message} \n Stacktrace: {ex.StackTrace}");
            }
        }
    }
}
