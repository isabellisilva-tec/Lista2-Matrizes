using System;

namespace BibliotecaMatriz
{
class Matriz{
    
    public static void lerMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0); //matriz é o nome do meu parametro
        int colunas = matriz.GetLength(1);


        //lendo a minha matriz. 
        for(int i=0; i<linhas; i++)
        {
            for(int j=0; j<colunas; j++)
            {
                Console.Write($"[{i}, {j}]: ");
                matriz[i,j] = int.Parse(Console.ReadLine());
            }//fim do for j
        } //fim do for i
    }
    
    public static void mostrarMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for(int i=0; i<linhas; i++)
        {
            for(int j=0; j<colunas; j++)
            {
                Console.Write($"{matriz[i,j],3}|");
            }//fim do for j
            Console.WriteLine(); //quebra a linha
        }//fim do for i
    }
    
    public static int maiorValor(int[,] matriz)
    {
             int linhas = matriz.GetLength(0);
             int colunas = matriz.GetLength(1);

             int maior = matriz[0,0];
        
           for(int i=0; i<linhas; i++)
        {
            for(int j=0; j<colunas; j++)
            {
                if(matriz[i,j] > maior)
                {
                    maior = matriz[i,j];
                }
            }
        }
         return maior;
    }

      public static int menorValor(int[,] matriz)
    {
             int linhas = matriz.GetLength(0);
             int colunas = matriz.GetLength(1);

             int menor = matriz[0,0];
        
           for(int i=0; i<linhas; i++)
        {
            for(int j=0; j<colunas; j++)
            {
                if(matriz[i,j] < menor)
                {
                    menor = matriz[i,j];
                }
            }
        }
         return menor;
    }
   
    public static void preencherTropas(int[,] matriz)
        {
        
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

         Random random = new Random();//para gerar numeros aleatorios

           for(int i=0; i<linhas; i++) //aqui é a minha matriz RxC (linhasXcolunas)
        {
            for(int j=0; j<colunas; j++)
            {
                matriz[i,j] = random.Next(0, 101); //aqui estou preenchendo com numeros aleatorios
              
            }
        }//fim i
        }

   public static void somarForcaRegioes(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        
        //ESSE FOR MOSTRA AS REGIÕES
        Console.WriteLine("Matriz das Tropas (Quantidade de Tropas por Cidade):");
        for(int i=0; i<linhas; i++) 
        {
            Console.Write("Região "+ (i + 1)+ ": ");

            for(int j=0; j<colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine(""); // Pula de linha após imprimir todas as cidades
        }//fim i

        //ESSE FOR MOSTRA A SOMA DAS REGIÕES
        Console.WriteLine("");
        Console.WriteLine("Força total das regiões: ");
         for(int i=0; i<linhas; i++) 
        {
            int somaRegiao = 0;

            for(int j=0; j<colunas; j++)
            {
                somaRegiao = somaRegiao + matriz[i,j];
            }
    
            Console.WriteLine("Região " + (i + 1) + ": " + somaRegiao + " tropas");
        }//fim i



        
    }

 }
}

