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

            if (Screen.PrimaryScreen != null)
            {
                Width = Screen.PrimaryScreen.Bounds.Width;
                Height = Screen.PrimaryScreen.Bounds.Height;
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult Logout = MessageBox.Show("Weet je zeker dat je wilt uitloggen?",
                "Uitloggen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

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
            this.Close();
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
                    RenderInvoicesMenu();
                    break;
                case "Customers":
                    RenderCustomersMenu();
                    break;
                case "Employees":
                    RenderEmployeesMenu();
                    break;
                case "Stock":
                    RenderStockMenu();
                    break;
                case "Planning":
                    // render planning menu, met knoppen per medewerker om agenda te zien
                    RenderPlanningMenu();
                    break;
                case "Dashboard":
                    // prestatie dashboard menu, met per medewerker laten zien hoe veel auto's zijn verhuurd
                    RenderDashboardMenu();
                    break;
                case "OpeningTimes":
                    RenderOpeningTimesMenu();
                    break;
                case "Logs":
                    RenderLogsMenu();
                    break;
                default:
                    break;
            }
        }

        private void RenderCarsMenu()
        {
            userCtrlAdminCars cars = new(_user)
            {
                Dock = DockStyle.Fill
            };

            spltAdminLayout.Panel2.Controls.Clear();
            spltAdminLayout.Panel2.Controls.Add(cars);
        }

        private void RenderInvoicesMenu()
        {
            MessageBox.Show("Wordt aan gewerkt, en is nog niet functioneel");
            userCtrlAdminInvoices invoices = new(_user)
            {
                Dock = DockStyle.Fill
            };

            spltAdminLayout.Panel2.Controls.Clear();
            spltAdminLayout.Panel2.Controls.Add(invoices);
        }

        private void RenderCustomersMenu()
        {
            userCtrlAdminCustomers cust = new()
            {
                Dock = DockStyle.Fill
            };
            spltAdminLayout.Panel2.Controls.Clear();
            spltAdminLayout.Panel2.Controls.Add(cust);
        }

        private void RenderEmployeesMenu()
        {
            userCtrlAdminEmployees employees = new()
            {
                Dock = DockStyle.Fill
            };

            MessageBox.Show("Nog niet af ");
            spltAdminLayout.Panel2.Controls.Clear();
            spltAdminLayout.Panel2.Controls.Add(employees);
        }

        private void RenderStockMenu()
        {
            MessageBox.Show("Nog niet af ");
            spltAdminLayout.Panel2.Controls.Clear();
        }

        private void RenderPlanningMenu()
        {
            MessageBox.Show("Nog niet af ");
            spltAdminLayout.Panel2.Controls.Clear();
        }

        private void RenderDashboardMenu()
        {
            MessageBox.Show("Nog niet af ");
            spltAdminLayout.Panel2.Controls.Clear();
        }

        private void RenderOpeningTimesMenu()
        {
            MessageBox.Show("Nog niet af ");
            spltAdminLayout.Panel2.Controls.Clear();
        }

        private void RenderLogsMenu()
        {
            MessageBox.Show("Nog niet af ");
            spltAdminLayout.Panel2.Controls.Clear();
        }
    }
}
