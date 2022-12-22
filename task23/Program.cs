Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= num)
{
    Console.Write($"{Math.Pow(i, 3)} ");
    // Ну, или не используя библиотеку Math
    // Console.Write($"{i*i*i} ");
    i++;
}

Console.WriteLine();