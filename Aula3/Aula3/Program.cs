//Pedir notas dos alunos for
/*int alunos;
float n1, n2;
Console.WriteLine("Total de alunos:");
while (!int.TryParse(Console.ReadLine(), out alunos))
{
    Console.WriteLine("Quantidade invalida");
    Console.WriteLine("Total de alunos:");
}
float[] notf = new float[alunos];



for (int i = 0; i < notf.Length; i++)
{
    Console.WriteLine("Digite a priemria nota:");
    n1 = 0;
    while (!float.TryParse(Console.ReadLine(), out n1))
    {
        Console.WriteLine("A nota não é valida");

    }

    Console.WriteLine("Digite a segunda nota:");
    n2 = 0;
    while (!float.TryParse(Console.ReadLine(), out n2))
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
*/


//Pedir notas dos alunos while
/*
int alunos;
int i = 0;
float n1, n2;
Console.WriteLine("Total de alunos:");
while (!int.TryParse(Console.ReadLine(), out alunos))
{
    Console.WriteLine("Quantidade invalida");
    Console.WriteLine("Total de alunos:");
}
float[] notf = new float[alunos];



while (i < alunos)
{
    Console.WriteLine("Digite a priemria nota:");
    n1 = 0;
    while (!float.TryParse(Console.ReadLine(), out n1))
    {
        Console.WriteLine("A nota não é valida");

    }

    Console.WriteLine("Digite a segunda nota:");
    n2 = 0;
    while (!float.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("A nota não é valida");
    }

    notf[i] = (n1 + n2) / 2;

    i += 1;
}

for ( i = 0; i < notf.Length; i++)
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
*/

/*

// imprimir barrinhas
Console.WriteLine("Qual caracter você desja usar?");
Console.WriteLine("_ ou -?");
string opcao = Console.ReadLine();

{
    if (opcao == "-")
    {
        for (int i = 0; i < 100; i++)
        {
            Console.Write("-");
        }
    }
    else if (opcao == "_")
    {
        for (int i = 0; i < 100; i++)
        {
            Console.Write("_");
        }
    }

    else
    {
        Console.WriteLine("Opção invalida");
    }
}
*/

/*

//tabuada
for (int i = 2; i <=9; i++)
{
    Console.WriteLine("**************");
    Console.WriteLine($"Tabuada do {i}");
    Console.WriteLine("**************");
    
    for (int j = 1; j<= 10; j++)
    {
        Console.WriteLine($" {i} X {j} = {i * j}");
    }
}
*/


//calculadora