using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Models
{
    public class Aluguel
    {
        [Key]
        public int IdAluguel { get; set; }

        public DateTime DataRetirada { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public int QuilometragemInicial { get; set; }
        public int? QuilometragemFinal { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorTotal { get; set; }
        public string Status { get; set; }

        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        public int IdVeiculo { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}