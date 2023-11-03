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

        }
    }
}
