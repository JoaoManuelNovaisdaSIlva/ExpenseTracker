using ExpenseTracker.Controller;
using ExpenseTracker.Ui;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseTracker
{
    partial class FormMain : Form
    {
        private AppController appController;

        public FormMain(AppController appController)
        {
            InitializeComponent();
            this.appController = appController;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
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

            bool authentication = appController.getUserController().AuthenticateUser(email, pw);


            if (authentication)
            {
                this.Hide();
                FormMainMenu formMainMenu = new FormMainMenu(email, appController);
                formMainMenu.FormClosed += (s, args) => this.Close();
                formMainMenu.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Error when loggin in!");
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreateAccount createAccount = new FormCreateAccount(this.appController);
            createAccount.FormClosed += (s, args) => this.Close();
            createAccount.ShowDialog();
            //this.Close();
        }
    }
}