/* int[] lista = {10, 20, 30, 40, 50, 60 };
int numero, posição = 0;

Console.WriteLine("Escreva o numero que procure");
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("valor invalido");
}


for (int i = 0; i < lista.Length; i++) 
{
    if (lista[i] == numero) 
    { 
        posição = i;
        break;
    }

    posição = -1;
}

if (posição  < 0)
{
    Console.WriteLine("Esse numero não existe na lista");
    Environment.Exit(-1);
}

Console.WriteLine($"Esse numero está na lista e está na posição {posição}");

*/

int[] lista = { 15,86,22,38,93,23,64,95,25,69,45,16 };
int numero, conti, meio;
int[] lista2 = (int[])lista.Clone();
int posição = -1;
int inicio = 0;
int fim = lista.Length - 1;
bool ini = true;
while (ini == true)
{


    
    Console.WriteLine("Escreva o numero que procure");
    while (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("valor invalido");
    }

    



      for (int i = 0; i < lista.Length; i++)
      {
          if (lista[i] == numero)
          {
              posição = i;
              break;
          }

          posição = -1;
      }

      if (posição < 0)
      {
          Console.WriteLine("Esse numero não existe na lista");

      }
      else
      {
          Console.WriteLine($"Esse numero está na lista e está na posição {posição}");
      }

    do
    {

        Array.Sort(lista2);
        meio = (inicio + fim) / 2;
        if (lista2[meio] == numero)
        {
            posição = meio;
            Console.WriteLine($"Esse numero está na lista e está na posição {posição}");
            break;
        }
        if (lista2[meio] > numero)
        {
            fim = meio - 1;
        }
        else
        {
            inicio = meio + 1;
        }

    } while (inicio <= fim);

    if (posição < 0)
    {
        Console.WriteLine("O numero n existe na lista");
    }

    Console.WriteLine("Deseja procurar mais um numero? \n 1)sim \n 2)Não");
    while (!int.TryParse(Console.ReadLine(), out conti))
    {
        Console.WriteLine("valor invalido");
    }
    if (conti == 2)
    {
        Console.WriteLine("Fechando programa");
        Environment.Exit(-1);
    }


    posição = -1;
    inicio = 0;
    fim = lista.Length - 1;

}
