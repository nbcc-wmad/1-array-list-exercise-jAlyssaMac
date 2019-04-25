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
        ArrayList sentence = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sentence.Add("I");
            sentence.Add("Love");
            sentence.Add("Programming");
            sentence.Add("So");
            sentence.Add("Much");

            TestMethod();
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Join(" ", sentence.ToArray());
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Join(" ", sentence.ToArray().Reverse());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sentence.Insert(1, txtSecondPos.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sentence.RemoveAt(1);
        }

        private void TestMethod()
        {
            MessageBox.Show("Hello");
        }
    }
}
