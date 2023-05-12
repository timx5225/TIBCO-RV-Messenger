using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RV_Messenger
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            Register registerForm = new Register();
            registerForm.Show();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            // Establish a connection to the SQL Server database
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False");

            // Retrieve the values entered into the textboxes for username and password
            string username = usernameText.Text;
            string password = passwordText.Text;

            // Use an SQL SELECT statement to retrieve the user's details from the database
            string sqlQuery = "SELECT * FROM [Users] WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS AND Password = @Password COLLATE Latin1_General_CS_AS";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Username", username);
            sqlCommand.Parameters.AddWithValue("@Password", password);

            sqlConnection.Open();

            // Execute the query and retrieve the results
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                // If a row was returned, the user's details were found in the database
                // Close the reader and the connection, and show the dashboard
                reader.Close();
                sqlConnection.Close();

                Dashboard dashboardForm = new Dashboard(username);
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                // If no rows were returned, the user's details were not found in the database
                // Show an error message and close the connection
                reader.Close();
                sqlConnection.Close();
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
