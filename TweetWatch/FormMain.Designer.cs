namespace TweetWatch
{
    partial class FormMain
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
            System.Windows.Forms.Label labelTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.linkLabelTweetUrl = new System.Windows.Forms.LinkLabel();
            this.textBoxTweet = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            labelTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Enabled = false;
            labelTitle.Location = new System.Drawing.Point(4, 4);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(69, 13);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "TweetWatch";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 241);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(284, 4);
            this.panelBottom.TabIndex = 6;
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(12, 35);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSite.TabIndex = 0;
            this.comboBoxSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxSite_SelectedIndexChanged);
            // 
            // linkLabelTweetUrl
            // 
            this.linkLabelTweetUrl.AutoSize = true;
            this.linkLabelTweetUrl.LinkColor = System.Drawing.Color.White;
            this.linkLabelTweetUrl.Location = new System.Drawing.Point(12, 211);
            this.linkLabelTweetUrl.Name = "linkLabelTweetUrl";
            this.linkLabelTweetUrl.Size = new System.Drawing.Size(92, 13);
            this.linkLabelTweetUrl.TabIndex = 3;
            this.linkLabelTweetUrl.TabStop = true;
            this.linkLabelTweetUrl.Text = "linkLabelTweetUrl";
            this.linkLabelTweetUrl.Visible = false;
            this.linkLabelTweetUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTweetUrl_LinkClicked);
            // 
            // textBoxTweet
            // 
            this.textBoxTweet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBoxTweet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTweet.ForeColor = System.Drawing.Color.White;
            this.textBoxTweet.Location = new System.Drawing.Point(12, 81);
            this.textBoxTweet.Multiline = true;
            this.textBoxTweet.Name = "textBoxTweet";
            this.textBoxTweet.ReadOnly = true;
            this.textBoxTweet.Size = new System.Drawing.Size(256, 127);
            this.textBoxTweet.TabIndex = 2;
            this.textBoxTweet.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(168, 33);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Wingdings 2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelStatus.Location = new System.Drawing.Point(246, 32);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(33, 25);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "˜";
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.LinkColor = System.Drawing.Color.White;
            this.linkLabelSite.Location = new System.Drawing.Point(12, 59);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(67, 13);
            this.linkLabelSite.TabIndex = 2;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "linkLabelSite";
            this.linkLabelSite.Visible = false;
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTop.Controls.Add(labelTitle);
            this.panelTop.Enabled = false;
            this.panelTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(243, 20);
            this.panelTop.TabIndex = 7;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonMinimize.Location = new System.Drawing.Point(243, 0);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(23, 24);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Text = "▼";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonClose.Location = new System.Drawing.Point(261, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(23, 24);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.LinkColor = System.Drawing.Color.White;
            this.linkLabelAbout.Location = new System.Drawing.Point(181, 225);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(100, 13);
            this.linkLabelAbout.TabIndex = 10;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "About TweetWatch";
            this.linkLabelAbout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.linkLabelTweetUrl);
            this.Controls.Add(this.comboBoxSite);
            this.Controls.Add(this.textBoxTweet);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(284, 245);
            this.Name = "FormMain";
            this.Text = "TweetWatch";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.LinkLabel linkLabelTweetUrl;
        private System.Windows.Forms.TextBox textBoxTweet;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
    }
}

