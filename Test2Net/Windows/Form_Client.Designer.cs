﻿namespace WinForms.Windows
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
            this.cmbbxName = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatusUI = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cmbbxName);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.pbar);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.lblStatusUI);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 163);
            this.panel1.TabIndex = 0;
            // 
            // cmbbxName
            // 
            this.cmbbxName.FormattingEnabled = true;
            this.cmbbxName.Items.AddRange(new object[] {
            "R2D2",
            "Станок Василий"});
            this.cmbbxName.Location = new System.Drawing.Point(94, 12);
            this.cmbbxName.Name = "cmbbxName";
            this.cmbbxName.Size = new System.Drawing.Size(228, 21);
            this.cmbbxName.TabIndex = 8;
            // 
            // lblError
            // 
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Green;
            this.lblError.Location = new System.Drawing.Point(0, 136);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(334, 27);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Хорошо!";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(11, 95);
            this.pbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(312, 32);
            this.pbar.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(222, 41);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(101, 36);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatusUI
            // 
            this.lblStatusUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusUI.ForeColor = System.Drawing.Color.Red;
            this.lblStatusUI.Location = new System.Drawing.Point(89, 41);
            this.lblStatusUI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusUI.Name = "lblStatusUI";
            this.lblStatusUI.Size = new System.Drawing.Size(135, 30);
            this.lblStatusUI.TabIndex = 2;
            this.lblStatusUI.Text = "Not Connection";
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
            this.ClientSize = new System.Drawing.Size(334, 163);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(500, 250);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Client_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatusUI;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbbxName;
    }
}

