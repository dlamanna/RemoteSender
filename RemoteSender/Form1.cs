using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteSender
{
    public partial class RemoteSender : Form
    {
        public RemoteSender()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            GlobalVar.ipaddress = toField.Text;
            GlobalVar.message = titleField.Text + " " + bodyField.Text;
            GlobalVar.connect();
        }

        private void RemoteSender_Load(object sender, EventArgs e) { this.toField.Text = GlobalVar.ipaddress; }
    }
}
