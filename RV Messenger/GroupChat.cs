using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using TIBCO.Rendezvous;

namespace RV_Messenger
{
    public partial class GroupChat : MaterialForm
    {
        private string groupName;
        private string currentUsername;

        private NetTransport transport;
        private string subject;

        public Listener listener;
        public Dispatcher dispatcher;

        public GroupChat(string groupName, string currentUsername)
        {
            InitializeComponent();
            this.groupName = groupName;
            this.currentUsername = currentUsername;
            PopulateFriendList();
        }

        private void GroupChat_Load(object sender, EventArgs e)
        {
            TIBCO.Rendezvous.Environment.Open();

            // Create Network transport
            transport = new NetTransport("", "", "");
            transport.CreateInbox();

            subject = "subject." + groupName;
            
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

            if (args.Message.SendSubject == $"subject.{groupName}")
            {
                consoleText.Invoke(new Action(() =>
                    consoleText.AppendText($"From {sender}: {receivedMessage}" + System.Environment.NewLine)
                ));
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageText.Text;

            // Create the message
            TIBCO.Rendezvous.Message msg = new TIBCO.Rendezvous.Message();
            msg.AddField("message", message);
            msg.AddField("sender", currentUsername);

            msg.SendSubject = "subject." + groupName;
            transport.Send(msg);

            messageText.Clear();
        }
    }
}
