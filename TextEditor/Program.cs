using System;
using System.IO;

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
            Console.WriteLine("2 - Editar arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 0: System.Environment.Exit(0); break;
            }

            //           Menu();

        }
        static void Abrir()
        {

        }

        static void Editar()

        {
            Console.Clear();
            Console.WriteLine("Digite o texto desejado e ao finalizar use ESC para sair.");
            Console.WriteLine("----------------------------------------------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine; // quebrando linha no fim de cada leitura


            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            // Console.WriteLine(text);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Informe o caminho onde o arquivo deve ser salvo: ");
            var path = Console.ReadLine();

            //atenção: no tratamento de arquivos sempre use fechar os arquivos permitindo assim que possa ser reaberto.
            // o using vai abrir e fechar todo objeto que receber, inclusive BD

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();

            Menu();
        }
    }

}