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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.linkLabelTweetUrl = new System.Windows.Forms.LinkLabel();
            this.textBoxTweet = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSite.TabIndex = 0;
            this.comboBoxSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxSite_SelectedIndexChanged);
            // 
            // linkLabelTweetUrl
            // 
            this.linkLabelTweetUrl.AutoSize = true;
            this.linkLabelTweetUrl.Location = new System.Drawing.Point(12, 188);
            this.linkLabelTweetUrl.Name = "linkLabelTweetUrl";
            this.linkLabelTweetUrl.Size = new System.Drawing.Size(92, 13);
            this.linkLabelTweetUrl.TabIndex = 1;
            this.linkLabelTweetUrl.TabStop = true;
            this.linkLabelTweetUrl.Text = "linkLabelTweetUrl";
            this.linkLabelTweetUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTweetUrl_LinkClicked);
            // 
            // textBoxTweet
            // 
            this.textBoxTweet.Enabled = false;
            this.textBoxTweet.Location = new System.Drawing.Point(12, 58);
            this.textBoxTweet.Multiline = true;
            this.textBoxTweet.Name = "textBoxTweet";
            this.textBoxTweet.Size = new System.Drawing.Size(256, 127);
            this.textBoxTweet.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(168, 10);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Wingdings 2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelStatus.Location = new System.Drawing.Point(246, 9);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(33, 25);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "˜";
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(12, 36);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(67, 13);
            this.linkLabelSite.TabIndex = 5;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "linkLabelSite";
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxTweet);
            this.Controls.Add(this.linkLabelTweetUrl);
            this.Controls.Add(this.comboBoxSite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "TweetWatch";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
    }
}

