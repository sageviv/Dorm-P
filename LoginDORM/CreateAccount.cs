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
    public partial class CreateAccount : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Male");
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            if (!this.email.Text.Contains('@') || !this.email.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(name.Text)|| string.IsNullOrEmpty(cboGender.Text)|| string.IsNullOrEmpty(email.Text)|| string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(user_password.Text))
            {
                MessageBox.Show("Please fill out all information", "Error");
                return;
            }
            else
            {
                connection.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.userinfo WHERE username = @username", connection),
                    cmd2 = new MySqlCommand("SELECT * FROM loginform.userinfo WHERE email = @useremail", connection);
                cmd1.Parameters.AddWithValue("@username", username.Text);
                cmd2.Parameters.AddWithValue("@email", email.Text);
                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");

                if (!(userExists || mailExists))
                {
                    string iquery = "INSERT INTO loginform.userinfo('ID','name','age','gender','contact','email','username','password') VALUES"
                }
            }
        }
    }
}
