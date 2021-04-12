using System;
using System.Windows.Forms;

namespace WinForms.Windows
{
    public partial class Form_Enter : Form
    {
        private Form_Server formServer;
        private Form_Client formClient;

        public Form_Enter()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            formServer = new Form_Server();
            formServer.Show();
            this.Hide();
        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            var test = textBox1.Text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            if (test.Length == 4)
            {
                foreach (var word in test)
                {
                    if (int.TryParse(word, out _))
                    {
                        continue;
                    }
                    else
                    {
                        labelError.Text = "Неправильный IP";
                        return;
                    }
                }
                formClient = new Form_Client(textBox1.Text);
                formClient.Show();
                this.Hide();
                labelError.Text = "";
                return;
            }
            labelError.Text = "Неправильный IP";
            return;

        }

        private void Form_Enter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }        
    }
}
