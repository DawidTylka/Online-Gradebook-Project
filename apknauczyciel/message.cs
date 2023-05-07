using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.dziennik_funkcje;

namespace Tylka.apknauczyciel
{
    public partial class message : UserControl
    {
        public message()
        {
            InitializeComponent();
        }
        private DataTable dtwiadomosci;
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private int currentPage = 1;
        private int pageSize = 5;
        private int maxPage;
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayMessages();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                DisplayMessages();
            }
        }

        private void DisplayMessages()
        {
            // ...
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"SELECT * FROM Wiadomosci WHERE id_receiver = {UserData.user_id} OR publicmessage = 1 ORDER BY id DESC OFFSET {(currentPage - 1) * pageSize} ROWS FETCH NEXT {pageSize} ROWS ONLY";

            // Create a SqlDataAdapter object to fill a DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.Columns.Add("sender_name");

            // Assign the DataTable to a class-level variable
            dtwiadomosci = dt;
            DataTable dtUsers = new DataTable();
            SqlCommand cmdUsers = new SqlCommand();
            cmdUsers.Connection = conn;
            cmdUsers.CommandText = "SELECT id, name, surname FROM Users";
            SqlDataAdapter adapterUsers = new SqlDataAdapter(cmdUsers);

            // Fill dtUsers with data from the Users table
            adapterUsers.Fill(dtUsers);

            // loop through each row in dtwiadomosci and set the value of the "sender_name" column

            // Loop through each row in dt and set the value of the "sender_name" column
            foreach (DataRow row in dt.Rows)
            {
                int senderId = (int)row["id_sender"];
                DataRow[] userRows = dtUsers.Select($"id = {senderId}");
                if (userRows.Length > 0)
                {
                    string senderName = $"{userRows[0]["name"]} {userRows[0]["surname"]}";
                    row["sender_name"] = senderName;
                }
            }

            // Clear existing labels
            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    this.Controls.Remove(label);
                    label.Dispose();
                }
                else if (control is Button button)
                {
                    this.Controls.Remove(button);
                    button.Dispose();
                }
            }

            // Create new labels for each message
            int y = 50; // vertical position of labels
            foreach (DataRow row in dtwiadomosci.Rows)
            {
                string senderName = row["sender_name"].ToString();
                string subject = row["subject"].ToString();
                string message = row["text"].ToString();
                DateTime dateSent = ((DateTime)row["time"]).Date;
                string formattedDate = dateSent.ToString("dd/MM/yyyy");
                string preview = message.Substring(0, Math.Min(message.Length, 10)) + "...";
                Label label = new Label
                {
                    Text = $"{senderName} - {subject} {preview} ({formattedDate}):",
                    AutoSize = true,
                    Location = new Point(50, y),
                    Tag = message // store the full message in the label's Tag property
                };
                Button button = new Button
                {
                    Text = "Show full message",
                    Location = new Point(450, y),
                    Tag = label // store the label that the button belongs to in the Tag property
                };
                button.Click += ShowMessageButton_Click;
                this.Controls.Add(label);
                this.Controls.Add(button);
                y += 30; // increment vertical position for next label
            }

            // Update the paging controls
            pagenr.Text = $"Page {currentPage} of {maxPage}";
            prvpage.Enabled = currentPage > 1;
            nxtpage.Enabled = currentPage < maxPage;
        }

        private void ShowMessageButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Label label = (Label)button.Tag;
            string message = label.Tag.ToString();
            MessageBox.Show(message, "Full Message");
        }
        private void message_Load(object sender, EventArgs e)
        {
            conn.Open();

            // First request: Get the total number of messages
            SqlCommand cmdCount = new SqlCommand();
            cmdCount.Connection = conn;
            cmdCount.CommandText = $"SELECT COUNT(*) FROM Wiadomosci WHERE id_receiver = {UserData.user_id} OR publicmessage = 1";
            int totalCount = (int)cmdCount.ExecuteScalar();

            // Calculate the max number of pages
            maxPage = (int)Math.Ceiling((double)totalCount / pageSize);

           
            conn.Close();

            DisplayMessages();
        }
    }
}