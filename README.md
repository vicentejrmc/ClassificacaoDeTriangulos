# Classificador de Tri�ngulo.

- **Este programa funciona no modo Console.App.**
- **Como o entitulado, tem como objetivo classificar Tri�ngulos dado os valores de numeros do tipo int representando os lados do triangulo.**

***

## Demo:

![](https://i.imgur.com/TMjAtuE.gif)

***

## Funcionalidades:

- **Permitir imput/entrada de valores digitadas pelo usu�rio:** Caso n�o seja, o sistema informar� ao usu�rio e solicitar� uma nova entrada. 
- **Verificar se o triangulo � valido. (A Soma de quaisquer dois lados � maior que o terceiro.)** Caso o Triangulo n�o seja valido, o programa informar� ao usu�rio.
- **Classificar o triangulo de acordo com o seu tipo:** (Eq�il�tero: Todos os lados s�o iguais) - (Is�sceles: Dois lados s�o iguais) - (Escaleno: Todos os lados s�o diferentes)
Ap�s classifica��o, o programa infomar� ao usu�rio o tipo do tri�ngulo digitado.

***

## Como Utilizar:

1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz.
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Compile a aplica��o utilizando o comando abaixo.

```
dotnet build --configuration Release
```

5. Para execultar o projeto compilando em tem real.

```
dotnet run --project ClassificacaoDeTriangulos.ConsoleApp
```

6.Para executar o arquivo compilado, navegue at� a pasta ./ClassificacaoDeTriangulo.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:

```
ClassificacaoDeTriangulos.ConsoleApp
```

***

## Requisitos.


- *.NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.*

****