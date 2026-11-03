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
        readonly User _user;
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

        private void ShowCorrectMenu(object? sender, EventArgs e)
        {
            if (sender is not Button)
            {
                return;
            }
            Button? btn = sender as Button;
            string Type = btn.Name.Remove(0, 7);

            switch (Type)
            {
                case "Cars":
                    RenderCarsMenu();
                    break;
                case "Invoices":
                    // render facturen menu
                    break;
                case "Customers":
                    // render klanten menu
                    break;
                case "Employees":
                    // render medewerkers menu
                    break;
                case "Stock":
                    // render voorraad en reserveringen menu
                    break;
                case "Planning":
                    // render planning menu, met knoppen per medewerker om agenda te zien
                    break;
                case "Dashboard":
                    // prestatie dashboard menu, met per medewerker laten zien hoe veel auto's zijn verhuurd
                    break;
                case "OpeningTimes":
                    // laat openingstijden zien
                    break;
                case "Logs":
                    // logs laten zien
                    break;
                default:
                    break;
            }
        }

        private void RenderCarsMenu()
        {
            userCtrlAdminCars cars = new()
            {
                Dock = DockStyle.Fill
            };
            spltAdminLayout.Panel2.Controls.Clear();
            spltAdminLayout.Panel2.Controls.Add(cars);
        }
    }
}
