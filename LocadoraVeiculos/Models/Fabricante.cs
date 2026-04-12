using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Models
{
    public class Fabricante
    {
        [Key]
        public int IdFabricante { get; set; }

        public string Nome { get; set; }
        public string PaisOrigem { get; set; }
    }
}