using System;
using BibliotecaMatriz;

/*9-Você deve implementar um programa em C# que ajude o mago a calcular a força total das tropas de cada
região. Para isso, crie uma matriz de tamanho R x C, onde R representa o número de regiões (linhas) e C o número
de cidades (colunas) em cada região.
Cada elemento da matriz conterá o número total de tropas (guerreiros, arqueiros e magos) naquela cidade. Seu
programa deve fazer o seguinte:
1. Preencher a matriz com números aleatórios (representando o número de tropas em cada cidade), variando
de 0 a 100.
2. Exibir a matriz gerada (a quantidade de tropas em cada cidade).
3. Para cada linha (região), calcular e exibir a soma total das tropas da região.*/

class Exercicio9
{


    static void Main(string[] args)
    {

        Console.WriteLine("Digite a quantidade de regiões(linhas): ");
        int linhas = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Digite a quantidade de cidades(colunas): ");
        int colunas = int.Parse(Console.ReadLine());

         int[,] matriz = new int[linhas,colunas];//aqui é o meu vetor chamado matriz, e logo a frente, a minha matriz [,]

        //chamando a minha funçao
        Matriz.preencherTropas(matriz);
        Matriz.somarForcaRegioes(matriz);
          

    }

    
}
