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
    partial class FormRecurringTimes : Form
    {
        public int times { get; set; }
        public FormRecurringTimes()
        {
            InitializeComponent();
        }

        private void FormRecurringTimes_Load(object sender, EventArgs e)
        {

        }
    }
}
