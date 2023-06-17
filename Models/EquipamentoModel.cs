using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class EquipamentoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do aparelho")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o gasto em KHW do aparelho")]
        public string Khw { get; set; }
        [Required(ErrorMessage = "Digite o tempo de uso do aparelho")]
        public string Tempo { get; set; }
        [Required(ErrorMessage = "Digite o tempo de uso do aparelho")]
        public string Quantidade { get; set; }
    }
}
