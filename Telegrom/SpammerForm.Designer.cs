
namespace Telegrom
{
    partial class SpammerForm
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
            this.listLogins = new System.Windows.Forms.ListBox();
            this.listLogs = new System.Windows.Forms.ListBox();
            this.btnLoadLogins = new System.Windows.Forms.Button();
            this.btnSaveLogs = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.btnStartSpam = new System.Windows.Forms.Button();
            this.btnStopSpam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numOfMesToChange = new System.Windows.Forms.NumericUpDown();
            this.numOfDelay = new System.Windows.Forms.NumericUpDown();
            this.comBoxActAcc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numOfMesToChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // listLogins
            // 
            this.listLogins.FormattingEnabled = true;
            this.listLogins.Location = new System.Drawing.Point(3, 42);
            this.listLogins.Name = "listLogins";
            this.listLogins.Size = new System.Drawing.Size(158, 303);
            this.listLogins.TabIndex = 0;
            // 
            // listLogs
            // 
            this.listLogs.FormattingEnabled = true;
            this.listLogs.Location = new System.Drawing.Point(400, 42);
            this.listLogs.Name = "listLogs";
            this.listLogs.Size = new System.Drawing.Size(158, 303);
            this.listLogs.TabIndex = 0;
            // 
            // btnLoadLogins
            // 
            this.btnLoadLogins.Location = new System.Drawing.Point(86, 13);
            this.btnLoadLogins.Name = "btnLoadLogins";
            this.btnLoadLogins.Size = new System.Drawing.Size(75, 23);
            this.btnLoadLogins.TabIndex = 1;
            this.btnLoadLogins.Text = "LOAD";
            this.btnLoadLogins.UseVisualStyleBackColor = true;
            this.btnLoadLogins.Click += new System.EventHandler(this.btnLoadLogins_Click);
            // 
            // btnSaveLogs
            // 
            this.btnSaveLogs.Location = new System.Drawing.Point(483, 13);
            this.btnSaveLogs.Name = "btnSaveLogs";
            this.btnSaveLogs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLogs.TabIndex = 1;
            this.btnSaveLogs.Text = "SAVE";
            this.btnSaveLogs.UseVisualStyleBackColor = true;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(167, 134);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(227, 182);
            this.messageBox.TabIndex = 2;
            this.messageBox.Text = "";
            // 
            // btnStartSpam
            // 
            this.btnStartSpam.Location = new System.Drawing.Point(167, 322);
            this.btnStartSpam.Name = "btnStartSpam";
            this.btnStartSpam.Size = new System.Drawing.Size(111, 23);
            this.btnStartSpam.TabIndex = 1;
            this.btnStartSpam.Text = "START SPAM";
            this.btnStartSpam.UseVisualStyleBackColor = true;
            this.btnStartSpam.Click += new System.EventHandler(this.btnStartSpam_Click);
            // 
            // btnStopSpam
            // 
            this.btnStopSpam.Location = new System.Drawing.Point(284, 322);
            this.btnStopSpam.Name = "btnStopSpam";
            this.btnStopSpam.Size = new System.Drawing.Size(110, 23);
            this.btnStopSpam.TabIndex = 1;
            this.btnStopSpam.Text = "STOP SPAM";
            this.btnStopSpam.UseVisualStyleBackColor = true;
            this.btnStopSpam.Click += new System.EventHandler(this.btnStopSpam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(237, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SETTINGS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change account after";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Active account now";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Delay between messages";
            // 
            // numOfMesToChange
            // 
            this.numOfMesToChange.Location = new System.Drawing.Point(284, 39);
            this.numOfMesToChange.Name = "numOfMesToChange";
            this.numOfMesToChange.Size = new System.Drawing.Size(50, 20);
            this.numOfMesToChange.TabIndex = 5;
            this.numOfMesToChange.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numOfDelay
            // 
            this.numOfDelay.Location = new System.Drawing.Point(302, 102);
            this.numOfDelay.Name = "numOfDelay";
            this.numOfDelay.Size = new System.Drawing.Size(50, 20);
            this.numOfDelay.TabIndex = 5;
            this.numOfDelay.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // comBoxActAcc
            // 
            this.comBoxActAcc.FormattingEnabled = true;
            this.comBoxActAcc.Location = new System.Drawing.Point(277, 74);
            this.comBoxActAcc.Name = "comBoxActAcc";
            this.comBoxActAcc.Size = new System.Drawing.Size(117, 21);
            this.comBoxActAcc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(396, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Logs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-1, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Logins";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SpammerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 348);
            this.Controls.Add(this.comBoxActAcc);
            this.Controls.Add(this.numOfDelay);
            this.Controls.Add(this.numOfMesToChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.btnStopSpam);
            this.Controls.Add(this.btnStartSpam);
            this.Controls.Add(this.btnSaveLogs);
            this.Controls.Add(this.btnLoadLogins);
            this.Controls.Add(this.listLogs);
            this.Controls.Add(this.listLogins);
            this.Name = "SpammerForm";
            this.Text = "SpammerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpammerForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numOfMesToChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLogins;
        private System.Windows.Forms.ListBox listLogs;
        private System.Windows.Forms.Button btnLoadLogins;
        private System.Windows.Forms.Button btnSaveLogs;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Button btnStartSpam;
        private System.Windows.Forms.Button btnStopSpam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numOfMesToChange;
        private System.Windows.Forms.NumericUpDown numOfDelay;
        private System.Windows.Forms.ComboBox comBoxActAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer;
    }
}