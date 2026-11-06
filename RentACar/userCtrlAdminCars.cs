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
    public partial class userCtrlAdminCars : UserControl
    {
        readonly Passwords passwords = new();
        List<Car> cars = [];
        User user;
        internal userCtrlAdminCars(User _user)
        {
            InitializeComponent();
            user = _user;
            pnlTabAdminAllCars.AutoSize = true;
            pnlTabAdminAllCars.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            pnlTabAdminAllCars.RowStyles.Clear();
            GetAllCars();
        }

        internal void GetAllCars()
        {
            int index = 0;
            using MySqlConnection conn = new(passwords.ConnStr);
            try
            {
                conn.Open();
                string query = "SELECT * FROM car WHERE deleted_at IS null";

                using MySqlCommand cmd = new(query, conn);

                using MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cars.Insert(index, new Car
                    {
                        id = reader.GetInt32("id").ToString(),
                        merk = reader.GetString("merk"),
                        model = reader.GetString("model"),
                        kenteken = reader.GetString("kenteken"),
                        type = reader.GetString("type"),
                        dagprijs = reader.GetInt32("dagprijs"),
                        status = reader.GetString("status")
                    });
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message} \nStacktrace: {ex.StackTrace}");
            }
            if (cars.Count < 1)
            {
                MessageBox.Show("Geen auto's gevonden");
                return;
            }
            int RowsAmount = 3;
            pnlTabAdminAllCars.RowCount = cars.Count / RowsAmount > 1
                ? cars.Count / RowsAmount
                : 1;
            DisplayAllCars();
        }

        internal void DisplayAllCars()
        {
            int count = 0;
            foreach (var car in cars)
            {
                userCtrlCarListing CarListing = new(car, user)
                {
                    Dock = DockStyle.Fill,
                };

                //frmEditCar edit = new(car);
                //CarListing.Click += (_, _) =>
                //{
                //    MessageBox.Show("Test");
                //    edit.Show();
                //};

                // niet vergeten om te zeggen WAAR het moet worden toegevoegd slimpie
                pnlTabAdminAllCars.Controls.Add(CarListing);

                if (count % 3 == 0)
                {
                    pnlTabAdminAllCars.RowCount++;
                    pnlTabAdminAllCars.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }
                count++;
            }
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            string Merk = txtMerk.Text.Trim();
            string Model = txtModel.Text.Trim();
            string Kenteken = txtKenteken.Text.Trim();
            string Type = txtType.Text.Trim();
            decimal Dagprijs = numDagprijs.Value;
            string Status = txtStatus.Text.Trim();

            if (!ValidateInput(Merk, Model, Kenteken, Type, Dagprijs, Status))
            {
                return;
            }
            if (!CreateCar(Merk, Model, Kenteken, Type, Dagprijs, Status))
            {
                return;
            }
            MessageBox.Show("Auto aangemaakt!");
            txtMerk.Clear();
            txtModel.Clear();
            txtKenteken.Clear();
            txtType.Clear();
            numDagprijs.Value = 0;
            txtStatus.Clear();
        }

        private static bool ValidateInput(string Merk, string Model, string Kenteken, string Type, decimal Dagprijs, string Status)
        {
            if (string.IsNullOrWhiteSpace(Merk)
                || string.IsNullOrWhiteSpace(Model)
                || string.IsNullOrWhiteSpace(Kenteken)
                || string.IsNullOrWhiteSpace(Type)
                || string.IsNullOrWhiteSpace(Status))
            {
                MessageBox.Show("Niet alles is ingevuld");
                return false;
            }

            if (Dagprijs.Equals(null))
            {
                MessageBox.Show("Geen dagprijs ingevuld. We doen hier niet aan liefdadigheid.");
                return false;
            }

            if (Merk.Length > 255
                || Model.Length > 255
                || Kenteken.Length > 255
                || Type.Length > 255
                || Status.Length > 255
                )
            {
                MessageBox.Show("In");
                return false;
            }

            return true;
        }

        private bool CreateCar(string Merk, string Model, string Kenteken, string Type, decimal Dagprijs, string Status)
        {
            using MySqlConnection conn = new(passwords.ConnStr);
            try
            {
                conn.Open();

                using var cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO car (merk, model, kenteken, type, dagprijs, Status) " +
                    "VALUES (@merk, @model, @kenteken, @type, @dagprijs, @status)";
                cmd.Parameters.AddWithValue("@merk", Merk);
                cmd.Parameters.AddWithValue("@model", Model);
                cmd.Parameters.AddWithValue("@kenteken", Kenteken);
                cmd.Parameters.AddWithValue("@type", Type);
                cmd.Parameters.AddWithValue("@dagprijs", Dagprijs);
                cmd.Parameters.AddWithValue("@status", Status);

                int RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected < 1)
                {
                    MessageBox.Show("Er is een fout opgetreden tijdens het maken van de auto. Probeer het opnieuw.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout opgetreden: {ex.Message} \nStacktrace: {ex.StackTrace}");
            }

            return true;
        }
    }
}
