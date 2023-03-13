using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                int num = int.Parse(textBox1.Text);
                MessageBox.Show("Резултат: " + Factorial(num));
            }
            catch (IOException) {
                MessageBox.Show("Моля въведете валидно цяло число");
                throw;
            }
        }

        private int Factorial(int number) {
            if (number == 1) {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}