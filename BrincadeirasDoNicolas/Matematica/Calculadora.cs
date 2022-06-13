
namespace BrincadeirasDoNicolas.Matematica
{
    public class Calculadora
    {
        double valorTotal = 0;
        string Operador = "";
        public double obterValor()
        {
            return valorTotal;
        }
        public void calculo(double num)
        {
            if (Operador == "+")
            {
                valorTotal = valorTotal + num;
            }
            else if (Operador == "-")
            {
                valorTotal = valorTotal - num;
            }
            else if (Operador == "*")
            {
                valorTotal = valorTotal * num;
            }
            else if (Operador == "/")
            {
                valorTotal = valorTotal / num;
            }
            else
            {
                valorTotal = num;
            }
        }

        public string OP(string operador)
        {
            Operador = operador;
            return Operador;

        }

        internal string obterOperador()
        {
            return Operador;
        }
    }
}
