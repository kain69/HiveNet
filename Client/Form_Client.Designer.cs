namespace Test2Net
{
    partial class Form_Client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModel1 = new System.Windows.Forms.Button();
            this.lblNameUI = new System.Windows.Forms.Label();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.btnModel2 = new System.Windows.Forms.Button();
            this.lblStatusUI = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnModel1);
            this.panel1.Controls.Add(this.lblNameUI);
            this.panel1.Controls.Add(this.pbar);
            this.panel1.Controls.Add(this.btnModel2);
            this.panel1.Controls.Add(this.lblStatusUI);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 171);
            this.panel1.TabIndex = 0;
            // 
            // btnModel1
            // 
            this.btnModel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModel1.Location = new System.Drawing.Point(116, 89);
            this.btnModel1.Margin = new System.Windows.Forms.Padding(2);
            this.btnModel1.Name = "btnModel1";
            this.btnModel1.Size = new System.Drawing.Size(99, 36);
            this.btnModel1.TabIndex = 6;
            this.btnModel1.Text = "model_1";
            this.btnModel1.UseVisualStyleBackColor = true;
            // 
            // lblNameUI
            // 
            this.lblNameUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameUI.Location = new System.Drawing.Point(84, 9);
            this.lblNameUI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameUI.Name = "lblNameUI";
            this.lblNameUI.Size = new System.Drawing.Size(140, 31);
            this.lblNameUI.TabIndex = 5;
            this.lblNameUI.Text = "Client-228";
            this.lblNameUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(10, 129);
            this.pbar.Margin = new System.Windows.Forms.Padding(2);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(205, 32);
            this.pbar.TabIndex = 4;
            // 
            // btnModel2
            // 
            this.btnModel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModel2.Location = new System.Drawing.Point(10, 89);
            this.btnModel2.Margin = new System.Windows.Forms.Padding(2);
            this.btnModel2.Name = "btnModel2";
            this.btnModel2.Size = new System.Drawing.Size(101, 36);
            this.btnModel2.TabIndex = 3;
            this.btnModel2.Text = "model_2";
            this.btnModel2.UseVisualStyleBackColor = true;
            // 
            // lblStatusUI
            // 
            this.lblStatusUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusUI.ForeColor = System.Drawing.Color.Red;
            this.lblStatusUI.Location = new System.Drawing.Point(95, 41);
            this.lblStatusUI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusUI.Name = "lblStatusUI";
            this.lblStatusUI.Size = new System.Drawing.Size(104, 30);
            this.lblStatusUI.TabIndex = 2;
            this.lblStatusUI.Text = "Not Connect";
            this.lblStatusUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(12, 41);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 30);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(10, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 167);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Client_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNameUI;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Button btnModel2;
        private System.Windows.Forms.Label lblStatusUI;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnModel1;
    }
}

