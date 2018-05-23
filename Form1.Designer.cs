namespace StartupUtils_Main
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.website2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.soundsDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.removeSoundBtn = new System.Windows.Forms.Button();
            this.addSoundBtn = new System.Windows.Forms.Button();
            this.soundTextBox = new System.Windows.Forms.TextBox();
            this.playSounds = new System.Windows.Forms.CheckBox();
            this.websitesTextBox = new System.Windows.Forms.TextBox();
            this.openWebsite = new System.Windows.Forms.CheckBox();
            this.removeProgramBtn = new System.Windows.Forms.Button();
            this.addProgramBtn = new System.Windows.Forms.Button();
            this.programTextBox = new System.Windows.Forms.TextBox();
            this.startProgram = new System.Windows.Forms.CheckBox();
            this.applySimpleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shutdownCheck = new System.Windows.Forms.CheckBox();
            this.shutdownTimeTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.website1 = new System.Windows.Forms.LinkLabel();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.applyAdvancedButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.graphicsLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Location = new System.Drawing.Point(2, 2);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(695, 822);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.website2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.soundsDelay);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.removeSoundBtn);
            this.tabPage1.Controls.Add(this.addSoundBtn);
            this.tabPage1.Controls.Add(this.soundTextBox);
            this.tabPage1.Controls.Add(this.playSounds);
            this.tabPage1.Controls.Add(this.websitesTextBox);
            this.tabPage1.Controls.Add(this.openWebsite);
            this.tabPage1.Controls.Add(this.removeProgramBtn);
            this.tabPage1.Controls.Add(this.addProgramBtn);
            this.tabPage1.Controls.Add(this.programTextBox);
            this.tabPage1.Controls.Add(this.startProgram);
            this.tabPage1.Controls.Add(this.applySimpleButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.shutdownCheck);
            this.tabPage1.Controls.Add(this.shutdownTimeTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(687, 789);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // website2
            // 
            this.website2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.website2.AutoSize = true;
            this.website2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website2.LinkArea = new System.Windows.Forms.LinkArea(43, 55);
            this.website2.Location = new System.Drawing.Point(10, 761);
            this.website2.Name = "website2";
            this.website2.Size = new System.Drawing.Size(435, 26);
            this.website2.TabIndex = 19;
            this.website2.TabStop = true;
            this.website2.Text = "Please tell me your Ideas and Wishes on my Forum.";
            this.website2.UseCompatibleTextRendering = true;
            this.website2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.website2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "s";
            // 
            // soundsDelay
            // 
            this.soundsDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soundsDelay.Location = new System.Drawing.Point(122, 554);
            this.soundsDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soundsDelay.MaxLength = 3;
            this.soundsDelay.Name = "soundsDelay";
            this.soundsDelay.Size = new System.Drawing.Size(37, 19);
            this.soundsDelay.TabIndex = 16;
            this.soundsDelay.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "with a delay of";
            // 
            // removeSoundBtn
            // 
            this.removeSoundBtn.BackColor = System.Drawing.Color.White;
            this.removeSoundBtn.Location = new System.Drawing.Point(177, 545);
            this.removeSoundBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeSoundBtn.Name = "removeSoundBtn";
            this.removeSoundBtn.Size = new System.Drawing.Size(87, 29);
            this.removeSoundBtn.TabIndex = 13;
            this.removeSoundBtn.Text = "Remove";
            this.removeSoundBtn.UseVisualStyleBackColor = false;
            this.removeSoundBtn.Click += new System.EventHandler(this.removeSoundBtn_Click);
            // 
            // addSoundBtn
            // 
            this.addSoundBtn.BackColor = System.Drawing.Color.White;
            this.addSoundBtn.Location = new System.Drawing.Point(177, 481);
            this.addSoundBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addSoundBtn.Name = "addSoundBtn";
            this.addSoundBtn.Size = new System.Drawing.Size(87, 29);
            this.addSoundBtn.TabIndex = 12;
            this.addSoundBtn.Text = "Add";
            this.addSoundBtn.UseVisualStyleBackColor = false;
            this.addSoundBtn.Click += new System.EventHandler(this.addSoundBtn_Click);
            // 
            // soundTextBox
            // 
            this.soundTextBox.Location = new System.Drawing.Point(277, 481);
            this.soundTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soundTextBox.Multiline = true;
            this.soundTextBox.Name = "soundTextBox";
            this.soundTextBox.ReadOnly = true;
            this.soundTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.soundTextBox.Size = new System.Drawing.Size(317, 93);
            this.soundTextBox.TabIndex = 11;
            // 
            // playSounds
            // 
            this.playSounds.AutoSize = true;
            this.playSounds.Location = new System.Drawing.Point(6, 481);
            this.playSounds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playSounds.Name = "playSounds";
            this.playSounds.Size = new System.Drawing.Size(127, 24);
            this.playSounds.TabIndex = 10;
            this.playSounds.Text = "Play Sounds:";
            this.playSounds.UseVisualStyleBackColor = true;
            // 
            // websitesTextBox
            // 
            this.websitesTextBox.Location = new System.Drawing.Point(177, 215);
            this.websitesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.websitesTextBox.Multiline = true;
            this.websitesTextBox.Name = "websitesTextBox";
            this.websitesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.websitesTextBox.Size = new System.Drawing.Size(417, 93);
            this.websitesTextBox.TabIndex = 9;
            // 
            // openWebsite
            // 
            this.openWebsite.AutoSize = true;
            this.openWebsite.Location = new System.Drawing.Point(6, 220);
            this.openWebsite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openWebsite.Name = "openWebsite";
            this.openWebsite.Size = new System.Drawing.Size(148, 24);
            this.openWebsite.TabIndex = 8;
            this.openWebsite.Text = "Open Websites:";
            this.openWebsite.UseVisualStyleBackColor = true;
            // 
            // removeProgramBtn
            // 
            this.removeProgramBtn.BackColor = System.Drawing.Color.White;
            this.removeProgramBtn.Location = new System.Drawing.Point(177, 128);
            this.removeProgramBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeProgramBtn.Name = "removeProgramBtn";
            this.removeProgramBtn.Size = new System.Drawing.Size(87, 29);
            this.removeProgramBtn.TabIndex = 7;
            this.removeProgramBtn.Text = "Remove";
            this.removeProgramBtn.UseVisualStyleBackColor = false;
            this.removeProgramBtn.Click += new System.EventHandler(this.removeProgrammBtn_Click);
            // 
            // addProgramBtn
            // 
            this.addProgramBtn.BackColor = System.Drawing.Color.White;
            this.addProgramBtn.Location = new System.Drawing.Point(177, 62);
            this.addProgramBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProgramBtn.Name = "addProgramBtn";
            this.addProgramBtn.Size = new System.Drawing.Size(87, 29);
            this.addProgramBtn.TabIndex = 6;
            this.addProgramBtn.Text = "Add";
            this.addProgramBtn.UseVisualStyleBackColor = false;
            this.addProgramBtn.Click += new System.EventHandler(this.addProgrammBtn_Click);
            // 
            // programTextBox
            // 
            this.programTextBox.Location = new System.Drawing.Point(277, 62);
            this.programTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.programTextBox.Multiline = true;
            this.programTextBox.Name = "programTextBox";
            this.programTextBox.ReadOnly = true;
            this.programTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.programTextBox.Size = new System.Drawing.Size(317, 93);
            this.programTextBox.TabIndex = 5;
            // 
            // startProgram
            // 
            this.startProgram.AutoSize = true;
            this.startProgram.Location = new System.Drawing.Point(6, 68);
            this.startProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startProgram.Name = "startProgram";
            this.startProgram.Size = new System.Drawing.Size(146, 24);
            this.startProgram.TabIndex = 4;
            this.startProgram.Text = "Start Programs:";
            this.startProgram.UseVisualStyleBackColor = true;
            // 
            // applySimpleButton
            // 
            this.applySimpleButton.BackColor = System.Drawing.Color.White;
            this.applySimpleButton.Location = new System.Drawing.Point(605, 8);
            this.applySimpleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applySimpleButton.Name = "applySimpleButton";
            this.applySimpleButton.Size = new System.Drawing.Size(75, 39);
            this.applySimpleButton.TabIndex = 3;
            this.applySimpleButton.Text = "Apply";
            this.applySimpleButton.UseVisualStyleBackColor = false;
            this.applySimpleButton.Click += new System.EventHandler(this.applySimpleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "minutes of inactivity.";
            // 
            // shutdownCheck
            // 
            this.shutdownCheck.AutoSize = true;
            this.shutdownCheck.Location = new System.Drawing.Point(6, 384);
            this.shutdownCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shutdownCheck.Name = "shutdownCheck";
            this.shutdownCheck.Size = new System.Drawing.Size(215, 24);
            this.shutdownCheck.TabIndex = 1;
            this.shutdownCheck.Text = "Shutdown computer after";
            this.shutdownCheck.UseVisualStyleBackColor = true;
            // 
            // shutdownTimeTextBox
            // 
            this.shutdownTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shutdownTimeTextBox.Location = new System.Drawing.Point(227, 386);
            this.shutdownTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shutdownTimeTextBox.MaxLength = 4;
            this.shutdownTimeTextBox.Name = "shutdownTimeTextBox";
            this.shutdownTimeTextBox.Size = new System.Drawing.Size(37, 19);
            this.shutdownTimeTextBox.TabIndex = 0;
            this.shutdownTimeTextBox.Text = "60";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.website1);
            this.tabPage2.Controls.Add(this.cmdTextBox);
            this.tabPage2.Controls.Add(this.applyAdvancedButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(687, 789);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // website1
            // 
            this.website1.AutoSize = true;
            this.website1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website1.LinkArea = new System.Windows.Forms.LinkArea(40, 47);
            this.website1.Location = new System.Drawing.Point(11, 621);
            this.website1.Name = "website1";
            this.website1.Size = new System.Drawing.Size(363, 24);
            this.website1.TabIndex = 6;
            this.website1.TabStop = true;
            this.website1.Text = "Only use after reading the manual on my GitHub.";
            this.website1.UseCompatibleTextRendering = true;
            this.website1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.website1_LinkClicked);
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(7, 31);
            this.cmdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdTextBox.Multiline = true;
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(587, 578);
            this.cmdTextBox.TabIndex = 5;
            // 
            // applyAdvancedButton
            // 
            this.applyAdvancedButton.BackColor = System.Drawing.Color.White;
            this.applyAdvancedButton.Location = new System.Drawing.Point(605, 8);
            this.applyAdvancedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyAdvancedButton.Name = "applyAdvancedButton";
            this.applyAdvancedButton.Size = new System.Drawing.Size(75, 39);
            this.applyAdvancedButton.TabIndex = 4;
            this.applyAdvancedButton.Text = "Apply";
            this.applyAdvancedButton.UseVisualStyleBackColor = false;
            this.applyAdvancedButton.Click += new System.EventHandler(this.applyAdvancedButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CMD arguments:";
            // 
            // cpuLabel
            // 
            this.cpuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(6, 828);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(117, 20);
            this.cpuLabel.TabIndex = 3;
            this.cpuLabel.Text = "CPU: Unknown";
            // 
            // graphicsLabel
            // 
            this.graphicsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.graphicsLabel.AutoSize = true;
            this.graphicsLabel.Location = new System.Drawing.Point(6, 848);
            this.graphicsLabel.Name = "graphicsLabel";
            this.graphicsLabel.Size = new System.Drawing.Size(148, 20);
            this.graphicsLabel.TabIndex = 4;
            this.graphicsLabel.Text = "Graphics: Unknown";
            // 
            // ramLabel
            // 
            this.ramLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ramLabel.AutoSize = true;
            this.ramLabel.Location = new System.Drawing.Point(6, 868);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(120, 20);
            this.ramLabel.TabIndex = 5;
            this.ramLabel.Text = "RAM: Unknown";
            // 
            // osLabel
            // 
            this.osLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(443, 848);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(107, 20);
            this.osLabel.TabIndex = 6;
            this.osLabel.Text = "OS: Unknown";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(443, 868);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(161, 20);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "Software Version: 1.2";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(443, 828);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(126, 20);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name: Unknown";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "made by SanguineTunic || May 2018";
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 898);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.osLabel);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.graphicsLabel);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "StartUp-Utils: Options";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox shutdownCheck;
        private System.Windows.Forms.TextBox shutdownTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label graphicsLabel;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button applySimpleButton;
        private System.Windows.Forms.Button applyAdvancedButton;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.CheckBox startProgram;
        private System.Windows.Forms.TextBox programTextBox;
        private System.Windows.Forms.Button addProgramBtn;
        private System.Windows.Forms.Button removeProgramBtn;
        private System.Windows.Forms.TextBox websitesTextBox;
        private System.Windows.Forms.CheckBox openWebsite;
        private System.Windows.Forms.CheckBox playSounds;
        private System.Windows.Forms.Button removeSoundBtn;
        private System.Windows.Forms.Button addSoundBtn;
        private System.Windows.Forms.TextBox soundTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soundsDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel website2;
        private System.Windows.Forms.LinkLabel website1;
    }
}

