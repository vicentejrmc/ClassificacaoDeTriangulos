namespace ClassificacaoDeTriangulos.ConsoleApp;

static class ClassificadorDeTriangulos
{
    public static bool MedidasformamTrianguloValido(int ladoX, int ladoY, int ladoZ)
    {
        bool medidasDotrianguloValidas =
           ladoX + ladoY > ladoZ &&
           ladoX + ladoZ > ladoY &&
           ladoY + ladoZ > ladoX;

        return medidasDotrianguloValidas;
    }

    public static string ClassificarTriangulo(int ladoX, int ladoY, int ladoZ)
    {
        string tipoTriangulo = "Não Classificado.";

        if (ladoX == ladoY && ladoY == ladoZ)
            tipoTriangulo = "Equilátero";
        else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
            tipoTriangulo = "Escaleno";
        else
            tipoTriangulo = "Isósceles";

        return tipoTriangulo;
    }

}
