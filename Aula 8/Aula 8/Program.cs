int[] lista = { 3, 5, 13, 7, 1899, 37, 1995, -7, 27 };
int salva = 0;


 for (int i = 0; lista.Length > i; i++)
{
    for (int j = 0; j < lista.Length; j++)
    {
        if (lista[j] > lista[i])
        {
            salva = lista[j];
            lista[j] = lista[i];
            lista[i] = salva;

        }
    }
} 

for (int i = 0; i < lista.Length; i++)
{
    Console.WriteLine(lista[i]);
}