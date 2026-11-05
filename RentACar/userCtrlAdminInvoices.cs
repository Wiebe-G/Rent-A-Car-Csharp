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
    public partial class userCtrlAdminInvoices : UserControl
    {
        readonly User _user;
        Passwords passwords = new();
        List<Invoice> invoices = [];
        internal userCtrlAdminInvoices(User user)
        {
            InitializeComponent();
            _user = user;

            if (!CheckThatUserExistsAndIsOwner()) return;

            RenderInvoices();
        }

        internal bool CheckThatUserExistsAndIsOwner()
        {
            if (_user == null)
            {
                MessageBox.Show("Geen gebruiker gevonden.");
                return false;
            }

            if (_user.role != "owner")
            {
                MessageBox.Show("Alleen eigenaren mogen hier komen.");
                return false;
            }

            return true;
        }

        internal void RenderInvoices()
        {
            // om bij reservering te komen, doe je dat zo
            //Invoice inv = new();
            //MessageBox.Show($"{inv.reservering.startdate}");

            FetchInvoiceData();
        }

        private void FetchInvoiceData()
        {
            int index = 0;
            MySqlConnection conn = new(passwords.ConnStr);
            try
            {
                conn.Open();

                string query = "SELECT inv.* " +
                    "FROM invoice inv " +
                    "INNER JOIN reservering res ON res.invoice_id = inv.id" +
                    "INNER JOIN reservering_car res_car ON car.id";

                using MySqlCommand cmd = new(query, conn);

                using MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show($"Reader heeft nu {reader[index]}");
                    invoices.Insert(index, new Invoice
                    {
                        // zet hier de data uit de db in de vorm van Invoice.cs
                    });

                    index++;
                }
                MessageBox.Show(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden. {ex.Message} \nStacktrace: {ex.StackTrace} \n{ex.Data}");
            }
        }
    }
}
