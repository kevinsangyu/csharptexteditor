
namespace assignment2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.topStrip = new System.Windows.Forms.ToolStrip();
            this.newStripButton = new System.Windows.Forms.ToolStripButton();
            this.openStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldStripButton = new System.Windows.Forms.ToolStripButton();
            this.itallicStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineStripButton = new System.Windows.Forms.ToolStripButton();
            this.fontSizeCombo = new System.Windows.Forms.ToolStripComboBox();
            this.usernameLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sideStrip = new System.Windows.Forms.ToolStrip();
            this.cutStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.topStrip.SuspendLayout();
            this.sideStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.openFile,
            this.toolStripSeparator2,
            this.saveFile,
            this.saveFileAs,
            this.toolStripSeparator3,
            this.logOut});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(37, 20);
            this.file.Text = "File";
            // 
            // newFile
            // 
            this.newFile.Image = ((System.Drawing.Image)(resources.GetObject("newFile.Image")));
            this.newFile.Name = "newFile";
            this.newFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFile.Size = new System.Drawing.Size(146, 22);
            this.newFile.Text = "New";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // openFile
            // 
            this.openFile.Image = ((System.Drawing.Image)(resources.GetObject("openFile.Image")));
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(146, 22);
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // saveFile
            // 
            this.saveFile.Image = ((System.Drawing.Image)(resources.GetObject("saveFile.Image")));
            this.saveFile.Name = "saveFile";
            this.saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFile.Size = new System.Drawing.Size(146, 22);
            this.saveFile.Text = "Save";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveFileAs
            // 
            this.saveFileAs.Image = ((System.Drawing.Image)(resources.GetObject("saveFileAs.Image")));
            this.saveFileAs.Name = "saveFileAs";
            this.saveFileAs.Size = new System.Drawing.Size(146, 22);
            this.saveFileAs.Text = "Save As";
            this.saveFileAs.Click += new System.EventHandler(this.saveFileAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // logOut
            // 
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(146, 22);
            this.logOut.Text = "Log out";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cut,
            this.copy,
            this.paste});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(39, 20);
            this.edit.Text = "Edit";
            // 
            // cut
            // 
            this.cut.Image = ((System.Drawing.Image)(resources.GetObject("cut.Image")));
            this.cut.Name = "cut";
            this.cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut.Size = new System.Drawing.Size(144, 22);
            this.cut.Text = "Cut";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.Image = ((System.Drawing.Image)(resources.GetObject("copy.Image")));
            this.copy.Name = "copy";
            this.copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy.Size = new System.Drawing.Size(144, 22);
            this.copy.Text = "Copy";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.Image = ((System.Drawing.Image)(resources.GetObject("paste.Image")));
            this.paste.Name = "paste";
            this.paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste.Size = new System.Drawing.Size(144, 22);
            this.paste.Text = "Paste";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "Help";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(116, 22);
            this.about.Text = "About...";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(27, 52);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(773, 398);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // topStrip
            // 
            this.topStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.topStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStripButton,
            this.openStripButton,
            this.saveStripButton,
            this.saveAsStripButton,
            this.toolStripSeparator1,
            this.boldStripButton,
            this.itallicStripButton,
            this.underlineStripButton,
            this.fontSizeCombo,
            this.usernameLabel,
            this.toolStripSeparator4});
            this.topStrip.Location = new System.Drawing.Point(0, 24);
            this.topStrip.Name = "topStrip";
            this.topStrip.Size = new System.Drawing.Size(800, 25);
            this.topStrip.TabIndex = 2;
            this.topStrip.Text = "toolStrip1";
            // 
            // newStripButton
            // 
            this.newStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newStripButton.Image")));
            this.newStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newStripButton.Name = "newStripButton";
            this.newStripButton.Size = new System.Drawing.Size(23, 22);
            this.newStripButton.Text = "newStripButton";
            this.newStripButton.ToolTipText = "New File";
            this.newStripButton.Click += new System.EventHandler(this.newStripButton_Click);
            // 
            // openStripButton
            // 
            this.openStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openStripButton.Image")));
            this.openStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openStripButton.Name = "openStripButton";
            this.openStripButton.Size = new System.Drawing.Size(23, 22);
            this.openStripButton.Text = "toolStripButton2";
            this.openStripButton.ToolTipText = "Open File";
            this.openStripButton.Click += new System.EventHandler(this.openStripButton_Click);
            // 
            // saveStripButton
            // 
            this.saveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveStripButton.Image")));
            this.saveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveStripButton.Name = "saveStripButton";
            this.saveStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveStripButton.Text = "saveStripButton";
            this.saveStripButton.ToolTipText = "Save File";
            this.saveStripButton.Click += new System.EventHandler(this.saveStripButton_Click);
            // 
            // saveAsStripButton
            // 
            this.saveAsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsStripButton.Image")));
            this.saveAsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsStripButton.Name = "saveAsStripButton";
            this.saveAsStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveAsStripButton.Text = "saveAsStripButton";
            this.saveAsStripButton.ToolTipText = "Save as";
            this.saveAsStripButton.Click += new System.EventHandler(this.saveAsStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // boldStripButton
            // 
            this.boldStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldStripButton.Image = ((System.Drawing.Image)(resources.GetObject("boldStripButton.Image")));
            this.boldStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldStripButton.Name = "boldStripButton";
            this.boldStripButton.Size = new System.Drawing.Size(23, 22);
            this.boldStripButton.Text = "boldStripButton";
            this.boldStripButton.ToolTipText = "Bold";
            this.boldStripButton.Click += new System.EventHandler(this.boldStripButton_Click);
            // 
            // itallicStripButton
            // 
            this.itallicStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itallicStripButton.Image = ((System.Drawing.Image)(resources.GetObject("itallicStripButton.Image")));
            this.itallicStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itallicStripButton.Name = "itallicStripButton";
            this.itallicStripButton.Size = new System.Drawing.Size(23, 22);
            this.itallicStripButton.Text = "itallicStripButton";
            this.itallicStripButton.ToolTipText = "Itallic";
            this.itallicStripButton.Click += new System.EventHandler(this.itallicStripButton_Click);
            // 
            // underlineStripButton
            // 
            this.underlineStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineStripButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineStripButton.Image")));
            this.underlineStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineStripButton.Name = "underlineStripButton";
            this.underlineStripButton.Size = new System.Drawing.Size(23, 22);
            this.underlineStripButton.Text = "underlineStripButton";
            this.underlineStripButton.ToolTipText = "Underline";
            this.underlineStripButton.Click += new System.EventHandler(this.underlineStripButton_Click);
            // 
            // fontSizeCombo
            // 
            this.fontSizeCombo.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.fontSizeCombo.Name = "fontSizeCombo";
            this.fontSizeCombo.Size = new System.Drawing.Size(121, 25);
            this.fontSizeCombo.SelectedIndexChanged += new System.EventHandler(this.fontSizeCombo_SelectedIndexChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 22);
            this.usernameLabel.Text = "usernameLabel";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // sideStrip
            // 
            this.sideStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sideStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutStripButton,
            this.copyStripButton,
            this.pasteStripButton});
            this.sideStrip.Location = new System.Drawing.Point(0, 49);
            this.sideStrip.Name = "sideStrip";
            this.sideStrip.Size = new System.Drawing.Size(24, 401);
            this.sideStrip.TabIndex = 3;
            this.sideStrip.Text = "toolStrip2";
            // 
            // cutStripButton
            // 
            this.cutStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutStripButton.Image")));
            this.cutStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutStripButton.Name = "cutStripButton";
            this.cutStripButton.Size = new System.Drawing.Size(21, 20);
            this.cutStripButton.Text = "toolStripButton1";
            this.cutStripButton.ToolTipText = "Cut text";
            this.cutStripButton.Click += new System.EventHandler(this.cutStripButton_Click);
            // 
            // copyStripButton
            // 
            this.copyStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyStripButton.Image")));
            this.copyStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyStripButton.Name = "copyStripButton";
            this.copyStripButton.Size = new System.Drawing.Size(21, 20);
            this.copyStripButton.Text = "toolStripButton1";
            this.copyStripButton.ToolTipText = "Copy text";
            this.copyStripButton.Click += new System.EventHandler(this.copyStripButton_Click);
            // 
            // pasteStripButton
            // 
            this.pasteStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteStripButton.Image")));
            this.pasteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteStripButton.Name = "pasteStripButton";
            this.pasteStripButton.Size = new System.Drawing.Size(21, 20);
            this.pasteStripButton.Text = "toolStripButton1";
            this.pasteStripButton.ToolTipText = "Paste text";
            this.pasteStripButton.Click += new System.EventHandler(this.pasteStripButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sideStrip);
            this.Controls.Add(this.topStrip);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.topStrip.ResumeLayout(false);
            this.topStrip.PerformLayout();
            this.sideStrip.ResumeLayout(false);
            this.sideStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem saveFileAs;
        private System.Windows.Forms.ToolStripMenuItem logOut;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStrip topStrip;
        private System.Windows.Forms.ToolStripButton newStripButton;
        private System.Windows.Forms.ToolStripButton openStripButton;
        private System.Windows.Forms.ToolStripButton saveStripButton;
        private System.Windows.Forms.ToolStripButton saveAsStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton boldStripButton;
        private System.Windows.Forms.ToolStripButton itallicStripButton;
        private System.Windows.Forms.ToolStripButton underlineStripButton;
        private System.Windows.Forms.ToolStripComboBox fontSizeCombo;
        private System.Windows.Forms.ToolStripLabel usernameLabel;
        private System.Windows.Forms.ToolStrip sideStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton cutStripButton;
        private System.Windows.Forms.ToolStripButton copyStripButton;
        private System.Windows.Forms.ToolStripButton pasteStripButton;
    }
}