namespace Final_Project
{
    partial class WelcomeWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeWindow));
            this.toolTipWelcomeWindowRobot = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxRobot = new System.Windows.Forms.PictureBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.toolTipWelcomeWindowButtons = new System.Windows.Forms.ToolTip(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.toolTipSocial = new System.Windows.Forms.ToolTip(this.components);
            this.buttonLinedIn = new System.Windows.Forms.Button();
            this.buttonFacebook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobot)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTipWelcomeWindowRobot
            // 
            this.toolTipWelcomeWindowRobot.AutoPopDelay = 6000;
            this.toolTipWelcomeWindowRobot.InitialDelay = 500;
            this.toolTipWelcomeWindowRobot.IsBalloon = true;
            this.toolTipWelcomeWindowRobot.ReshowDelay = 500;
            this.toolTipWelcomeWindowRobot.ToolTipTitle = "Hello!";
            // 
            // pictureBoxRobot
            // 
            this.pictureBoxRobot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRobot.ErrorImage = global::Final_Project.Properties.Resources.robotImage;
            this.pictureBoxRobot.Image = global::Final_Project.Properties.Resources.robotImage;
            this.pictureBoxRobot.Location = new System.Drawing.Point(18, 18);
            this.pictureBoxRobot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxRobot.Name = "pictureBoxRobot";
            this.pictureBoxRobot.Size = new System.Drawing.Size(510, 732);
            this.pictureBoxRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRobot.TabIndex = 0;
            this.pictureBoxRobot.TabStop = false;
            this.toolTipWelcomeWindowRobot.SetToolTip(this.pictureBoxRobot, "Hey user!\r\nI am grapher, your graph assitant.\r\nI  will assist you with your graph" +
        " assignments.\r\n*(whispers) Even I know graph as much as you :D*");
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonExit);
            this.panelControls.Controls.Add(this.buttonMinimize);
            this.panelControls.Controls.Add(this.buttonInfo);
            this.panelControls.Location = new System.Drawing.Point(962, 17);
            this.panelControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(146, 43);
            this.panelControls.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = global::Final_Project.Properties.Resources.exitImage;
            this.buttonExit.Location = new System.Drawing.Point(100, 3);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(38, 38);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::Final_Project.Properties.Resources.minimizeImage;
            this.buttonMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimize.Location = new System.Drawing.Point(54, 3);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(38, 38);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Image = global::Final_Project.Properties.Resources.aboutImage;
            this.buttonInfo.Location = new System.Drawing.Point(8, 3);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(38, 38);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // toolTipWelcomeWindowButtons
            // 
            this.toolTipWelcomeWindowButtons.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // buttonStart
            // 
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Image = global::Final_Project.Properties.Resources.graphImage;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(618, 343);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(435, 123);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Let\'s graph ....";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // toolTipSocial
            // 
            this.toolTipSocial.AutoPopDelay = 5000;
            this.toolTipSocial.InitialDelay = 50;
            this.toolTipSocial.IsBalloon = true;
            this.toolTipSocial.ReshowDelay = 80;
            // 
            // buttonLinedIn
            // 
            this.buttonLinedIn.FlatAppearance.BorderSize = 0;
            this.buttonLinedIn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLinedIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLinedIn.Image = global::Final_Project.Properties.Resources.linkedinImage__2_;
            this.buttonLinedIn.Location = new System.Drawing.Point(969, 660);
            this.buttonLinedIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLinedIn.Name = "buttonLinedIn";
            this.buttonLinedIn.Size = new System.Drawing.Size(60, 62);
            this.buttonLinedIn.TabIndex = 3;
            this.buttonLinedIn.UseVisualStyleBackColor = true;
            this.buttonLinedIn.Click += new System.EventHandler(this.buttonLinedIn_Click);
            // 
            // buttonFacebook
            // 
            this.buttonFacebook.FlatAppearance.BorderSize = 0;
            this.buttonFacebook.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacebook.Image = global::Final_Project.Properties.Resources.facebookImage__2_;
            this.buttonFacebook.Location = new System.Drawing.Point(1038, 660);
            this.buttonFacebook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFacebook.Name = "buttonFacebook";
            this.buttonFacebook.Size = new System.Drawing.Size(60, 62);
            this.buttonFacebook.TabIndex = 0;
            this.buttonFacebook.UseVisualStyleBackColor = true;
            this.buttonFacebook.Click += new System.EventHandler(this.buttonFacebook_Click);
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1125, 769);
            this.Controls.Add(this.buttonLinedIn);
            this.Controls.Add(this.buttonFacebook);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.pictureBoxRobot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WelcomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobot)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipWelcomeWindowRobot;
        private System.Windows.Forms.PictureBox pictureBoxRobot;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.ToolTip toolTipWelcomeWindowButtons;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFacebook;
        private System.Windows.Forms.ToolTip toolTipSocial;
        private System.Windows.Forms.Button buttonLinedIn;
    }
}