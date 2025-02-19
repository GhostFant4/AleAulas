Console.WriteLine("Total de alunos:");
if (!int.TryParse(Console.ReadLine(), out int alunos))
{
    Console.WriteLine("Quantidade invalida");
}
float[] notf = new float[alunos];



for (int i = 0; i < notf.Length; i++)
{
    Console.WriteLine("Difite a priemria nota:");
    if (!float.TryParse(Console.ReadLine(), out float n1))
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

    notf[i] = (n1+ n2) /2;
}

for (int i = 0;i < notf.Length;i++)
{
    if (notf[i] >= 6)
{
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}
