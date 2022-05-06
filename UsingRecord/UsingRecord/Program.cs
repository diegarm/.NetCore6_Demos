// See https://aka.ms/new-console-template for more information
using UsingRecord;

Console.WriteLine("Hello, Example Record");

var carro = new Carro(
    "Ford",
    "Fiesta",
    "Branco",
    "Gasolina"
);


Console.WriteLine($"Carro Inicial: {carro}");

/*NOVO CARRO*/
var novoCarro = carro with { Modelo = "Focus" };

Console.WriteLine($"Novo Carro: {novoCarro}");

/*COMPARAÇÃO*/
Console.WriteLine($"Carro é igual ao Novo Carro: {carro == novoCarro}");
novoCarro = carro with { Modelo = "Fiesta" };
Console.WriteLine($"Carro é igual ao Novo Carro: {carro == novoCarro}");

/*DECONSTRUCT*/
var (marca, modelo, cor, combustivel) = novoCarro;
Console.WriteLine($"Marca: {marca}");
Console.WriteLine($"Modelo: {modelo}");
Console.WriteLine($"Cor:{cor}");
Console.WriteLine($"Combustivel:{combustivel}");



