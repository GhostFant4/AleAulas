/*
int A = 10;
int B = 15;
int C = A;
Console.WriteLine($"O valor de A é {A}");
Console.WriteLine($"E o valor de B é {B}");
Console.WriteLine("Aperte Enter para converter");
Console.ReadLine();
A = B;
B = C;

Console.WriteLine($"Agora o valor de A é {A}");
Console.WriteLine($"E o valor de B é {B}");
*/
/*
double Saudo;
double Saque = 20;

Console.WriteLine("Digite a quantia do seu saudo, para informar os centavos use a virgula \n\rExemplo: 20,50");
while (!double.TryParse(Console.ReadLine(), out Saudo))
{
    Console.WriteLine("valor invalido, tente um valor valido");
}
if (Saudo < Saque)
{
    Console.Write("Infelizmente o seu saldo não é suficiente para essa saque");
}
else
{
    Saudo -= Saque;
    Console.WriteLine($"Você sacou R${Saque} \n\rAgora Você Possuie R${Saudo}");
} */
/*
double Produto, Dinheiro, Troco;

Console.WriteLine("Informe o valor do produto, usando a virgula para definir os centavos");
while (!double.TryParse(Console.ReadLine(), out Produto))
{
    Console.WriteLine("VAlor invalido, tente novamente");
}
Console.WriteLine("Informe a quantia entregue de dinehiro, usando a virgula para definir os centavos");
while (!double.TryParse(Console.ReadLine(), out Dinheiro))
{
    Console.WriteLine("Valor invalido, tente novamente");
}

if (Dinheiro > Produto)
{
    Troco = Dinheiro - Produto;
    Console.WriteLine($"Seu troco é R${Troco} Obrigado pela preferencia, volte sempre!");
}
else if (Dinheiro == Produto)
{
    Console.WriteLine("Obrigado pela preferencia, volte sempre!");
}
else
{
    Console.WriteLine("Valor insuficiente para continuar a compra");
}
*/

/*
double Saldo, porcentagem;

Console.WriteLine("Digite um valor do saldo");
while (!double.TryParse(Console.ReadLine(), out Saldo))
{
    Console.WriteLine("Esse valor, não é valido, tente novamente");
}
porcentagem = Saldo + Saldo *0.05;

Console.WriteLine($"O valor da sua conta depois do reajusto é de: R${porcentagem:F2}");
*/

/*
int esco;
bool val = false;
double entrada,parcelas, total;
double[] carro = new double[3];
carro[1] = 100000.00;
carro[2] = 150000.00;

Console.WriteLine($"Escolha a opção do seu melhor agrado:\n\rCarro 1: R${carro[1]:F2} \n\rCarro 2: R${carro[2]:F2}");

while (val == false)
{
    while (!int.TryParse(Console.ReadLine(), out esco))
    {
        Console.WriteLine("Digite um valor valido");
    }

    if (esco > 2 || esco <= 0) 
    {
        Console.WriteLine($"Essa, não é uma opção valida. As opcões validas são: \n\rCarro 1: R${carro[1]:F2} \n\rCarro 2: R${carro[2]:F2}");
    }
    else
    {
        entrada = carro[esco] * 0.4;
        total = carro[esco] - entrada;
        parcelas = total / 12;
        Console.WriteLine(entrada);
        Console.WriteLine(parcelas);
        Console.WriteLine(total);

        val = true;
    }
}
*/

/*
int Numero;
Console.WriteLine("Escreva um numero");
while (!int.TryParse(Console.ReadLine(), out Numero))
{
    Console.WriteLine("Isso não é um numero, por favor digite um numero valido");
}
Console.WriteLine($"{Numero - 1},{Numero},{Numero + 1} ");
*/

/*
int numero;
Console.WriteLine("Fala um numero para saber a tabuada dele");
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Esse valor é invalido, tente novamente");
}
Console.WriteLine("TABUADA:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}
*/

string nome;
double salario, vendas, pagamento;

Console.WriteLine("Informe o nome do vendedor");
nome = Console.ReadLine();
while (string.IsNullOrEmpty(nome))
{
    Console.WriteLine("Por favor, prencha com algum nome");
    nome = Console.ReadLine();
}

Console.WriteLine("Escreva o salario do funcionario, use a , para escrever os centavos");
while (!double.TryParse(Console.ReadLine(), out salario))
{
    Console.WriteLine("Salario invalido. Digite um valor valido");
}
Console.WriteLine("Escreva o total de vendas de vendas, usas a , para representar os centavos");
while (!double.TryParse(Console.ReadLine(), out vendas))
{
    Console.WriteLine("Salario invalido. Digite um valor valido");
}

pagamento = salario + (vendas * 0.05);


Console.WriteLine($"O funcionario:{nome} \n\rSalario Final:{pagamento:F2}");