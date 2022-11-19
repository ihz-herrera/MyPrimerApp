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
        private const string path = @"D:\BasesDeDatos\Pacientes.csv";

        public frmPacientes()
        {
            InitializeComponent();

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {


            using (var reader = new System.IO.StreamReader(path))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    string[] data = line.Split(',');
                    var paciente = new Paciente()
                    {
                        Nombre = data[0],
                        Altura = Double.Parse(data[1]),
                        Peso = Double.Parse(data[2]),
                        FechaNacimiento = DateTime.Parse(data[3])
                    };

                    MessageBox.Show(paciente.ToString());

                    Personas.Add(paciente);
                    line = reader.ReadLine();

                }

                reader.Close();

            }




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
            using (var writer = new System.IO.StreamWriter(path, true))
            {
                writer.WriteLine(paciente.ToString());
                writer.AutoFlush = true;
                writer.Close();
            }
                
            
            
            dtgPacientes.DataSource = null;
            dtgPacientes.DataSource = Personas;

        }

        private void GuardarTodosLosPacientes(List<Paciente> pacientes)
        {
            using (var writer = new System.IO.StreamWriter(path))
            {
                foreach (Paciente paciente in pacientes)
                {
                    //Todo:Almacenar Informacion 

                    writer.WriteLine(paciente.ToString());
                    writer.AutoFlush = true;
                    writer.Close();

                }
            }

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
