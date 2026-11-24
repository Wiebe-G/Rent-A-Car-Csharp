using MySql.Data.MySqlClient;

namespace RentACar
{
    public partial class userCtrlAdminOpeningTimes : UserControl
    {
        Passwords passwords = new();
        Dictionary<string, (TimeOnly? Open, TimeOnly? Close)> OpeningTimes = new()
        {
            ["mon"] = (null, null),
            ["tue"] = (null, null),
            ["wed"] = (null, null),
            ["thu"] = (null, null),
            ["fri"] = (null, null),
            ["sat"] = (null, null),
            ["sun"] = (null, null)
        };

        public userCtrlAdminOpeningTimes()
        {
            InitializeComponent();
            LoadOpeningTimes();
        }

        private void LoadOpeningTimes()
        {
            using MySqlConnection conn = new(passwords.ConnStr);

            conn.Open();

            string query = "SELECT * FROM opening_times";

            using MySqlCommand cmd = new(query, conn);

            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TimeOnly? Open = null;
                TimeOnly? Close = null;

                if (!reader.IsDBNull(reader.GetOrdinal("open")))
                {
                    Open = TimeOnly.FromTimeSpan(reader.GetTimeSpan("open"));
                }

                if (!reader.IsDBNull(reader.GetOrdinal("close")))
                {
                    Close = TimeOnly.FromTimeSpan(reader.GetTimeSpan("close"));
                }

                OpeningTimes[reader.GetString("day")] = (Open, Close);
            }
            RenderOpeningTimes();
        }

        private void RenderOpeningTimes()
        {
            if (OpeningTimes["mon"].Open == null
                || OpeningTimes["mon"].Close == null)
            {
                dateTimeMon.Enabled = false;
                dateTimeMonClosed.Enabled = false;
                chkMonClosed.Checked = true;
            }
            else
            {
                dateTimeMon.Value = DateTime.Today.Add(OpeningTimes["mon"].Open!.Value.ToTimeSpan());
                dateTimeMonClosed.Value = DateTime.Today.Add(OpeningTimes["mon"].Close!.Value.ToTimeSpan());
            }

            if (OpeningTimes["tue"].Open == null
                || OpeningTimes["tue"].Close == null)
            {
                dateTimeTue.Enabled = false;
                dateTimeTueClosed.Enabled = false;
                chkTueClosed.Checked = true;
            }
            else
            {
                dateTimeTue.Value = DateTime.Today.Add(OpeningTimes["tue"].Open!.Value.ToTimeSpan());
                dateTimeTueClosed.Value = DateTime.Today.Add(OpeningTimes["tue"].Close!.Value.ToTimeSpan());
            }

            if (OpeningTimes["wed"].Open == null
                || OpeningTimes["wed"].Close == null)
            {
                dateTimeWed.Enabled = false;
                dateTimeWedClosed.Enabled = false;
                chkWedClosed.Checked = true;
            }
            else
            {
                dateTimeWed.Value = DateTime.Today.Add(OpeningTimes["wed"].Open!.Value.ToTimeSpan());
                dateTimeWedClosed.Value = DateTime.Today.Add(OpeningTimes["wed"].Close!.Value.ToTimeSpan());
            }

            if (OpeningTimes["thu"].Open == null
                || OpeningTimes["thu"].Close == null)
            {
                dateTimeThu.Enabled = false;
                dateTimeThuClosed.Enabled = false;
                chkThuClosed.Checked = true;
            }
            else
            {
                dateTimeThu.Value = DateTime.Today.Add(OpeningTimes["thu"].Open!.Value.ToTimeSpan());
                dateTimeThuClosed.Value = DateTime.Today.Add(OpeningTimes["thu"].Close!.Value.ToTimeSpan());
            }

            if (OpeningTimes["fri"].Open == null
                || OpeningTimes["fri"].Close == null)
            {
                dateTimeFri.Enabled = false;
                dateTimeFriClosed.Enabled = false;
                chkFriClosed.Checked = true;
            }
            else
            {
                dateTimeFri.Value = DateTime.Today.Add(OpeningTimes["fri"].Open!.Value.ToTimeSpan());
                dateTimeFriClosed.Value = DateTime.Today.Add(OpeningTimes["fri"].Close!.Value.ToTimeSpan());
            }

            if (OpeningTimes["sat"].Open == null
                || OpeningTimes["sat"].Close == null)
            {
                dateTimeSat.Enabled = false;
                dateTimeSatClosed.Enabled = false;
                chkSatClosed.Checked = true;
            }
            else
            {
                dateTimeSat.Value = DateTime.Today.Add(OpeningTimes["sat"].Open!.Value.ToTimeSpan());
                dateTimeSatClosed.Value = DateTime.Today.Add(OpeningTimes["sat"].Close!.Value.ToTimeSpan());
            }

            if (OpeningTimes["sun"].Open == null
                || OpeningTimes["sun"].Close == null)
            {
                dateTimeSun.Enabled = false;
                dateTimeSunClosed.Enabled = false;
                chkSunClosed.Checked = true;
            }
            else
            {
                dateTimeSun.Value = DateTime.Today.Add(OpeningTimes["sun"].Open!.Value.ToTimeSpan());
                dateTimeSunClosed.Value = DateTime.Today.Add(OpeningTimes["sun"].Close!.Value.ToTimeSpan());
            }
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

            MessageBox.Show("Tijden zijn aangepast!");
        }

