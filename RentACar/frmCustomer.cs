using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace RentACar
{
    public partial class frmCustomer : Form
    {
        User _user;
        Passwords passwords = new();

        // PAS AAN: de naam van het id-veld in jouw User-klasse
        int UserId => _user.id;

        // ---------- Kleuren (hier kun je het thema aanpassen) ----------
        static readonly Color MenuColor = Color.FromArgb(45, 45, 48);
        static readonly Color MenuHoverColor = Color.FromArgb(63, 63, 70);
        static readonly Color AccentColor = Color.FromArgb(0, 120, 212);
        static readonly Color PageColor = Color.FromArgb(244, 245, 247);
        static readonly Color MutedText = Color.FromArgb(108, 117, 125);

        List<Button> _menuButtons = new();

        internal frmCustomer(User user)
        {
            InitializeComponent();
            _user = user;

            StyleLayout();
            ShowWagenpark();
        }

        private void btnWagenpark_Click(object sender, EventArgs e) => ShowWagenpark();
        private void btnReserveringen_Click(object sender, EventArgs e) => ShowReserveringen();
        private void btnHuurgeschiedenis_Click(object sender, EventArgs e) => ShowHuurgeschiedenis();
        private void btnFacturen_Click(object sender, EventArgs e) => ShowFacturen();

        // ---------- Opmaak ----------

        private void StyleLayout()
        {
            pnlMenu.Width = 220;
            pnlMenu.BackColor = MenuColor;
            pnlContent.BackColor = PageColor;
            pnlContent.Padding = new Padding(32, 24, 32, 24);

            _menuButtons = new() { btnWagenpark, btnReserveringen, btnHuurgeschiedenis, btnFacturen };
            foreach (Button btn in _menuButtons)
            {
                btn.Height = 52;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = MenuColor;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10.5F);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(24, 0, 0, 0);
                btn.Cursor = Cursors.Hand;
                btn.UseVisualStyleBackColor = false;
                btn.FlatAppearance.MouseOverBackColor = MenuHoverColor;
            }

            // titel bovenaan het menu (laatst toegevoegd = bovenaan bij Dock.Top)
            pnlMenu.Controls.Add(new Label
            {
                Text = "RentACar",
                Dock = DockStyle.Top,
                Height = 80,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(24, 0, 0, 0)
            });
        }

        private void SetActive(Button active)
        {
            foreach (Button btn in _menuButtons)
            {
                bool isActive = btn == active;
                btn.BackColor = isActive ? AccentColor : MenuColor;
                btn.FlatAppearance.MouseOverBackColor = isActive ? AccentColor : MenuHoverColor;
            }
        }

        // bouwt een pagina: titel, ondertitel, optioneel een toolbar en de inhoud
        private void ShowPage(Button menuButton, string title, string subtitle, Control body, Control? toolbar = null)
        {
            SetActive(menuButton);

            pnlContent.SuspendLayout();
            pnlContent.Controls.Clear();

            pnlContent.Controls.Add(body);                 // Fill
            if (toolbar != null) pnlContent.Controls.Add(toolbar);
            pnlContent.Controls.Add(new Label
            {
                Text = subtitle,
                Dock = DockStyle.Top,
                Height = 40,
                ForeColor = MutedText,
                Font = new Font("Segoe UI", 10F)
            });
            pnlContent.Controls.Add(new Label
            {
                Text = title,
                Dock = DockStyle.Top,
                Height = 48,
                ForeColor = Color.FromArgb(33, 37, 41),
                Font = new Font("Segoe UI", 22F, FontStyle.Bold)
            });

            pnlContent.ResumeLayout();
        }

        // ---------- Secties ----------

        private void ShowWagenpark()
        {
            DataTable cars = GetTable(
                @"SELECT id AS Id, merk AS Merk, model AS Model, kenteken AS Kenteken,
                         type AS Type, dagprijs AS Dagprijs, Status AS Status
                  FROM car");

            // menu om op type te filteren
            ComboBox cmbType = new()
            {
                Dock = DockStyle.Left,
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10F)
            };
            cmbType.Items.Add("Alle types");
            foreach (string t in cars.AsEnumerable().Select(r => r.Field<string>("Type")!).Distinct().OrderBy(t => t))
                cmbType.Items.Add(t);
            cmbType.SelectedIndex = 0;

            cmbType.SelectedIndexChanged += (s, e) =>
            {
                cars.DefaultView.RowFilter = cmbType.SelectedIndex == 0
                    ? ""
                    : $"[Type] = '{cmbType.Text.Replace("'", "''")}'";
            };

            Panel toolbar = new() { Dock = DockStyle.Top, Height = 48, Padding = new Padding(0, 0, 0, 12) };
            toolbar.Controls.Add(cmbType);

            ShowPage(btnWagenpark, "Wagenpark", "Alle auto's die je kunt huren", BuildBody(cars), toolbar);
        }

        private void ShowReserveringen()
        {
            DataTable table = GetTable(ReserveringQuery(""), UserId);
            ShowPage(btnReserveringen, "Reserveringen", "Al je reserveringen", BuildBody(table));
        }

        private void ShowHuurgeschiedenis()
        {
            DataTable table = GetTable(ReserveringQuery("AND r.enddate < NOW()"), UserId);
            ShowPage(btnHuurgeschiedenis, "Huurgeschiedenis", "Verhuurperiodes die zijn afgelopen", BuildBody(table));
        }

        private void ShowFacturen()
        {
            DataTable table = GetTable(
                @"SELECT i.id AS Factuurnummer, r.id AS Reservering,
                         i.dagprijs_bij_boeking AS DagprijsBijBoeking,
                         i.total_price AS Totaalprijs, i.status AS Status
                  FROM invoice i
                  JOIN reservering r ON r.invoice_id = i.id
                  WHERE r.customer_id = @id
                  ORDER BY i.id DESC", UserId);
            ShowPage(btnFacturen, "Facturen", "Je facturen op een rij", BuildBody(table));
        }

        // ---------- Hulpmethodes ----------

        private static string ReserveringQuery(string extraWhere) =>
            $@"SELECT r.id AS Reservering, r.startdate AS Startdatum, r.enddate AS Einddatum,
                      GROUP_CONCAT(CONCAT(c.merk, ' ', c.model) SEPARATOR ', ') AS Auto,
                      i.total_price AS Totaalprijs
               FROM reservering r
               LEFT JOIN reservering_car rc ON rc.reservering_id = r.id
               LEFT JOIN car c ON c.id = rc.car_id
               LEFT JOIN invoice i ON i.id = r.invoice_id
               WHERE r.customer_id = @id {extraWhere}
               GROUP BY r.id, r.startdate, r.enddate, i.total_price
               ORDER BY r.startdate DESC";

        private DataTable GetTable(string query, int? userId = null)
        {
            DataTable table = new();
            try
            {
                using MySqlConnection conn = new(passwords.ConnStr);
                using MySqlCommand cmd = new(query, conn);
                if (userId != null) cmd.Parameters.AddWithValue("@id", userId);

                using MySqlDataAdapter adapter = new(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden. {ex.Message}");
            }
            return table;
        }

        // grid met data, of een nette melding als er niks is
        private Control BuildBody(DataTable table)
        {
            if (table.Rows.Count == 0)
            {
                return new Label
                {
                    Text = "Er zijn nog geen gegevens om te tonen.",
                    Dock = DockStyle.Fill,
                    BackColor = Color.White,
                    ForeColor = MutedText,
                    Font = new Font("Segoe UI", 12F),
                    TextAlign = ContentAlignment.MiddleCenter
                };
            }

            DataGridView grid = CreateGrid();
            grid.DataSource = table;
            FormatColumns(grid);
            return grid;
        }

        private static DataGridView CreateGrid()
        {
            DataGridView grid = new()
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(230, 232, 236),
                EnableHeadersVisualStyles = false,
                ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                ColumnHeadersHeight = 44
            };

            grid.RowTemplate.Height = 40;
            grid.Font = new Font("Segoe UI", 10F);

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(73, 80, 87);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(73, 80, 87);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(222, 237, 252);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 37, 41);
            grid.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);

            return grid;
        }

        // datums, bedragen en kolomkoppen netjes weergeven
        private static void FormatColumns(DataGridView grid)
        {
            CultureInfo nl = new("nl-NL");

            foreach (DataGridViewColumn col in grid.Columns)
            {
                switch (col.Name)
                {
                    case "Startdatum":
                    case "Einddatum":
                        col.DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
                        break;

                    case "Dagprijs":
                    case "DagprijsBijBoeking":
                    case "Totaalprijs":
                        col.DefaultCellStyle.Format = "€ #,##0";
                        col.DefaultCellStyle.FormatProvider = nl;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;

                    case "Id":
                    case "Reservering":
                    case "Factuurnummer":
                        col.FillWeight = 40;   // smalle id-kolommen
                        break;
                }

                if (col.Name == "DagprijsBijBoeking") col.HeaderText = "Dagprijs bij boeking";
            }
        }
    }
}