using MiPrimerApp.Formularios.Clases;

namespace MiPrimerApp.Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = int.Parse(textBox1.Text);
            var y = int.Parse(textBox2.Text);

            var calculo = new Calcular();
            calculo.Sumar(x, y);


            MessageBox.Show(calculo.Mensaje(calculo.Resultado,Calcular.Idioma.Aleman));
        }
    }
}