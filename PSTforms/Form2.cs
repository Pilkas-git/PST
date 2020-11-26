using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSTforms
{
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
            txtText.Text = text;
            txtText.BorderStyle = 0;
            txtText.BackColor = BackColor;
            txtText.Multiline = true;
            txtText.TabStop = false;
            txtText.WordWrap = true;

            txtText.Width = Width - 40;
            txtText.Height = Height - 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            txtText.Width = Width - 30;
            txtText.Height = Height - 30;
        }
    }
}
