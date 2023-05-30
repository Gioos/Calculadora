
namespace Calculadora.Entities
{
    public static class Operacoes
    {

        public static void Menu()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine(" 1 - somar ");
            Console.WriteLine(" 2 - subtrair ");
            Console.WriteLine(" 3 - dividir ");
            Console.WriteLine(" 4 - multiplicar ");
            Console.WriteLine(" 5 - sair ");
            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("***** SELECIONE UMA OPÇÃO: *****");
            short res = short.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Console.WriteLine("Obrigado por usar minha calculadora!"); System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        public static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float resultado = n1 + n2;
            Console.WriteLine($"Total : {resultado}");
            Console.ReadKey();
            Menu();
        }

        public static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float resultado = n1 - n2;
            Console.WriteLine($"Total : {resultado}");
            Console.ReadKey();
            Menu();

        }
        public static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float resultado = n1 / n2;
            Console.WriteLine($"Total : {resultado}");
            Console.ReadKey();
            Menu();
        }

        public static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            float resultado = n1 * n2;
            Console.WriteLine($"Total : {resultado}");
            Console.ReadKey();
            Menu();

        }
    }
}