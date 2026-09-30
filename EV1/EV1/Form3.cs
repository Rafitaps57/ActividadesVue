using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EV1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            textBox1.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("radioButton1 fue seleccionado");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("radioButton2 fue seleccionado");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("radioButton3 fue seleccionado");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(textBox3.Text, out n))
            {
                MessageBox.Show("Introduce un número");
                return;
            }

            if (n < 1)
            {
                MessageBox.Show("Introduce un número");
                return;
            }

            int i = 1;
            var sb = new StringBuilder();
            while (i <= n)
            {
                if (sb.Length > 0) sb.Append(", ");
                sb.Append(i);
                i += 2; 
            }

            MessageBox.Show(sb.ToString(), "Serie impares");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int anioNacimiento = Convert.ToInt32(comboBox1.SelectedItem);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
