using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5 {
    public class Exercises {


        public static void Exercicio_01() {

            Console.WriteLine("\nExercicio_01\n");
            int[] N = new int[20]; // Vetor N com 20 elementos
            bool success = false;

            while (!success) {
                try {
                    LerValores(N); // Chama a função para ler os valores do vetor N
                    success = true; // Se não ocorrer exceção, marca como sucesso
                }
                catch (Exception e) {
                    Console.WriteLine($"Ocorreu um erro: {e.Message}");
                    Console.WriteLine("Por favor, tente novamente.");
                }
            }

            EncontrarMenorElemento(N); // Chama a função para encontrar o menor elemento e exibir o resultado


            static void LerValores(int[] vetor) {
                for (int i = 0; i < vetor.Length; i++) {
                    Console.Write($"Digite o valor para N[{i}]: ");
                    vetor[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            static void EncontrarMenorElemento(int[] vetor) {
                int menor = vetor[0]; // Assume que o primeiro elemento é o menor
                int posicao = 0; // Posição do menor elemento

                for (int i = 1; i < vetor.Length; i++) {
                    if (vetor[i] < menor) {
                        menor = vetor[i];
                        posicao = i;
                    }
                }

                ExibirResultado(menor, posicao);
            }

            static void ExibirResultado(int menor, int posicao) {
                Console.WriteLine($"O menor elemento de N é {menor} e sua posição dentro do vetor é {posicao}.");
            }
        }

        public static void Exercicio_02() {

            Console.WriteLine("\nExercicio_02\n");
            double[] notas = new double[10]; // Vetor para armazenar as notas dos alunos
            PreencherNotas(notas); // Chama o procedimento para preencher as notas
            CalcularMediaENotasAcimaDaMedia(notas); // Chama o procedimento para calcular a média e contar as notas acima da média


            static void PreencherNotas(double[] vetor) {
                for (int i = 0; i < vetor.Length; i++) {
                    Console.Write($"Digite a nota do aluno {i + 1}: ");
                    vetor[i] = Convert.ToDouble(Console.ReadLine());
                }
            }

            static void CalcularMediaENotasAcimaDaMedia(double[] vetor) {
                double soma = 0;
                int acimaMedia = 0;

                for (int i = 0; i < vetor.Length; i++) {
                    soma += vetor[i];
                }

                double media = soma / vetor.Length;

                for (int i = 0; i < vetor.Length; i++) {
                    if (vetor[i] > media) {
                        acimaMedia++;
                    }
                }

                ExibirResultado(media, acimaMedia);
            }

            static void ExibirResultado(double media, int acimaMedia) {
                Console.WriteLine($"A média da turma é {media:N2}");
                Console.WriteLine($"Alunos com nota acima da média: {acimaMedia}");
            }
        }

        public static void Exercicio_03() {

            Console.WriteLine("\nExercicio_03\n");
            int[] vetorX = new int[10]; // Vetor X com 10 elementos
            PreencherVetorX(vetorX); // Chama o procedimento para preencher o vetor X

            int[] vetorNegativos = ObterVetorNegativos(vetorX); // Chama a função para obter o vetor com os valores negativos

            ExibirVetor(vetorNegativos); // Chama o procedimento para exibir o vetor com os valores negativos

            static void PreencherVetorX(int[] vetor) {
                for (int i = 0; i < vetor.Length; i++) {
                    Console.Write($"Digite o valor para X[{i}]: ");
                    vetor[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            static int[] ObterVetorNegativos(int[] vetor) {
                int contadorNegativos = 0;

                // Conta a quantidade de valores negativos no vetor
                for (int i = 0; i < vetor.Length; i++) {
                    if (vetor[i] < 0) {
                        contadorNegativos++;
                    }
                }

                int[] vetorNegativos = new int[contadorNegativos]; // Vetor para armazenar os valores negativos
                int indiceVetorNegativos = 0;

                // Copia os valores negativos para o novo vetor
                for (int i = 0; i < vetor.Length; i++) {
                    if (vetor[i] < 0) {
                        vetorNegativos[indiceVetorNegativos] = vetor[i];
                        indiceVetorNegativos++;
                    }
                }

                return vetorNegativos;
            }

            static void ExibirVetor(int[] vetor) {
                Console.WriteLine("Vetor:");
                for (int i = 0; i < vetor.Length; i++) {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        public static void Exercicio_04() {


            Console.WriteLine("\nExercicio_04\n");
            int[] vetorX = new int[10]; // Vetor X com 10 elementos
            int[] vetorY = new int[10]; // Vetor Y com 10 elementos

            PreencherVetores(vetorX, vetorY); // Chama o procedimento para preencher os vetores X e Y

            int[] vetorInterpolado = GerarVetorInterpolado(vetorX, vetorY); // Chama o procedimento para gerar o vetor interpolado

            ExibirVetor(vetorInterpolado); // Chama o procedimento para exibir o vetor interpolado


            static void PreencherVetores(int[] vetorX, int[] vetorY) {
                for (int i = 0; i < vetorX.Length; i++) {
                    Console.Write($"Digite o valor para X[{i}]: ");
                    vetorX[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < vetorY.Length; i++) {
                    Console.Write($"Digite o valor para Y[{i}]: ");
                    vetorY[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            static int[] GerarVetorInterpolado(int[] vetorX, int[] vetorY) {
                int[] vetorInterpolado = new int[20]; // Vetor para armazenar os elementos interpolados
                int indiceVetorInterpolado = 0; // Índice para percorrer o vetor interpolado

                for (int i = 0; i < vetorX.Length; i++) {
                    vetorInterpolado[indiceVetorInterpolado] = vetorX[i];
                    indiceVetorInterpolado++;

                    vetorInterpolado[indiceVetorInterpolado] = vetorY[i];
                    indiceVetorInterpolado++;
                }

                return vetorInterpolado;
            }

            static void ExibirVetor(int[] vetor) {
                Console.WriteLine("Vetor:");
                for (int i = 0; i < vetor.Length; i++) {
                    Console.WriteLine(vetor[i]);
                }
            }

        }

        public static void Exercicio_05() {

            Console.WriteLine("\nExercicio_05\n");
            int[] numerosSorteados = SortearNumeros(); // Chama a função para sortear os números

            Console.WriteLine("Tente adivinhar um dos números sorteados!");

            int tentativa;
            do {
                Console.Write("Digite um número: ");
                tentativa = Convert.ToInt32(Console.ReadLine());

                if (VerificarAcerto(tentativa, numerosSorteados)) {
                    Console.WriteLine("Parabéns! Você acertou!");
                    break;
                }
                else {
                    Console.WriteLine("Tente novamente.");
                }
            } while (true);


            static int[] SortearNumeros() {
                Random random = new Random();
                int[] numerosSorteados = new int[3];

                for (int i = 0; i < numerosSorteados.Length; i++) {
                    numerosSorteados[i] = random.Next(10, 51);
                }

                return numerosSorteados;
            }

            static bool VerificarAcerto(int tentativa, int[] numerosSorteados) {
                for (int i = 0; i < numerosSorteados.Length; i++) {
                    if (tentativa == numerosSorteados[i]) {
                        return true;
                    }
                }

                return false;
            }
        }

        public static void Exercicio_06() {

            Console.WriteLine("\nExercicio_06\n");
            int[] temperaturas = new int[31]; // Vetor com as temperaturas de outubro

            Console.WriteLine("Preenchendo as temperaturas de outubro:");
            PreencherTemperaturas(temperaturas); // Chama o procedimento para preencher as temperaturas

            Console.WriteLine("\nTemperaturas registradas em outubro:");
            ExibirTemperaturas(temperaturas); // Chama o procedimento para exibir as temperaturas

            int menorTemperatura = EncontrarMenorTemperatura(temperaturas); // Chama a função para encontrar a menor temperatura
            Console.WriteLine("\nA menor temperatura ocorrida em outubro foi: " + menorTemperatura + "°C");

            int maiorTemperatura = EncontrarMaiorTemperatura(temperaturas); // Chama a função para encontrar a maior temperatura
            Console.WriteLine("A maior temperatura ocorrida em outubro foi: " + maiorTemperatura + "°C");

            double temperaturaMedia = CalcularTemperaturaMedia(temperaturas); // Chama a função para calcular a temperatura média
            Console.WriteLine("A temperatura média em outubro foi: " + temperaturaMedia + "°C");

            int diasAbaixoMedia = ContarDiasAbaixoMedia(temperaturas, temperaturaMedia); // Chama a função para contar os dias abaixo da média
            Console.WriteLine("O número de dias em que a temperatura foi inferior à média é: " + diasAbaixoMedia);

            static void PreencherTemperaturas(int[] temperaturas) {
                for (int i = 0; i < temperaturas.Length; i++) {
                    Console.Write($"Digite a temperatura do dia {i + 1}: ");
                    temperaturas[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            static void ExibirTemperaturas(int[] temperaturas) {
                for (int i = 0; i < temperaturas.Length; i++) {
                    Console.WriteLine("Dia " + (i + 1) + ": " + temperaturas[i] + "°C");
                }
            }

            static int EncontrarMenorTemperatura(int[] temperaturas) {
                int menor = temperaturas[0];

                for (int i = 1; i < temperaturas.Length; i++) {
                    if (temperaturas[i] < menor) {
                        menor = temperaturas[i];
                    }
                }

                return menor;
            }

            static int EncontrarMaiorTemperatura(int[] temperaturas) {
                int maior = temperaturas[0];

                for (int i = 1; i < temperaturas.Length; i++) {
                    if (temperaturas[i] > maior) {
                        maior = temperaturas[i];
                    }
                }

                return maior;
            }

            static double CalcularTemperaturaMedia(int[] temperaturas) {
                int soma = 0;

                for (int i = 0; i < temperaturas.Length; i++) {
                    soma += temperaturas[i];
                }

                return (double)soma / temperaturas.Length;
            }

            static int ContarDiasAbaixoMedia(int[] temperaturas, double media) {
                int contador = 0;

                for (int i = 0; i < temperaturas.Length; i++) {
                    if (temperaturas[i] < media) {
                        contador++;
                    }
                }

                return contador;
            }
        }

        public static void Exercicio_07() {

            Console.WriteLine("\nExercicio_07\n");
            int[,] matriz = new int[5, 5]; // Matriz 5 x 5

            Console.WriteLine("Preenchendo a matriz:");
            PreencherMatriz(matriz); // Chama o procedimento para preencher a matriz

            Console.WriteLine("\nMatriz preenchida:");
            ExibirMatriz(matriz); // Chama o procedimento para exibir a matriz

            int somaLinha4 = CalcularSomaLinha(matriz, 4); // Chama a função para calcular a soma da linha 4
            Console.WriteLine("\nSoma da linha 4: " + somaLinha4);

            int somaColuna2 = CalcularSomaColuna(matriz, 2); // Chama a função para calcular a soma da coluna 2
            Console.WriteLine("Soma da coluna 2: " + somaColuna2);

            int somaDiagonalPrincipal = CalcularSomaDiagonalPrincipal(matriz); // Chama a função para calcular a soma da diagonal principal
            Console.WriteLine("Soma da diagonal principal: " + somaDiagonalPrincipal);

            int somaDiagonalSecundaria = CalcularSomaDiagonalSecundaria(matriz); // Chama a função para calcular a soma da diagonal secundária
            Console.WriteLine("Soma da diagonal secundária: " + somaDiagonalSecundaria);

            int somaTotal = CalcularSomaTotal(matriz); // Chama a função para calcular a soma de todos os elementos da matriz
            Console.WriteLine("Soma total da matriz: " + somaTotal);

            static void PreencherMatriz(int[,] matriz) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        Console.Write($"Digite o valor para a posição [{i}, {j}]: ");
                        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            static void ExibirMatriz(int[,] matriz) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            static int CalcularSomaLinha(int[,] matriz, int linha) {
                int soma = 0;

                for (int j = 0; j < matriz.GetLength(1); j++) {
                    soma += matriz[linha, j];
                }

                return soma;
            }

            static int CalcularSomaColuna(int[,] matriz, int coluna) {
                int soma = 0;

                for (int i = 0; i < matriz.GetLength(0); i++) {
                    soma += matriz[i, coluna];
                }

                return soma;
            }

            static int CalcularSomaDiagonalPrincipal(int[,] matriz) {
                int soma = 0;

                for (int i = 0; i < matriz.GetLength(0); i++) {
                    soma += matriz[i, i];
                }

                return soma;
            }

            static int CalcularSomaDiagonalSecundaria(int[,] matriz) {
                int soma = 0;
                int tamanho = matriz.GetLength(0);

                for (int i = 0; i < tamanho; i++) {
                    soma += matriz[i, tamanho - 1 - i];
                }

                return soma;
            }

            static int CalcularSomaTotal(int[,] matriz) {
                int soma = 0;

                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        soma += matriz[i, j];
                    }
                }

                return soma;
            }

        }

        public static void Exercicio_08() {

            Console.WriteLine("\nExercicio_08\n");
            int[,] matriz = new int[4, 4]; // Matriz 4 x 4

            Console.WriteLine("Preenchendo a matriz:");
            PreencherMatriz(matriz); // Chama o procedimento para preencher a matriz

            Console.WriteLine("\nMatriz preenchida:");
            ExibirMatriz(matriz); // Chama o procedimento para exibir a matriz

            int soma = CalcularSomaAbaixoDiagonal(matriz); // Chama a função para calcular a soma dos elementos abaixo da diagonal principal
            Console.WriteLine("\nSoma dos elementos abaixo da diagonal principal: " + soma);

            Console.WriteLine("\nElementos da diagonal principal:");
            ExibirDiagonalPrincipal(matriz); // Chama o procedimento para exibir os elementos da diagonal principal

            static void PreencherMatriz(int[,] matriz) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        Console.Write($"Digite o valor para a posição [{i}, {j}]: ");
                        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            static void ExibirMatriz(int[,] matriz) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            static int CalcularSomaAbaixoDiagonal(int[,] matriz) {
                int soma = 0;

                for (int i = 1; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < i; j++) {
                        soma += matriz[i, j];
                    }
                }

                return soma;
            }

            static void ExibirDiagonalPrincipal(int[,] matriz) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    Console.WriteLine(matriz[i, i]);
                }
            }
        }

        public static void Exercicio_09() {

            Console.WriteLine("\nExercicio_09\n");
            int[,] matrizA = new int[4, 6]; // Matriz A 4x6
            int[,] matrizB = new int[4, 6]; // Matriz B 4x6

            Console.WriteLine("Preenchendo a matriz A:");
            PreencherMatriz(matrizA); // Chama o procedimento para preencher a matriz A

            Console.WriteLine("Preenchendo a matriz B:");
            PreencherMatriz(matrizB); // Chama o procedimento para preencher a matriz B

            int[,] matrizSoma = CalcularSomaMatrizes(matrizA, matrizB); // Chama a função para calcular a soma das matrizes A e B
            Console.WriteLine("Matriz Soma (A + B):");
            ExibirMatriz(matrizSoma); // Chama o procedimento para exibir a matriz soma

            int[,] matrizDiferenca = CalcularDiferencaMatrizes(matrizA, matrizB); // Chama a função para calcular a diferença das matrizes A e B
            Console.WriteLine("Matriz Diferença (A - B):");
            ExibirMatriz(matrizDiferenca); // Chama o procedimento para exibir a matriz diferença


            static void PreencherMatriz(int[,] matriz) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        Console.Write($"Digite o valor para a posição [{i}, {j}]: ");
                        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            static int[,] CalcularSomaMatrizes(int[,] matrizA, int[,] matrizB) {
                int[,] matrizSoma = new int[matrizA.GetLength(0), matrizA.GetLength(1)];

                for (int i = 0; i < matrizA.GetLength(0); i++) {
                    for (int j = 0; j < matrizA.GetLength(1); j++) {
                        matrizSoma[i, j] = matrizA[i, j] + matrizB[i, j];
                    }
                }

                return matrizSoma;
            }

            static int[,] CalcularDiferencaMatrizes(int[,] matrizA, int[,] matrizB) {
                int[,] matrizDiferenca = new int[matrizA.GetLength(0), matrizA.GetLength(1)];

                for (int i = 0; i < matrizA.GetLength(0); i++) {
                    for (int j = 0; j < matrizA.GetLength(1); j++) {
                        matrizDiferenca[i, j] = matrizA[i, j] - matrizB[i, j];
                    }
                }

                return matrizDiferenca;
            }

            static void ExibirMatriz(int[,] matriz) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void Exercicio_10() {

            Console.WriteLine("\nExercicio_10\n");
            int[,] matriz = new int[10, 10]; // Matriz M(10, 10)

            Console.WriteLine("Preenchendo a matriz:");
            PreencherMatriz(matriz); // Chama o procedimento para preencher a matriz

            Console.WriteLine("Matriz original:");
            ExibirMatriz(matriz); // Chama o procedimento para exibir a matriz original

            TrocarLinhas(matriz, 2, 8); // Chama o procedimento para trocar a linha 2 com a linha 8
            Console.WriteLine("Matriz após a troca das linhas 2 e 8:");
            ExibirMatriz(matriz); // Chama o procedimento para exibir a matriz resultante da troca

            TrocarColunas(matriz, 4, 10); // Chama o procedimento para trocar a coluna 4 com a coluna 10
            Console.WriteLine("Matriz após a troca das colunas 4 e 10:");
            ExibirMatriz(matriz); // Chama o procedimento para exibir a matriz resultante da troca

            TrocarDiagonais(matriz); // Chama o procedimento para trocar a diagonal principal com a diagonal secundária
            Console.WriteLine("Matriz após a troca das diagonais principal e secundária:");
            ExibirMatriz(matriz); // Chama o procedimento para exibir a matriz resultante da troca

            TrocarLinhaComColuna(matriz, 5, 10); // Chama o procedimento para trocar a linha 5 com a coluna 10
            Console.WriteLine("Matriz após a troca da linha 5 com a coluna 10:");
            ExibirMatriz(matriz); // Chama o procedimento para exibir a matriz resultante da troca


            static void PreencherMatriz(int[,] matriz) {

                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        Console.Write($"Digite o valor para a posição [{i}, {j}]: ");
                        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            static void TrocarLinhas(int[,] matriz, int linha1, int linha2) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    int temp = matriz[linha1, j];
                    matriz[linha1, j] = matriz[linha2, j];
                    matriz[linha2, j] = temp;
                }
            }

            static void TrocarColunas(int[,] matriz, int coluna1, int coluna2) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    int temp = matriz[i, coluna1];
                    matriz[i, coluna1] = matriz[i, coluna2];
                    matriz[i, coluna2] = temp;
                }
            }

            static void TrocarDiagonais(int[,] matriz) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    int temp = matriz[i, i];
                    matriz[i, i] = matriz[i, matriz.GetLength(0) - 1 - i];
                    matriz[i, matriz.GetLength(0) - 1 - i] = temp;
                }
            }

            static void TrocarLinhaComColuna(int[,] matriz, int linha, int coluna) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    int temp = matriz[i, coluna];
                    matriz[i, coluna] = matriz[linha, i];
                    matriz[linha, i] = temp;
                }
            }

            static void ExibirMatriz(int[,] matriz) {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();//Para pular para próxima linha
                }
            }
        }

    }
}