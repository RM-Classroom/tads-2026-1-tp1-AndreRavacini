using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Models
{
    public class CategoriaVeiculo
    {
        [Key]
        public int IdCategoriaVeiculo { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}