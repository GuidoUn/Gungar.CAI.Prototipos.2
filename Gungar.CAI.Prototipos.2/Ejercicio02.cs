namespace Gungar.CAI.Prototipos._2
{
    public partial class Ejercicio02 : Form
    {
        Ejercicio02Model model;

        public Ejercicio02()
        {
            InitializeComponent();
        }

        private void ReiniciarForm()
        {
            this.precioText.ResetText();
            this.modeloText.ResetText();
            this.anoText.ResetText();
            this.marcaCombo.ResetText();
            this.resultadoText.ResetText();

            model = new Ejercicio02Model();
        }

        private void Ejercicio02_Load(object sender, EventArgs e)
        {
            model = new Ejercicio02Model();
            this.marcaCombo.Items.AddRange(model.Marcas);
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            model.PrecioIngresado = this.precioText.Text;
            model.ModeloIngresado = this.modeloText.Text;
            model.AnoIngresado = this.anoText.Text;
            model.MarcaIngresada = (string)this.marcaCombo.SelectedItem;

            string mensaje = model.Validar();
            this.resultadoText.Text = mensaje;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ReiniciarForm();
        }
    }
}