namespace TweetWatch
{
    partial class FormSettings
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
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            System.Windows.Forms.Panel panel4;
            System.Windows.Forms.Label label4;
            this.numericUpDownPollPeriod = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.panelColorContainer = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.textBoxSound = new System.Windows.Forms.TextBox();
            this.buttonSound = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonTitleClose = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonCancel = new System.Windows.Forms.Button();
            labelTitle = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPollPeriod)).BeginInit();
            panel2.SuspendLayout();
            this.panelColorContainer.SuspendLayout();
            panel4.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Enabled = false;
            labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTitle.Location = new System.Drawing.Point(4, 4);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(186, 24);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "TweetWatch Settings";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            panel1.Controls.Add(label1);
            panel1.Controls.Add(this.numericUpDownPollPeriod);
            panel1.Location = new System.Drawing.Point(13, 48);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(775, 81);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(14, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(742, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter the interval, in seconds, to check twitter for new tweets.";
            // 
            // numericUpDownPollPeriod
            // 
            this.numericUpDownPollPeriod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownPollPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPollPeriod.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPollPeriod.Location = new System.Drawing.Point(17, 42);
            this.numericUpDownPollPeriod.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPollPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPollPeriod.Name = "numericUpDownPollPeriod";
            this.numericUpDownPollPeriod.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownPollPeriod.TabIndex = 1;
            this.numericUpDownPollPeriod.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            panel2.Controls.Add(label2);
            panel2.Controls.Add(this.checkBoxMinimizeToTray);
            panel2.Location = new System.Drawing.Point(13, 145);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(775, 81);
            panel2.TabIndex = 20;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(14, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(742, 28);
            label2.TabIndex = 0;
            label2.Text = "Tick this box to have TweetWatch minmize to the system tray rather than the task " +
    "bar.\r\n";
            // 
            // checkBoxMinimizeToTray
            // 
            this.checkBoxMinimizeToTray.AutoSize = true;
            this.checkBoxMinimizeToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMinimizeToTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(17, 42);
            this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
            this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(199, 24);
            this.checkBoxMinimizeToTray.TabIndex = 13;
            this.checkBoxMinimizeToTray.Text = "Minimize To System Tray";
            this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // panelColorContainer
            // 
            this.panelColorContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panelColorContainer.Controls.Add(this.labelColor);
            this.panelColorContainer.Controls.Add(this.textBoxColor);
            this.panelColorContainer.Controls.Add(this.buttonChooseColor);
            this.panelColorContainer.Controls.Add(this.panelColor);
            this.panelColorContainer.Location = new System.Drawing.Point(13, 243);
            this.panelColorContainer.Name = "panelColorContainer";
            this.panelColorContainer.Size = new System.Drawing.Size(775, 101);
            this.panelColorContainer.TabIndex = 21;
            // 
            // labelColor
            // 
            this.labelColor.Location = new System.Drawing.Point(14, 11);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(742, 44);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = resources.GetString("labelColor.Text");
            // 
            // textBoxColor
            // 
            this.textBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(17, 60);
            this.textBoxColor.MinimumSize = new System.Drawing.Size(148, 24);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(148, 24);
            this.textBoxColor.TabIndex = 14;
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.FlatAppearance.BorderSize = 0;
            this.buttonChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseColor.Location = new System.Drawing.Point(237, 61);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(114, 23);
            this.buttonChooseColor.TabIndex = 16;
            this.buttonChooseColor.Text = "Choose color...";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(186, 60);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(43, 24);
            this.panelColor.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            panel4.Controls.Add(label4);
            panel4.Controls.Add(this.textBoxSound);
            panel4.Controls.Add(this.buttonSound);
            panel4.Location = new System.Drawing.Point(13, 363);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(775, 101);
            panel4.TabIndex = 22;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(14, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(742, 44);
            label4.TabIndex = 0;
            label4.Text = "Specify the name of the wav file to use as the alert sound. If just a file name w" +
    "ithout a full path is entered the TweetWatch will look for the file in the Tweet" +
    "Watch  application folder.";
            // 
            // textBoxSound
            // 
            this.textBoxSound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSound.Location = new System.Drawing.Point(17, 58);
            this.textBoxSound.MinimumSize = new System.Drawing.Size(148, 24);
            this.textBoxSound.Name = "textBoxSound";
            this.textBoxSound.Size = new System.Drawing.Size(607, 24);
            this.textBoxSound.TabIndex = 15;
            // 
            // buttonSound
            // 
            this.buttonSound.FlatAppearance.BorderSize = 0;
            this.buttonSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSound.Location = new System.Drawing.Point(630, 58);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(114, 23);
            this.buttonSound.TabIndex = 18;
            this.buttonSound.Text = "Choose sound...";
            this.buttonSound.UseVisualStyleBackColor = true;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(686, 490);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(102, 34);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "OK";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 543);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 4);
            this.panelBottom.TabIndex = 7;
            // 
            // buttonTitleClose
            // 
            this.buttonTitleClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonTitleClose.FlatAppearance.BorderSize = 0;
            this.buttonTitleClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTitleClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTitleClose.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonTitleClose.Location = new System.Drawing.Point(769, 0);
            this.buttonTitleClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTitleClose.Name = "buttonTitleClose";
            this.buttonTitleClose.Size = new System.Drawing.Size(31, 31);
            this.buttonTitleClose.TabIndex = 12;
            this.buttonTitleClose.TabStop = false;
            this.buttonTitleClose.Text = "X";
            this.buttonTitleClose.UseVisualStyleBackColor = true;
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
            this.panelTop.Size = new System.Drawing.Size(769, 31);
            this.panelTop.TabIndex = 10;
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "wav";
            this.openFileDialog.Filter = "WAV files|*.wav";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(567, 490);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 34);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(panel4);
            this.Controls.Add(this.panelColorContainer);
            this.Controls.Add(panel2);
            this.Controls.Add(panel1);
            this.Controls.Add(this.buttonTitleClose);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.buttonClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSettings";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPollPeriod)).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.panelColorContainer.ResumeLayout(false);
            this.panelColorContainer.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonTitleClose;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.NumericUpDown numericUpDownPollPeriod;
        private System.Windows.Forms.CheckBox checkBoxMinimizeToTray;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxSound;
        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Panel panelColorContainer;
    }
}