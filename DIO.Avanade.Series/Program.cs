using DIO.Avanade.Series.App.Service;
using System;

namespace DIO.Avanade.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            SeriesServices service = new();
            string userOption = Options();

            while (userOption != "X")
            {
                switch (userOption)
                {
                    case "1":
                        service.SeriesList();
                        break;
                    case "2":
                        service.InsertSerie();
                        break;
                    case "3":
                        service.UpdateSerie();
                        break;
                    case "4":
                        service.DeleteSerie();
                        break;
                    case "5":
                        service.ShowSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOption = Options();
            }
            
        }

        private static string Options() 
        {
            Console.WriteLine("");
            Console.WriteLine("DIO AVANADE BOOTCAMP - PROJETO LISTA DE SERIES");
            Console.WriteLine("Selecione uma opção no menu:");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            return Console.ReadLine().ToUpper();
        }
    }
}
