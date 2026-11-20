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
    public partial class userCtrlAdminOpeningTimes : UserControl
    {
        Passwords passwords = new();
        public userCtrlAdminOpeningTimes()
        {
            InitializeComponent();
        }

        private void userCtrlAdminOpeningTimes_Load(object sender, EventArgs e)
        {

        }

        private void pnlTabOpeningTimes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeEnabledForOpened(object sender, EventArgs e)
        {
            if (sender is not CheckBox)
            {
                return;
            }

            CheckBox chk = sender as CheckBox;
            string Name = chk.Name[3..6];

            switch (Name.ToLower())
            {
                case "mon":
                    dateTimeMon.Enabled = !dateTimeMon.Enabled;
                    dateTimeMonClosed.Enabled = !dateTimeMonClosed.Enabled;
                    break;
                case "tue":
                    dateTimeTue.Enabled = !dateTimeTue.Enabled;
                    dateTimeTueClosed.Enabled = !dateTimeTueClosed.Enabled;
                    break;
                case "wed":
                    dateTimeWed.Enabled = !dateTimeWed.Enabled;
                    dateTimeWedClosed.Enabled = !dateTimeWedClosed.Enabled;
                    break;
                case "thu":
                    dateTimeThu.Enabled = !dateTimeThu.Enabled;
                    dateTimeThuClosed.Enabled = !dateTimeThuClosed.Enabled;
                    break;
                case "fri":
                    dateTimeFri.Enabled = !dateTimeFri.Enabled;
                    dateTimeFriClosed.Enabled = !dateTimeFriClosed.Enabled;
                    break;
                case "sat":
                    dateTimeSat.Enabled = !dateTimeSat.Enabled;
                    dateTimeSatClosed.Enabled = !dateTimeSatClosed.Enabled;
                    break;
                case "sun":
                    dateTimeSun.Enabled = !dateTimeSun.Enabled;
                    dateTimeSunClosed.Enabled = !dateTimeSunClosed.Enabled;
                    break;
                default:
                    break;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            TimeOnly? MonOpen = null;
            TimeOnly? MonClose = null;
            TimeOnly? TueOpen = null;
            TimeOnly? TueClose = null;
            TimeOnly? WedOpen = null;
            TimeOnly? WedClose = null;
            TimeOnly? ThuOpen = null;
            TimeOnly? ThuClose = null;
            TimeOnly? FriOpen = null;
            TimeOnly? FriClose = null;
            TimeOnly? SatOpen = null;
            TimeOnly? SatClose = null;
            TimeOnly? SunOpen = null;
            TimeOnly? SunClose = null;

            if (dateTimeMon.Enabled)
            {
                MonOpen = TimeOnly.FromTimeSpan(dateTimeMon.Value.TimeOfDay);
                MonClose = TimeOnly.FromTimeSpan(dateTimeMonClosed.Value.TimeOfDay);
            }

            if (dateTimeTue.Enabled)
            {
                TueOpen = TimeOnly.FromTimeSpan(dateTimeTue.Value.TimeOfDay);
                TueClose = TimeOnly.FromTimeSpan(dateTimeTueClosed.Value.TimeOfDay);
            }

            if (dateTimeWed.Enabled)
            {
                WedOpen = TimeOnly.FromTimeSpan(dateTimeWed.Value.TimeOfDay);
                WedClose = TimeOnly.FromTimeSpan(dateTimeWedClosed.Value.TimeOfDay);
            }

            if (dateTimeThu.Enabled)
            {
                ThuOpen = TimeOnly.FromTimeSpan(dateTimeThu.Value.TimeOfDay);
                ThuClose = TimeOnly.FromTimeSpan(dateTimeThuClosed.Value.TimeOfDay);
            }

            if (dateTimeFri.Enabled)
            {
                FriOpen = TimeOnly.FromTimeSpan(dateTimeFri.Value.TimeOfDay);
                FriClose = TimeOnly.FromTimeSpan(dateTimeFriClosed.Value.TimeOfDay);
            }

            if (dateTimeSat.Enabled)
            {
                SatOpen = TimeOnly.FromTimeSpan(dateTimeSat.Value.TimeOfDay);
                SatClose = TimeOnly.FromTimeSpan(dateTimeSatClosed.Value.TimeOfDay);
            }

            if (dateTimeSun.Enabled)
            {
                SunOpen = TimeOnly.FromTimeSpan(dateTimeSun.Value.TimeOfDay);
                SunClose = TimeOnly.FromTimeSpan(dateTimeSunClosed.Value.TimeOfDay);
            }

            using MySqlConnection conn = new(passwords.ConnStr);

            conn.Open();
        }
    }
}
