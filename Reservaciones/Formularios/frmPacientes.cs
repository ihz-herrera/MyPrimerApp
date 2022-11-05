using Reservaciones.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones
{
    public partial class frmPacientes : Form
    {
        
        List<Persona> Personas = new List<Persona>();

        public frmPacientes()
        {
            InitializeComponent();

        }









        private void frmPacientes_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = txtNombre.Text;
            persona.Altura = double.Parse(txtAltura.Text);
            persona.Peso = double.Parse(txtPeso.Text);
            persona.FechaNacimiento = dtpFechaNacimiento.Value;

            Personas.Add(persona);

            dtgPacientes.DataSource = null;
            dtgPacientes.DataSource = Personas;

        }
    }
}
