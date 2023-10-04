using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingRecord
{
    public record Carro
    {
        public string? Marca { get; init; }
        public string? Modelo { get; init; }
        public string? Cor { get; init; }
        public string? Combustivel { get; init; }

        public Carro(string? marca, string? modelo, string? cor, string? combustivel)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Combustivel = combustivel;
        }

        public void Deconstruct(out string? marca, out string? modelo, out string? cor, out string? combustivel)
        {
            marca = Marca;
            modelo = Modelo;
            cor = Cor;  
            combustivel = Combustivel;
        }



    }
}
