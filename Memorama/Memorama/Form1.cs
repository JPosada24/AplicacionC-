using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Form1 : Form
    {
        public int tamanioColumnas = 4;
        public int tamanioFilas = 5;
        public int movimientos = 0;
        public int cartasVolteadas = 0;

        List<string> cartasEnumeradas;
        List<string> cartasRevueltas;

        ArrayList cartasSeleccionadas;
        PictureBox cartaTemporal1;
        PictureBox cartaTemporal2;

        public int cartaActual = 0;

        public Form1()
        {
            InitializeComponent();
            iniciarJuego();
        }

        public void iniciarJuego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            lblPuntuacion.Text = "0";
            cartasVolteadas = 0;
            movimientos = 0;
            panelJuego.Controls.Clear();
            cartasEnumeradas = new List<string>();
            cartasRevueltas = new List<string>();
            cartasSeleccionadas = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                cartasEnumeradas.Add(i.ToString());
                cartasEnumeradas.Add(i.ToString());
            }

            var numeroAleatorio = new Random();
            var resultado = cartasEnumeradas.OrderBy(item => numeroAleatorio.Next());

            foreach (string valorCarta in resultado)
            {
                cartasRevueltas.Add(valorCarta);
            }

            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = tamanioFilas;
            tablaPanel.ColumnCount = tamanioColumnas;

            for (int i = 0; i < tamanioFilas; i++)
            {
                var porcentaje = 150f / (float)tamanioColumnas - 1;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, porcentaje));
            }

            int contadorFichas = 1;

            for (int i = 0; i < tamanioColumnas; i++)
            {
                for (int j = 0; j < tamanioFilas; j++)
                {
                    var cartasJuego = new PictureBox();
                    cartasJuego.Name = string.Format("{0}", contadorFichas);
                    cartasJuego.Dock = DockStyle.Fill;
                    cartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    cartasJuego.Image = Properties.Resources.lol1;
                    cartasJuego.Cursor = Cursors.Hand;
                    cartasJuego.Click += bntCarta_Click;
                    tablaPanel.Controls.Add(cartasJuego, j, i);
                    contadorFichas++;
                }
            }

            tablaPanel.Dock = DockStyle.Fill;
            panelJuego.Controls.Add(tablaPanel);
        }

        private void bntReiniciar_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }

        private void bntCarta_Click(object sender, EventArgs e)
        {
            if (cartasSeleccionadas.Count < 2)
            {

                movimientos++;
                lblPuntuacion.Text = Convert.ToString(movimientos);
                var seleccionadasUsuario = (PictureBox)sender;

                cartaActual = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(seleccionadasUsuario.Name) - 1]);
                seleccionadasUsuario.Image = RecuperarImagen(cartaActual);
                cartasSeleccionadas.Add(seleccionadasUsuario);

                // 2 veces el evento click se activó,

                if (cartasSeleccionadas.Count == 2)
                {
                    cartaTemporal1 = (PictureBox)cartasSeleccionadas[0];
                    cartaTemporal2 = (PictureBox)cartasSeleccionadas[1];

                    int carta1 = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(cartaTemporal1.Name) - 1]);
                    int carta2 = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(cartaTemporal2.Name) - 1]);

                    if (carta1 != carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        cartasVolteadas++;
                        if (cartasVolteadas > 9)
                        {
                            MessageBox.Show("El juego ha terminado.");
                            iniciarJuego();
                        }

                        cartaTemporal1.Enabled = false; cartaTemporal2.Enabled = false;
                        cartasSeleccionadas.Clear();
                    }
                }

            }
        }

        public Bitmap RecuperarImagen(int numeroImagen)
        {
            Bitmap tmpImg = new Bitmap(200, 100);

            switch (cartaActual)
            {
                case 0: tmpImg = Properties.Resources.img11;
                    break;
                default: tmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + numeroImagen);
                    break;
            }

            return tmpImg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tiempo = 1;

            if (tiempo == 1)
            {
                cartaTemporal1.Image = Properties.Resources.lol1;
                cartaTemporal2.Image = Properties.Resources.lol1;

                cartasSeleccionadas.Clear();
                tiempo = 0;
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
