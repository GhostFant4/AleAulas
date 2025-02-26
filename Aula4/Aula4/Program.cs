/*string nome = "Alex";

Console.WriteLine(nome[2]);
int teste = 7;
int[] numero = new int[5]; //Já coloca um tamanho pre estabelecido
int[] numero2;  //o sistema esolha um tamanho e se precisar ele vai copiar e criar uma nova array com o numero maior e apagar a essa. Isso para todas as array, nunca muda.

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("Digite a priemria nota:");
    numero[i] = 0;
    while (!int.TryParse(Console.ReadLine(), out numero[i]))
    {
        Console.WriteLine("A nota não é valida");

    }
}

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("numero da posiçã {0} teste test e=", numero[i] ); // imprimir um numero especifico no meio de um texto
    Console.WriteLine(numero[i]);
} */


// Soma 10 nume
/*
int[] numero = new int[10];
int numsoma = 0;
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("Digite um numero:" = (i+1));
    numero[i] = 0;
    while (!int.TryParse(Console.ReadLine(), out numero[i]))
    {
        Console.WriteLine("O numero não é valido");

    }
}

for (int i = 0; i < numero.Length; i++)
{
    numsoma += numero[i];
}

Console.WriteLine("O total de numeros é:"+ numsoma);
*/


//Numero tras pra frente
/*
int[] numero = new int[20];

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("Digite um numero:" + (i+1));
    numero[i] = 0;
    while (!int.TryParse(Console.ReadLine(), out numero[i]))
    {
        Console.WriteLine("O numero não é valido");

    }
}
for (int i = numero.Length -1; i >= 0; i--)
{
    Console.WriteLine(numero[i]);
}
*/

//numero par
int[] numero = new int[4];
int[] numero2= new int[4];
int numpares = 0;

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("Digite um numero:" + (i + 1));
    numero[i] = 0;
    while (!int.TryParse(Console.ReadLine(), out numero[i]))
    {
        Console.WriteLine("O numero não é valido");

    }
}
for (int i = 0; i < numero.Length; i++)
{
    if (numero[i] % 2 == 0)
    {
        numero2[i] = numero[i];
        numpares += 1;
    }
}
Console.WriteLine("Você possuie"+ numpares +"numeros pares, e eles são:");
for (int i = 0;i < numero2.Length; i++)
{
    if (numero2[i] % 2 == 0)
    {
        Console.WriteLine(numero2[i]);
    }
    else { }
}










