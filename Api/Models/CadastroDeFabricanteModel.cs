using AGREGAMENTO.Enums;
using System.ComponentModel.DataAnnotations;

namespace AGREGAMENTO.Models
{
    public class CadastroDeFabricanteModel
    {
        [Key]
        public bool Ativo { get; set; }
        public int IdSerede { get; set; }
        public DateTime DataDaAcao { get; set; }


        public FabricanteEnum Nome { get; set; }
        
       

    }
}
