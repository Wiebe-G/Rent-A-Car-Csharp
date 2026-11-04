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
    public partial class userCtrlCarListing : UserControl
    {
        readonly User _user;
        Car _car;
        internal userCtrlCarListing(Car car, User user)
        {
            InitializeComponent();
            _user = user;
            if (user == null) btnEditCar.Enabled = false;
            btnEditCar.Enabled = user.role != "customer";

            _car = car;
            // zet dit naar echte foto van auto wanneer dat een ding wordt
            picCarPhoto.ImageLocation =
                "https://imgs.search.brave.com/-UIo6AqCwCL-KxgjS1CpkhdIJ51fY42qwV-gsnLoEqg/rs:fit:500:0:1:0/g:ce/aHR0cHM6Ly90NC5m/dGNkbi5uZXQvanBn/LzA2LzEyLzQ0LzY1/LzM2MF9GXzYxMjQ0/NjUxOF80NlU3M05C/Ump3bnFHOE16WkN0/WnNKekIwQWJLNktP/YS5qcGc";
            lblMerk.Text = $"Merk: {car.merk}";
            lblModel.Text = $"Model: {car.model}";
            lblKenteken.Text = $"Kenteken: {car.kenteken}";
            lblType.Text = $"Type: {car.type}";
            lblDagprijs.Text = $"Dagprijs: {car.dagprijs}";
            lblStatus.Text = $"Status: {car.status}";
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            frmEditCar edit = new(_car, _user);
            edit.Show();
        }
    }
}
