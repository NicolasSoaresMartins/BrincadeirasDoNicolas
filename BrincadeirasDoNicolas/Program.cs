using BrincadeirasDoNicolas.Matematica;

namespace BrincadeirasDoNicolas
{
    public class Program
    {
        private static string[] OPERADORES = new string[] { "+", "-", "*", "/" };

        public static void Main(string[] args)
        {
            string receba = "";

            Console.WriteLine("Bem vindo ao programa do nicolas. Informe apenas um número para iniciar");

            Calculadora calculadora = new Calculadora();
            while (true)
            {
                while (true)
                {
                    receba = Console.ReadLine();
                    if (double.TryParse(receba, out double num))
                    {
                        calculadora.calculo(num);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write($"={calculadora.obterValor()}{calculadora.obterOperador()}");
                    }
                }

                Console.Clear();
                Console.Write($"={calculadora.obterValor()}");

                while (true)
                {
                    var operador = Console.ReadKey().KeyChar.ToString();
                    if (OPERADORES.Contains(operador))
                    {
                        calculadora.OP(operador);
                        break;
                    }

                }
                Console.Clear();
                Console.Write($"={calculadora.obterValor()}{calculadora.obterOperador()}");
            }
        }
    }
}
