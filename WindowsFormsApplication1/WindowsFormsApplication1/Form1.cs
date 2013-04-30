using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puntos = 0;

            if (this.pcristy.Checked) puntos++;

            if (this.p20.Text == "20") puntos++;

            if (this.pmexico.Checked) puntos++;


            string fechaSeleccionada = calendario.ToString();
            if (fechaSeleccionada == "03/06/1991")
            {
                puntos++;
            }
            string nombre = this.Nombre.Text;
            string codigo = this.Codigo.Text;
            string grupo = this.Grupo.Text;

            MessageBox.Show("\nEl alumno: " + nombre + "\nCon codigo: " + codigo + "\nTiene " + puntos + " puntos de 5 ","Calificacion",MessageBoxButtons.OK);



        }



    }
}
