
namespace Telegrom
{
    partial class AuthForm
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
            this.panelAcctiveAcc = new System.Windows.Forms.Panel();
            this.lblActivePhone = new System.Windows.Forms.Label();
            this.lblActiveTxt = new System.Windows.Forms.Label();
            this.panelChanged = new System.Windows.Forms.Panel();
            this.lblChangedPhone = new System.Windows.Forms.Label();
            this.lvlSelectedTxt = new System.Windows.Forms.Label();
            this.listAcc = new System.Windows.Forms.ListBox();
            this.phoneBox = new System.Windows.Forms.GroupBox();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.GroupBox();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.panelAcctiveAcc.SuspendLayout();
            this.panelChanged.SuspendLayout();
            this.phoneBox.SuspendLayout();
            this.codeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcctiveAcc
            // 
            this.panelAcctiveAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAcctiveAcc.Controls.Add(this.lblActivePhone);
            this.panelAcctiveAcc.Controls.Add(this.lblActiveTxt);
            this.panelAcctiveAcc.Location = new System.Drawing.Point(13, 13);
            this.panelAcctiveAcc.Name = "panelAcctiveAcc";
            this.panelAcctiveAcc.Size = new System.Drawing.Size(203, 81);
            this.panelAcctiveAcc.TabIndex = 0;
            // 
            // lblActivePhone
            // 
            this.lblActivePhone.AutoSize = true;
            this.lblActivePhone.Location = new System.Drawing.Point(58, 13);
            this.lblActivePhone.Name = "lblActivePhone";
            this.lblActivePhone.Size = new System.Drawing.Size(16, 13);
            this.lblActivePhone.TabIndex = 0;
            this.lblActivePhone.Text = "---";
            // 
            // lblActiveTxt
            // 
            this.lblActiveTxt.AutoSize = true;
            this.lblActiveTxt.Location = new System.Drawing.Point(14, 13);
            this.lblActiveTxt.Name = "lblActiveTxt";
            this.lblActiveTxt.Size = new System.Drawing.Size(48, 13);
            this.lblActiveTxt.TabIndex = 0;
            this.lblActiveTxt.Text = "ACTIVE:";
            // 
            // panelChanged
            // 
            this.panelChanged.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChanged.Controls.Add(this.lblChangedPhone);
            this.panelChanged.Controls.Add(this.lvlSelectedTxt);
            this.panelChanged.Location = new System.Drawing.Point(13, 100);
            this.panelChanged.Name = "panelChanged";
            this.panelChanged.Size = new System.Drawing.Size(203, 81);
            this.panelChanged.TabIndex = 0;
            // 
            // lblChangedPhone
            // 
            this.lblChangedPhone.AutoSize = true;
            this.lblChangedPhone.Location = new System.Drawing.Point(86, 14);
            this.lblChangedPhone.Name = "lblChangedPhone";
            this.lblChangedPhone.Size = new System.Drawing.Size(16, 13);
            this.lblChangedPhone.TabIndex = 0;
            this.lblChangedPhone.Text = "---";
            // 
            // lvlSelectedTxt
            // 
            this.lvlSelectedTxt.AutoSize = true;
            this.lvlSelectedTxt.Location = new System.Drawing.Point(14, 14);
            this.lvlSelectedTxt.Name = "lvlSelectedTxt";
            this.lvlSelectedTxt.Size = new System.Drawing.Size(66, 13);
            this.lvlSelectedTxt.TabIndex = 0;
            this.lvlSelectedTxt.Text = "SELECTED:";
            // 
            // listAcc
            // 
            this.listAcc.FormattingEnabled = true;
            this.listAcc.Location = new System.Drawing.Point(223, 13);
            this.listAcc.Name = "listAcc";
            this.listAcc.Size = new System.Drawing.Size(198, 342);
            this.listAcc.TabIndex = 1;
            this.listAcc.SelectedIndexChanged += new System.EventHandler(this.listAcc_SelectedIndexChanged);
            // 
            // phoneBox
            // 
            this.phoneBox.Controls.Add(this.inputPhone);
            this.phoneBox.Controls.Add(this.btnSend);
            this.phoneBox.Location = new System.Drawing.Point(427, 13);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(204, 134);
            this.phoneBox.TabIndex = 2;
            this.phoneBox.TabStop = false;
            this.phoneBox.Text = "PHONE";
            // 
            // inputPhone
            // 
            this.inputPhone.Location = new System.Drawing.Point(5, 41);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(193, 20);
            this.inputPhone.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(6, 85);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(192, 31);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // codeBox
            // 
            this.codeBox.Controls.Add(this.inputCode);
            this.codeBox.Controls.Add(this.btnLogin);
            this.codeBox.Location = new System.Drawing.Point(426, 153);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(204, 134);
            this.codeBox.TabIndex = 2;
            this.codeBox.TabStop = false;
            this.codeBox.Text = "CODE";
            // 
            // inputCode
            // 
            this.inputCode.Location = new System.Drawing.Point(5, 40);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(193, 20);
            this.inputCode.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 84);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(192, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(427, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(203, 62);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(13, 208);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(204, 60);
            this.btnActivate.TabIndex = 3;
            this.btnActivate.Text = "ACTIVATE";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 60);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tick
            // 
            this.tick.Interval = 1000;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 366);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.listAcc);
            this.Controls.Add(this.panelChanged);
            this.Controls.Add(this.panelAcctiveAcc);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthForm_FormClosed);
            this.panelAcctiveAcc.ResumeLayout(false);
            this.panelAcctiveAcc.PerformLayout();
            this.panelChanged.ResumeLayout(false);
            this.panelChanged.PerformLayout();
            this.phoneBox.ResumeLayout(false);
            this.phoneBox.PerformLayout();
            this.codeBox.ResumeLayout(false);
            this.codeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAcctiveAcc;
        private System.Windows.Forms.Label lblActiveTxt;
        private System.Windows.Forms.Panel panelChanged;
        private System.Windows.Forms.Label lvlSelectedTxt;
        private System.Windows.Forms.ListBox listAcc;
        private System.Windows.Forms.GroupBox phoneBox;
        private System.Windows.Forms.TextBox inputPhone;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox codeBox;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblActivePhone;
        private System.Windows.Forms.Label lblChangedPhone;
        private System.Windows.Forms.Timer tick;
    }
}