using Actividad3._3.Models;

namespace Actividad3._3
{
    public partial class Form1 : Form
    {
        Campo campo = new Campo();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estancia = new Estancia("La Ana", "AB12", 3000.0);
            Estancia.Casco.Administrador = "Jorge"
            est
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estancia.AgregarCampos("AC12", 234)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int n = 0; estancia.VerCantidadCampos(); n++)
            {
                Campo campo = estancia.VerCampo(n);
                comboBox1.Items.Add(campo);
            }
        }
    }
}
