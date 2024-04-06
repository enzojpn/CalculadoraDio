// See https://aka.ms/new-console-template for more information
using Calculadora;

Console.WriteLine("Hello, World!");
var c = new CalculadoraImp(); 
int res = c.soma(2, 5);

Console.WriteLine(res);
c.divisao(10,2);
Console.WriteLine(res);