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
            btnOpenProfileForm.Text = $"{_user.fname} {_user.lname}";
            btnOpenEmployeePanel.Enabled = _user.role == "customer" ? false : true;
            btnOpenEmployeePanel.Visible = _user.role == "customer" ? false : true;
        }

        internal void GetCorrectRole()
        {
            using MySqlConnection conn = new(passwords.ConnStr);
            try
            {
                conn.Open();

                string query = "SELECT name FROM role WHERE id = @id";

                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(_user.role));

                using MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Role = reader.GetString("name");
                    _user.role = Role;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden. {ex.Message} \n Stacktrace: {ex.StackTrace}");
            }
        }

        private void btnOpenEmployeePanel_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new(_user);
            this.Hide();
            emp.Show();
        }

        private void btnOpenProfileForm_Click(object sender, EventArgs e)
        {
            frmUserProfile user = new(_user);
            this.Hide();
            user.Show();
        }
    }
}
