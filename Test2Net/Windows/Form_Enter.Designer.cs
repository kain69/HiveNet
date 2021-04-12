namespace WinForms.Windows
{
    partial class Form_Enter
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
            this.lblChoice = new System.Windows.Forms.Label();
            this.btnMachine = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChoice
            // 
            this.lblChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChoice.Location = new System.Drawing.Point(39, 38);
            this.lblChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(357, 157);
            this.lblChoice.TabIndex = 0;
            this.lblChoice.Text = "Выберите приложение";
            this.lblChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMachine
            // 
            this.btnMachine.BackgroundImage = global::Test2Net.Properties.Resources.machine;
            this.btnMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMachine.Location = new System.Drawing.Point(39, 199);
            this.btnMachine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Size = new System.Drawing.Size(173, 160);
            this.btnMachine.TabIndex = 1;
            this.btnMachine.UseVisualStyleBackColor = true;
            this.btnMachine.Click += new System.EventHandler(this.btnMachine_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackgroundImage = global::Test2Net.Properties.Resources.server;
            this.btnServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServer.Location = new System.Drawing.Point(217, 199);
            this.btnServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(177, 160);
            this.btnServer.TabIndex = 2;
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // lblMachine
            // 
            this.lblMachine.Location = new System.Drawing.Point(39, 352);
            this.lblMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(173, 28);
            this.lblMachine.TabIndex = 3;
            this.lblMachine.Text = "Станок";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(217, 352);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(177, 28);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "Сервер";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 398);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 394);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "62.16.41.195";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(207, 398);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 7;
            // 
            // Form_Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(441, 425);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnMachine);
            this.Controls.Add(this.lblChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(459, 468);
            this.Name = "Form_Enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно выбора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Enter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Button btnMachine;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelError;
    }
}