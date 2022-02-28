
namespace Telegrom
{
    partial class TelegromForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAccManager = new System.Windows.Forms.Button();
            this.btnSpammer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccManager
            // 
            this.btnAccManager.Location = new System.Drawing.Point(12, 12);
            this.btnAccManager.Name = "btnAccManager";
            this.btnAccManager.Size = new System.Drawing.Size(260, 54);
            this.btnAccManager.TabIndex = 0;
            this.btnAccManager.Text = "ACC_MANAGER";
            this.btnAccManager.UseVisualStyleBackColor = true;
            this.btnAccManager.Click += new System.EventHandler(this.btnAccManager_Click);
            // 
            // btnSpammer
            // 
            this.btnSpammer.Location = new System.Drawing.Point(12, 72);
            this.btnSpammer.Name = "btnSpammer";
            this.btnSpammer.Size = new System.Drawing.Size(260, 54);
            this.btnSpammer.TabIndex = 0;
            this.btnSpammer.Text = "SPAMMER";
            this.btnSpammer.UseVisualStyleBackColor = true;
            this.btnSpammer.Click += new System.EventHandler(this.btnSpammer_Click);
            // 
            // TelegromForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.btnSpammer);
            this.Controls.Add(this.btnAccManager);
            this.Name = "TelegromForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccManager;
        private System.Windows.Forms.Button btnSpammer;
    }
}

