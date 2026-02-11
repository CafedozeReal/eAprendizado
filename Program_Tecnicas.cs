using System.Diagnostics;

namespace Tecnicas_inicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            do
            {
                Consulta();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("digite 'Y' caso queira retomar?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ResetColor();
                string cont = Console.ReadLine();
                cont.ToLower();

                if (cont != "y")
                {
                    play = false;
                }

            } while (play == true);

            Console.WriteLine("Sistema encerrado");
        }

        public static void Consulta()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite qual será a modalidade");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string mod = Console.ReadLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite qual será o peso do pedido");
            Console.ForegroundColor= ConsoleColor.Yellow;
            double peso = double.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite qual a distância da entrega");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double dist = double.Parse(Console.ReadLine());
            Console.ResetColor();

            Pedido.CalcularFrete(mod, peso, dist);
        }
    }

    internal class Pedido
    {
        public static void CalcularFrete(string mod, double peso, double distancia)
        {

            switch (mod.ToLower())
            {
                case "pac":
                    break;
                case "sedex":
                    break;
                case "transportadora":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Forma de transporte indisponível ou digitada erradamente.");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
