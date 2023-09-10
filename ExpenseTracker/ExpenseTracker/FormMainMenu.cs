using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class FormMainMenu : Form
    {
        private String ConnectionString;
        private SqlConnection sqlConnection;

        public FormMainMenu(string email)
        {
            InitializeComponent();
        }

        public void FormMainMenu_Load(object sender, EventArgs e)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ExpenseTrackerDB"].ConnectionString;
            sqlConnection = new SqlConnection(ConnectionString);

            //labelWelcome.Text = "Welcome" + //getNameByEmail(email);
        }


    }
}
