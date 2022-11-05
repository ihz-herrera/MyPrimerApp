using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerApp.Formularios.Clases
{
    internal class Calcular
    {
		public enum Idioma
		{
			Español,
			Ingles,
			Aleman
		}


		private int _resultado;

		public int Resultado
		{
			get { return _resultado; }
		}

		public void Sumar(int x,int y)
		{
			_resultado = x+y;
		}

		public string Mensaje(int resultado,Idioma idioma)
		{
			var mensaje = String.Empty;

			switch (idioma)
			{
				case Idioma.Español:
					mensaje = $"El resultado de la operacion es {resultado}";
					break;
				case Idioma.Ingles:
                    mensaje = $"The result of the operation is {resultado}";
                    break;
				case Idioma.Aleman:
                    mensaje = $"Das Ergebnis der Operation ist {resultado}";
                    break;
				default:
                    mensaje = $"El resultado de la operacion es {resultado}";
                    break;



            }
			
			
			return mensaje;
		}

	}
}
