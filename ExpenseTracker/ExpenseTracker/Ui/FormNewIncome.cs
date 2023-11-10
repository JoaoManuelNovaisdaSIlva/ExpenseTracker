using ExpenseTracker.Business_Logic;
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
    partial class FormNewIncome : Form
    {
        private AppController appController;
        private UsersBL user;
        private int form; // 0- Spending, 1-Transactions
        public FormNewIncome(UsersBL user, AppController appController, int form)
        {
            InitializeComponent();

            this.user = user;
            this.appController = appController;
            this.form = form;
        }

        private void FormNewIncome_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxIncome.Text);

            if (amount > 0 || textBoxIncome.Text.Length > 0)
            {
                string msg = appController.getIncomeController().addNewIncome(this.user.getUserId(), amount, DateTime.Now);
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("You can not add a negative income!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.form == 0)
            {
                FormSpendings spending = new FormSpendings(user, appController);
                spending.FormClosed += (s, args) => this.Close();
                spending.ShowDialog();
            }
            else
            {
                FormTransaction transaction = new FormTransaction(user, appController);
                transaction.FormClosed += (s, args) => this.Close();
                transaction.ShowDialog();
            }
        }
    }
}
