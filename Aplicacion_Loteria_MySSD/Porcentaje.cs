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
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Veces Aparecidas", "Veces Aparecidas");
            dataGridView1.Columns.Add("Tasa Aparición", "Tasa Aparición");
            dataGridView1.Columns.Add("# Rectangular", "# Rectangular");
        }

        // Método para agregar datos al DataGridView
        public void CargarDatos(string[] nuevaCarta)
        {
            // Calcular el valor de "# Rectangular"
            float tasaAparicion = float.Parse(nuevaCarta[2].TrimEnd('%')) / 100;
            string valorRectangular = tasaAparicion.ToString("F5"); // Formato con 5 decimales

            // Crear una fila combinada con el nuevo valor
            string[] filaConRectangular = nuevaCarta.Concat(new string[] { valorRectangular }).ToArray();

            // Agregar la fila al DataGridView
            dataGridView1.Rows.Add(filaConRectangular);
        }

        public void ActualizarTasasUniformes(List<Carta> historial, int cartasTotal)
        {
            // Calcular la tasa uniforme
            float tasaUniforme = 1.0f / cartasTotal;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Ignorar filas vacías o incompletas
                if (fila.IsNewRow || fila.Cells["ID"].Value == null) continue;

                // Actualizar la columna "Tasa Aparición"
                fila.Cells["Tasa Aparición"].Value = (tasaUniforme * 100).ToString("F2") + "%";

                // Actualizar la columna "# Rectangular" (tasa dividida entre 100)
                fila.Cells["# Rectangular"].Value = tasaUniforme.ToString("F4");
            }
        }




        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Porcentaje_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CargarHistorial(List<Carta> historial)
        {
            // Limpiar filas previas en el DataGridView
            dataGridView1.Rows.Clear();

            // Añadir cada carta del historial al DataGridView
            foreach (var carta in historial)
            {
                dataGridView1.Rows.Add(
                    carta.ID,
                    carta.VecesAparecidas,
                    carta.TasaAparicion.ToString("P2"), // Tasa como porcentaje
                    carta.TasaAparicion.ToString("F5") // Número rectangular (tasa en decimal)
                );
            }
        }





    }
}
