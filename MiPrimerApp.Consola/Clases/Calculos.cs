

namespace MiPrimerApp.Consola.Clases
{
    public class Calculos
    {
        //atributo
        private int _resultado;

        //propiedades
        public int Resultado { 
            get {
               return _resultado;
            } 
            //set { 
            //    _resultado = value;
            //} 
        }


        public int Sumar(int x, int y)
        {
            //int x= numero1;
            //int y = numero2;

            //Console.WriteLine(x + y);

            return x + y;

        }

        public void Multiplicar(int x, int y)
        {
            //int x= numero1;
            //int y = numero2;

            //Console.WriteLine(x + y);
            _resultado = x * y;
            //return Resultado;

        }
    }
}
