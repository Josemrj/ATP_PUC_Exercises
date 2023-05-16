using System;
using System.Collections.Generic;
using System.Globalization;
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

                    indiceAluno = i + 1;

                    Console.Write($"\nAluno #{indiceAluno},digite o primeiro valor: ");
                    int valor1 = int.Parse(Console.ReadLine());

                    Console.Write($"Aluno #{indiceAluno},digite o segundo valor: ");
                    int valor2 = int.Parse(Console.ReadLine());

                    Console.Write("Digite [A] para média aritmética ou [P] para média ponderada: ");
                    char caractere = char.Parse(Console.ReadLine());

                    resultados[i] = CalcularProcedimento(valor1, valor2, caractere, indiceAluno);
                }
                return resultados;
            }

            public static string CalcularProcedimento(int valor1, int valor2, char caractere, int indiceAluno) {

                if (caractere == 'P') {

                    int somaPreco = valor1 + valor2;
                    int mediaPonderada = ((valor1 * 5) + (valor2 * 3)) / somaPreco;

                    return $"Prezado aluno #{indiceAluno:F0}, a sua média ponderada é de: {mediaPonderada:F2}";
                }
                else if (caractere == 'A') {

                    int mediaAritmetica = (valor1 + valor2) / 3;
                    return $"Prezado aluno #{indiceAluno:F0}, a sua média aritmetica é de: {mediaAritmetica:F2}";
                }


                else {
                    return $"\nPrezado aluno #{indiceAluno:F0}, o caractere é indevido!\nPor favor compilar o código novamente e digitar um valor válido";
                }
            }
            public void PrintResultados(string[] resultados) {
                for (int i = 0; i < resultados.Length; i++) {
                    int contagem = i + 1;
                    Console.WriteLine($"\nResultado Aluno #{contagem:F0}:");
                    Console.WriteLine(resultados[i]);
                }

                Console.Write("\n\nDigite qualquer tecla para encerrar o programa: ");
                Console.ReadKey();
            }
        }
        public class Exercise_02 {

            public static void Exercicio02() {

                Console.WriteLine("\t\t\t\t\t\nExercicio_02");
                Console.WriteLine("Digite o número de filhos e salário de uma pessoa para uma pesquisa onde seja indeterminado.\nOS NUMEROS DEVEM SER POSITIVOS ( >= 1 ) !!\nO ponto de parada é <= 0");

                // LerNumeroTransformarIndeterminados();

                double resultados = LerNumeroTransformarIndeterminados();

                Console.WriteLine($"\nA média de salário da população é: {resultados:C2}");
            }

            public static double LerNumeroTransformarIndeterminados() {

                //Declaração de variáveis
                double somaSalario = 0;
                int i;

                //Ponto de parada é 0 tanto para lerSalario e lerNumFilhos
                //Loop para lerSalario e lerNumFilhos por pessoa para realizar lógica de questão
                for (i = 1; i >= 1; i++) {

                    //Entrar com valor de salario
                    Console.WriteLine($"\nDigite o salário da pessoa #{i}: ");
                    double lerSalario = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                    //Ponto de parada <=0 qualquer de ambos
                    if (lerSalario >= 0) {
                        somaSalario += lerSalario;
                        lerSalario = 0;
                    }
                    else break;

                    //Entrar com valor de Filhos
                    Console.WriteLine($"\nDigite a quantidade de filhos da pessoa #{i}: ");
                    int lerNumFilhos = int.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                    //Ponto de parada <=0 qualquer de ambos
                    if (lerNumFilhos >= 0) {
                    }
                    else break;
                }

                //Calcular média de salário de um número "agora" determinado de pessoas
                double mediaSalario = somaSalario / i;

                //Resultado
                return mediaSalario;
            }
        }
    }
}
