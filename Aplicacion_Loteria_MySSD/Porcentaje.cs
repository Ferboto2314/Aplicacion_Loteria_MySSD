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
        private List<Carta> baraja;
        public Porcentaje(List<Carta> baraja)
        {
            InitializeComponent();
            this.baraja = baraja;

            // Llamar al método para mostrar las estadísticas
            MostrarEstadisticas();
        }

        private void MostrarEstadisticas()
        {
            // Limpiar cualquier dato anterior en el DataGridView
            dataGridView1.Rows.Clear();

            // Añadir cada carta como fila en el DataGridView
            foreach (var carta in baraja)
            {
                dataGridView1.Rows.Add(carta.ID, carta.VecesAparecidas, carta.TasaAparicion.ToString("F8"));
            }

            // Opcional: Personalizar las columnas del DataGridView si es necesario
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Veces Aparecidas";
            dataGridView1.Columns[2].HeaderText = "Tasa de Aparición";
        }

        private void Porcentaje_Load(object sender, EventArgs e)
        {

        }
    }
}
