using AGREGAMENTO.Enums;

namespace AGREGAMENTO.Models
{
    public class LogFabricanteModel
    {
        public int IdSerede { get; set; }
        public DateTime DataDaAcao { get; set; }


        public FabricanteEnum Nome { get; set; }
    }
}
