using System;
using BibliotecaMatriz;

/*2-Crie uma função que receba uma matriz de N Linhas x M Colunas valores inteiros 
e retorne qual o menor valor da matriz.*/
class Exercicio2
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
        int menor = Matriz.menorValor(matriz);
        
        Console.WriteLine($"Menor valor: {menor}");


    }
}