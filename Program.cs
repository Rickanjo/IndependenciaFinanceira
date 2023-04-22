//Faça um programa que calcule quanto dinheiro é necessário possuir em um investimento para conseguir sua independência financeira.

Console.WriteLine("Programa de investimeto financeira\n");

Console.Write("informe seus gastos mensais: R$");
double gastosMensais = double.Parse(Console.ReadLine()!);

Console.Write("Informe os Rendimentos mensais (%): ");
double dividendYield = double.Parse(Console.ReadLine()!);

double valorNecessario = gastosMensais / dividendYield / 100;

Console.WriteLine($"Para receber R$ {gastosMensais} todo mês com {dividendYield}% de dividend yield, é necessário investir R$ {valorNecessario.ToString("N2")}");

