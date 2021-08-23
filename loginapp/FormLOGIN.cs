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

namespace loginapp
{
    public partial class FormLOGIN : Form
    {
          
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLOGIN_Load(object sender, EventArgs e)
        {

        }

        private void Butn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void Butn_Pass_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = text_UsrN.Text;
            String password = text_Pass.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Username`= @usn and `Password`= @pass", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //ckeck user
            if(table.Rows.Count > 0)
            {
                this.Hide();
                MainForm2 mainForm2 = new MainForm2();
                mainForm2.Show();
            }

            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void labelGoSingUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoSingUp.ForeColor = Color.LemonChiffon;
        }

        private void labelGoSingUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoSingUp.ForeColor = Color.Crimson;
        }

        private void FormLOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = text_UsrN.Text;
            String password = text_Pass.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Username`= @usn and `Password`= @pass", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //ckeck user
            if (table.Rows.Count > 0)
            {
                this.Hide();
                AdminForm2 adminForm2 = new AdminForm2();
                adminForm2.Show();
            }

            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
