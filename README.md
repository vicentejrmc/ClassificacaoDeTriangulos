# Classificador de Triângulo.

- **Este programa funciona no modo Console.App.**
- **Como o entitulado, tem como objetivo classificar Triângulos dado os valores de numeros do tipo int representando os lados do triangulo.**

***

## Demo:

![](https://i.imgur.com/TMjAtuE.gif)

***

## Funcionalidades:

- **Permitir imput/entrada de valores digitadas pelo usuário:** Caso não seja, o sistema informará ao usuário e solicitará uma nova entrada. 
- **Verificar se o triangulo é valido. (A Soma de quaisquer dois lados é maior que o terceiro.)** Caso o Triangulo não seja valido, o programa informará ao usuário.
- **Classificar o triangulo de acordo com o seu tipo:** (Eqüilátero: Todos os lados são iguais) - (Isósceles: Dois lados são iguais) - (Escaleno: Todos os lados são diferentes)
Após classificação, o programa infomará ao usuário o tipo do triângulo digitado.

***

## Como Utilizar:

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz.
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Compile a aplicação utilizando o comando abaixo.

```
dotnet build --configuration Release
```

5. Para execultar o projeto compilando em tem real.

```
dotnet run --project ClassificacaoDeTriangulos.ConsoleApp
```

6.Para executar o arquivo compilado, navegue até a pasta ./ClassificacaoDeTriangulo.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:

```
ClassificacaoDeTriangulos.ConsoleApp
```

***

## Requisitos.


- *.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.*

****