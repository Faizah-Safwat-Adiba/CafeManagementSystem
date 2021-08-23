using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loginapp
{
    public partial class AdminForm2 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        public AdminForm2()
        {
            InitializeComponent();
        }

        public void openconnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeconnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeQuery( String query)
        {
            try
            {
                openconnection();
                command = new MySqlCommand(query, connection);
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeconnection();
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE admin_user_db.menu_pricetable SET price=" + textBoxPrice.Text + " WHERE item_no = " + textBoxItemNo.Text;
            executeQuery(updateQuery);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
