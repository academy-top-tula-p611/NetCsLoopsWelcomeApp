//int i = 0;
//int result = 0;
//int n;

//Console.Write("Введите натуральное число: ");
//n = Convert.ToInt32(Console.ReadLine());

//while (i < n)
//{
//    //result = result + (i + 1);
//    result += i + 1;
//    i++;
//}

//for (int i = 0; i < n; i++)
//    result += i + 1;

//Console.WriteLine(result);

int left, right, result = 0;

string menu;

do
{
    //Console.Clear();

    Console.Write("Введите первое число: ");
    left = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    right = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("1. Сложить");
    Console.WriteLine("2. Вычисть");
    Console.WriteLine("3. Перемножить");
    Console.WriteLine("4. Поделить");
    Console.WriteLine("0. Завершить");

    Console.Write("Ваш выбор: ");
    menu = Console.ReadLine();

    switch (menu)
    {
        case "1": result = left + right; break;
        case "2": result = left - right; break;
        case "3": result = left * right; break;
        case "4": result = left / right; break;
    }

    Console.WriteLine($"Результат: {result}");
} while (menu != "0");
