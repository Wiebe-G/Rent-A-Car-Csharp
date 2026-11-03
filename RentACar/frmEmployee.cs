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
    public partial class frmEmployee : Form
    {
        User _user;
        internal frmEmployee(User user)
        {
            InitializeComponent();
            _user = user;
            if (_user.role == "customer")
            {
                MessageBox.Show("Dit is niet voor klanten. OPROTTEN!");
                return;
            }
            btnOpenAdminPanel.Enabled = user.role == "owner" ? true : false;
            btnOpenAdminPanel.Visible = user.role == "owner" ? true : false;
        }

        private void btnOpenAdminPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
