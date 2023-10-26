namespace AtividadePraticaC__Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== CALCULADORA ====");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Escolha: ");
            int operecao = int.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            Adicao adicao = new Adicao();
            Subtracao subtracao = new Subtracao();
            Multiplicacao multiplicacao = new Multiplicacao();
            Divisao divisao = new Divisao();

            switch (operecao)
            {
                case 1:
                    resultado = adicao.CalcularSoma(n1, n2);
                    break;
                case 2:
                    resultado = subtracao.CalcularSubtracao(n1, n2);
                    break;
                case 3:
                    resultado = multiplicacao.CalcularMultiplicacao(n1, n2);
                    break;
                case 4:
                    resultado = divisao.CalcularDivisao(n1, n2);
                    break;
                default:
                    Console.WriteLine("[!!] ERROR [!!]");
                    break;
            }
            Console.WriteLine("==========================\n");
            Console.WriteLine($"O resultado é {resultado}\n");
            Console.WriteLine("==========================\n");
        }
    }
}