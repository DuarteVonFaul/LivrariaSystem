using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LivrariaSystem.models
{
    public class Address
    {
        [JsonPropertyName("logradouro")]
        public string Street { get; set; }
        [JsonPropertyName("cidade")]
        public string City { get; set; }
        [JsonPropertyName("pais")]
        public string Country { get; set; }
        [JsonPropertyName("estado")]
        public string State { get; set; }
        [JsonPropertyName("cep")]
        public string PostalCode { get; set; }
        
        public string Number { get; set; }


        public override string ToString()
        {
            return  $"    [Rua: {Street},\n" +
                    $"    Cidade: {City},\n" +
                    $"    Estado: {State},\n" +
                    $"    CEP: {PostalCode}]";
        }
    }
}
