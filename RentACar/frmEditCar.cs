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
    public partial class frmEditCar : Form
    {
        readonly Car _car;
        readonly User _user;
        readonly Passwords passwords = new();

        internal frmEditCar(Car car, User user)
        {
            InitializeComponent();
            _user = user;
            _car = car;
            if (!EnsureCarAndUserExistAndAreAllowed()) return;

            txtMerkEdit.Text = car.merk ?? "Onbekend";
            txtModelEdit.Text = car.model ?? "Onbekend";
            txtKentekenEdit.Text = car.kenteken ?? "Onbekend";
            txtTypeEdit.Text = car.type ?? "Onbekend";
            numDagprijsEdit.Value = car?.dagprijs ?? 0;
            txtStatusEdit.Text = car.status ?? "Onbekend";

            numDagprijsEdit.Maximum = 100000;
        }

        private bool EnsureCarAndUserExistAndAreAllowed()
        {
            if (_user == null)
            {
                MessageBox.Show("Geen gebruiker gevonden.");
                this.Close();
                return false;
            }

            if (_user.role == "customer")
            {
                MessageBox.Show("Klanten mogen hier niet zijn.");
                this.Close();
                return false;
            }

            if (_car == null)
            {
                MessageBox.Show("Geen auto gevonden");
                return false;
            }

            return true;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je het zeker? Niet opgeslagen data gaat verloren",
                "Afsluiten",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string Merk = txtMerkEdit.Text;
            string Model = txtModelEdit.Text;
            string Kenteken = txtKentekenEdit.Text;
            string Type = txtTypeEdit.Text;
            decimal Dagprijs = numDagprijsEdit.Value;
            string Status = txtStatusEdit.Text;
            if (!ValidateInput(Merk, Model, Kenteken, Type, Dagprijs, Status)) return;

            if (!EditCar(Merk, Model, Kenteken, Type, Dagprijs, Status)) return;
            MessageBox.Show("Auto bewerkt! Sluit dit bericht om de pagina af te sluiten.");

            this.Close();
        }

        private static bool ValidateInput(string Merk, string Model, string Kenteken, string Type, decimal Dagprijs, string Status)
        {
            if (string.IsNullOrWhiteSpace(Merk)
                            || string.IsNullOrWhiteSpace(Model)
                            || string.IsNullOrWhiteSpace(Kenteken)
                            || string.IsNullOrWhiteSpace(Type)
                            || string.IsNullOrWhiteSpace(Status)
                            )
            {
                MessageBox.Show("Niet alle gegevens zijn ingevuld.");
                return false;
            }

            if (Dagprijs <= 0)
            {
                MessageBox.Show("Auto moet wel een prijs hebben.");
                return false;
            }

            if (Merk.Length > 255 || Kenteken.Length > 255 || Type.Length > 255 | Status.Length > 255)
            {
                MessageBox.Show("Input mag maximaal 255 karakters zijn.");
                return false;
            }

            return true;
        }

        private bool EditCar(string Merk, string Model, string Kenteken, string Type, decimal Dagprijs, string Status)
        {
            if (Merk == _car.merk
                && Model == _car.model
                && Kenteken == _car.kenteken
                && Type == _car.type
                && Status == _car.status
                )
            {
                MessageBox.Show("Niks aangepast");
                return false;
            }

            using MySqlConnection conn = new(passwords.ConnStr);
            try
            {
                conn.Open();

                using var cmd = conn.CreateCommand();

                // waarom is ook alleen status met hoofdletter??? wat was ik aan het doen
                cmd.CommandText = "UPDATE car set merk=@merk, model=@model, kenteken=@kenteken, type=@type, dagprijs=@dagprijs, Status=@status " +
                    "WHERE id=@id";
                cmd.Parameters.AddWithValue("@merk", Merk);
                cmd.Parameters.AddWithValue("@model", Model);
                cmd.Parameters.AddWithValue("@kenteken", Kenteken);
                cmd.Parameters.AddWithValue("@type", Type);
                cmd.Parameters.AddWithValue("@dagprijs", Dagprijs);
                cmd.Parameters.AddWithValue("@status", Status);
                cmd.Parameters.AddWithValue("@id", _car.id);

                int RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected <= 0)
                {
                    MessageBox.Show("Auto kon niet worden bijgewerkt. Probeer het later opnieuw.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden. {ex.Message} \nStacktrace: {ex.StackTrace} \n{ex.Data}");
            }


            return true;
        }
    }
}
