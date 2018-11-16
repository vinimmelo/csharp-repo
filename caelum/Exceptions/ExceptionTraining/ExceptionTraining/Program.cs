using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (NullReferenceException er)
            {
                Console.WriteLine(er.Message);
                Console.WriteLine(er.StackTrace);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }

        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente cc = null;
            cc.NullAcess = "Test";
            return numero / divisor;
        }

        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
