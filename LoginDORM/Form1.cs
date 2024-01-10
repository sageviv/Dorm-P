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


namespace LoginDORM
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(user_password.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE username = '" + username.Text + "' AND password = '" + user_password + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "where username'"+this.username.Text+"';";

                    MySqlConnection Myconn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, Myconn2);
                    MySqlDataReader Myreader2;
                    Myconn2.Open();
                    Myreader2 = MyCommand2.ExecuteReader();
                    while (Myreader2.Read())
                    {

                    }
                    Myconn2.Close();
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    loginSuccess frm2 = new loginSuccess();
                    frm2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again. ");
                }
                connection.Close();
            }
        }

        private void create_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount frm3 = new CreateAccount();
            frm3.ShowDialog();
        }
    }
}
