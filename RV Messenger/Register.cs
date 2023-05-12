using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RV_Messenger
{
    public partial class Register : MaterialForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Establish a connection to the SQL Server database.
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False");

            // Retrieve the values entered into the textboxes for username, password, and confirm password.
            string username = usernameText.Text;
            string password = passwordText.Text;
            string confirmPassword = confirmPasswordText.Text;

            // Check if the username or password fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            // Validate the input to ensure that the password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password do not match.");
                return;
            }

            // Use an SQL SELECT statement to check if the username already exists in the database
            string sqlQuery = "SELECT COUNT(*) FROM [Users] WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Username", username);
            sqlConnection.Open();

            int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();

            if (count > 0)
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            // Use an SQL INSERT statement to insert the user's details into the database.
            sqlQuery = "INSERT INTO [Users] (Username, Password) VALUES (@Username, @Password)";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();

            sqlCommand.Parameters.AddWithValue("@Username", username);
            sqlCommand.Parameters.AddWithValue("@Password", password);

            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (result > 0)
            {
                MessageBox.Show("User created successfully.");
            }
            else
            {
                MessageBox.Show("Error creating user.");
            }

            // Hide the register form
            this.Hide();

            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
