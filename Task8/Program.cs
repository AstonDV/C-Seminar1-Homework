Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 2;
Console.Clear();
while(count <= number)
{
    Console.Write($"{count} ");
    count = count + 2;
}