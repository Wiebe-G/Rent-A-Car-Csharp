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
        Car car;
        internal frmEditCar(Car _car)
        {
            InitializeComponent();
            car = _car;
            txtMerkEdit.Text = car.merk;
            txtModelEdit.Text = car.model;
            txtKentekenEdit.Text = car.kenteken;
            txtTypeEdit.Text = car.type;
            numDagprijsEdit.Value = car.dagprijs;
            txtStatusEdit.Text = car.status;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
