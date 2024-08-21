using System;

namespace Calculadorateste
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual opçaõ deseja utilizar ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5 -MetodoParaBrincar");
            Console.WriteLine("Sair");

            Console.WriteLine("---------");
            Console.WriteLine("Selecione uma opção: ");
            
            short res = short.Parse(Console.ReadLine());

            switch(res) {
                
                case 1: Soma (); break;
                case 2: Subtracao (); break;
                case 3: Multiplacao (); break;
                case 4: Divisao (); break;
                case 5: MetodoParaBrincar (); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

        }

        static void Soma()


        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(v1);

            Console.WriteLine("segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é" + resultado);
           Console.WriteLine($"O resultado da soma é {resultado}");
           // Console.WriteLine($"O resultado da soma é {v1 + v2}");
           // Console.WriteLine("O resultado da soma é" + (v1 + v2));
           Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();

            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1-v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();



            


        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1/v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();


        }
        
        static void MetodoParaBrincar()
        {
            Console.Clear();

            Console.WriteLine("Mudei o texto");
            var entrada = Console.ReadLine();
            System.Console.WriteLine(entrada);
            

        }

        static void Multiplacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1*v2;
            Console.WriteLine("O resultado da multiplicação é" + (v1*v2));
            Console.ReadKey();
            Menu();



        }
    }

}
