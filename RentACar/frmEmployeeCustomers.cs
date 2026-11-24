using System.Data;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;

namespace RentACar
{
    public partial class frmEmployeeCustomers : UserControl
    {
        private readonly Passwords _passwords = new();
        private int? _selectedCustomerId;
        private int? _selectedAddressId;

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
            if (_selectedCustomerId.HasValue)
            {
                UpdateCustomer();
                return;
            }

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
                        u.user_address_id,
                        u.fname,
                        u.lname,
                        u.email,
                        u.status AS status_id,
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

            if (dgvCustomers.Columns["user_address_id"] != null)
            {
                dgvCustomers.Columns["user_address_id"].Visible = false;
            }

            if (dgvCustomers.Columns["status_id"] != null)
            {
                dgvCustomers.Columns["status_id"].Visible = false;
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
                || (!_selectedCustomerId.HasValue
                    && string.IsNullOrWhiteSpace(txtPassword.Text))
                || string.IsNullOrWhiteSpace(txtStreetname.Text)
                || string.IsNullOrWhiteSpace(txtZipcode.Text)
                || string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show(
                    "Vul alle verplichte klant en adresgegevens in.",
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

            if (!_selectedCustomerId.HasValue
    && txtPassword.Text.Length < 8)
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
            _selectedCustomerId = null;
            _selectedAddressId = null;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtStreetname.Clear();
            txtZipcode.Clear();
            txtCity.Clear();

            txtPassword.PlaceholderText = string.Empty;
            grpAddCustomer.Text = "Nieuwe klant";
            btnAddCustomer.Text = "Klant toevoegen";
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecteer eerst een klant.",
                    "Geen klant geselecteerd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow row = dgvCustomers.SelectedRows[0];

            _selectedCustomerId = Convert.ToInt32(row.Cells["user_id"].Value);
            _selectedAddressId = Convert.ToInt32(row.Cells["user_address_id"].Value);

            txtFirstName.Text = Convert.ToString(row.Cells["fname"].Value) ?? string.Empty;
            txtLastName.Text = Convert.ToString(row.Cells["lname"].Value) ?? string.Empty;
            txtEmail.Text = Convert.ToString(row.Cells["email"].Value) ?? string.Empty;
            txtStreetname.Text =
                Convert.ToString(row.Cells["streetname"].Value) ?? string.Empty;
            txtZipcode.Text =
                Convert.ToString(row.Cells["zipcode"].Value) ?? string.Empty;
            txtCity.Text = Convert.ToString(row.Cells["city"].Value) ?? string.Empty;

            txtPassword.Clear();
            txtPassword.PlaceholderText =
                "Leeg laten om wachtwoord te behouden";

            grpAddCustomer.Text = "Klant bewerken";
            btnAddCustomer.Text = "Wijzigingen opslaan";
        }

        private void UpdateCustomer()
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
                    WHERE email = @email
                      AND user_id != @user_id;
                    """;

                using MySqlCommand duplicateEmailCommand =
                    new(duplicateEmailQuery, connection, transaction);

                duplicateEmailCommand.Parameters.AddWithValue(
                    "@user_id",
                    _selectedCustomerId.Value);
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
                    UPDATE user_address
                    SET
                        streetname = @streetname,
                        zipcode = @zipcode,
                        city = @city
                    WHERE id = @id;
                    """;

                using MySqlCommand addressCommand =
                    new(addressQuery, connection, transaction);

                addressCommand.Parameters.AddWithValue(
                    "@id",
                    _selectedAddressId.Value);
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

                const string userQuery = """
                    UPDATE `user`
                    SET
                        fname = @fname,
                        lname = @lname,
                        email = @email,
                        status = @status,
                        updated_at = @updated_at
                    WHERE user_id = @user_id;
                    """;

                using MySqlCommand userCommand =
                    new(userQuery, connection, transaction);

                userCommand.Parameters.AddWithValue(
                    "@user_id",
                    _selectedCustomerId.Value);
                userCommand.Parameters.AddWithValue(
                    "@fname",
                    txtFirstName.Text.Trim());
                userCommand.Parameters.AddWithValue(
                    "@lname",
                    txtLastName.Text.Trim());
                userCommand.Parameters.AddWithValue(
                    "@email",
                    txtEmail.Text.Trim());
                userCommand.Parameters.AddWithValue("@status", 1);
                userCommand.Parameters.AddWithValue("@updated_at", DateTime.Now);

                userCommand.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show(
                    "De klantgegevens zijn succesvol bijgewerkt.",
                    "Klant bijgewerkt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearCustomerInput();
                LoadCustomers();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"De klantgegevens konden niet worden bijgewerkt.\n\n{exception.Message}",
                    "Databasefout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnToggleCustomerStatus_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecteer eerst een klant.",
                    "Geen klant geselecteerd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow row = dgvCustomers.SelectedRows[0];

            int customerId = Convert.ToInt32(row.Cells["user_id"].Value);
            int currentStatus = Convert.ToInt32(row.Cells["status_id"].Value);
            int newStatus = currentStatus == 1 ? 0 : 1;

            string action = newStatus == 1
                ? "activeren"
                : "inactief zetten";

            DialogResult result = MessageBox.Show(
                $"Wil je deze klant {action}?",
                "Bevestiging",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            UpdateCustomerStatus(customerId, newStatus);
        }

        private void UpdateCustomerStatus(int customerId, int status)
        {
            try
            {
                using MySqlConnection connection = new(_passwords.ConnStr);
                connection.Open();

                const string query = """
                    UPDATE `user`
                    SET
                        status = @status,
                        updated_at = @updated_at
                    WHERE user_id = @user_id
                      AND role_id = 1;
                    """;

                using MySqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@updated_at", DateTime.Now);
                command.Parameters.AddWithValue("@user_id", customerId);

                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show(
                        "De klantstatus kon niet worden aangepast.",
                        "Databasefout",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                ClearCustomerInput();
                LoadCustomers();

                MessageBox.Show(
                    status == 1
                        ? "De klant is geactiveerd."
                        : "De klant is inactief gemaakt.",
                    "Status aangepast",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"De klantstatus kon niet worden aangepast.\n\n{exception.Message}",
                    "Databasefout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecteer eerst een klant.",
                    "Geen klant geselecteerd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow row = dgvCustomers.SelectedRows[0];

            int customerId = Convert.ToInt32(row.Cells["user_id"].Value);
            string customerName =
                $"{row.Cells["fname"].Value} {row.Cells["lname"].Value}";

            DialogResult result = MessageBox.Show(
                $"Weet je zeker dat je klant {customerName} wilt verwijderen?\n\n"
                + "Deze actie kan niet ongedaan worden gemaakt.",
                "Klant definitief verwijderen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            DeleteCustomer(customerId);
        }

        private void DeleteCustomer(int customerId)
        {
            try
            {
                using MySqlConnection connection = new(_passwords.ConnStr);
                connection.Open();

                const string reservationCheckQuery = """
            SELECT COUNT(*)
            FROM reservering
            WHERE customer_id = @customer_id;
            """;

                using MySqlCommand reservationCheckCommand =
                    new(reservationCheckQuery, connection);

                reservationCheckCommand.Parameters.AddWithValue(
                    "@customer_id",
                    customerId);

                int reservationCount = Convert.ToInt32(
                    reservationCheckCommand.ExecuteScalar());

                if (reservationCount > 0)
                {
                    MessageBox.Show(
                        "Deze klant kan niet definitief worden verwijderd, "
                        + "omdat er reserveringen aan gekoppeld zijn.\n\n"
                        + "Maak de klant in plaats daarvan inactief.",
                        "Klant kan niet worden verwijderd",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using MySqlTransaction transaction = connection.BeginTransaction();

                const string addressIdQuery = """
            SELECT user_address_id
            FROM `user`
            WHERE user_id = @customer_id
              AND role_id = 1;
            """;

                using MySqlCommand addressIdCommand =
                    new(addressIdQuery, connection, transaction);

                addressIdCommand.Parameters.AddWithValue(
                    "@customer_id",
                    customerId);

                object? addressIdResult = addressIdCommand.ExecuteScalar();

                if (addressIdResult == null || addressIdResult == DBNull.Value)
                {
                    transaction.Rollback();

                    MessageBox.Show(
                        "De klant kon niet worden gevonden.",
                        "Verwijderen mislukt",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int addressId = Convert.ToInt32(addressIdResult);

                const string deleteUserQuery = """
            DELETE FROM `user`
            WHERE user_id = @customer_id
              AND role_id = 1;
            """;

                using MySqlCommand deleteUserCommand =
                    new(deleteUserQuery, connection, transaction);

                deleteUserCommand.Parameters.AddWithValue(
                    "@customer_id",
                    customerId);

                int deletedUsers = deleteUserCommand.ExecuteNonQuery();

                if (deletedUsers != 1)
                {
                    transaction.Rollback();

                    MessageBox.Show(
                        "De klant kon niet worden verwijderd.",
                        "Verwijderen mislukt",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                const string deleteAddressQuery = """
            DELETE FROM user_address
            WHERE id = @address_id
              AND NOT EXISTS
              (
                  SELECT 1
                  FROM `user`
                  WHERE user_address_id = @address_id
              );
            """;

                using MySqlCommand deleteAddressCommand =
                    new(deleteAddressQuery, connection, transaction);

                deleteAddressCommand.Parameters.AddWithValue(
                    "@address_id",
                    addressId);

                deleteAddressCommand.ExecuteNonQuery();

                transaction.Commit();

                ClearCustomerInput();
                LoadCustomers();

                MessageBox.Show(
                    "De klant is definitief verwijderd.",
                    "Klant verwijderd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (MySqlException exception) when (exception.Number == 1451)
            {
                MessageBox.Show(
                    "Deze klant kan niet worden verwijderd omdat er nog "
                    + "gekoppelde gegevens bestaan.",
                    "Klant kan niet worden verwijderd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"De klant kon niet worden verwijderd.\n\n{exception.Message}",
                    "Databasefout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}