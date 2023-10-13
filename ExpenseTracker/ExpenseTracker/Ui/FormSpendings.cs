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
    partial class FormSpendings : Form
    {
        private AppController appController;
        private string email;
        public FormSpendings(string email, AppController appController)
        {
            InitializeComponent();

            this.appController = appController;
            this.email = email;
        }

        private void FormSpendings_Load(object sender, EventArgs e)
        {
            labelMonth.Text = DateTime.Now.ToString("MMMM yyyy");
            DateTime now =  new DateTime();
            now = DateTime.Now;
            UpdatePage(sender, e, now);
        }

        public void UpdatePage(object sender, EventArgs e, DateTime date)
        {
            int idUser = appController.userController.getIdByEmail(email);
            if (idUser == -1) MessageBox.Show("Fatal error: account not found!");

            DataTable table = new DataTable();
            table = appController.expensesController.getExpensesOfUser(idUser);

            listBoxExpenses.DataSource = table;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Parse(labelMonth.Text);
            DateTime previousMonth = current.AddMonths(-1);
            labelMonth.Text = previousMonth.ToString("MMMM yyyy");
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Parse(labelMonth.Text);
            DateTime previousMonth = current.AddMonths(1);
            labelMonth.Text = previousMonth.ToString("MMMM yyyy");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu mainMenu = new FormMainMenu(this.email, this.appController);
            mainMenu.ShowDialog();
            this.Close();
        }

    }
}
