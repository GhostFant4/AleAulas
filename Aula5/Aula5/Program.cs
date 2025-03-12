//int[,] n2 = new int[2, 2] { { 0, 1 }, { 1, 2 } };

int[,] matriz = new int[10, 10];
/*matriz[0, 0] = 1;
matriz[0, 9] = 1;
matriz[9, 0] = 1;
matriz[9, 9] = 1;
matriz[4, 4] = 1;
matriz[4, 5] = 1;
matriz[5, 4] = 1;
matriz[5, 5] = 1;
*/

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        if ((i == 0 || i == 9) && (j == 0 || j == 9))
        {
            matriz[i, j] = 1;
        }
        if ((i == 4 || i== 5) && (j== 4 || j==5))
            {
            matriz[i, j] = 1;
                }
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

/*
int[,] matriz = new int[2, 3] { { 25, 10, 26 }, { 34, 48, 52 } }; 
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write($"{matriz[i, j]} ({i}), ({j})    ");
    }
    Console.WriteLine();
}
*/