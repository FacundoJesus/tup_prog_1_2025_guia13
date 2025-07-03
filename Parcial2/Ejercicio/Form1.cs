namespace Ejercicio
{
    public partial class Form1 : Form // Principal:
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1º Declaro e Inicio vectores
        string[] patentes = new string[20];
        double[] kilometros = new double[20];
        int cantidad = 0;

        // 2º Método de Búsqueda Secuencial
        private int Buscar(string patente)
        {
            int i = 0;
            int pos = -1;
            while (pos == -1 && i < cantidad)
            {
                if (patentes[i] == patente)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }

        // 2º Método de Ordenamiento Burbuja
        private void Ordenar()
        {
            string xPatente;
            double xKilometro;
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (kilometros[i] > kilometros[j]) // Menor: > / Mayor: <
                    {

                        //Ordeno vector Kilometros
                        xKilometro = kilometros[i];
                        kilometros[i] = kilometros[j];
                        kilometros[j] = xKilometro;

                        //Ordeno vector Patentes
                        xPatente = patentes[i];
                        patentes[i] = patentes[j];
                        patentes[j] = xPatente;
                    }
                }
            }
        }

        // 3º Botones
        private void btnRegistrar_Click(object sender, EventArgs e) //Boton Registrar:
        {
            //Creo objeto ventana Modal
            Fdatos fdatos = new Fdatos();

            //Abro ventana y verifico cantidad menor a 20
            if (fdatos.ShowDialog() == DialogResult.OK && cantidad < 20)
            {

                //Almaceno los datos que me ponga el usuario en variables
                string patente = fdatos.tbPatente.Text;
                double kilometraje = Convert.ToDouble(fdatos.tbKilometros.Text);

                //Luego las almaceno a cada una en cada vector
                patentes[cantidad] = patente;
                kilometros[cantidad] = kilometraje;

                //Incremento la posicion o indice 
                cantidad++;

                //Agrego la patente en la ventana principal de list boxs.
                listBoxPatentes.Items.Add($"{patente}");
            }
            else
            {
                MessageBox.Show("Registro Cancelado");
            }

            //Liberar recursos
            fdatos.Dispose();
        }

        private void btnCargarViaje_Click(object sender, EventArgs e)
        {
            Fdatos fDatos = new Fdatos();

            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                string patente = fDatos.tbPatente.Text;
                int indice = Buscar(patente);

                if (indice != -1)
                {
                    //Nuevo kilometros
                    double kmAcobrar = Convert.ToDouble(fDatos.tbKilometros.Text);

                    //Acumular kilometros en esa posicion
                    kilometros[indice] += kmAcobrar;

                    //Mostrarlo en el label de la ventana principal
                    labelKM.Text = $"{kmAcobrar}";

                }
                else
                {
                    MessageBox.Show("Patente inexistente");
                }
            }
            else
            {
                MessageBox.Show("Carga de viaje cancelada");
            }

            fDatos.Dispose();
        }

        private void btnResumenFinal_Click(object sender, EventArgs e)
        {
            //Instancio ventana Resumen
            Fresumen fResumen = new Fresumen();

            //Acumulo y calculo promedio
            double acumulador = 0;
            for (int i = 0; i < cantidad; i++)
            {
                acumulador += kilometros[i];
            }
            double promedio = acumulador / cantidad;

            //Ordeno
            Ordenar();

            //Los agrego ordenados al listboxs de la ventana Fresumen.
            for (int i = 0; i < cantidad; i++)
            {
                fResumen.listBoxPatentes.Items.Add($"PATENTE:{patentes[i]}, KILOMETROS: {kilometros[i]}");
            }

            //Para Mostrar siempre el ShowDialog() al final!!
            fResumen.ShowDialog();
            fResumen.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
