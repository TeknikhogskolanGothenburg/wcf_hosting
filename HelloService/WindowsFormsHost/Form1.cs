using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace WindowsFormsHost
{
    public partial class Form1 : Form
    {
        ServiceHost host;
        public Form1()
        {
            InitializeComponent();
            host = new ServiceHost(typeof(HelloService.HelloService));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(host.State == CommunicationState.Closed || host.State == CommunicationState.Created)
            {
                host = new ServiceHost(typeof(HelloService.HelloService));
                host.Open();
                lblStatus.Text = "Host is connected";
                lblStatus.ForeColor = Color.Green;
                btnConnect.Text = "Disconnect";
            }
            else
            {
                host.Close();
                lblStatus.Text = "Host is disconnected";
                lblStatus.ForeColor = Color.Red;
                btnConnect.Text = "Connect";
            }
        }
    }
}
