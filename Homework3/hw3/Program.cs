Console.Clear();
Console.WriteLine("Введите число, а я выдам таблицу кубов для данного количества");
double a = int.Parse(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    Console.Write(Math.Pow(i, 3));
    Console.Write("   ");
}