using DIO.Avanade.Series.App.Model;
using DIO.Avanade.Series.App.Model.Enum;
using DIO.Avanade.Series.App.Repository;
using System;

namespace DIO.Avanade.Series.App.Service
{
    public class SeriesServices
    {
        SerieRepository repository = new();

        public void SeriesList()
        {
            Console.WriteLine("Listagem de Series: ");
            if (repository.DataList().Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var serie in repository.DataList())
                Console.WriteLine("ID - {0}: {1} {2}", serie.SerieId(), serie.SeriesTitulo() , (serie.StateSerie() ? "*Excluido*" : ""));
        }
        public Serie ChangeInfo(int idSerie) 
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));

            Console.WriteLine("Selecione o genero da série entre as opções acima: ");
            int readGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da série: ");
            string readTitle = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da série: ");
            int readYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma descrição para a série: ");
            string readDescription = Console.ReadLine();

            return new Serie(id: idSerie,
                genero: (Genero)readGenero,
                titulo: readTitle,
                descricao: readDescription,
                ano: readYear,
                deleted: false);
        }

        public void InsertSerie()
        {
            Console.WriteLine("Inserir nova série: ");
            repository.Insert(ChangeInfo(repository.SetId()));
        }

        public void UpdateSerie() 
        {
            Console.WriteLine("Digite o ID da série: ");
            int idSerie = int.Parse(Console.ReadLine());
            repository.Update(idSerie,ChangeInfo(idSerie)); 
        }

        public void DeleteSerie() 
        {
            Console.WriteLine("Digite o ID da série: ");
            int idSerie = int.Parse(Console.ReadLine());
            
            Serie selectedSerie = repository.SearchById(idSerie);
            Console.WriteLine(selectedSerie.ToString());

            Console.WriteLine("Remover este registro ? ");
            string choice;
            do
            {
                Console.WriteLine("Digite Y para sim  ou N para não.");
                choice = Console.ReadLine().ToUpper().Trim();

            } while (choice.Equals("Y") == false && choice.Equals("N") == false);
            if (choice == "Y")
                repository.Remove(idSerie);
            else
                Console.WriteLine("Remoção cancelada");
            
        }
        public void ShowSerie() 
        {
            Console.WriteLine("Digite o ID da série: ");
            Serie serie = repository.SearchById(int.Parse(Console.ReadLine()));
            Console.WriteLine("{0}", serie.StateSerie() ? "Série não encontrada" : serie);
            Console.WriteLine();

        }
    }
}
