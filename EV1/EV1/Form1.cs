using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV1
{
    public partial class Login_Rafael_Aruti : Form
    {
        public Login_Rafael_Aruti()
        {
            InitializeComponent();
            MessageBox.Show("Cargando....");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("Bienvenido al sistema");
                Form2 ficha = new Form2();
                ficha.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }
    }

}

      