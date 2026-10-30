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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Fname = txtFname.Text.Trim();
            string Lname = txtLname.Text.Trim();

            string City = txtCity.Text.Trim();
            string ZipCode = txtZipCode.Text.Trim();
            string StreetName = txtStreetname.Text.Trim();

            string Email = txtEmail.Text.Trim();

            string Password = txtPassword.Text.Trim();
            string PassConfirm = txtPasswordConfirm.Text.Trim();

            if (!ValidateInputs(Fname, Lname, City, ZipCode, StreetName, Email, Password, PassConfirm))
            {
                return;
            }


        }

        private static bool ValidateInputs(string Fname, string Lname, string City, string ZipCode, string StreetName, string Email, string Password, string PassConfirm)
        {
            if (string.IsNullOrWhiteSpace(Fname)
                || string.IsNullOrWhiteSpace(Lname)
                || string.IsNullOrWhiteSpace(City)
                || string.IsNullOrWhiteSpace(ZipCode)
                || string.IsNullOrWhiteSpace(StreetName)
                || string.IsNullOrWhiteSpace(Email)
                || string.IsNullOrWhiteSpace(Password)
                || string.IsNullOrWhiteSpace(PassConfirm)
                )
            {
                MessageBox.Show("Niet alle gegevens zijn ingevuld");
                return false;
            }
            if (Fname.Length > 255 || Lname.Length > 255)
            {
                MessageBox.Show("Naam mag niet langer dan 255 karakters zijn.");
                return false;
            }

            if (Password != PassConfirm)
            {
                MessageBox.Show("Wachtwoorden komen niet overeen.");
                return false;
            }

            if (Password.Length > 255 || Password.Length < 8)
            {
                MessageBox.Show("Wachtwoord mag niet langer dan 255 of korter dan 8 karakters zijn");
                return false;
            }

            if (City.Length > 255 || ZipCode.Length > 255 || StreetName.Length > 255)
            {
                MessageBox.Show("Adresgegevens zijn te lang. Probeer alles onder 255 karakters te krijgen.");
                return false;
            }

            if (Email.Length > 255)
            {
                MessageBox.Show("Email is te lang. Mag maximaal 255 karakters zijn");
                return false;
            }

            return true;
        }
    }
}
