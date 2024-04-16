using System.Text.Json.Serialization;

namespace AGREGAMENTO.Enums
{// Transformar a utilização de número para texto
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BancoEnum
    {
        ITAU,
        BANCO_DO_BRASIL,
        BRADESCO
    }
}
