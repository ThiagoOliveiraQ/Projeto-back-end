using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calculodeequipamentos.Models
{
    public class EquipamentoEletronico
    {
        [Key]
        public string Nome { get; set; }
        public int Potencia { get; set; }
        public int TempoDeUso { get; set; }
        public double Consumo { get; set; }
    }
}
