using System.Text.Json.Serialization;

namespace AGREGAMENTO.Enums
{
    // Transformar a utilização de número para texto
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EstadoEnum
    {
        RJ,
        SP,
        SC,
        PA,
        AM,
        BA,
        MG,
        PR,
    }
}
