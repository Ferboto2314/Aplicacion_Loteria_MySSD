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

            // Selección aleatoria de una carta
            Random rand = new Random();
            int indice = rand.Next(Baraja.Count);
            Carta cartaSeleccionada = Baraja[indice];

            // Mostrar la carta anterior en el segundo PictureBox (pictureBox2)
            if (Historial.Count > 0)
            {
                Carta cartaAnterior = Historial[Historial.Count - 1];
                pbxCartaAnterior.Image = cartaAnterior.Imagen;
            }

            // Actualizar datos de la carta seleccionada
            cartaSeleccionada.VecesAparecidas++;
            CartasTotal++;

            // Agregar la carta al historial
            Historial.Add(cartaSeleccionada);

            // Eliminar la carta seleccionada de la Baraja
            Baraja.RemoveAt(indice);

            // Mostrar la carta seleccionada en el PictureBox principal (pbxCartaActual)
            pbxCartaActual.Image = cartaSeleccionada.Imagen;

            // Actualizar las tasas uniformes en el formulario de porcentaje, si está abierto
            if (porcentajeForm != null)
            {
                porcentajeForm.ActualizarTasasUniformes(Historial, CartasTotal);
            }
        }




        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (Historial.Count == 0)
            {
                MessageBox.Show("No hay cartas seleccionadas para mostrar.");
                return;
            }

            // Tomar la última carta del historial
            Carta cartaSeleccionada = Historial.Last();

            // Crear los datos de la carta seleccionada
            string[] datosCarta = new string[]
            {
                cartaSeleccionada.ID.ToString(),
                cartaSeleccionada.VecesAparecidas.ToString(),
                cartaSeleccionada.TasaAparicion.ToString("P2"), // Tasa como porcentaje
            };

            // Si el formulario no está inicializado, crear uno nuevo
            if (porcentajeForm == null)
            {
                porcentajeForm = new Porcentaje();
            }

            // Pasar los datos al formulario
            porcentajeForm.CargarDatos(datosCarta);

            // Mostrar el formulario (sin crear otra instancia)
            if (!porcentajeForm.Visible)
            {
                porcentajeForm.Show();
            }
            else
            {
                porcentajeForm.BringToFront(); // Traerlo al frente si ya está abierto
            }
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            // Agregar todas las cartas de Historial a Baraja
            foreach (var carta in Historial)
            {
                Baraja.Add(carta);
            }

            // Limpiar el historial
            Historial.Clear();

            // Opcional: Mostrar un mensaje confirmando que las cartas se han devuelto
            MessageBox.Show("Las cartas han sido devueltas a la baraja.");
        }
    }
    public class Carta
    {
        public int ID { get; set; }
        public Image Imagen { get; set; }
        public int VecesAparecidas { get; set; }
        public float TasaAparicion { get; set; }
    }
}
