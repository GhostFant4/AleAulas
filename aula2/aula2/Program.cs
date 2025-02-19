using System;
/*
Console.WriteLine("Informe a nota 1:");
float nota1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Informe a nota 2:");
float nota2 = Convert.ToInt16(Console.ReadLine());

float notaf = (nota1 + nota2) / 2;

Console.WriteLine($"A sua media é de {notaf}"); 

if (notaf >= 6)
    { 
    Console.WriteLine("Aprovado");
}

else
{
    Console.WriteLine("Reprovado");
}

*/


Console.WriteLine("Difite a priemria nota:");
if(!float.TryParse(Console.ReadLine(), out float n1))
{
    Console.WriteLine("A nota não é valida");
    Environment.Exit(0);
}

Console.WriteLine("Difite a segunda nota:");
float n2 = 0;
if (!float.TryParse(Console.ReadLine(), out n2))
{
    Console.WriteLine("A nota não é valida");
}

if ((n1 + n2) / 2 >= 6)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

/*
Console.WriteLine("Informe a nota 1:");
float not1 = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a nota 2:");
float not2 = float.Parse(Console.ReadLine());
float notf = (nota1 + nota2) / 2;
Console.WriteLine($"A sua media é de {notf}");

if (notf >= 6)
{
    Console.WriteLine("Aprovado");
}

else
{
    Console.WriteLine("Reprovado");
}
*/