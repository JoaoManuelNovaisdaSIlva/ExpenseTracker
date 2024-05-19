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
    partial class FormNewExpense : Form
    {
        private AppController appController;
        private UsersBL user;
        private int form;
        private List<string> categoriesIds = new List<string>();
        public FormNewExpense(UsersBL user, AppController appController, int form)
        {
            InitializeComponent();

            this.appController = appController;
            this.user = user;
            this.form = form;
        }

        private void FormNewExpense_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = appController.getCategoriesController().getCategories();

            foreach (DataRow row in dt.Rows)
            {
                string id = row["CategoryId"].ToString();
                this.categoriesIds.Add(id);

                string category = row["CategoryName"].ToString();
                comboBoxCategories.Items.Add(category);
            }
            comboBoxRecurring.Items.Add("");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBoxAmount.Text);
            DateTime date = DateTime.Parse(textBoxDate.Text);
            int selected = comboBoxCategories.SelectedIndex;
            int catId = Int32.Parse(this.categoriesIds[selected]);
            string disc = textBoxDescription.Text;

            if (textBoxAmount.Text.Length < 0 || textBoxDate.Text.Length < 0 || amount <= 0)
            {
                MessageBox.Show("You have to enter the required information!");
            }
            else
            {
                string msg = appController.getExpensesController().addNewExpense(this.user.getUserId(), catId, amount, date, disc);
                MessageBox.Show(msg);
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

        private void comboBoxRecurring_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRecurring.SelectedIndex == 0)
            {
                using (FormRecurringDate recuringDate = new FormRecurringDate())
                {
                    recuringDate.ShowDialog();

                    DateTime choice = recuringDate.selectedDate;
                }
            }
            else if(comboBoxRecurring.SelectedIndex == 1)
            {
                using (FormRecurringTimes recurringTimes = new FormRecurringTimes())
                {
                    recurringTimes.ShowDialog();

                    int times = recurringTimes.times;
                }
            }
           
            
        }
    }
}
