﻿using System;
using System.Windows.Forms;
using WinForms.Client;
using System.Drawing;

namespace WinForms.Windows
{
    public partial class Form_Client : Form
    {
        public Form_Client()
        {
            InitializeComponent();
        }

        delegate void Delegate(object value);

        public int progress
        {
            get => pbar.Value;
            set => pbar.Invoke(new Delegate((s) => pbar.Value = (int)value), "newText");
        }

        public string Error
        {
            get => lblError.Text;
            set => lblError.Invoke(new Delegate((s) => lblError.Text = (string)value), "newText");
        }
        
        public string Status
        {
            get => lblStatusUI.Text;
            set
            {
                lblStatusUI.Invoke(new Delegate((s) => lblStatusUI.Text = (string)value), "newText");
                if (lblStatusUI.Text == "Connected")
                    lblStatusUI.Invoke(new Delegate((s) => lblStatusUI.ForeColor = Color.Green), "newText");
                else
                    lblStatusUI.Invoke(new Delegate((s) => lblStatusUI.ForeColor = Color.Red), "newText");
            }
        }

        public string UserName
        {
            get => cmbbxName.Text;
        }

        private void Form_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Enter formEnter = (Form_Enter)Application.OpenForms["Form_Enter"];
            formEnter.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ClientObject client = new ClientObject(this);
            client.Connect();
        }
    }
}
