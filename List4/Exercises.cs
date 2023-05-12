using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List4 {
    public class Exercises {

        public class Exercise_01 {

            public static string[] Exercicio01() {

                Console.WriteLine("\t\t\t\t.:.Exercicio 01.:.");
                Console.Write("\nDigite a quantidade de alunos: ");
                int indiceAluno = 1;

                int N = int.Parse(Console.ReadLine());


                string[] resultados = new string[N];


                for (int i = 0; i < N; i++) {

                    indiceAluno = i +1;

                    Console.Write($"\nAluno #{indiceAluno},digite o primeiro valor: ");
                    int valor1 = int.Parse(Console.ReadLine());

                    Console.Write($"\nAluno #{indiceAluno},digite o segundo valor: ");
                    int valor2 = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite [A] para média aritmética ou [P] para média ponderada: ");
                    char caractere = char.Parse(Console.ReadLine());

                    resultados[i] = CalcularProcedimento(valor1, valor2, caractere, indiceAluno);
                }
                return resultados;
            }

            public static string CalcularProcedimento(int valor1, int valor2, char caractere, int indiceAluno) {

                if (caractere == 'P') {

                    int somaPreco = valor1 + valor2;
                    int mediaPonderada = ((valor1 * 5) + (valor2 * 3)) / somaPreco;

                    return $"\nPrezado aluno #{indiceAluno:F0}, a sua média ponderada é de: {mediaPonderada:F2}";
                }
                else if (caractere == 'A') {

                    int mediaAritmetica = (valor1 + valor2) / 3;
                    return $"\nPrezado aluno #{indiceAluno:F0}, a sua média aritmetica é de: {mediaAritmetica:F2}";
                }


                else {
                    return $"\nPrezado aluno #{indiceAluno:F0}, o caractere é indevido!\nPor favor compilar o código novamente e digitar um valor válido";
                }
            }
        }
        public class Exercise_02 {

        }
    
    }
}
