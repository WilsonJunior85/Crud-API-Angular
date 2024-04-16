using AGREGAMENTO.Enums;
using System.ComponentModel.DataAnnotations;

namespace AGREGAMENTO.Models
{
    public class CadastroDeValoresModel
    {
        [Key]
        public EstadoEnum  Estado{ get; set; }
        public int Valor { get; set; }
        public bool Ativo { get; set; }
        public  DateTime DataDaAcao { get; set; }
        public int IdSerede { get; set; }
    }
}
