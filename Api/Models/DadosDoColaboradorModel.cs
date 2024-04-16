using AGREGAMENTO.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AGREGAMENTO.Models
{
    public class DadosDoColaboradorModel
    {
        
        [KeyAttribute()]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public  int IdSerede { get; set; }
        public string Nome { get; set; }
        public bool SituacaoDoColaborador { get; set; }
        public string CPF { get; set; }
        public string PIS { get; set; }
        public string CentroDeCusto { get; set; }
        public string Cargo { get; set; }
        public string Estado { get; set; }
        public string  Gestor { get; set; }
    }
}
