using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + (
                textBox1.Text + " " +
                textBox2.Text + ", " +
                textBox4.Text + " лет," +
                Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox7.Text) + " руб.") +
                Environment.NewLine;
            textBox1.Text = ""; textBox2.Text = ""; textBox4.Text = "";
            textBox5.Text = ""; textBox6.Text = ""; textBox7.Text = "";
        }
    }
}
