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

            cmbSelectEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            pnlTabPlanningTemp.AutoScroll = true;
            pnlTabPlanningTemp.RowStyles.Clear();
            pnlTabPlanningTemp.RowCount = 0;

            cmbWhoToPlanIn.DropDownStyle = ComboBoxStyle.DropDownList;

            FetchEmployeesAndPlanning();
            RenderEmployeesForMakingPlanning();
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
                "AND user.status = 1 " +
                "AND planning.date >=  CURDATE()";

            using MySqlCommand cmd = new(query, conn);

            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int userId = reader.GetInt32("user_id");
                if (!employees.Any(e => e.id == userId))
                {
                    employees.Insert(index, new User
                    {
                        id = reader.GetInt32("user_id"),
                        role = "medewerker",
                        fname = reader.GetString("fname"),
                        lname = reader.GetString("lname"),
                        status = reader.GetInt32("status"),
                    });
                }
                planning.Insert(index, new Planning
                {
                    employee_id = reader.GetInt32("employee_id"),
                    date = reader.GetDateTime("date").Date,
                    starttime = (TimeSpan)reader.GetValue(reader.GetOrdinal("starttime")),
                    endtime = (TimeSpan)reader.GetValue(reader.GetOrdinal("endtime"))
                });
                index++;
            }
            RenderEmployeeChoicesOnLeftSide();
        }

        internal void RenderEmployeeChoicesOnLeftSide()
        {
            var items = employees
                .Select(emp => new KeyValuePair<int, string>(emp.id, $"{emp.fname} {emp.lname}"))
                .ToList();
            cmbSelectEmployee.DisplayMember = "Value";
            cmbSelectEmployee.ValueMember = "Key";
            cmbSelectEmployee.DataSource = items;
        }

        private void cmbSelectEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectEmployee.SelectedValue is not int employeeId)
                return;

            List<Planning> filteredPlanning = planning
                .Where(p => p.employee_id == employeeId)
                .ToList();

            pnlTabPlanningTemp.Controls.Clear();

            //if (filteredPlanning.Count > 0)
            //{
            foreach (var pl in filteredPlanning)
            {
                Label lbl = new()
                {
                    Dock = DockStyle.Fill,
                    Text = $"{DateOnly.FromDateTime(pl.date)} vanaf {pl.starttime} tot {pl.endtime}",
                    AutoSize = true
                };
                pnlTabPlanningTemp.Controls.Add(lbl);
                //}
            }
        }

        private void RenderEmployeesForMakingPlanning()
        {
            var Items = employees
                .Select(emp => new KeyValuePair<int, string>(emp.id, $"{emp.fname} {emp.lname}"))
                .ToList();
            cmbWhoToPlanIn.DisplayMember = "Value";
            cmbWhoToPlanIn.ValueMember = "Key";
            cmbWhoToPlanIn.DataSource = Items;
        }

        private void btnSavePlanning_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{cmbWhoToPlanIn.SelectedValue ?? "test"}");
        }
    }
}
