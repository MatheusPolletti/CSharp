/*
// Mudar o título
Console.Title = "Console Polletti";
// Mudar a cor da letra
Console.ForegroundColor = ConsoleColor.DarkRed;
// x linhas de altura
Console.WindowHeight = 40;

// Console.WriteLine("");
// Console.ReadLine();

Console.WriteLine("Um dia um viajante chamado");
Console.ReadLine();
Console.WriteLine("Entrou em uma tenda chamada perpetua e se encontrou com um ");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Mas Infelizmente antes que eles pudessem conversar um urso comeu eles dois");

// Como ler algo do promp
Console.ReadKey();
*/

// Int, float, double, string e bool
// Use var se não souber o tipo

/*
Console.WriteLine("Digite seus números: ");

double num1;
double num2;
double num3;

Console.Write("Digite seu primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite seu segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
num3 = Convert.ToInt32(Console.ReadLine());

double operacao = (num1 + num2 + num3) / 3;

Console.Write("Operação = " + operacao);

Console.ReadKey();
*/

/*
Console.WriteLine("Bem vindo ao cinema Polletti. Os valores dos ingressos são R$5,00. Por favor, insira seu dinheiro: ");
int dinheiro = Convert.ToInt32(Console.ReadLine());

if (dinheiro < 5)
{
    Console.WriteLine("Os ingressos custam R$5,00 e você inseriou R$" + dinheiro + ".\nEssa quantia não é suficiente para comprar um ingresso.");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("A sua compra foi cancelada.");
}
else if (dinheiro > 300)
{
    Console.WriteLine("Lamentamos, mas nosso sistema não aceita uma quantia tão alta de dinheiro.");
}
else
{
    Console.WriteLine("Quantos ingressos você gostaria de comprar?");
    int quantiaTickets = Convert.ToInt32(Console.ReadLine());

    int valorTickets = quantiaTickets * 5;

    if (dinheiro - valorTickets < 0)
    {
        Console.WriteLine("Você quer comprar " + quantiaTickets + " tickets, mas precisa de R$" + valorTickets + " e só tem R$" + dinheiro);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("A sua compra não foi realizada.");
    }
    else
    {
        int troco = Convert.ToInt32(dinheiro - valorTickets);

        Console.WriteLine("Você comprou " + quantiaTickets + " tickets\nO seu troco é de R$" + troco);
    }

}

Console.ReadKey();

int idade;
int altura;

Console.WriteLine("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite sua altura em cm: ");
altura = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade < 60 || altura > 160)
{
    Console.WriteLine("Você pode entrar.");
}
else
{
    Console.WriteLine("Você não pode entrar.");
}

Console.ReadKey();
*/

/*
string operacao01 = "2 * 2 + 2";
string operacao02 = "3 * 4 + 4";


Console.WriteLine("Digite o resultado da operação: " + operacao01);
int resultado01 = Convert.ToInt32(Console.ReadLine());

switch (resultado01)
{
    case 6:
        Console.WriteLine("Parabéns! Você acertou!");
        break;
    default:
        Console.WriteLine("Você errou! Tente novamente.");
        break;
}

Console.WriteLine("Digite o resultado da operação: " + operacao02);
int resultado02 = Convert.ToInt32(Console.ReadLine());

switch (resultado02)
{
    case 16:
        Console.WriteLine("Parabéns! Você acertou!");
        break;
    default:
        Console.WriteLine("Você errou! Tente novamente.");
        break;
}

Console.ReadKey();
*/

/*
Console.WriteLine("Digite quantos números você deseja escrever: ");
int contador = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= contador; i++)
{
    int resultado = Convert.ToInt32(Math.Pow(2, i));
    double resultadoDiferente = Math.Pow(2, i);
    Console.WriteLine(resultado);
}

Console.ReadKey();
*/

/*
int roll = 0;
int tentativas = 0;

Random geradorNumero = new Random();

Console.WriteLine("Aperte um botão para o dado rodar.");

while (roll != 6)
{
    Console.ReadLine();
    roll = geradorNumero.Next(1, 7);
    Console.WriteLine(roll);
    tentativas++;
}

Console.WriteLine("Tentivas: " + tentativas);

Console.ReadKey();
*/

