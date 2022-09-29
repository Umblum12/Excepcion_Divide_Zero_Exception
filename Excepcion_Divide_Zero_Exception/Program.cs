using Excepcion_Divide_Zero_Exception;

namespace Excepcion_Divide_Zero_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUno = 10, valorDos = 0, resultado;

            resultado = valorUno / valorDos;
            
            Console.WriteLine(resultado);
        }
    }
}