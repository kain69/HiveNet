using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Net
{
    public partial class Form_Enter : Form
    {
        public Form_Enter()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Form_Server formServer = new Form_Server();
            formServer.Show();
            this.Hide();
        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            Form_Client formClient = new Form_Client();
            formClient.Show();
            this.Hide();
        }

        private void Form_Enter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }        
    }
}
