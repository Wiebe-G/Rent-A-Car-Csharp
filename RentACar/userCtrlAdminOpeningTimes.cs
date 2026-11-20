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
            LoadOpeningTimes();
        }

        private void userCtrlAdminOpeningTimes_Load(object sender, EventArgs e)
        {

        }

        private void pnlTabOpeningTimes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadOpeningTimes()
        {
            MessageBox.Show("In deze method moeten de tijden worden opgehaald");
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

            if (!CreateOpeningTimes(MonOpen, MonClose, TueOpen, TueClose, WedOpen, WedClose, ThuOpen, ThuClose, FriOpen, FriClose, SatOpen, SatClose, SunOpen, SunClose))
            {
                return;
            }
        }

        private bool CreateOpeningTimes(TimeOnly? MonOpen, TimeOnly? MonClose, TimeOnly? TueOpen, TimeOnly? TueClose, TimeOnly? WedOpen, TimeOnly? WedClose, TimeOnly? ThuOpen, TimeOnly? ThuClose, TimeOnly? FriOpen, TimeOnly? FriClose, TimeOnly? SatOpen, TimeOnly? SatClose, TimeOnly? SunOpen, TimeOnly? SunClose)
        {
            MySqlConnection conn = new(passwords.ConnStr);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            // BOMBOCLAT wat een query
            cmd.CommandText = "UPDATE opening_times SET open = case day " +
                "WHEN 'mon' THEN @MonOpen " +
                "WHEN 'tue' THEN @TueOpen " +
                "WHEN 'wed' THEN @WedOpen " +
                "WHEN 'thu' THEN @ThuOpen " +
                "WHEN 'fri' THEN @FriOpen " +
                "WHEN 'sat' THEN @SatOpen " +
                "WHEN 'sun' THEN @SunOpen " +
                "ELSE null " +
                "end, close = case day " +
                "WHEN 'mon' THEN @MonClose " +
                "WHEN 'tue' THEN @TueClose " +
                "WHEN 'wed' THEN @WedClose " +
                "WHEN 'thu' THEN @ThuClose " +
                "WHEN 'fri' THEN @FriClose " +
                "WHEN 'sat' THEN @SatClose " +
                "WHEN 'sun' THEN @SunClose " +
                "end";
            cmd.Parameters.AddWithValue("@MonOpen", MonOpen);
            cmd.Parameters.AddWithValue("@TueOpen", TueOpen);
            cmd.Parameters.AddWithValue("@WedOpen", WedOpen);
            cmd.Parameters.AddWithValue("@ThuOpen", ThuOpen);
            cmd.Parameters.AddWithValue("@FriOpen", FriOpen);
            cmd.Parameters.AddWithValue("@SatOpen", SatOpen);
            cmd.Parameters.AddWithValue("@SunOpen", SunOpen);

            cmd.Parameters.AddWithValue("@MonClose", MonClose);
            cmd.Parameters.AddWithValue("@TueClose", TueClose);
            cmd.Parameters.AddWithValue("@WedClose", WedClose);
            cmd.Parameters.AddWithValue("@ThuClose", ThuClose);
            cmd.Parameters.AddWithValue("@FriClose", FriClose);
            cmd.Parameters.AddWithValue("@SatClose", SatClose);
            cmd.Parameters.AddWithValue("@SunClose", SunClose);

            int RowsAffected = cmd.ExecuteNonQuery();

            if (RowsAffected < 0)
            {
                MessageBox.Show("Er is een probleem opgetreden. Probeer het later opnieuw.");
                return false;
            }

            return true;
        }
    }
}
