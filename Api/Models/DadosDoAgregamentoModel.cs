using AGREGAMENTO.Enums;

namespace AGREGAMENTO.Models
{
    public class DadosDoAgregamentoModel
    {
        public FabricanteEnum Fabricante { get; set; }
        public string Modelo { get; set; }
        public int Serial { get; set; }
        public int CodigoSap { get; set; }
        public DateTime DataDeAgregamento { get; set; }
        public BancoEnum Banco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public string NomeDaAgencia { get; set; }
        public string EnderecoDaAgencia { get; set; }
        public int ValorAgregamento { get; set; }
        public DateTime DataAssinatura { get; set; }
        public DateTime DataJuridico { get; set; }
    }
}
