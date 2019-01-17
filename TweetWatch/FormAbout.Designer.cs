namespace TweetWatch
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.control1 = new System.Windows.Forms.Control();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 38);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1, 174);
            this.panelLeft.TabIndex = 12;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(391, 38);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1, 174);
            this.panelRight.TabIndex = 13;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(195, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "About TweetWatch";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(392, 38);
            this.panelTop.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(270, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Location = new System.Drawing.Point(1, 208);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(390, 4);
            this.panelBottom.TabIndex = 11;
            // 
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelVersion.Location = new System.Drawing.Point(158, 55);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(157, 23);
            this.labelVersion.TabIndex = 14;
            this.labelVersion.Text = "Version 1.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelCopyright.Location = new System.Drawing.Point(158, 94);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(222, 23);
            this.labelCopyright.TabIndex = 15;
            this.labelCopyright.Text = "Copyright (c) Aspallar 2018";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(0, 0);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(0, 0);
            this.control1.TabIndex = 0;
            this.control1.Text = "control1";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(392, 212);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAbout";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Control control1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
    }
}