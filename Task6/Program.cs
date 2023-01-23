Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    Console.Clear();
    Console.WriteLine("Да! Ваше число четное!!!");
}
else
{
    Console.Clear();
    Console.WriteLine("Нет, Ваше число нечетное");
}