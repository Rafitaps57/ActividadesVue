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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EV1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(
                textBox1.Text,
                textBox2.Text,
                comboBox1.SelectedItem?.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila válida para eliminar.");
            }

        }
        private void LimpiarFormulario()
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            // Crear las columnas del DataGridView
            dataGridView1.Columns.Add("colCodigo", "CODIGOPRODUCTO");
            dataGridView1.Columns.Add("colNombre", "NOMBREPRODUCTO");
            dataGridView1.Columns.Add("colCategoria", "CATEGORIA");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.Items.AddRange(new string[] { "Bebidas", "Lacteos", "Abarrotes" });
        }
    }
}

