using ExpenseTracker.Controller;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseTracker
{
    partial class FormMain : Form
    {
        private AppController appController;

        public FormMain(AppController appController){
            InitializeComponent();
            this.appController = appController;
        }

        private void FormMain_Load(object sender, EventArgs e){ 
            labelError.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e){
            string email = textBoxEmail.Text;
            string pw = textBoxPw.Text;

            if (email.Length <= 0 || pw.Length <= 0){
                labelError.Visible = true;
                return;
            }

            bool authentication = appController.userController.AuthenticateUser(email, pw);


            if (authentication){
                FormMainMenu formMainMenu = new FormMainMenu(email, appController);
                formMainMenu.ShowDialog();
                this.Hide();
            }
            else{
                ErrorFrom errorForm = new ErrorFrom();
                errorForm.ShowDialog();
            }
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