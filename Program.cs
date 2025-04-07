using System.Reflection;

string nomePrimeiroItem = "Controle Gamer";
double precoPrimeiroItem = 29.90;

string nomeSegundoItem = "Headset RGB";
double precoSegundoItem = 134.90;

string nomeTerceiroItem = "Gift Card";
double precoTerceiroItem = 189.00;

double percentualImpostoVenda = 0.088; //0,8%

Console.WriteLine("+=========================================================+");
Console.WriteLine("|                   Loja de Games Pixel                   |");
Console.WriteLine("+=========================================================+");
Console.WriteLine("|                         CATALOGO                        |");
Console.WriteLine("+=========================================================+");
Console.WriteLine("|   ITEM                                       VALOR      |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| 1. {nomePrimeiroItem.PadRight(40,' ')} R${precoPrimeiroItem.ToString().PadRight(10,' ')}|");
Console.WriteLine($"| 2. {nomeSegundoItem.PadRight(39,' ')}  R${precoSegundoItem.ToString().PadRight(10,' ')}|");
Console.WriteLine($"| 3. {nomeTerceiroItem.PadRight(39,' ')}  R${precoTerceiroItem.ToString().PadRight(10,' ')}|");
Console.WriteLine("+=========================================================+");
Console.WriteLine("| Imposto sobre a venda: 8,8%                             |");
Console.WriteLine("+=========================================================+");

Console.WriteLine("\nDigite a quantidade dos itens desejados: ");

Console.Write("Item 1: ");
int qtdItem1 = int.Parse(Convert.ToString(Console.ReadLine()!));

Console.Write("Item 2: ");
int qtdItem2 = int.Parse(Convert.ToString(Console.ReadLine()!));

Console.Write("Item 3: ");
int qtdItem3 = int.Parse(Convert.ToString(Console.ReadLine()!));


double subtotalItem1 = qtdItem1 * precoPrimeiroItem;
double subtotalItem2 = qtdItem2 * precoSegundoItem;
double subtotalItem3 = qtdItem3 * precoTerceiroItem;
double totalClienteUm = subtotalItem1 + subtotalItem2 + subtotalItem3;

double impostoClienteUm = totalClienteUm * percentualImpostoVenda;
double totalComImposto = totalClienteUm + impostoClienteUm;

Console.Clear();

Console.WriteLine("+=========================================================+");
Console.WriteLine("|                    RECIBO DA COMPRA                     |");
Console.WriteLine("+=========================================================+");
Console.WriteLine("|   ITEM                                       VALOR      |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| {qtdItem1} x {nomePrimeiroItem.PadRight(40,' ')} R${subtotalItem1.ToString().PadRight(9,' ')}|");
Console.WriteLine($"| {qtdItem2} x {nomeSegundoItem.PadRight(40,' ')} R${subtotalItem2.ToString().PadRight(9,' ')}|");
Console.WriteLine($"| {qtdItem3} x {nomeTerceiroItem.PadRight(40,' ')} R${subtotalItem3.ToString().PadRight(9,' ')}|");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"|                       IMPOSTO (8,8%): R${impostoClienteUm:f2}           |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"|                                  TOTAL: R${totalComImposto:f2}        |");
Console.WriteLine("+=========================================================+");


