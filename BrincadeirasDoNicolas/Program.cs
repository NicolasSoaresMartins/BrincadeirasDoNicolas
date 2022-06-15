using BrincadeirasDoNicolas.Matematica;

namespace BrincadeirasDoNicolas
{
    public class Program
    {
        //enum cor { Vermelho = 1, azul, laranja, preto }
        enum menu {Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}
        //enum cor { Vermelho = 1, Azul, Verde, Branco, Amarelo }
        //private static ConsoleKey[] OPERADORES = new ConsoleKey[] { ConsoleKey.Add, ConsoleKey.Subtract, ConsoleKey.Multiply, ConsoleKey.Divide };

        public static void Main(string[] args)
        {

            Console.WriteLine("1-Soma\n2-Subtração\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");
            menu opcao = (menu)int.Parse(Console.ReadLine());
                        






            //CONVERSÃO DE INTEIRO PARA ENUM
            //string receba = Console.ReadLine();
            //cor escolhida = (cor)int.Parse(receba);
            //Console.WriteLine(escolhida);




            //int contador = 30;
            //for (int i = 0; i < contador; contador--)
            //{
            //    Console.WriteLine(contador);
            //}

            //REPETIÇÃO PARA COPULAR UM ARRAY
            //string[] sabores = new string[8];
            //int pizzas =10;
            //for (int i = 0; i < pizzas; i++)
            //{
            //    Console.WriteLine("Digite sabores");
            //    sabores[i]= Console.ReadLine();

            //}


            //Console.WriteLine("Digite um numero");
            //var receba = Console.ReadLine() ?? String.Empty;
            //cor escolhido = Enum.Parse<cor>(receba);

            //Console.WriteLine(escolhido);





            //var servivosexo = new SerVivoTipoSexo { Sexo = "Masculino" };
            //var servivotipo = new SerVivoTipo { Sexo = servivosexo, Tipo = "Ser Huamno" };
            //var nicolas = new SerVivo { SerVivoTipo = servivotipo, Idade = 18 };

            //int[] array = new int[] { 5, 21, 2, 5, 123, 5, 6, 2, 23, 5, 13, 5, 1, 23, 5, 6, 7, 2, 34 };
            //OrdenarTresNumeros(array, out int[] ordenadoCrescente, out int[] ordenadoDecrescente);

            //Console.WriteLine(string.Join(", ", array));
            //Console.WriteLine(string.Join(", ", ordenadoCrescente));
            //Console.WriteLine(string.Join(", ", ordenadoDecrescente));

            //    string receba = "";

            //    Console.WriteLine("Bem vindo ao programa do nicolas. Informe apenas um número para iniciar. Pressione CTRL+C para sair.");

            //    Calculadora calculadora = new Calculadora();
            //    while (true)
            //    {
            //        while (true)
            //        {
            //            receba = Console.ReadLine();

            //            var valorEhUmDouble = double.TryParse(receba, out double num);
            //            if (valorEhUmDouble)
            //            {
            //                calculadora.calculo(num);
            //                break;
            //            }
            //            else
            //            {
            //                Console.Clear();
            //                Console.Write($"={calculadora.obterValor()}{calculadora.obterOperador()}");
            //            }
            //        }

            //        Console.Clear();
            //        Console.Write($"={calculadora.obterValor()}");

            //        while (true)
            //        {
            //            var infoDaTeclaPressionada = Console.ReadKey();
            //            var teclaPressionada = infoDaTeclaPressionada.Key;
            //            //   var operador = Console.ReadKey().KeyChar.ToString();


            //            if (OPERADORES.Contains(teclaPressionada))
            //            {
            //                calculadora.OP(teclaPressionada);
            //                break;
            //            }

            //        }
            //        Console.Clear();
            //        Console.Write($"={calculadora.obterValor()}{calculadora.obterOperador()}");
            //    }
            //}

            //public static void OrdenarTresNumeros(int[] array, out int[] arrayOrdenado, out int[] arrayDescrente)
            //{
            //    arrayOrdenado = new int[array.Length];
            //    arrayDescrente = new int[array.Length];
            //    array.CopyTo(arrayOrdenado, 0);
            //    int temp = 0;
            //    for (int write = 0; write < arrayOrdenado.Length; write++)
            //    {
            //        for (int sort = 0; sort < arrayOrdenado.Length - 1; sort++)
            //        {
            //            if (arrayOrdenado[sort] > arrayOrdenado[sort + 1])
            //            {
            //                temp = arrayOrdenado[sort + 1];
            //                arrayOrdenado[sort + 1] = arrayOrdenado[sort];
            //                arrayOrdenado[sort] = temp;
            //            }
            //        }
            //    }

            //    arrayDescrente = array.OrderByDescending(x => x).ToArray();

        }









    }
}
