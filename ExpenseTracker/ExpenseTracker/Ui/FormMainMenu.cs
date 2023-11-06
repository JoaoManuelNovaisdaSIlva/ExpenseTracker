using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Business_Logic;
using ExpenseTracker.Controller;
using ExpenseTracker.Ui;

namespace ExpenseTracker
{
    partial class FormMainMenu : Form
    {
        private AppController appController;
        private UsersBL user;

        public FormMainMenu(UsersBL user, AppController appController)
        {
            InitializeComponent();

            this.user = user;
            this.appController = appController;
        }

        public void FormMainMenu_Load(object sender, EventArgs e)
        {
            string welcomeString = "Welcome " + this.user.getName();
            labelWelcome.Text = welcomeString;
        }

        private void buttonSpendings_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSpendings formSpendings = new FormSpendings(user, this.appController);
            formSpendings.FormClosed += (s, args) => this.Close();
            formSpendings.ShowDialog();
        }

        private void buttonTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTransaction formTransactions = new FormTransaction(user, this.appController);
            formTransactions.FormClosed += (s, args) => this.Close();
            formTransactions.ShowDialog();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain(this.appController);
            formMain.FormClosed += (s, args) => this.Close();
            formMain.ShowDialog();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCategories formCategories = new FormCategories(this.appController, this.user);
            formCategories.FormClosed += (s, args) => this.Close();
            formCategories.ShowDialog();
        }
    }
}
