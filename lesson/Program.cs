using System.Runtime.CompilerServices;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            /*
            //tipo di dato booleano: rispetta l'algebra di boole (vero / falso)
            //bool b = true; O
            bool b = false;
            Console.WriteLine("Tipo di dato 'bool': ");
            Console.WriteLine($"- ammette {true} oppure {false}");
            Console.WriteLine($"- non ammette nessun altro valore");

            Console.WriteLine();
            //tipo di dato "numero intero". Non ammette cifre dietro la virgola. Permette le operazioni di resto e quoto  
            int i = 0;
            Console.WriteLine("Tipo di dato 'int':");
            Console.WriteLine("-rappresenta un numero intero");
            Console.WriteLine($"- valore minimo: {int.MinValue}");
            Console.WriteLine($"- valore massimo: {int.MaxValue}");

            Console.WriteLine();
            //tipo di dato "numero intero corto". Come int, ma ha un intervallo di valore stretto (circa la metà di int)
            short sh = 0;

            Console.WriteLine("Tipo di dato 'short':");
            Console.WriteLine("-rappresenta un numero intero");
            Console.WriteLine($"- valore minimo: {short.MinValue}");
            Console.WriteLine($"- valore massimo: {short.MaxValue}");

            Console.WriteLine();
            //tipo di dato "numero intero lungo". Come int, ma ha un intervallo di valori più ampio (circa il doppio delle cifre di int)
            long l = 0;

            Console.WriteLine("Tipo di dato 'long':");
            Console.WriteLine("-rappresenta un numero intero");
            Console.WriteLine($"- valore minimo: {long.MinValue}");
            Console.WriteLine($"- valore massimo: {long.MaxValue}");

            Console.WriteLine();
            //tipo di dato "numero con virgola". Permette cifre dietro la virgola, ad una determinata PRECISIONE (precisione singola)
            float f = 0;

            Console.WriteLine("Tipo di dato 'float':");
            Console.WriteLine("-rappresenta un numero con la virgola");
            Console.WriteLine($"- valore minimo: {float.MinValue}");
            Console.WriteLine($"- valore massimo: {float.MaxValue}");
            Console.WriteLine($"- Infinito: {float.PositiveInfinity}");
            Console.WriteLine($"- Infinito: {float.NegativeInfinity}");

            Console.WriteLine();
            //tipo di dato "numero con virgola, precisione doppia". Come float, ma ammette una precisione maggiore
            double d = 0;

            Console.WriteLine("Tipo di dato 'double':");
            Console.WriteLine("-rappresenta un numero con la virgola");
            Console.WriteLine($"- valore minimo: {double.MinValue}");
            Console.WriteLine($"- valore massimo: {double.MaxValue}");
            Console.WriteLine($"- Infinito: {double.PositiveInfinity}");
            Console.WriteLine($"- Infinito: {double.NegativeInfinity}");

            Console.WriteLine();
            //tipo di dato decimal, ovvero "numero decimale con virgola". Come float, ma ha una precisione molto maggiore. Occupa molta memoria.
            decimal dc = 0;

            Console.WriteLine("Tipo di dato 'decimal':");
            Console.WriteLine("-rappresenta un numero con la virgola");
            Console.WriteLine($"- valore minimo: {decimal.MinValue}");
            Console.WriteLine($"- valore massimo: {decimal.MaxValue}");

            Console.WriteLine();
            //tipo di dato "byte". Numero intero fra 0 e 255.
            byte bt = 0;

            Console.WriteLine("Tipo di dato 'byte':");
            Console.WriteLine("-rappresenta un numero che sta in un byte");
            Console.WriteLine($"- valore minimo: {byte.MinValue}");
            Console.WriteLine($"- valore massimo: {byte.MaxValue}");

            Console.WriteLine();
            //tipo di dato "carattere". Rappresenta un singolo carattere UNICODE.
            char c = '\0';

            Console.WriteLine("Tipo di dato 'char':");
            Console.WriteLine("-rappresenta un carattere");
            Console.WriteLine($"- valore minimo: {char.MinValue}");
            Console.WriteLine($"- valore massimo: {char.MaxValue}"); //65535 = 2 byte - 1 

            Console.WriteLine();
            //tipo di dato "stringa". Rappresenta una serie di caratteri, terminata da un carattere terminatore ('\0', in  C# è astratto)
            string s = "";

            Console.WriteLine("Tipo di dato 'stringa':");
            Console.WriteLine("-rappresenta una stringa");
            Console.WriteLine($"- String.Empty: {string.Empty}"); // == "";

            Console.WriteLine("---------------------------");
            Console.WriteLine();

            Console.WriteLine(@"Il metodp .Join permette di mettere insieme più stringhe in una sola,
                                opzionalmente separando con un carattere serparatore");

            */
            Console.WriteLine("Ora gli esercizi");
            Console.WriteLine("Esecizio 1: ");
            Esercizion1();

            Console.WriteLine("Esercizio 2: ");
            Exercise2();

            Console.WriteLine("Esercizio 3: ");
            Exercise3();

            Console.WriteLine("Esercizio 4: ");
            Exercise4();
        }

        /// <summary>
        /// Visualizza 100 numeri pari, partendo dal numero 2
        /// </summary>    
        private static void Esercizion1()
        {
            for (int i = 0; i <= 200; i += 2)
            {
                Console.WriteLine($"{i}");
            }
        }
        /// <summary>
        /// Calcola il fattoriale di un numero n in ingresso.
        /// Il fattoriale di un numero si indica con n!.
        /// 0! = 1, 1! = 1, 2! = 2 * 1, 3! = 3 * 2 * 1, e così
        /// </summary>
        private static void Exercise2()
        {
            int n;
            Console.WriteLine("Inserisci un valore n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int fattoriale = 1;
            if (n < 0)
            {
                Console.WriteLine($"{n} non è un numero positivo!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fattoriale *= i;
                }
                Console.WriteLine($"Il fattoriale di {n} è {fattoriale}");
            }
        }

        /// <summary>
        /// Converte un numero binario fornito in ingresso nel numero intero decimale corrispondente.
        /// Es. "1000" -> 8, "1010" -> 10, "1111" -> 15, e così via.
        /// </summary>
        private static void Exercise3()
        {
            Console.WriteLine("Inerisci un numero in binario: ");
            string line = Console.ReadLine()!;
            double result = 0;

            for (int i = 0; i < line.Length; i++)
            {
                int currentExpValue = Convert.ToInt32(line[i] - '0');
                result += currentExpValue * Math.Pow(2, line.Length - 1 - i);
            }
            Console.WriteLine($"{line} - > {result}");
        }

        /// <summary>
        /// Dato in unput un numero n intero positivo, stampa a video il termine
        /// n-esimo della successione di Fibonacci
        /// 
        /// fibonacci(0) = 0;
        /// fibonacci(1) = 1;
        /// fibonacci(n+2) = fibonacci(n + 1) + fibonacci(n)
        /// </summary>
        private static void Exercise4()
        {
            Console.WriteLine("Inserire N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine($"{n} non è un numero positivo");
            }
            else if (n < 2)
            {
                Console.WriteLine($"Fibonacci({n}) -> {n}");
            }
            else
            {
                int first = 0;
                int second = 1;

                for(int i = 2; i <= n; i++)
                {
                    int third = first + second;
                    first = second;
                    second = third;
                }
                Console.WriteLine($"Fibonacci({n}) -> {second}");
            }
        }
    }
}
