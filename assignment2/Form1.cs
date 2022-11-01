using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Login";
        }

        private void loginButton_Click(object sender, EventArgs e) //login button click
        {
            List<string[]> logins = new List<string[]>();
            using (StreamReader sr = new StreamReader("login.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    logins.Add(line.Split(','));
                }
            }
            string username = usernameTextBox.Text;
            string password = passTextBox.Text;
            foreach (string[] login in logins)
            {
                if (username == login[0])
                {
                    if (password == login[1])
                    {
                        this.Hide();
                        usernameTextBox.Text = "";
                        passTextBox.Text = "";
                        Form3 textEditForm = new Form3(this, "Edit"==login[2], login[0]);
                        textEditForm.Show();
                        return;
                    }
                }
            }
            MessageBox.Show("Given credentials were not valid.", "Incorrect details", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            usernameTextBox.Text = "";
            passTextBox.Text = "";
            Form2 newUserForm = new Form2(this);
            newUserForm.Show();
        }

        private void passTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
