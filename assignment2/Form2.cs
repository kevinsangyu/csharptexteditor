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

namespace assignment2
{
    public partial class Form2 : Form
    {
        private Form1 parent;
        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            this.parent = parentForm;
            this.Text = "Register new User";
            this.userType.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }

        private void submitButon_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passTextBox.Text == "" || fnameTextBox.Text == "" || lnameTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all sections.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (passTextBox.Text != passconfTextBox.Text)
            {
                MessageBox.Show("The given passwords do not match. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            List<string[]> logins = new List<string[]>();
            using (StreamReader sr = new StreamReader("login.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    logins.Add(line.Split(','));
                }
            }
            foreach (string[] login in logins)
            {
                if (usernameTextBox.Text == login[0])
                {
                    MessageBox.Show("The provided username already exists. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            StreamWriter sw = new StreamWriter("login.txt", append:true);
            sw.Write("\n{0},{1},{2},{3},{4},{5}", usernameTextBox.Text, passTextBox.Text, userType.SelectedItem, fnameTextBox.Text, lnameTextBox.Text, dobPicker.Value.Date.ToString("dd-MM-yyyy"));
            sw.Close();
            this.Close();
            this.parent.Show();
        }
    }
}
