﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient1
{
    public partial class Form1 : Form
    {
        HelloService.HelloServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HelloService.HelloServiceClient("netTcpBinding");
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(client.GetMessage(txtName.Text));
        }

        private void rdbTcp_CheckedChanged(object sender, EventArgs e)
        {
            client = new HelloService.HelloServiceClient("netTcpBinding");
        }

        private void rdbHttp_CheckedChanged(object sender, EventArgs e)
        {
            client = new HelloService.HelloServiceClient("basicHttpBinding");
        }
    }
}
