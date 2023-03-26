using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_OPERATIONS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployeesRecord();

        }
        private void GetEmployeesRecord() 
        {
            SqlConnection conn = new SqlConnection("");

        }

       
    }
}