        private bool CreateOpeningTimes(TimeOnly? MonOpen, TimeOnly? MonClose, TimeOnly? TueOpen, TimeOnly? TueClose, TimeOnly? WedOpen, TimeOnly? WedClose, TimeOnly? ThuOpen, TimeOnly? ThuClose, TimeOnly? FriOpen, TimeOnly? FriClose, TimeOnly? SatOpen, TimeOnly? SatClose, TimeOnly? SunOpen, TimeOnly? SunClose)
        {
            MySqlConnection conn = new(passwords.ConnStr);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            var OpeningTimes = new Dictionary<string, (TimeOnly? Open, TimeOnly? Close)>
            {
                ["mon"] = (MonOpen, MonClose),
                ["tue"] = (TueOpen, TueClose),
                ["wed"] = (WedOpen, WedClose),
                ["thu"] = (ThuOpen, ThuClose),
                ["fri"] = (FriOpen, FriClose),
                ["sat"] = (SatOpen, SatClose),
                ["sun"] = (SunOpen, SunClose)
            };

            cmd.CommandText = @"UPDATE opening_times " +
                                "SET open=@Open, close=@Close " +
                                "WHERE day=@Day";
            //cmd.Parameters.AddWithValue("@MonOpen", MonOpen);
            //cmd.Parameters.AddWithValue("@TueOpen", TueOpen);
            //cmd.Parameters.AddWithValue("@WedOpen", WedOpen);
            //cmd.Parameters.AddWithValue("@ThuOpen", ThuOpen);
            //cmd.Parameters.AddWithValue("@FriOpen", FriOpen);
            //cmd.Parameters.AddWithValue("@SatOpen", SatOpen);
            //cmd.Parameters.AddWithValue("@SunOpen", SunOpen);

            //cmd.Parameters.AddWithValue("@MonClose", MonClose);
            //cmd.Parameters.AddWithValue("@TueClose", TueClose);
            //cmd.Parameters.AddWithValue("@WedClose", WedClose);
            //cmd.Parameters.AddWithValue("@ThuClose", ThuClose);
            //cmd.Parameters.AddWithValue("@FriClose", FriClose);
            //cmd.Parameters.AddWithValue("@SatClose", SatClose);
            //cmd.Parameters.AddWithValue("@SunClose", SunClose);

            foreach (var (day, times) in OpeningTimes)
            {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Open", (object?)times.Open ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Close", (object?)times.Close ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Day", day);

                int RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected < 0)
                {
                    MessageBox.Show("Er is een probleem opgetreden. Probeer het later opnieuw.");
                    return false;
                }
            }

            return true;
        }
    }
}
