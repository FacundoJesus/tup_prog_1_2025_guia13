namespace RepasoParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Servicio servicio = new Servicio();

        private void btnAgregarExpediente_Click(object sender, EventArgs e)
        {
            FormDatos formdatos = new FormDatos();

            if (formdatos.ShowDialog() == DialogResult.OK)
            {
                int nroCausa = Convert.ToInt32(formdatos.tbNroCausa.Text);
                int dni = Convert.ToInt32(formdatos.tbDni.Text);
                double importe = Convert.ToDouble(formdatos.tbMonto.Text);

                servicio.RegistrarExpediente(nroCausa, dni, importe);

            }
            else
            {
                MessageBox.Show("Registro cancelado");
            }
            formdatos.Dispose();
        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            FormVer formver = new FormVer();

            servicio.OrdenarExpedientes();

            formver.lsbResultados.Items.Clear();
            for (int i = 0; i < servicio.VerContador(); i++)
            {

                int nro;
                int dni;
                double monto;
                servicio.VerExpediente(i, out nro, out dni, out monto);

                formver.lsbResultados.Items.Add($"{nro} - {dni} - {monto} ");

            }
            formver.ShowDialog();
            formver.Dispose();
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
            FormVer formver = new FormVer();

            int cantidad;
            int[] idxs = servicio.MayoresAlPromedio(out cantidad);

            formver.lsbResultados.Items.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                int nro;
                int dni;
                double monto;
                servicio.VerExpediente(i, out nro, out dni, out monto);

                formver.lsbResultados.Items.Add($"Expediente: {nro} - DNI: {dni} - Monto: {monto}");
            }
            formver.ShowDialog();
            formver.Dispose();
        }

        private void btnVerExpedientes_Click(object sender, EventArgs e)
        {
            FormVer formver = new FormVer();
            int dniBuscado = Convert.ToInt32(tbDni.Text);

            int cantidad;
            int[] idxs = servicio.VerExpedientesPorDNI(dniBuscado, out cantidad);

            formver.lsbResultados.Items.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                int idx = idxs[i];

                int nro;
                int dni;
                double monto;
                servicio.VerExpediente(idx, out nro, out dni, out monto);

                formver.lsbResultados.Items.Add($"Expediente: {nro} - DNI: {dni} - Monto: {monto}");
            }
            formver.ShowDialog();
            formver.Dispose();
        }

        private void btnVerCausa_Click(object sender, EventArgs e)
        {
            FormVer formver = new FormVer();

            int nroCausa = Convert.ToInt32(tbNroCausa.Text);
            int posicion = servicio.VerExpedientePorNumero(nroCausa);

            formver.lsbResultados.Items.Clear();
            if (posicion != -1)
            {
                int nro;
                int dni;
                double monto;
                servicio.VerExpediente(posicion, out nro, out dni, out monto);

                formver.lsbResultados.Items.Add($"Índice: {posicion} - Expediente: {nro} - DNI: {dni} - Monto: {monto}");
                formver.ShowDialog();
                formver.Dispose();
            }
            else
            {
                MessageBox.Show("El expediente ingresado no existe.");
            }

        }
    }
}
