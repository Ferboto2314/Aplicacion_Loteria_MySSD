using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace Aplicacion_Loteria_MySSD
{
    public partial class frmCartas : Form
    {

        public event Action<List<Carta>> HistorialActualizado;
        private List<Carta> Baraja = new List<Carta>(); // Array de cartas
        private List<Carta> Historial = new List<Carta>(); // Array para el historial
        private int CartasTotal = 0;
        private Porcentaje porcentajeForm;  //Instancia unica del formulario Porcentaje

        public frmCartas()
        {
            InitializeComponent();
            CargarBaraja();
        }

        private void CargarBaraja()
        {
            for (int i = 1; i <= 54; i++)
            {
                // Usa nombres de recursos en el formato Carta1, Carta2, ..., Carta54
                string resourceName = $"{i}";
                Image img = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);

                if (img != null)
                {
                    Baraja.Add(new Carta
                    {
                        ID = i,
                        Imagen = img,
                        VecesAparecidas = 0
                    });
                }
                else
                {
                    MessageBox.Show($"La imagen {resourceName} no se encontró en Resources.resx.");
                }
            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCartas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Baraja.Count == 0) return;

            Random rand = new Random();
            Carta cartaSeleccionada = null;

            while (true)
            {
                int indice = rand.Next(Baraja.Count);
                cartaSeleccionada = Baraja[indice];

                Historial.Add(cartaSeleccionada);

                if (RealizarPruebaKS())
                {
                    Baraja.RemoveAt(indice);
                    break;
                }

                Historial.RemoveAt(Historial.Count - 1);
            }

            cartaSeleccionada.VecesAparecidas++;
            CartasTotal++;

            foreach (var carta in Historial)
            {
                carta.TasaAparicion = (float)carta.VecesAparecidas / CartasTotal;
            }

            pbxCartaActual.Image = cartaSeleccionada.Imagen;
            if (Historial.Count > 1)
            {
                pbxCartaAnterior.Image = Historial[Historial.Count - 2].Imagen;
            }

            porcentajeForm?.CargarHistorial(Historial);
        }


        private bool RealizarPruebaKS()
        {
            if (Historial.Count < 2) return true;

            var frecuenciasObservadas = Historial
                .GroupBy(c => c.ID)
                .OrderBy(g => g.Key)
                .Select(g => (float)g.Count() / Historial.Count)
                .ToList();

            var distribucionEsperada = Enumerable.Repeat(1.0f / 54, 54).Take(frecuenciasObservadas.Count).ToList();

            float maxDiferencia = 0;
            for (int i = 0; i < frecuenciasObservadas.Count; i++)
            {
                float diferencia = Math.Abs(frecuenciasObservadas[i] - distribucionEsperada[i]);
                if (diferencia > maxDiferencia)
                    maxDiferencia = diferencia;
            }

            float valorCritico = 1.36f / (float)Math.Sqrt(Historial.Count);

            return maxDiferencia < valorCritico;
        }







        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (porcentajeForm == null)
            {
                porcentajeForm = new Porcentaje();
            }

            // Suscribir el formulario al evento si no lo está
            HistorialActualizado -= porcentajeForm.CargarHistorial; // Evitar suscripciones duplicadas
            HistorialActualizado += porcentajeForm.CargarHistorial;

            // Mostrar el formulario
            if (!porcentajeForm.Visible)
            {
                porcentajeForm.Show();
            }
            else
            {
                porcentajeForm.BringToFront();
            }

            // Cargar historial inicial
            porcentajeForm.CargarHistorial(Historial);
        }



        private void btnMix_Click(object sender, EventArgs e)
        {
            // Agregar todas las cartas del historial a la baraja
            Baraja.AddRange(Historial);

            // Limpiar el historial, pero mantener las estadísticas acumuladas
            Historial.Clear();

            // Opcional: Mostrar un mensaje confirmando que las cartas se han devuelto
            MessageBox.Show("Las cartas han sido devueltas a la baraja. Las estadísticas acumuladas permanecen.");

            // Limpiar los PictureBox
            pbxCartaActual.Image = null;
            pbxCartaAnterior.Image = null;

            // Actualizar el formulario de porcentaje, si está abierto
            porcentajeForm?.CargarHistorial(Historial);
        }


    }

    public class Carta
    {
        public int ID { get; set; }
        public Image Imagen { get; set; }
        public int VecesAparecidas { get; set; }
        public float TasaAparicion { get; set; }
        public float numeroRectangular { get; set; }
    }
}
