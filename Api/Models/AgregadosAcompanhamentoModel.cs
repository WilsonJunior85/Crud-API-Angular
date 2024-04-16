using AGREGAMENTO.Enums;
using System.ComponentModel.DataAnnotations;

namespace AGREGAMENTO.Models
{
    public class AgregadosAcompanhamentoModel
    {
        [Key]
        public int IdSerede { get; set; }
        public CargoEnum Cargo { get; set; }
        public MotivoEnum Situacao { get; set; }
        public string Termo { get; set; }
        public EstadoEnum UF { get; set; }
        public SituacaoDoColaboradorEnum SituacaoColaborador { get; set; }
        public PagamentoEnum Pagamento { get; set; }
        public GestorCentroDeCustoEnum GestorCentroDeCusto { get; set; }

    }
}
