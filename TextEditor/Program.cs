using System;

namespace TextEditor
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
            Console.WriteLine("Selecione a opção desejada: ");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 0: System.Environment.Exit(0); break;
            }
        }
        static void Abrir()
        {

        }

        static void Editar()
        {

        }
    }

}