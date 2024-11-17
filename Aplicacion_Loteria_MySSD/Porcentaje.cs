using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Aplicacion_Loteria_MySSD
{
    public partial class Porcentaje : Form
    {
        //Lista para almacenar todas las cartas seleccionadas
        private List<string[]> datosAcumulados = new List<string[]>();

        public Porcentaje()
        {
            InitializeComponent();
        }

        // Método para agregar datos al DataGridView
        public void CargarDatos(string[] nuevaCarta)
        {
            // Calcular el valor de "# Rectangular"
            float tasaAparicion = float.Parse(nuevaCarta[2].TrimEnd('%')) / 100;
            string valorRectangular = tasaAparicion.ToString("F4"); // Formato con 4 decimales

            // Crear una fila combinada con el nuevo valor
            string[] filaConRectangular = nuevaCarta.Concat(new string[] { valorRectangular }).ToArray();

            // Agregar la fila al DataGridView
            dataGridView1.Rows.Add(filaConRectangular);
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
