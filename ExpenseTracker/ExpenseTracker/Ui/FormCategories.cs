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
    partial class FormCategories : Form
    {
        private AppController appController;
        private UsersBL user;
        public FormCategories(AppController appController, UsersBL user)
        {
            InitializeComponent();

            this.appController = appController;
            this.user = user;
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            UpdatePage(sender, e);
        }

        public void UpdatePage(object sender, EventArgs e)
        {
            DataTable categoriesTable = appController.getCategoriesController().getCategories();
            if (categoriesTable == null && categoriesTable.Rows.Count <= 0)
            {
                listBox1.Items.Clear();
                return;
            }

            foreach (DataRow row in categoriesTable.Rows)
            {
                string category = row["CategoryName"].ToString();
                listBox1.Items.Add(category);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu mainMenu = new FormMainMenu(user, appController);
            mainMenu.FormClosed += (s, args) => this.Close();
            mainMenu.ShowDialog();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewCategory newCategory = new FormNewCategory(appController, user);
            newCategory.FormClosed += (s, args) => this.Close();
            newCategory.ShowDialog();
        }
    }
}
