// See https://aka.ms/new-console-template for more information
namespace Calculadora
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            short selectUser;
            Console.Clear();
            System.Console.WriteLine("===== Calculadora - Created by Alison =====\n\n");
            System.Console.WriteLine("Qual operação deseja realizar?\n");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Subtração");
            System.Console.WriteLine("3 - Divisão");
            System.Console.WriteLine("4 - Multiplicação");
            System.Console.WriteLine("0 - Sair da aplicação\n");
            selectUser = short.Parse(Console.ReadLine());
            switch (selectUser)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            float n1; float n2; float res;
            System.Console.WriteLine("Digite um valor: ");
            n1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite outro valor: ");
            n2 = float.Parse(Console.ReadLine());
            res = n1 + n2;
            System.Console.WriteLine("\nO resultado da soma é: {0}", res);
            System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            float n1; float n2; float res;
            System.Console.WriteLine("Digite um valor: ");
            n1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite outro valor: ");
            n2 = float.Parse(Console.ReadLine());
            res = n1 - n2;
            System.Console.WriteLine("\nO resultado da subtração é: {0}", res);
            System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            float n1; float n2; float res;
            System.Console.WriteLine("Digite um valor: ");
            n1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite outro valor: ");
            n2 = float.Parse(Console.ReadLine());
            res = n1 / n2;
            System.Console.WriteLine("\nO resultado da divisão é: {0}", res);
            System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            float n1; float n2; float res;
            System.Console.WriteLine("Digite um valor: ");
            n1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite outro valor: ");
            n2 = float.Parse(Console.ReadLine());
            res = n1 * n2;
            System.Console.WriteLine("\nO resultado da multiplicação é: {0}", res);
            System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }
    }
}