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
using System.Linq;
using ExpenseTracker.Business_Logic;

namespace ExpenseTracker.Ui
{
    partial class FormSpendings : Form
    {
        private AppController appController;
        private UsersBL user;
        public FormSpendings(UsersBL user, AppController appController)
        {
            InitializeComponent();

            this.appController = appController;
            this.user = user;
        }

        private void FormSpendings_Load(object sender, EventArgs e)
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
            DataTable categoriesTable = appController.getCategoriesController().getCategories();
            if (expensesTable == null && expensesTable.Rows.Count <= 0)
            {
                emptyTable(sender, e, categoriesTable);
                return;
            }

            var filteredExpenses = expensesTable.AsEnumerable()
                .Where(expenseRow =>
                {
                    DateTime expenseDate = expenseRow.Field<DateTime>("Date");
                    return expenseDate.Year == date.Year && expenseDate.Month == date.Month;
                });

            var query = from categoryRow in categoriesTable.AsEnumerable()
                        join expenseRow in filteredExpenses
                        on categoryRow.Field<int>("CategoryId") equals expenseRow.Field<int>("Category_Id") into joined
                        from expenseGroup in joined.DefaultIfEmpty()
                        group expenseGroup by categoryRow.Field<string>("CategoryName") into grouped
                        select new
                        {
                            CategoryName = grouped.Key,
                            TotalAmount = grouped.Sum(r => r?.Field<decimal>("Amount") ?? 0)
                        };

            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Category Name", typeof(string));
            resultTable.Columns.Add("Total Amount Spent", typeof(decimal));

            foreach (var item in query)
            {
                resultTable.Rows.Add(item.CategoryName, item.TotalAmount);
                TotalSpendings += item.TotalAmount;
            }

            dataGridView1.DataSource = resultTable;
            dataGridView1.Columns["Total Amount Spent"].DefaultCellStyle.Format = "C";

            Decimal monthIncome = appController.getIncomeController().getMonthsIncome(idUser, DateTime.Parse(labelMonth.Text));
            if (monthIncome == -1)
            {
                labelIncome.Text = "No income";
                labelBalance.Text = (0 - TotalSpendings).ToString();
            }
            else
            {
                labelIncome.Text = monthIncome.ToString();
                labelBalance.Text = (monthIncome - TotalSpendings).ToString();
            }
            labelExpense.Text = TotalSpendings.ToString();
        }

        public void emptyTable(Object sender, EventArgs e, DataTable categories)
        {
            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Category Name", typeof(string));
            resultTable.Columns.Add("Total Amount Spent", typeof(decimal));

            foreach (DataRow row in categories.Rows)
            {
                resultTable.Rows.Add(row["CategoryName"], 0);
            }
            dataGridView1.DataSource = resultTable;
            dataGridView1.Columns["Total Amount Spent"].DefaultCellStyle.Format = "C";
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Parse(labelMonth.Text);
            DateTime previousMonth = current.AddMonths(-1);
            labelMonth.Text = previousMonth.ToString("MMMM yyyy");

            UpdatePage(sender, e, previousMonth);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Parse(labelMonth.Text);
            DateTime nextMonth = current.AddMonths(1);
            labelMonth.Text = nextMonth.ToString("MMMM yyyy");

            UpdatePage(sender, e, nextMonth);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu mainMenu = new FormMainMenu(this.user, this.appController);
            mainMenu.ShowDialog();
            this.Close();
        }

        private void buttonPlusIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTransaction transaction = new FormTransaction(this.user, this.appController);
        }

        private void buttonPlusExpense_Click(object sender, EventArgs e)
        {

        }
    }
}
