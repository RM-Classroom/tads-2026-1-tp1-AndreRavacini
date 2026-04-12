using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocadoraVeiculos.Models
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }

        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int QuilometragemAtual { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public decimal ValorDiariaBase { get; set; }
        public string Status { get; set; }

        [ForeignKey("Fabricante")]
        public int IdFabricante { get; set; }
        public Fabricante? Fabricante { get; set; }

        [ForeignKey("CategoriaVeiculo")]
        public int IdCategoriaVeiculo { get; set; }
        public CategoriaVeiculo? CategoriaVeiculo { get; set; }
    }
}