
namespace Telegrom
{
    partial class ParserForm
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
            this.btnLoadDatabase = new System.Windows.Forms.Button();
            this.logsList = new System.Windows.Forms.ListBox();
            this.existTelegramPhonesList = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLogs = new System.Windows.Forms.Label();
            this.lblExistPhones = new System.Windows.Forms.Label();
            this.lblLost = new System.Windows.Forms.Label();
            this.withoutTelegramList = new System.Windows.Forms.ListBox();
            this.lblWithoutTelegram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadDatabase
            // 
            this.btnLoadDatabase.Location = new System.Drawing.Point(11, 12);
            this.btnLoadDatabase.Name = "btnLoadDatabase";
            this.btnLoadDatabase.Size = new System.Drawing.Size(90, 33);
            this.btnLoadDatabase.TabIndex = 0;
            this.btnLoadDatabase.Text = "LoadDatabase";
            this.btnLoadDatabase.UseVisualStyleBackColor = true;
            this.btnLoadDatabase.Click += new System.EventHandler(this.btnLoadDatabase_Click);
            // 
            // logsList
            // 
            this.logsList.FormattingEnabled = true;
            this.logsList.Location = new System.Drawing.Point(109, 51);
            this.logsList.Name = "logsList";
            this.logsList.Size = new System.Drawing.Size(200, 368);
            this.logsList.TabIndex = 1;
            // 
            // existTelegramPhonesList
            // 
            this.existTelegramPhonesList.FormattingEnabled = true;
            this.existTelegramPhonesList.Location = new System.Drawing.Point(315, 51);
            this.existTelegramPhonesList.Name = "existTelegramPhonesList";
            this.existTelegramPhonesList.Size = new System.Drawing.Size(200, 368);
            this.existTelegramPhonesList.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 51);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogs.Location = new System.Drawing.Point(185, 17);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(48, 20);
            this.lblLogs.TabIndex = 2;
            this.lblLogs.Text = "Logs";
            // 
            // lblExistPhones
            // 
            this.lblExistPhones.AutoSize = true;
            this.lblExistPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExistPhones.Location = new System.Drawing.Point(367, 17);
            this.lblExistPhones.Name = "lblExistPhones";
            this.lblExistPhones.Size = new System.Drawing.Size(108, 20);
            this.lblExistPhones.TabIndex = 2;
            this.lblExistPhones.Text = "ExistPhones";
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Location = new System.Drawing.Point(11, 128);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(33, 13);
            this.lblLost.TabIndex = 3;
            this.lblLost.Text = "Lost: ";
            // 
            // withoutTelegramList
            // 
            this.withoutTelegramList.FormattingEnabled = true;
            this.withoutTelegramList.Location = new System.Drawing.Point(521, 51);
            this.withoutTelegramList.Name = "withoutTelegramList";
            this.withoutTelegramList.Size = new System.Drawing.Size(200, 368);
            this.withoutTelegramList.TabIndex = 1;
            // 
            // lblWithoutTelegram
            // 
            this.lblWithoutTelegram.AutoSize = true;
            this.lblWithoutTelegram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWithoutTelegram.Location = new System.Drawing.Point(551, 17);
            this.lblWithoutTelegram.Name = "lblWithoutTelegram";
            this.lblWithoutTelegram.Size = new System.Drawing.Size(145, 20);
            this.lblWithoutTelegram.TabIndex = 2;
            this.lblWithoutTelegram.Text = "WithoutTelegram";
            // 
            // ParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 424);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.lblWithoutTelegram);
            this.Controls.Add(this.lblExistPhones);
            this.Controls.Add(this.lblLogs);
            this.Controls.Add(this.withoutTelegramList);
            this.Controls.Add(this.existTelegramPhonesList);
            this.Controls.Add(this.logsList);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLoadDatabase);
            this.Name = "ParserForm";
            this.Text = "ParserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParserForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadDatabase;
        private System.Windows.Forms.ListBox logsList;
        private System.Windows.Forms.ListBox existTelegramPhonesList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.Label lblExistPhones;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.ListBox withoutTelegramList;
        private System.Windows.Forms.Label lblWithoutTelegram;
    }
}