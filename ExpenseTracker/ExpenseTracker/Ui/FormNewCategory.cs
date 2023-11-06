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
    partial class FormNewCategory : Form
    {
        private AppController appController;
        private UsersBL user;
        public FormNewCategory(AppController appController, UsersBL user)
        {
            InitializeComponent();

            this.appController = appController;
            this.user = user;
        }

        private void FormNewCategory_Load(object sender, EventArgs e)
        {
            updatePage();
        }

        public void updatePage()
        {
            listBox1.Items.Clear();
            DataTable dt = appController.getCategoriesController().getCategories();
            if (dt == null && dt.Rows.Count <= 0)
            {
                listBox1.Items.Clear();
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {
                string category = dr["CategoryName"].ToString();
                listBox1.Items.Add(category);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string cat = textBox1.Text;

            if (cat.Length <= 0)
            {
                MessageBox.Show("You haven't writen any new category!");
            }
            else
            {
                string msg = this.appController.getCategoriesController().addNewCategory(cat);
                MessageBox.Show(msg);
                updatePage();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCategories cat = new FormCategories(appController, user);
            cat.FormClosed += (s, args) => this.Close();
            cat.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string removing = listBox1.SelectedItem.ToString();
            string msg = this.appController.getCategoriesController().removeCategory(removing);
            MessageBox.Show(msg);
            updatePage();
        }
    }
}
