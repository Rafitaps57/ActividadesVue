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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fORM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema");
            Form3 ficha = new Form3();
            ficha.Show();
            this.Hide();
        }

        private void fORM4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema");
            Form4 ficha = new Form4();
            ficha.Show();
            this.Hide();
        }

        private void fORM5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema");
            Form5 ficha = new Form5();
            ficha.Show();
            this.Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "¿Está seguro de que desea salir del programa?",
            "Confirmación",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question
        );

            if (respuesta == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
