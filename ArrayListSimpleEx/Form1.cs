using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList message = new ArrayList();
        private bool click;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.Text = message.ToString();
        }

        private void LoadList()
        {
            message.Add("I ");
            message.Add("Love ");
            message.Add("Programming ");
            message.Add("So ");
            message.Add("Much");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
