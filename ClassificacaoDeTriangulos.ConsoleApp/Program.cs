namespace ClassificacaoDeTriangulos.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabecalho();

            int ladoX =LerLado("X");
            int ladoY =LerLado("Y");
            int ladoZ =LerLado("Z");

            ExibirValoresInformados(ladoX, ladoY, ladoZ);

            bool medidasFormamTrianguloValido =
                ClassificadorDeTriangulos.MedidasformamTrianguloValido(ladoX, ladoY, ladoZ);

            if (medidasFormamTrianguloValido) 
            {
                string tipoTriangulo = 
                 ClassificadorDeTriangulos.ClassificarTriangulo(ladoX, ladoY, ladoZ);

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

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("---- Classificador de Triangulos ----");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
        }

        static int LerLado(string nomeLado)
        {
            int valor;
            while (true)
            {
                Console.Write($"Informe o valor Lado {nomeLado}: ");
                bool consegueConverter = int.TryParse(Console.ReadLine(), out valor);
                if (consegueConverter)
                    break;
            }

            return valor;
        }

        static void ExibirValoresInformados(int ladoX, int ladoY, int ladoZ)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Valores informados:");
            Console.WriteLine($"Lado X: {ladoX}");
            Console.WriteLine($"Lado Y: {ladoY}");
            Console.WriteLine($"Lado Z: {ladoZ}");
            Console.WriteLine("-------------------------------------------------");
        }

    }
}
