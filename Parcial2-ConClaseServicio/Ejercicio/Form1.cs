using Ejercicio.Models;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Fdatos fDatos = new Fdatos();

            if (fDatos.ShowDialog() == DialogResult.OK && servicio.CantVeh < 20)
            {
                string patente = fDatos.tbPatente.Text;
                double kms = Convert.ToDouble(fDatos.tbKilometros.Text);

                servicio.CrearVehiculo(patente, kms);

                lsbPatentes.Items.Add(patente.ToString());
            }
            else
            {
                MessageBox.Show("Registro cancelado.");
            }
            fDatos.Dispose();
        }

        private void btnCargarViaje_Click(object sender, EventArgs e)
        {
            Fdatos fDatos = new Fdatos();

            
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                string patente = fDatos.tbPatente.Text;

                int pos = servicio.Buscar(patente);

                if (pos != -1)
                {
                    double kmAcobrar = Convert.ToDouble(fDatos.tbKilometros.Text);
                    servicio.CargarViaje(pos, kmAcobrar);

                    lbKM.Text = kmAcobrar.ToString();
                }
                else
                {
                    MessageBox.Show("Patente inexistente");
                }
            }
            else
            {
                MessageBox.Show("Carga cancelada.");
            }

            fDatos.Dispose();
        }

        private void btnResumenFinal_Click(object sender, EventArgs e)
        {
            Fresumen fResumen = new Fresumen();

            double promedio = servicio.CalcularPromedioKMS();

            servicio.Ordenar();
            for (int i = 0;i < servicio.CantVeh;i++) {

                string patente;
                double kilometros;
                servicio.VerVehiculo(i, out patente, out kilometros);

                fResumen.lsbPatentes.Items.Add($"Patente: {patente} - Kms: {kilometros:f2}");

            }
            fResumen.lsbPatentes.Items.Add($"Promedio de Kms: {promedio:f2}");
            fResumen.ShowDialog();
            fResumen.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
