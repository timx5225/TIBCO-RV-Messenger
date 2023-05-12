using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TIBCO.Rendezvous;


namespace RV_Messenger
{
    public partial class Dashboard : MaterialForm
    {
        private string currentUsername;
        private NetTransport transport;
        private string subject;

        public Listener listener;
        public Dispatcher dispatcher;
        public Dashboard(string username)
        {
            InitializeComponent();
            this.currentUsername = username;
            PopulateFriendList();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            TIBCO.Rendezvous.Environment.Open();

            // Create Network transport
            transport = new NetTransport("", "", "");
            transport.CreateInbox();

            subject = "subject." + currentUsername;
            listener = new Listener(Queue.Default, transport, subject, null);
            
            dispatcher = new Dispatcher(Queue.Default);
            listener.MessageReceived += OnMessageReceived;
        }
        
        private void PopulateFriendList()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Friendname FROM Friendlist WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable friendListTable = new DataTable();
                        adapter.Fill(friendListTable);

                        friendListDataGridView.DataSource = friendListTable;
                    }
                }
            }
        }

        private void OnMessageReceived(object listener, MessageReceivedEventArgs args)
        {
            TIBCO.Rendezvous.Message message = args.Message;
            string receivedMessage = message.GetField("message").Value.ToString();
            string sender = message.GetField("sender").Value.ToString();

            if (args.Message.SendSubject == $"subject.{currentUsername}")
            {
                consoleText.Invoke(new Action(() =>
                    consoleText.AppendText($"From {sender}: {receivedMessage}" + System.Environment.NewLine)
                ));
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string friendUsername = usernameText.Text.Trim();
            string message = messageText.Text;

            // Check if the user is trying to send a message to themselves
            if (friendUsername == currentUsername)
            {
                MessageBox.Show("You cannot send a message to yourself.");
                return;
            }

            // Check if the friend is in the user's friend list
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Friendlist WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS AND Friendname COLLATE Latin1_General_CS_AS = @Friendname COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);
                    command.Parameters.AddWithValue("@Friendname", friendUsername);

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("User is not in your friend list.");
                        return;
                    }
                }
            }

            // Create the message
            TIBCO.Rendezvous.Message msg = new TIBCO.Rendezvous.Message();
            msg.AddField("message", message);
            msg.AddField("sender", currentUsername);

            msg.SendSubject = "subject." + friendUsername;
            transport.Send(msg);

            consoleText.AppendText($"Send message to {friendUsername}: {message}\r\n");

            messageText.Clear();
        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            string friendUsername = usernameText.Text.Trim();

            // Check if the user is trying to add themselves as a friend
            if (friendUsername == currentUsername)
            {
                MessageBox.Show("You cannot add yourself as a friend.");
                return;
            }

            // Establish connection with SQL Server
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                // Check if the username exists in the Users table
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", friendUsername);

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("User does not exist in the database");
                        return;
                    }
                }

                // Check if the two users are already friends
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Friendlist WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS AND Friendname COLLATE Latin1_General_CS_AS = @Friendname COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);
                    command.Parameters.AddWithValue("@Friendname", friendUsername);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Users are already friends");
                        return;
                    }
                }

                // Insert data into the Friendlist table
                using (SqlCommand command = new SqlCommand("INSERT INTO Friendlist (Username, Friendname) VALUES (@Username, @Friendname)", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);
                    command.Parameters.AddWithValue("@Friendname", friendUsername);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Friend added successfully");
                        PopulateFriendList(); // Refresh the friend list
                    }
                    else
                    {
                        MessageBox.Show("User does not exist in the database");
                    }
                }
            }
        }

        private void deleteFriendButton_Click(object sender, EventArgs e)
        {
            string friendUsername = usernameText.Text.Trim();

            // Establish connection with SQL Server
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                // Delete the friend from the Friendlist table
                using (SqlCommand command = new SqlCommand("DELETE FROM Friendlist WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS AND Friendname COLLATE Latin1_General_CS_AS = @Friendname COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);
                    command.Parameters.AddWithValue("@Friendname", friendUsername);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Friend deleted successfully");
                        PopulateFriendList(); // Refresh the friend list
                    }
                    else
                    {
                        MessageBox.Show("Friend does not exist in the database");
                    }
                }
            }
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            string[] users = usernameText.Text.Split(',');
            string groupName = Microsoft.VisualBasic.Interaction.InputBox("Enter a group name", "Group Name", "");

            // Create an instance of the GroupChat form and show it
            GroupChat groupChatForm = new GroupChat(groupName, currentUsername);
            groupChatForm.Show();

            // Open connection to SQL Server database
            //using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False"))
            //{
            //    connection.Open();
                
            //    // Insert new group information into the Groups table
            //    using (SqlCommand command = new SqlCommand("INSERT INTO Groups (GroupName, Users) VALUES (@groupName, @users)", connection))
            //    {
            //        command.Parameters.AddWithValue("@groupName", groupName);
            //        command.Parameters.AddWithValue("@users", string.Join(",", users));
            //        command.ExecuteNonQuery();
            //    }
            //}
        }
    }
}
