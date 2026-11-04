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
        internal frmEditCar(Car car)
        {
            InitializeComponent();
            _car = car;
            if (car == null)
            {
                MessageBox.Show("Geen auto gevonden");
                return;
            }
            txtMerkEdit.Text = car.merk ?? "Onbekend";
            txtModelEdit.Text = car.model ?? "Onbekend";
            txtKentekenEdit.Text = car.kenteken ?? "Onbekend";
            txtTypeEdit.Text = car.type ?? "Onbekend";
            numDagprijsEdit.Value = car?.dagprijs ?? 0;
            txtStatusEdit.Text = car.status ?? "Onbekend";
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
