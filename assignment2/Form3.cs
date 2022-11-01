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
    public partial class Form3 : Form
    {
        private Form1 parentForm;
        private bool editPerm;
        private string username;
        private string path;
        public Form3(Form1 parent, bool editPerm, string username)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.editPerm = editPerm;
            if (!this.editPerm)
            {
                richTextBox.ReadOnly = true;
            }
            this.username = username;
            usernameLabel.Text = "User Name: " + this.username;
            this.Text = "New Text File";
            fontSizeCombo.SelectedIndex = 0;
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Any unsaved changes will be lost. Do you still wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                richTextBox.Text = "";
                this.path = null;
                this.Text = "New Text File";
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a Text File";
            ofd.Filter = "Text files (*.txt) |*.txt| Rich Text Format (*.rtf) |*.rtf| All files (*.*) |*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.path = ofd.FileName;
                this.Text = this.path;
                using (StreamReader sr = new StreamReader(this.path))
                {
                    richTextBox.Text = sr.ReadToEnd();
                }
            }
        }
        private void saveFile_Click(object sender, EventArgs e)
        {
            if (this.path != null)
            {
                using (StreamWriter sw = new StreamWriter(this.path))
                {
                    sw.Write(richTextBox.Text);
                }
            }
            else
            {
                saveFileAs_Click(sender, e);
            }
        }
        private void saveFileAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt) |*.txt| Rich Text Format (*.rtf) |*.rtf| All files (*.*) |*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != null)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.Write(richTextBox.Text);
                    }
                    this.path = sfd.FileName;
                    this.Text = this.path;
                }
            }
        }
        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox.SelectedText);
                richTextBox.SelectedText = "";
            }
            catch (System.ArgumentNullException)
            {
            }
        }
        private void copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox.SelectedText);
            }
            catch (System.ArgumentNullException) {
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {
            if (this.editPerm)
            {
                richTextBox.SelectedText = Clipboard.GetText();
            }
        }

        private void newStripButton_Click(object sender, EventArgs e)
        {
            newFile.PerformClick();
        }

        private void openStripButton_Click(object sender, EventArgs e)
        {
            openFile.PerformClick();
        }

        private void saveStripButton_Click(object sender, EventArgs e)
        {
            saveFile.PerformClick();
        }

        private void saveAsStripButton_Click(object sender, EventArgs e)
        {
            saveFileAs.PerformClick();
        }

        private void boldStripButton_Click(object sender, EventArgs e)
        {
            if (!this.editPerm)
            {
                return;
            }
            if (richTextBox.SelectionFont.Style.Equals(FontStyle.Bold))
            {
                richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, richTextBox.Font.Size, FontStyle.Regular);
            }
            else
            {
                richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, richTextBox.Font.Size, FontStyle.Bold);
            }
        }

        private void itallicStripButton_Click(object sender, EventArgs e)
        {
            if (!this.editPerm)
            {
                return;
            }
            if (richTextBox.SelectionFont.Style.Equals(FontStyle.Italic))
            {
                richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, richTextBox.Font.Size, FontStyle.Regular);
            }
            else
            {
                richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, richTextBox.Font.Size, FontStyle.Italic);
            }
        }

        private void underlineStripButton_Click(object sender, EventArgs e)
        {
            if (!this.editPerm)
            {
                return;
            }
            if (richTextBox.SelectionFont.Style.Equals(FontStyle.Underline))
            {
                richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, richTextBox.Font.Size, FontStyle.Regular);
            }
            else
            {
                richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, richTextBox.Font.Size, FontStyle.Underline);
            }
        }

        private void fontSizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.editPerm)
            {
                return;
            }
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, Convert.ToInt32(fontSizeCombo.SelectedItem), richTextBox.SelectionFont.Style);
        }

        private void cutStripButton_Click(object sender, EventArgs e)
        {
            cut.PerformClick();
        }

        private void copyStripButton_Click(object sender, EventArgs e)
        {
            copy.PerformClick();
        }

        private void pasteStripButton_Click(object sender, EventArgs e)
        {
            paste.PerformClick();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# Text Editor for txt and rtf files.\nVersion 1.0\nCreator: Kevin Yu\nRelease date: 20/10/2022", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Any unsaved changes will be lost. Do you still wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == result)
            {
                e.Cancel = true;
            }
            else
            {
                this.parentForm.Show();
            }
        }
    }
}
