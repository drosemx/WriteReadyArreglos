using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            if (args.Length == 0)
            {
                Console.WriteLine("0 argumentos introducidos.");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Los argumentos ingresados son: ");
                for (int i = 0; i < args.Length; i++) // Loop through array
                {
                    string argument = args[i];
                    Console.Write("args index ");
                    Console.Write(i); // Write index
                    Console.Write(" is [");
                    Console.Write(argument); // Write string
                    Console.WriteLine("]");
                }
                Console.WriteLine("el argumento leido es: " + args[0]);
                Console.WriteLine("El numero de argumentos ingresados es:" + args.Length.ToString());
                Console.WriteLine("Now Using  foreach: ");

                foreach (string items in args)
                {
                    Console.Write("args ");
                    Console.Write(" is [");
                    Console.Write(items);
                    Console.WriteLine("]");

                }
            }

            Console.WriteLine("ahora utilizamos un arreglo definido y el uso tambien de foreach:");

            // creating an array
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // foreach loop begin
            // it will run till the
            // last element of the array
            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }



            Console.WriteLine("Ingrese su nombre");
            string s = Console.ReadLine();
            Console.WriteLine("el valor solicitado es: " + s);
            Console.Write("INtroduzca solo un caracter(pero se pueden intriducir mas caracteres por el readline: ");
            char chr = Console.ReadLine()[0];
            Console.Write("El caracter es:" +chr);
            // printing the input character
            Console.WriteLine("\t");
            Console.Write("Introduzca un caracter uso el readkey keychar solo permitiendo un caracter:");
            chr = Console.ReadKey().KeyChar;
            Console.WriteLine("\t");
            // printing the input character
            Console.WriteLine("El caracter leido es: "+chr +"\t");
            Console.Write("Gracias... Hasta pronto!");
            Console.ReadKey();
        }
    }
}
