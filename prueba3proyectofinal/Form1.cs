using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba3proyectofinal
{
    public partial class Form1 : Form
    {
        private int fila = 0;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;

            if (fila!=-1)
            {
                emp.Text = (string)guardreg.Rows[fila].Cells[0].Value;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sueldo, isr, igs, irt,sueldt;

            sueldo = Convert.ToInt32(suel.Text);

            isr = sueldo * 0.05;
            igs = sueldo * 0.055;
            irt = sueldo * 0.01;
            sueldt = sueldo - (isr + igs + irt);

            //crear nuevo renglón

            int fila = guardreg.Rows.Add();

            //llegar información

            guardreg.Rows[fila].Cells[0].Value = nom.Text;
            guardreg.Rows[fila].Cells[1].Value = ape.Text;
            guardreg.Rows[fila].Cells[2].Value = suel.Text;
            guardreg.Rows[fila].Cells[3].Value = isr;
            guardreg.Rows[fila].Cells[4].Value = igs;
            guardreg.Rows[fila].Cells[5].Value = irt;
            guardreg.Rows[fila].Cells[6].Value = sueldt;

            //limpiar los textbox despues de usarlos

            nom.Text = "";
            ape.Text = "";
            suel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fila!=-1)
            {
                guardreg.Rows.RemoveAt(fila);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Salir?", "El Chispudo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (salir==DialogResult.Yes)
            {
                Close();
            }
        }

        private void suel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo números","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }
    }
}
