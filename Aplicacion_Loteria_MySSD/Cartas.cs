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
            if (Historial.Count > 0) // Solo mostrar la carta anterior si existe en el historial
            {
                Carta cartaAnterior = Historial[Historial.Count - 1];
                pbxCartaAnterior.Image = cartaAnterior.Imagen; // Mostrar la carta anterior
            }

            // Actualización de datos de la carta seleccionada
            cartaSeleccionada.VecesAparecidas++;
            CartasTotal++;
            cartaSeleccionada.TasaAparicion = (float)cartaSeleccionada.VecesAparecidas / CartasTotal;

            // Agregar la carta al historial
            Historial.Add(cartaSeleccionada);

            // Eliminar la carta seleccionada de la Baraja
            Baraja.RemoveAt(indice);

            // Mostrar la carta seleccionada en el PictureBox principal (pbxCartaActual)
            pbxCartaActual.Image = cartaSeleccionada.Imagen;
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            Porcentaje frmPorcentaje = new Porcentaje(Baraja);
            frmPorcentaje.Show();
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
