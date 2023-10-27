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
        private string email;
        public FormTransaction(string email, AppController appController)
        {
            InitializeComponent();

            this.appController = appController;
            this.email = email;
        }
    }
}
