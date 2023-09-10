using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseTracker
{
    public partial class FormMain : Form
    {
        private String ConnectionString;
        private SqlConnection sqlConnection;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ExpenseTrackerDB"].ConnectionString;
            sqlConnection = new SqlConnection(ConnectionString);

            labelError.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string pw = textBoxPw.Text;

            if (email.Length <= 0 || pw.Length <= 0)
            {
                labelError.Visible = true;
                return;
            }

            bool authentication = authenticationUser(email, pw);

            if (authentication)
            {
                // Authentication success
                //MessageBox.Show("SUCESSO!!");
                this.Close();
                FormMainMenu formMainMenu = new FormMainMenu(email);
                formMainMenu.ShowDialog();
            }
            else
            {
                ErrorFrom errorForm = new ErrorFrom();
                errorForm.ShowDialog();
            }
        }

        private bool authenticationUser(string email, string password)
        {
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", sqlConnection))
            {
                //tryConnection();

                DataTable queryOut = new DataTable();
                adapter.Fill(queryOut);

                foreach(DataRow row in queryOut.Rows) {
                    string tableEmail = row["Email"].ToString();
                    string tablePw = row["Password"].ToString();

                    if (email.Equals(tableEmail) && password.Equals(tablePw))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /**private void tryConnection() // Not necessary for now
        {
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
            }
        }**/
    }
}