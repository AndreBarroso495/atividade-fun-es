using System;

namespace atividade_fun_es
{
    class Program
    {
        static void Main(string[] args)
        {
          
        //   1 - Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
	    //   A. A Média do aluno
	    //   B. A quantidade de Aprovados (Média >=7)
	    //   C. A quantidade de Reprovados (Méida < 7)
	    //   D. A Média geral dos 10 alunos.
        float[] mediaAluno = new float[10];
        string[] nomes = new string[10];
        float[] notas = new float[4];

        for (var i = 0; i < 10; i++){
            Console.WriteLine("Escreva um nome: ");
            nomes[i] = Console.ReadLine();
            for (var x = 0; x < 4; x++){
                Console.WriteLine("Digite a "+(x+1)+" nota : ");
                notas[x] = float.Parse(Console.ReadLine());
                
            mediaAluno [i] = (notas[0] + notas[1] + notas[2] + notas[3])/4;
            
            }
            Console.WriteLine($"Nome : {nomes[i]} - média : {mediaAluno[i]}");
            {
                
            }

        }
        {
            
        }








        }
    }
}
