using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TimerBlocking
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnStart_Click(object sender, EventArgs e) {
            int seconds = (int) numericUpDown1.Value;
            Thread.Sleep(seconds / 1000);
        }
    }
}