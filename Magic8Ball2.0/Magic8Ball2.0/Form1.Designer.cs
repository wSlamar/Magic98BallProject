namespace Magic8Ball2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.insertText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anotherQuestion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertText
            // 
            this.insertText.BackColor = System.Drawing.SystemColors.MenuText;
            this.insertText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insertText.Font = new System.Drawing.Font("Retro Gaming", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertText.ForeColor = System.Drawing.Color.White;
            this.insertText.Location = new System.Drawing.Point(35, 233);
            this.insertText.Multiline = true;
            this.insertText.Name = "insertText";
            this.insertText.Size = new System.Drawing.Size(942, 132);
            this.insertText.TabIndex = 0;
            this.insertText.TextChanged += new System.EventHandler(this.insertText_TextChanged);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.SystemColors.MenuText;
            this.outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText.Font = new System.Drawing.Font("Retro Gaming", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.ForeColor = System.Drawing.Color.White;
            this.outputText.Location = new System.Drawing.Point(35, 474);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(942, 132);
            this.outputText.TabIndex = 1;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.BackgroundImage = global::Magic8Ball2._0.Properties.Resources.clickSubmit2;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.ForeColor = System.Drawing.Color.Transparent;
            this.submitButton.Location = new System.Drawing.Point(1008, 218);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(186, 163);
            this.submitButton.TabIndex = 2;
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.guideToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // guideToolStripMenuItem
            // 
            this.guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            this.guideToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.guideToolStripMenuItem.Text = "Guide";
            this.guideToolStripMenuItem.Click += new System.EventHandler(this.guideToolStripMenuItem_Click);
            // 
            // anotherQuestion
            // 
            this.anotherQuestion.BackColor = System.Drawing.Color.Transparent;
            this.anotherQuestion.BackgroundImage = global::Magic8Ball2._0.Properties.Resources.clickAnother2;
            this.anotherQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anotherQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anotherQuestion.ForeColor = System.Drawing.Color.Transparent;
            this.anotherQuestion.Location = new System.Drawing.Point(1008, 458);
            this.anotherQuestion.Name = "anotherQuestion";
            this.anotherQuestion.Size = new System.Drawing.Size(186, 163);
            this.anotherQuestion.TabIndex = 4;
            this.anotherQuestion.UseVisualStyleBackColor = false;
            this.anotherQuestion.Click += new System.EventHandler(this.another);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Magic8Ball2._0.Properties.Resources.magicballDROP4;
            this.ClientSize = new System.Drawing.Size(1208, 641);
            this.Controls.Add(this.anotherQuestion);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.insertText);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1224, 680);
            this.MinimumSize = new System.Drawing.Size(1224, 680);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic 98 Ball";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insertText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button anotherQuestion;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guideToolStripMenuItem;
    }
}

