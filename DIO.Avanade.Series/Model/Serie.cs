using DIO.Avanade.Series.App.Model.Enum;
using System;

namespace DIO.Avanade.Series.App.Model
{
    public class Serie: BaseEntity
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao{ get; set; }
        private int Ano { get; set; }
        private bool Deleted { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano, bool deleted) 
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Deleted = deleted;
        }

        public override string ToString()
        {
            string output = "";

            output += "Gênero: " + Genero + Environment.NewLine;
            output += "Titulo: " + Titulo + Environment.NewLine;
            output += "Descricao: " + Descricao + Environment.NewLine;
            output += "Ano de Inicio: " + Ano + Environment.NewLine;

            return output;
        }

        public void Exclude() => Deleted = true;
        public int SerieId() => Id;
        public string SeriesTitulo() =>  Titulo;
        public bool StateSerie() => Deleted;
    }
}
