namespace List4 {
    public class Program {
        public static void Main(string[] args) {
            string[] resultados01 = Exercises.Exercise_01.Exercicio01();
            /*string[] resultados02 = Exercises.Exercicio02();*/

            Console.WriteLine("\nResultados Exercise_01: \n");
            PrintResultados(resultados01);
            
            /*
            Console.WriteLine("\nResultados Exercise_02: \n");
            PrintResultados(resultados02);*/

            Console.ReadKey();
        }

        public static void PrintResultados(string[] resultados) {
            for (int i = 0; i < resultados.Length; i++) {
                Console.WriteLine(resultados[i]);
            }
        }
    }
}
