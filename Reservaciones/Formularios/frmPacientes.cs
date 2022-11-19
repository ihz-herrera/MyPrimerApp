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
        
        List<Paciente> Personas = new List<Paciente>();

        public frmPacientes()
        {
            InitializeComponent();

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {

            Paciente paciente = new Paciente();

            Personas = paciente.LeerPacientes();
            
            dtgPacientes.DataSource = null;
            dtgPacientes.DataSource = Personas;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.Nombre = txtNombre.Text;
            paciente.Altura = double.Parse(txtAltura.Text);
            paciente.Peso = double.Parse(txtPeso.Text);
            paciente.FechaNacimiento = dtpFechaNacimiento.Value;

            Personas.Add(paciente);

            //Todo:Almacenar Informacion 
            paciente.Agregar(paciente);
                
            dtgPacientes.DataSource = null;
            dtgPacientes.DataSource = Personas;

        }

        

        [Obsolete("Usar método ToString() en su lugar",true)]
        private string ConfigurarRegistro(Paciente paciente)
        {
            //return paciente.Nombre + ',' + paciente.Altura + ',' + paciente.Peso + ',' + paciente.FechaNacimiento
            //Interpolacion
            return $"{paciente.Nombre},{paciente.Altura}, {paciente.Peso},{paciente.FechaNacimiento}";
        }
    }
}
