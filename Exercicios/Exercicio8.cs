/*8- A entrada contém um único conjunto de testes, que deve ser lido do dispositivo de entrada 
padrão(normalmente o teclado)A primeira linha da entrada contem um número inteiro N (2 < N < 500.000) 
representando o número de registros de raios no relatório. Cada uma das N linhas seguintes contém 2 números 
inteiros X, Y (0 < X, Y < 500) , representando o registro de um raio que caiu no quadrante cujas coordenada
são (X, Y).
Saída
Seu programa deve imprimir 1 se um raio caiu alguma vez em um mesmo lugar ou 0 caso isso não ocorreu;*/

using System;

class Exercicio8
{

    static void Main(string[] args)
    {
      
        int[,] mapaRaios = new int[501, 501];

        int resultado = 0;

        Console.WriteLine("Digite a quantidade de registros de raios: ");
        int qtdRegistros = int.Parse(Console.ReadLine());
       

        for(int i=1; i <= qtdRegistros; i++)
            {
                Console.WriteLine($"Digite as coordenadas do raio (Por exemplo: 2 3): ");
               
                string[] coordenadas = Console.ReadLine().Split(' ');

                int X = int.Parse(coordenadas[0]);
                int Y = int.Parse(coordenadas[1]);
            
        if(mapaRaios[X,Y] == 1)
        {
            resultado = 1;
        }
        else
        {
            mapaRaios[X, Y] = 1;
        }
    }
        Console.WriteLine(resultado);

    }
}
