namespace CalcularSueldo
{
    public partial class Form1 : Form
    {


        Empleados Empleados = new Empleados();
        CalculoSueldo Calc = new CalculoSueldo();

        public Form1()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" ) 
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar el nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            decimal pagadiaria;
            if (!Decimal.TryParse(txtSueloDiario.Text, out pagadiaria))
            {
                errorProvider2.SetError(txtSueloDiario, "Debe ingresar la cantidad");
                txtSueloDiario.Focus();
                return;
            } 

            Empleados.Nombre = txtNombre.Text;
            Empleados.Legajo = Convert.ToInt32(txtLegajo.Text);
            Empleados.SueldoDiario = pagadiaria;
            Calc.DiasTrabajados = Convert.ToInt32(txtDiastrabajados.Text);

            MessageBox.Show("Se guardo correctamente");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int diastrabajo = Convert.ToInt32(txtDiastrabajados.Text);
            int valor = Convert.ToInt32(txtSueloDiario.Text);
            txtSueldo.Text = Calc.ClacularSueldo(diastrabajo, valor).ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtSueloDiario.Clear();
            txtNombre.Clear();
            txtLegajo.Clear();
            txtSueldo.Clear();
            txtDiastrabajados.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
