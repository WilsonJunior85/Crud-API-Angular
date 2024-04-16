using AGREGAMENTO.Enums;

namespace AGREGAMENTO.Models
{
    public class InformacoesDeDesagregamentoModel
    {
        public MotivoEnum Motivo { get; set; }
        public DateTime DataDesagregamento { get; set; }
        public string Observacao { get; set; }
    }
}
