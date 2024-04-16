using System.Text.Json.Serialization;

namespace AGREGAMENTO.Enums
{
    // Transformar a utilização de número para texto
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CargoEnum
    {
        DIRETOR,
        GERENTE,
        CORDENADOR,
        ESPECIALISTA,
        ANALISTA,
        ASSISTENTE,
    }
}
