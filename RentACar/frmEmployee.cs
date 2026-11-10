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
    public partial class frmEmployee : Form
    {
        private readonly User _user;
        private readonly Passwords _passwords = new();
        internal frmEmployee(User user)
        {
            InitializeComponent();
            _user = user;
            if (_user.role != "employee" && _user.role != "owner")
            {
                MessageBox.Show(
                    "Je hebt geen toegang tot het medewerkersgedeelte.",
                    "Geen toegang",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Load += (_, _) => Close();
                return;
            }

            btnOpenAdminPanel.Visible = user.role == "owner";
            btnOpenAdminPanel.Enabled = user.role == "owner";

            Load += (_, _) => LoadCars();
        }
        private void LoadCars()
        {
            try
            {
                using MySqlConnection connection = new(_passwords.ConnStr);
                connection.Open();

                string query = """
                    SELECT
                        id AS car_id,
                        merk,
                        model,
                        kenteken,
                        type,
                        dagprijs,
                        status
                    FROM car
                    WHERE (
                            @search = ''
                            OR merk LIKE @searchLike
                            OR model LIKE @searchLike
                            OR kenteken LIKE @searchLike
                          )
                      AND (
                            @status = ''
                            OR status = @status
                          )
                    ORDER BY merk, model;
                    """;

                using MySqlCommand command = new(query, connection);

                string search = txtSearch.Text.Trim();
                string status = cmbStatusFilter.Text == "Alle statussen"
                    ? string.Empty
                    : cmbStatusFilter.Text;

                command.Parameters.AddWithValue("@search", search);
                command.Parameters.AddWithValue("@searchLike", $"%{search}%");
                command.Parameters.AddWithValue("@status", status);

                using MySqlDataAdapter adapter = new(command);
                DataTable cars = new();

                adapter.Fill(cars);

                dgvCars.DataSource = cars;

                if (dgvCars.Columns["car_id"] != null)
                {
                    dgvCars.Columns["car_id"].Visible = false;
                }

                dgvCars.Columns["merk"].HeaderText = "Merk";
                dgvCars.Columns["model"].HeaderText = "Model";
                dgvCars.Columns["kenteken"].HeaderText = "Kenteken";
                dgvCars.Columns["type"].HeaderText = "Type";
                dgvCars.Columns["dagprijs"].HeaderText = "Dagprijs";
                dgvCars.Columns["status"].HeaderText = "Status";

                dgvCars.Columns["dagprijs"].DefaultCellStyle.Format = "€ 0.00";
                dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Add this block to translate the status column
                foreach (DataRow row in cars.Rows)
                {
                    row["status"] = row["status"] switch
                    {
                        "available" => "Beschikbaar",
                        "rented" => "Verhuurd",
                        "maintenance" => "In onderhoud",
                        "out_of_service" => "Buiten gebruik",
                        _ => row["status"]
                    };
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                 $"De auto's konden niet worden geladen.\n\n{exception.Message}",
                    "Databasefout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "De invoerform voor nieuwe auto's wordt als volgende stap toegevoegd.",
                "Nog niet beschikbaar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecteer eerst een auto.",
                    "Geen auto geselecteerd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;

            }

            MessageBox.Show(
                "De bewerkform voor auto's wordt als volgende stap toegevoegd.",
                "Nog niet beschikbaar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSetCarOutOfService_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecteer eerst een auto.",
                    "Geen auto geselecteerd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow selectedRow = dgvCars.SelectedRows[0];
            int carId = Convert.ToInt32(selectedRow.Cells["car_id"].Value);
            string carName =
                $"{selectedRow.Cells["merk"].Value} {selectedRow.Cells["model"].Value}";

            DialogResult result = MessageBox.Show(
                $"Wil je {carName} buiten gebruik zetten?",
                "Bevestiging",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try

            {
                using MySqlConnection connection = new(_passwords.ConnStr);
                connection.Open();

                const string query = """
                    UPDATE car
                    SET status = @status
                    WHERE id = @carId;
                    """;

                using MySqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@status", "buiten gebruik");
                command.Parameters.AddWithValue("@carId", carId);

                command.ExecuteNonQuery();

                LoadCars();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"De status van de auto kon niet worden aangepast.\n\n{exception.Message}",
                    "Databasefout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnOpenAdminPanel_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new(_user);
            admin.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain? mainForm = Application.OpenForms
                .OfType<frmMain>()
                .FirstOrDefault();

            if (mainForm != null)
            {
                mainForm.Show();
                mainForm.BringToFront();
            }

            Close();
        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            pnlTabTopBarEmployee.Visible = true;
            dgvCars.Visible = true;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Het klantgedeelte wordt later toegevoegd.",
                "Nog niet beschikbaar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnDayOverview_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Het dagoverzicht wordt later toegevoegd.",
                "Nog niet beschikbaar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnOpeningHours_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "De openingstijden worden later toegevoegd.",
                "Nog niet beschikbaar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
