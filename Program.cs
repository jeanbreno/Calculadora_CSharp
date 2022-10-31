using System;

namespace Calculadora {
    internal class Program {
        public static void Main(string[] args) {
            int op;

            do { 
                MenuCalculadora();
                int opcao = EscolherOpcao();
                ExecutarCalculadora(opcao);
                op = ContinuarExecucao();
                Console.Clear();
            } while (op == 1);
            
        }

        static public int ContinuarExecucao() {
            Console.Write("Deseja realizar outra operação? \n" +
                            "[1] - SIM\n" +
                            "[2] - NÃO\n" +
                            "Opção: ");
            int op = int.Parse(Console.ReadLine());
  
            return op;
        }

        static public void MostrarOperacao(double result) {

            result = Math.Round(result, 2);

            Console.WriteLine("\nResultado: " + result + "\n");
        }

        public static double LerOperando() {
            double op;

            Console.Write("Operando: ");
            op = double.Parse(Console.ReadLine());

            return op;
        }

        public static void Somar() {
            double op1, op2, result;

            Console.Clear();
            Console.WriteLine("--- Operação Soma ---\n");

            op1 = LerOperando();
            op2 = LerOperando();

            result = op1 + op2;

            MostrarOperacao(result);
        }

        public static void Subtrair() {
            double op1, op2, result;

            Console.Clear();
            Console.WriteLine("--- Operação Subtrair ---\n");

            op1 = LerOperando();
            op2 = LerOperando();

            result = op1 - op2;

            MostrarOperacao(result);
        }

        public static void Multiplicar() {
            double op1, op2, result;

            Console.Clear();
            Console.WriteLine("--- Operação Multiplicar ---\n");

            op1 = LerOperando();
            op2 = LerOperando();

            result = op1 * op2;

            MostrarOperacao(result);
        }

        public static void Dividir() {
            double op1, op2, result;

            Console.Clear();
            Console.WriteLine("--- Operação Dividir ---\n");

            op1 = LerOperando();
            op2 = LerOperando();

            while (op2 == 0) {
                Console.WriteLine("Segundo Operador não pode ser 0 em uma divisão. Digite novamente.");
                op2 = LerOperando();
            }

            result = op1 / op2;

            MostrarOperacao(result);
        }

        public static void ExecutarCalculadora(int opcao) {
            
            switch (opcao) {
                case 1:
                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        public static int EscolherOpcao() {
            int opcao;

            opcao = int.Parse(Console.ReadLine());

            return opcao;
        }

        public static void MenuCalculadora() {
            Console.WriteLine("------ Calculadora ------\n");
            Console.Write(  "[1] Soma \n" +
                            "[2] Subtração \n" +
                            "[3] Multiplicação \n" +
                            "[4] Divisão \n" +
                            "[5] - \n" +
                            "[0] Sair \n\n" +
                            "Opção: ");
        }
    }
}
