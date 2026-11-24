using System.Data;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;

namespace RentACar
{
    public partial class frmEmployeeCustomers : UserControl
    {
        private readonly Passwords _passwords = new();

        internal frmEmployeeCustomers()
        {
            InitializeComponent();
        }

        private void frmEmployeeCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomerInput())
            {
                return;
            }

            try
            {
                using MySqlConnection connection = new(_passwords.ConnStr);
                connection.Open();

                using MySqlTransaction transaction = connection.BeginTransaction();

                const string duplicateEmailQuery = """
                    SELECT COUNT(*)
                    FROM `user`
                    WHERE email = @email;
                    """;

                using MySqlCommand duplicateEmailCommand =
                    new(duplicateEmailQuery, connection, transaction);

                duplicateEmailCommand.Parameters.AddWithValue(
                    "@email",
                    txtEmail.Text.Trim());

                if (Convert.ToInt32(
                    duplicateEmailCommand.ExecuteScalar()) > 0)
                {
                    transaction.Rollback();

                    MessageBox.Show(
                        "Er bestaat al een klant met dit e-mailadres.",
                        "E-mailadres bestaat al",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                const string addressQuery = """
                    INSERT INTO user_address
                        (streetname, zipcode, city)
                    VALUES
                        (@streetname, @zipcode, @city);
                    """;

                using MySqlCommand addressCommand =
                    new(addressQuery, connection, transaction);

                addressCommand.Parameters.AddWithValue(
                    "@streetname",
                    txtStreetname.Text.Trim());
                addressCommand.Parameters.AddWithValue(
                    "@zipcode",
                    txtZipcode.Text.Trim());
                addressCommand.Parameters.AddWithValue(
                    "@city",
                    txtCity.Text.Trim());

                addressCommand.ExecuteNonQuery();

                long addressId = addressCommand.LastInsertedId;
                string passwordHash =
                    BC.HashPassword(txtPassword.Text, workFactor: 12);

                const string userQuery = """
                    INSERT INTO `user`
                    (
                        role_id,
                        user_address_id,
                        fname,
                        lname,
                        email,
                        password,
                        status,
                        created_at,
                        updated_at
                    )
                    VALUES
                    (
                        1,
                        @address_id,
                        @fname,
                        @lname,
                        @email,
                        @password,
                        1,
                        @created_at,
                        @updated_at
                    );
                    """;

                using MySqlCommand userCommand =
                    new(userQuery, connection, transaction);

                DateTime now = DateTime.Now;

                userCommand.Parameters.AddWithValue("@address_id", addressId);
                userCommand.Parameters.AddWithValue(
                    "@fname",
                    txtFirstName.Text.Trim());
                userCommand.Parameters.AddWithValue(
                    "@lname",
                    txtLastName.Text.Trim());
                userCommand.Parameters.AddWithValue(
                    "@email",
                    txtEmail.Text.Trim());
                userCommand.Parameters.AddWithValue("@password", passwordHash);
                userCommand.Parameters.AddWithValue("@created_at", now);
                userCommand.Parameters.AddWithValue("@updated_at", now);

                userCommand.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show(
                    "De klant is succesvol toegevoegd.",
                    "Klant toegevoegd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearCustomerInput();
                LoadCustomers();
            }
            catch (MySqlException exception) when (exception.Number == 1062)
            {
                MessageBox.Show(
                    "Er bestaat al een klant met dit e-mailadres.",
                    "E-mailadres bestaat al",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"De klant kon niet worden toegevoegd.\n\n{exception.Message}",
                    "Databasefout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadCustomers()
        {
            try
            {
                using MySqlConnection connection = new(_passwords.ConnStr);
                connection.Open();

                const string query = """
                    SELECT
                        u.user_id,
                        u.fname,
                        u.lname,
                        u.email,
                        CASE
                            WHEN u.status = 1 THEN 'Actief'
                            ELSE 'Inactief'
                        END AS status,
                        a.streetname,
                        a.zipcode,
                        a.city
                    FROM `user` u
                    LEFT JOIN user_address a
                        ON a.id = u.user_address_id
                    WHERE u.role_id = 1
                      AND (
                            @search = ''
                            OR u.fname LIKE @searchLike
                            OR u.lname LIKE @searchLike
                            OR u.email LIKE @searchLike
                          )
                    ORDER BY u.lname, u.fname;
                    """;

                using MySqlCommand command = new(query, connection);

                string search = txtCustomerSearch.Text.Trim();

                command.Parameters.AddWithValue("@search", search);
                command.Parameters.AddWithValue("@searchLike", $"%{search}%");

                using MySqlDataAdapter adapter = new(command);
                DataTable customers = new();
                adapter.Fill(customers);

                dgvCustomers.DataSource = customers;

                ConfigureCustomerGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"De klanten konden niet worden geladen.\n\n{exception.Message}",
                    "Databasefout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigureCustomerGrid()
        {
            if (dgvCustomers.Columns["user_id"] != null)
            {
                dgvCustomers.Columns["user_id"].Visible = false;
            }

            SetHeader("fname", "Voornaam");
            SetHeader("lname", "Achternaam");
            SetHeader("email", "E-mailadres");
            SetHeader("status", "Status");
            SetHeader("streetname", "Straat");
            SetHeader("zipcode", "Postcode");
            SetHeader("city", "Plaats");

            SetFillWeight("fname", 90);
            SetFillWeight("lname", 110);
            SetFillWeight("email", 180);
            SetFillWeight("status", 75);
            SetFillWeight("streetname", 130);
            SetFillWeight("zipcode", 80);
            SetFillWeight("city", 100);

            dgvCustomers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetHeader(string columnName, string headerText)
        {
            if (dgvCustomers.Columns[columnName] != null)
            {
                dgvCustomers.Columns[columnName].HeaderText = headerText;
            }
        }

        private void SetFillWeight(string columnName, float fillWeight)
        {
            if (dgvCustomers.Columns[columnName] != null)
            {
                dgvCustomers.Columns[columnName].FillWeight = fillWeight;
            }
        }

        private bool ValidateCustomerInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text)
                || string.IsNullOrWhiteSpace(txtLastName.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtPassword.Text)
                || string.IsNullOrWhiteSpace(txtStreetname.Text)
                || string.IsNullOrWhiteSpace(txtZipcode.Text)
                || string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show(
                    "Vul alle klant- en adresgegevens in.",
                    "Ongeldige invoer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            try
            {
                _ = new MailAddress(txtEmail.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Vul een geldig e-mailadres in.",
                    "Ongeldig e-mailadres",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show(
                    "Het wachtwoord moet minimaal 8 tekens bevatten.",
                    "Ongeldig wachtwoord",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (txtFirstName.Text.Trim().Length > 255
                || txtLastName.Text.Trim().Length > 255
                || txtEmail.Text.Trim().Length > 255
                || txtStreetname.Text.Trim().Length > 255
                || txtZipcode.Text.Trim().Length > 255
                || txtCity.Text.Trim().Length > 255)
            {
                MessageBox.Show(
                    "Een of meer velden bevatten meer dan 255 tekens.",
                    "Ongeldige invoer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void ClearCustomerInput()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtStreetname.Clear();
            txtZipcode.Clear();
            txtCity.Clear();
        }
    }
}