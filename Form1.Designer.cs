namespace BinaryConverter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toBinary = new System.Windows.Forms.Button();
            this.toText = new System.Windows.Forms.Button();
            this.normalRich = new System.Windows.Forms.RichTextBox();
            this.binaryRich = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTextFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importBinaryFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTextToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBinaryToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(197, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(755, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Binary";
            // 
            // toBinary
            // 
            this.toBinary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toBinary.Location = new System.Drawing.Point(461, 278);
            this.toBinary.Name = "toBinary";
            this.toBinary.Size = new System.Drawing.Size(95, 23);
            this.toBinary.TabIndex = 5;
            this.toBinary.Text = "-> To Binary ->";
            this.toBinary.UseVisualStyleBackColor = true;
            this.toBinary.Click += new System.EventHandler(this.toBinary_Click);
            // 
            // toText
            // 
            this.toText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toText.Location = new System.Drawing.Point(461, 331);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(95, 23);
            this.toText.TabIndex = 6;
            this.toText.Text = "<- To Text <-";
            this.toText.UseVisualStyleBackColor = true;
            this.toText.Click += new System.EventHandler(this.toText_Click);
            // 
            // normalRich
            // 
            this.normalRich.AcceptsTab = true;
            this.normalRich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.normalRich.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalRich.Location = new System.Drawing.Point(12, 56);
            this.normalRich.Name = "normalRich";
            this.normalRich.Size = new System.Drawing.Size(434, 729);
            this.normalRich.TabIndex = 7;
            this.normalRich.Text = "";
            // 
            // binaryRich
            // 
            this.binaryRich.AcceptsTab = true;
            this.binaryRich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.binaryRich.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryRich.Location = new System.Drawing.Point(583, 56);
            this.binaryRich.Name = "binaryRich";
            this.binaryRich.Size = new System.Drawing.Size(434, 729);
            this.binaryRich.TabIndex = 8;
            this.binaryRich.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importTextFromFileToolStripMenuItem,
            this.importBinaryFromFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveTextToFileToolStripMenuItem,
            this.saveBinaryToFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importTextFromFileToolStripMenuItem
            // 
            this.importTextFromFileToolStripMenuItem.Name = "importTextFromFileToolStripMenuItem";
            this.importTextFromFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.importTextFromFileToolStripMenuItem.Text = "Import text from file";
            this.importTextFromFileToolStripMenuItem.Click += new System.EventHandler(this.importTextFromFileToolStripMenuItem_Click);
            // 
            // importBinaryFromFileToolStripMenuItem
            // 
            this.importBinaryFromFileToolStripMenuItem.Name = "importBinaryFromFileToolStripMenuItem";
            this.importBinaryFromFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.importBinaryFromFileToolStripMenuItem.Text = "Import binary from file";
            this.importBinaryFromFileToolStripMenuItem.Click += new System.EventHandler(this.importBinaryFromFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // saveTextToFileToolStripMenuItem
            // 
            this.saveTextToFileToolStripMenuItem.Name = "saveTextToFileToolStripMenuItem";
            this.saveTextToFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveTextToFileToolStripMenuItem.Text = "Save text to file";
            this.saveTextToFileToolStripMenuItem.Click += new System.EventHandler(this.saveTextToFileToolStripMenuItem_Click);
            // 
            // saveBinaryToFileToolStripMenuItem
            // 
            this.saveBinaryToFileToolStripMenuItem.Name = "saveBinaryToFileToolStripMenuItem";
            this.saveBinaryToFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveBinaryToFileToolStripMenuItem.Text = "Save binary to file";
            this.saveBinaryToFileToolStripMenuItem.Click += new System.EventHandler(this.saveBinaryToFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1029, 797);
            this.Controls.Add(this.binaryRich);
            this.Controls.Add(this.normalRich);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.toBinary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Binary Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toBinary;
        private System.Windows.Forms.Button toText;
        private System.Windows.Forms.RichTextBox normalRich;
        private System.Windows.Forms.RichTextBox binaryRich;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTextFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importBinaryFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTextToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBinaryToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

