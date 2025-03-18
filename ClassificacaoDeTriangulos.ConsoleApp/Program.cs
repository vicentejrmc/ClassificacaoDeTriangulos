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
                Console.WriteLine();

                //(Imput do usuario) Entrada de dados
                int ladoX;
                while(true)
                {
                    Console.Write("Informe o valor Lado X: ");
                    bool consegueConverter = int.TryParse(Console.ReadLine(), out ladoX);
                    if (consegueConverter)
                        break;
                }

                int ladoY;
                while(true)
                {
                    Console.Write("Informe o valor Lado Y: ");
                    bool consegueConverter = int.TryParse(Console.ReadLine(), out ladoY);
                    if (consegueConverter)
                        break;
                }

                int ladoZ;
                while (true)
                {
                    Console.Write("Informe o valor Lado Y: ");
                    bool consegueConverter = int.TryParse(Console.ReadLine(), out ladoZ);
                    if (consegueConverter)
                        break;
                }

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
                {
                    string tipoTriangulo = "Não Classificado.";

                    if (ladoX == ladoY && ladoY == ladoZ)
                        tipoTriangulo = "Equilátero";
                    else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                        tipoTriangulo = "Escaleno";
                    else
                        tipoTriangulo = "Isósceles";

                    Console.WriteLine($"O Triângulo é: {tipoTriangulo}");
                }   
                else
                    Console.WriteLine("Os valores informados não forma um triângulo valido");

                Console.WriteLine("-------------------------------------------------");
                Console.Write("Deseja Continuar? (S/N) ");
                string opecaoContinuar = Console.ReadLine()!.ToUpper();

                if (opecaoContinuar != "S")
                    break;
            }


        }//F
    }
}
