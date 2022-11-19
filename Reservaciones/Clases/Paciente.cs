using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Clases
{
    public class Paciente
    {
        private const string path = @"D:\BasesDeDatos\Pacientes.csv";



        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public DateTime FechaNacimiento { get; set; }



        public override string ToString()
        {
            return $"{Nombre},{Altura}, {Peso},{FechaNacimiento}";
        }


        public List<Paciente> LeerPacientes()
        {

            List<Paciente> ListaPacientes = new List<Paciente>();
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

                    ListaPacientes.Add(paciente);
                    line = reader.ReadLine();

                }

                reader.Close();

            }

            return ListaPacientes;
        }


        public void GuardarTodosLosPacientes(List<Paciente> pacientes)
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

        public void Agregar(Paciente paciente)
        {
            using (var writer = new System.IO.StreamWriter(path, true))
            {
                writer.WriteLine(paciente.ToString());
                writer.AutoFlush = true;
                writer.Close();
            }
        }
    }
}
