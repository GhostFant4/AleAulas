
Random numeroR = new Random();

int numer = numeroR.Next(100);

Console.WriteLine(numer);

bool te = true;

static void Jogo(int num)
{
    int tentaN = num;
    Console.WriteLine("Essa é a sua dificuldade:");
    Console.WriteLine(tentaN);


}

Console.WriteLine("Menu 1: seleciona a dificuldade");
 Menu Mu = Console.ReadLine();


switch (Mu)
{
    case Menu.facil;
        Console.WriteLine("teste");

/*while (te)   
{
    Console.WriteLine("Digite o seu chute");
    int chute = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine(chute);

    if (chute != numer)
    {
        Console.WriteLine("Errou!");


    }

    else
    {
        Console.WriteLine("Acertou!");
         te = false;
    }

} */
enum Menu {facil= 1, medio= 2, dificil=3, sair=0}