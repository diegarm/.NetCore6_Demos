// See https://aka.ms/new-console-template for more information
using ModeloAnemico;

Console.WriteLine("Hello, World!");

try
{
    var cliente = new Cliente(Guid.NewGuid(), "Di", "Bento");
    Console.WriteLine(cliente.Name);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}


