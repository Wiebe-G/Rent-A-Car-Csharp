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
    public partial class userCtrlAdminPlanning : UserControl
    {
        Passwords passwords = new();
        List<User> employees = [];
        List<Planning> planning = [];
        public userCtrlAdminPlanning()
        {
            InitializeComponent();

            FetchEmployeesAndPlanning();
        }

        internal void FetchEmployeesAndPlanning()
        {
            int index = 0;
            using MySqlConnection conn = new(passwords.ConnStr);

            conn.Open();

            string query = "SELECT user.user_id, user.role_id, user.fname, user.lname, user.status, " +
                "planning.employee_id, planning.date, planning.starttime, planning.endtime " +
                "FROM user " +
                "JOIN planning ON planning.employee_id = user.user_id " +
                "WHERE user.role_id = 2 " +
                "AND status = 1";

            using MySqlCommand cmd = new(query, conn);

            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employees.Insert(index, new User
                {
                    id = reader.GetInt32("user_id"),
                    role = "medewerker",
                    fname = reader.GetString("fname"),
                    lname = reader.GetString("lname"),
                    status = reader.GetInt32("status"),
                });
                planning.Insert(index, new Planning
                {
                    employee_id = reader.GetInt32("employee_id"),
                    date = reader.GetDateTime("date").Date,
                    starttime = (TimeSpan)reader.GetValue(reader.GetOrdinal("starttime")),
                    endtime = (TimeSpan)reader.GetValue(reader.GetOrdinal("endtime"))
                });
                index++;
            }
            MessageBox.Show($"{employees.Count}");
            RenderEmployeeChoicesOnLeftSide();
        }

        internal void RenderEmployeeChoicesOnLeftSide()
        {
            foreach (var emp in employees)
            {
                Button btn = new()
                {
                    Dock = DockStyle.Fill,
                    Text = $"{emp.fname} {emp.lname}"
                };
                pnlTabSelectEmployee.RowCount++;
                pnlTabSelectEmployee.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }
    }
}