/*
int dado01 = -2;
int dado02 = -1;
int tentativas = 0;

Random geradorDeNumero = new Random();

Console.WriteLine("Aperte no enter para rodar os dados.");

while (dado01 != dado02)
{
    Console.ReadLine();
    dado01 = geradorDeNumero.Next(1, 9);
    dado02 = geradorDeNumero.Next(1, 9);
    Console.WriteLine("Você rodou os dados: " + dado01 + " e " + dado02);
    tentativas++;
}

Console.WriteLine("Você precisou de " + tentativas + " tentativas.");

Console.ReadKey();
*/

/*
string[] filmes = { "Show de Truman", "Scarface", "Viagem ao Centro da Terra", "Viagem no Tempo", "Alive"};

for (int i = 0; i < filmes.Length; i++)
{
    int rank = i + 1;
    Console.WriteLine(rank + " - " + filmes[i]);
}

Console.ReadKey();
*/

/*
string[] filmes = new string[4];

Console.WriteLine("Digite o nome de 4 filmes");

for (int i = 0; i < filmes.Length; i++)
{
    filmes[i] = Console.ReadLine();
}

Array.Sort(filmes);

Console.WriteLine("Esses são seus filmes em ordem alfabética: ");

for (int i = 0; i < filmes.Length; i++)
{
    Console.WriteLine(filmes[i]);
}

Console.ReadKey();
*/

/*
// Usar listas
using System.Collections.Generic;

List<string> listaCompras = new List<string>();
int verdadeiro = 0;
int tamanho = 0;

Console.WriteLine("Digite quantos itens você quer adicionar na sua lista de compras: ");

while (verdadeiro == 0)
{
    tamanho = Convert.ToInt32(Console.ReadLine());
    if (tamanho > 0)
    {
        verdadeiro = 1;
    }
    else
    {
        Console.WriteLine("Digite uma quantia válida!");
    }
}

for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine("Digite o item que você deseja comprar: ");
    string itemCompra = Convert.ToString(Console.ReadLine());
    if (itemCompra == "")
    {
        itemCompra = "Esse valor está nulo";
    }
    listaCompras.Add(itemCompra);
}

for (int i = 0; i < listaCompras.Count; i++)
{
    Console.WriteLine(listaCompras[i]);
}

listaCompras.Remove("Alface");
listaCompras.RemoveAt(2);

Console.ReadKey();
*/

/*
Console.WriteLine("Digite a quantia de alunos que tem na sua sala: ");
int quantiaAlunos = Convert.ToInt32(Console.ReadLine());

string[] alunos = new string[quantiaAlunos];

for (int i = 0; i < alunos.Length; i++)
{
    Console.WriteLine("Digite o nome do aluno: ");
    alunos[i] = Console.ReadLine();
}

Array.Sort(alunos);

for (int i = 0; i < alunos.Length; i++)
{
    Console.WriteLine(alunos[i]);
}

Console.ReadKey();
*/

/*
static void ConhecerAlien()
{
    Random numeroAleatorio = new Random();

    string nome = "X-" + numeroAleatorio.Next(0, 1000);
    int idade = numeroAleatorio.Next(0, 2000);

    Console.WriteLine("Olá, eu sou o " + nome);
    Console.WriteLine("Eu tenho " + idade + " anos.\nE eu sou um alien.");
}

ConhecerAlien();
Console.WriteLine("------------------");
ConhecerAlien();

Console.ReadKey();
*/

/*
static string Multiplicar(int x, int y)
{
    int operacao = x * y;
    if (operacao % 2 == 0)
    {
        return "O valor de " + x + " * " + y + " é um número par.";
    }
    else
    {
        return "O valor de " + x + " * " + y + " é um número ímpar.";
    }
}

Console.WriteLine("Digite o primeiro número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
int num2 = Convert.ToInt32(Console.ReadLine());

string resultado = Convert.ToString(Multiplicar(num1, num2));

Console.WriteLine(resultado);

Console.ReadKey();
*/

/*
static int PalavrasFrase(string palavra)
{
    int tamanho = palavra.Split(' ').Length;
    return tamanho;
}

int verificador = 0;
string palavraExemplo = "";

Console.WriteLine("Digite a frase para saber quantas palavras ela tem: ");

while (verificador == 0)
{
    palavraExemplo = Convert.ToString(Console.ReadLine());
    if (palavraExemplo != "")
    {
        verificador = 1;
    }
    else
    {
        Console.WriteLine("Digite uma frase válida.");
    }
}

int resultado = PalavrasFrase(palavraExemplo);

Console.WriteLine("A frase possui " + resultado + " palavras.");

Console.ReadKey();
*/
