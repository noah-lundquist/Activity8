using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carbsfatcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Fat.Text = "Calories From Fat " +FatCalories(int.Parse(textBox1.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carbs.Text = "Calories From Carbs " +CarbCalories(int.Parse(textBox2.Text));

        }

        public static int FatCalories(int fat)
        {
            return fat * 9;
        }

        public static int CarbCalories(int carbs)
        {
            return carbs * 4;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
