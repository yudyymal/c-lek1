Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
string numberReverse = String.Empty;

for (int i = number.Length - 1; i >= 0; i--)
{
    numberReverse = numberReverse + number[i];
}
if (number == numberReverse)
{
    Console.WriteLine("Число - палиндром");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}