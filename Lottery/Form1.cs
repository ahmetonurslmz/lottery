using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtHouseNumbers4_TextChanged(object sender, EventArgs e)
        {

        }

        static Random _random = new Random();

        public int generateRandomNumber(int range = 11)
        {
            /**
             * Get random system from static new Random.
             */
            return _random.Next(range);
        }

        private void btnGenerateRnadomNumbers_Click(object sender, EventArgs e)
        {
            txtYourNumbers1.Text = generateRandomNumber().ToString();
            txtYourNumbers2.Text = generateRandomNumber().ToString();
            txtYourNumbers3.Text = generateRandomNumber().ToString();
            txtYourNumbers4.Text = generateRandomNumber().ToString();
        }
    }
}
