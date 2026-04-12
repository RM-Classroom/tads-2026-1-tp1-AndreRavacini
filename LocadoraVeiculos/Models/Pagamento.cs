using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocadoraVeiculos.Models
{
    public class Pagamento
    {
        [Key]
        public int IdPagamento { get; set; }

        public DateTime DataPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public string FormaPagamento { get; set; }
        public string StatusPagamento { get; set; }

        [ForeignKey("Aluguel")]
        public int IdAluguel { get; set; }
        public Aluguel? Aluguel { get; set; }
    }
}