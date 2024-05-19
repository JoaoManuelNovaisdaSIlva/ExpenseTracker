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
    partial class FormRecurringDate : Form
    {
        public DateTime selectedDate { get; set; }

        public FormRecurringDate()
        {
            InitializeComponent();
        }

        private void FormRecurring_Load(object sender, EventArgs e)
        {
            monthCalendar1.DateSelected += monthCalender_Select;
        }

        public void monthCalender_Select(object sender, EventArgs e)
        {
            DateTime selected = monthCalendar1.SelectionStart;
            this.selectedDate = selected;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
