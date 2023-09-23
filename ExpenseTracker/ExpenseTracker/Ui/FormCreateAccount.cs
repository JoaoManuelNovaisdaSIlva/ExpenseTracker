using ExpenseTracker.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Ui
{
    partial class FormCreateAccount : Form
    {
        private AppController appController;
        public FormCreateAccount(AppController appController)
        {
            InitializeComponent();

            this.appController = appController;
        }

        private void FormCreateAccount_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain(this.appController);
            formMain.ShowDialog();
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPw.Text;
            string name = textBoxName.Text;

            if (email.Length <= 0 || password.Length <= 0 || name.Length <= 0)
            {
                labelError.Visible = true;
                return;
            }

            MessageBox.Show(appController.userController.addNewUser(email, password, name));
        }
    }
}
