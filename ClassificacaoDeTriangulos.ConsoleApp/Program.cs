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
                Console.Write("Informe o valor Lado X: ");
                int ladoX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor Lado X: ");
                int ladoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor Lado X: ");
                int ladoZ = Convert.ToInt32(Console.ReadLine());

                //Exibição de Valores Digitados
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Valores informados:");
                Console.WriteLine($"Lado X: {ladoX}");
                Console.WriteLine($"Lado Y: {ladoY}");
                Console.WriteLine($"Lado Z: {ladoZ}");
                Console.WriteLine("-------------------------------------------------");

                //Verificar validdade do triangulo
                bool medidasDotrianguloValidas = // se as tres condições forem validas o resultado é true.
                    ladoX + ladoY > ladoZ &&     // Caso contrario o resultado é false.
                    ladoX + ladoZ > ladoY &&
                    ladoY + ladoZ > ladoX;

                if(medidasDotrianguloValidas == true)
                    Console.WriteLine("O triângulo é valido.");
                else
                    Console.WriteLine("Os valores informados não forma um triângulo valido");

                    Console.Write("Deseja Continuar? ");
                string opecaoContinuar = Console.ReadLine()!.ToUpper();

                if (opecaoContinuar != "S")
                    break;
            }
        }
    }
}
