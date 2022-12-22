// int min = 10000;
// int max = 99999;
// int num = new Random().Next(min, max + 1);

Console.WriteLine("Введите число");
string s_num = Console.ReadLine() ?? "";
if (s_num.Length != 5)
{
    Console.WriteLine("нет(Incorrect input)");
}
else
{
    // Вариант с числами
    int num = Convert.ToInt32(s_num);

    int first_number = num / 10000;
    int second_number = num / 1000 % 10;
    int fourth_number = num / 10 % 10;
    int fifth_number = num % 10;

    if (first_number == fifth_number && second_number == fourth_number)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }

    // Варинт со строкой. Но проверка на введена ли строка не выполнена т.к. мне по задаче на вход всегда получаем число
    // if (s_num[0] == s_num[4] && s_num[1] == s_num[3])
    // {
    //     Console.WriteLine("да");
    // }
    // else
    // {
    //     Console.WriteLine("нет");
    // }
}