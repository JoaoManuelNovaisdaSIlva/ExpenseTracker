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
    partial class FormTransaction : Form
    {
        private AppController appController;
        private UsersBL user;
        public FormTransaction(UsersBL user, AppController appController)
        {
            InitializeComponent();

            this.appController = appController;
            this.user = user;
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            labelMonth.Text = DateTime.Now.ToString("MMMM yyyy");
            DateTime now = new DateTime();
            now = DateTime.Now;
            UpdatePage(sender, e, now);
        }

        public void UpdatePage(object sender, EventArgs e, DateTime date)
        {
            int idUser = this.user.getUserId();
            Decimal TotalSpendings = 0;


            DataTable expensesTable = appController.getExpensesController().getExpensesOfUser(idUser);
            if (expensesTable == null && expensesTable.Rows.Count <= 0)
            {
                emptyTable(sender, e);
                return;
            }

            var filteredExpenses = expensesTable.AsEnumerable()
                .Where(expenseRow =>
                {
                    DateTime expenseDate = expenseRow.Field<DateTime>("Date");
                    return expenseDate.Year == date.Year && expenseDate.Month == date.Month;
                })
                .OrderBy(expenseRow => expenseRow.Field<DateTime>("Date"));



            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Date", typeof(DateTime));
            resultTable.Columns.Add("Description", typeof(string));
            resultTable.Columns.Add("Amount Spent", typeof(decimal));

            foreach (var expenseRow in filteredExpenses)
            {
                DateTime expenseDate = expenseRow.Field<DateTime>("Date");
                string description = expenseRow.Field<string>("Description");
                decimal amount = expenseRow.Field<decimal>("Amount");

                resultTable.Rows.Add(expenseDate, description, amount);
                TotalSpendings += amount;
            }

            dataGridView1.DataSource = resultTable;
            dataGridView1.Columns["Amount Spent"].DefaultCellStyle.Format = "C";
        }

        public void emptyTable(Object sender, EventArgs e)
        {
            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Date", typeof(DateTime));
            resultTable.Columns.Add("Descriptions", typeof(string));
            resultTable.Columns.Add("Amount Spent", typeof(decimal));

            resultTable.Rows.Add(DateTime.MinValue, "n/a", 0);

            dataGridView1.DataSource = resultTable;
            dataGridView1.Columns["Amount Spent"].DefaultCellStyle.Format = "C";
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Parse(labelMonth.Text);
            DateTime nextMonth = current.AddMonths(1);
            labelMonth.Text = nextMonth.ToString("MMMM yyyy");

            UpdatePage(sender, e, nextMonth);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Parse(labelMonth.Text);
            DateTime previousMonth = current.AddMonths(-1);
            labelMonth.Text = previousMonth.ToString("MMMM yyyy");

            UpdatePage(sender, e, previousMonth);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu mainMenu = new FormMainMenu(user, appController);
            mainMenu.FormClosed += (s, args) => this.Close();
            mainMenu.ShowDialog();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewIncome newIncome = new FormNewIncome(user, appController, 1);
            newIncome.FormClosed += (s, args) => this.Close();
            newIncome.ShowDialog();
        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewExpense newExpense = new FormNewExpense(user, appController, 0);
            newExpense.FormClosed += (s, args) => this.Close();
            newExpense.ShowDialog();
        }
    }
}
