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

namespace WindowsFormsClient2
{
    public partial class Form1 : Form
    {
        HelloService.HelloServiceClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            client = new HelloService.HelloServiceClient("basicHttpBinding");
            MessageBox.Show(client.GetMessage(txtName.Text));
        }
    }
}
