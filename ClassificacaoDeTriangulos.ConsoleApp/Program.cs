using System.Runtime.InteropServices;

namespace ClassificacaoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Cabeçalho
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("---- Classificador de Triangulos ----");
                Console.WriteLine("-------------------------------------");

                //Entrada de dados
                Console.Write("Informe os Valores do Triângulo");
                Console.Write("Lado X: ");
                int ladoX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lado X: ");
                int ladoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lado X: ");
                int ladoZ = Convert.ToInt32(Console.ReadLine());

                //Exibição de Valores Digitados
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Valores informados:");
                Console.WriteLine($"Lado X: {ladoX}");
                Console.WriteLine($"Lado Y: {ladoY}");
                Console.WriteLine($"Lado Z: {ladoZ}");
                Console.WriteLine("-------------------------------------------------");

                Console.Write("Deseja Continuar? ");
                string opecaoContinuar = Console.ReadLine()!.ToUpper();

                if (opecaoContinuar != "S")
                    break;
            }
        }
    }
}
