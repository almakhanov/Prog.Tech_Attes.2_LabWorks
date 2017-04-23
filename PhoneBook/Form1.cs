using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection;
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;
        BindingSource bindingSource;
        string query = "SELECT * FROM contacts";
        bool asc = true;
        string word;

        public void Sql()
        {
            mySqlConnection = new MySqlConnection(
                   "SERVER=localhost;" +
                   "DATABASE=phonebook;" +
                   "UID=root;" +
                   "PASSWORD=;");

            mySqlConnection.Open();            

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

      

        private void Update_Click(object sender, EventArgs e)
        {
            mySqlDataAdapter.Update(dataTable);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (asc)
            {
                query = "SELECT * FROM `contacts` ORDER BY `contacts`.`date` DESC";
                asc = false;
            }
            else
            {
                query = "SELECT * FROM `contacts` ORDER BY `contacts`.`date` ASC";
                asc = true;
            }
            Sql();            
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            word = txtB.Text;
            query = "SELECT * FROM `contacts` WHERE `" + "username" + "`  LIKE '%" + word + "%'";
            Sql();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sql();
        }
    }
}
