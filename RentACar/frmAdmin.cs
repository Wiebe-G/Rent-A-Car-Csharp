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
    public partial class frmAdmin : Form
    {
        User _user;
        internal frmAdmin(User user)
        {
            InitializeComponent();
            _user = user;
            if (_user == null)
            {
                MessageBox.Show("Geen gebruiker gevonden");
                return;
            }
            if (_user.role != "owner")
            {
                MessageBox.Show("Dit gedeelte is alleen voor eigenaren.");
                return;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult Logout = MessageBox.Show("Weet je zeker dat je wilt uitloggen?", "Uitloggen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Logout == DialogResult.Yes)
            {
                MessageBox.Show("Ok, zie u later o/");
                Environment.Exit(0);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new(_user);
            emp.Show();
            this.Hide();
        }
    }
}
