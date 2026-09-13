using System;
using BibliotecaMatriz;

/*1-Crie uma função que receba uma matriz de N Linhas x M Colunas valores inteiros
e retorne qual o maiorvalor da matriz.*/

class Exercicio1
{
    static void Main(string[] args)
    {
        int linhas;
        int colunas;


        Console.Write("Digite a quantidade de linhas: ");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade de colunas: ");
        colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas,colunas];
     

        //chamando a minha função
        Matriz.lerMatriz(matriz);
        Matriz.mostrarMatriz(matriz);
        int maior = Matriz.maiorValor(matriz);
        
        Console.WriteLine($"Maior valor: {maior}");

    }
}