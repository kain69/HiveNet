namespace WinForms.Windows
{
    partial class Form_Server
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
            this.btnServerStop = new System.Windows.Forms.Button();
            this.btnServStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelWork1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.lblType1 = new System.Windows.Forms.Label();
            this.panelWork2 = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.lblType2 = new System.Windows.Forms.Label();
            this.panelWork3 = new System.Windows.Forms.Panel();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.btnStart3 = new System.Windows.Forms.Button();
            this.lblType3 = new System.Windows.Forms.Label();
            this.panelWork4 = new System.Windows.Forms.Panel();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.btnStart4 = new System.Windows.Forms.Button();
            this.lblType4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatusLog = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelWork1.SuspendLayout();
            this.panelWork2.SuspendLayout();
            this.panelWork3.SuspendLayout();
            this.panelWork4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnServerStop);
            this.panel1.Controls.Add(this.btnServStart);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 635);
            this.panel1.TabIndex = 0;
            // 
            // btnServerStop
            // 
            this.btnServerStop.Location = new System.Drawing.Point(117, 64);
            this.btnServerStop.Name = "btnServerStop";
            this.btnServerStop.Size = new System.Drawing.Size(91, 42);
            this.btnServerStop.TabIndex = 2;
            this.btnServerStop.Text = "Остановить";
            this.btnServerStop.UseVisualStyleBackColor = true;
            this.btnServerStop.Click += new System.EventHandler(this.btnServerStop_Click);
            // 
            // btnServStart
            // 
            this.btnServStart.Location = new System.Drawing.Point(8, 64);
            this.btnServStart.Name = "btnServStart";
            this.btnServStart.Size = new System.Drawing.Size(91, 42);
            this.btnServStart.TabIndex = 1;
            this.btnServStart.Text = "Запустить";
            this.btnServStart.UseVisualStyleBackColor = true;
            this.btnServStart.Click += new System.EventHandler(this.btnServStart_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 60);
            this.label5.TabIndex = 0;
            this.label5.Text = "Управление сервером";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panelWork1);
            this.flowLayoutPanel1.Controls.Add(this.panelWork2);
            this.flowLayoutPanel1.Controls.Add(this.panelWork3);
            this.flowLayoutPanel1.Controls.Add(this.panelWork4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(218, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(834, 635);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelWork1
            // 
            this.panelWork1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelWork1.Controls.Add(this.progressBar1);
            this.panelWork1.Controls.Add(this.btnStart1);
            this.panelWork1.Controls.Add(this.lblType1);
            this.panelWork1.Location = new System.Drawing.Point(3, 3);
            this.panelWork1.Name = "panelWork1";
            this.panelWork1.Size = new System.Drawing.Size(200, 196);
            this.panelWork1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 30);
            this.progressBar1.TabIndex = 2;
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(0, 56);
            this.btnStart1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(200, 40);
            this.btnStart1.TabIndex = 1;
            this.btnStart1.Text = "Старт";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // lblType1
            // 
            this.lblType1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType1.Location = new System.Drawing.Point(0, 0);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(200, 56);
            this.lblType1.TabIndex = 0;
            this.lblType1.Text = "Not Connection";
            this.lblType1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWork2
            // 
            this.panelWork2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelWork2.Controls.Add(this.progressBar2);
            this.panelWork2.Controls.Add(this.btnStart2);
            this.panelWork2.Controls.Add(this.lblType2);
            this.panelWork2.Location = new System.Drawing.Point(209, 3);
            this.panelWork2.Name = "panelWork2";
            this.panelWork2.Size = new System.Drawing.Size(200, 196);
            this.panelWork2.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar2.Location = new System.Drawing.Point(0, 166);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(200, 30);
            this.progressBar2.TabIndex = 2;
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(0, 56);
            this.btnStart2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(200, 40);
            this.btnStart2.TabIndex = 1;
            this.btnStart2.Text = "Старт";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // lblType2
            // 
            this.lblType2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType2.Location = new System.Drawing.Point(0, 0);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(200, 56);
            this.lblType2.TabIndex = 0;
            this.lblType2.Text = "Not Connection";
            this.lblType2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWork3
            // 
            this.panelWork3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelWork3.Controls.Add(this.progressBar3);
            this.panelWork3.Controls.Add(this.btnStart3);
            this.panelWork3.Controls.Add(this.lblType3);
            this.panelWork3.Location = new System.Drawing.Point(415, 3);
            this.panelWork3.Name = "panelWork3";
            this.panelWork3.Size = new System.Drawing.Size(200, 196);
            this.panelWork3.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar3.Location = new System.Drawing.Point(0, 166);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(200, 30);
            this.progressBar3.TabIndex = 2;
            // 
            // btnStart3
            // 
            this.btnStart3.Location = new System.Drawing.Point(0, 56);
            this.btnStart3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnStart3.Name = "btnStart3";
            this.btnStart3.Size = new System.Drawing.Size(200, 40);
            this.btnStart3.TabIndex = 1;
            this.btnStart3.Text = "Старт";
            this.btnStart3.UseVisualStyleBackColor = true;
            this.btnStart3.Click += new System.EventHandler(this.btnStart3_Click);
            // 
            // lblType3
            // 
            this.lblType3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblType3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType3.Location = new System.Drawing.Point(0, 0);
            this.lblType3.Name = "lblType3";
            this.lblType3.Size = new System.Drawing.Size(200, 56);
            this.lblType3.TabIndex = 0;
            this.lblType3.Text = "Not Connection";
            this.lblType3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWork4
            // 
            this.panelWork4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelWork4.Controls.Add(this.progressBar4);
            this.panelWork4.Controls.Add(this.btnStart4);
            this.panelWork4.Controls.Add(this.lblType4);
            this.panelWork4.Location = new System.Drawing.Point(621, 3);
            this.panelWork4.Name = "panelWork4";
            this.panelWork4.Size = new System.Drawing.Size(200, 196);
            this.panelWork4.TabIndex = 3;
            // 
            // progressBar4
            // 
            this.progressBar4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar4.Location = new System.Drawing.Point(0, 166);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(200, 30);
            this.progressBar4.TabIndex = 2;
            // 
            // btnStart4
            // 
            this.btnStart4.Location = new System.Drawing.Point(0, 56);
            this.btnStart4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnStart4.Name = "btnStart4";
            this.btnStart4.Size = new System.Drawing.Size(200, 40);
            this.btnStart4.TabIndex = 1;
            this.btnStart4.Text = "Старт";
            this.btnStart4.UseVisualStyleBackColor = true;
            this.btnStart4.Click += new System.EventHandler(this.btnStart4_Click);
            // 
            // lblType4
            // 
            this.lblType4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblType4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType4.Location = new System.Drawing.Point(0, 0);
            this.lblType4.Name = "lblType4";
            this.lblType4.Size = new System.Drawing.Size(200, 56);
            this.lblType4.TabIndex = 0;
            this.lblType4.Text = "Not Connection";
            this.lblType4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.lblStatusLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(218, 607);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 28);
            this.panel2.TabIndex = 2;
            // 
            // lblStatusLog
            // 
            this.lblStatusLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusLog.Location = new System.Drawing.Point(0, 0);
            this.lblStatusLog.Name = "lblStatusLog";
            this.lblStatusLog.Size = new System.Drawing.Size(834, 28);
            this.lblStatusLog.TabIndex = 0;
            this.lblStatusLog.Text = "Статус: Без ошибок";
            this.lblStatusLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Server_FormClosing);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelWork1.ResumeLayout(false);
            this.panelWork2.ResumeLayout(false);
            this.panelWork3.ResumeLayout(false);
            this.panelWork4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnServerStop;
        private System.Windows.Forms.Button btnServStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelWork1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Panel panelWork2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Panel panelWork3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button btnStart3;
        private System.Windows.Forms.Label lblType3;
        private System.Windows.Forms.Panel panelWork4;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button btnStart4;
        private System.Windows.Forms.Label lblType4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatusLog;
    }
}

