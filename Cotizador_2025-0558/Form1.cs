namespace Cotizador_2025_0558
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHuesped.Text))
            {
                MessageBox.Show("Escribe el nombre del huésped.", "Falta un dato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHuesped.Focus();
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text, out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor que cero.", "Dato incorrecto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarifa.Focus();
                txtTarifa.SelectAll();
                return;
            }

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = decimal.Parse(txtTarifa.Text),
                EsTemporadaAlta = chkTemporadaAlta.Checked
            };

            lblSubtotal.Text = reserva.Subtotal.ToString("N2");
            lblDescuento.Text = "-" + reserva.Descuento.ToString("N2");
            lblItbis.Text = reserva.Itbis.ToString("N2");
            lblServicio.Text = reserva.Servicio.ToString("N2");
            lblTotal.Text = reserva.Total.ToString("N2");

            MessageBox.Show(
        $"Huésped: {txtHuesped.Text}\nNoches: {nudNoches.Value}\nTemporada alta: {chkTemporadaAlta.Checked}",
        "Prueba de lectura");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHuesped.Clear();
            txtTarifa.Clear();
            nudNoches.Value = 1;
            chkTemporadaAlta.Checked = false;

            lblSubtotal.Text = lblDescuento.Text = lblItbis.Text =
                lblServicio.Text = lblTotal.Text = "0.00";

            txtHuesped.Focus();
        }
    }
}
