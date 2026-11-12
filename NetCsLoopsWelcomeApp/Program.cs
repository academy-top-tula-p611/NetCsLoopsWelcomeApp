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

//int left, right, result = 0;
//string menu;
//do
//{
//    //Console.Clear();

//    Console.Write("Введите первое число: ");
//    left = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Введите второе число: ");
//    right = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("1. Сложить");
//    Console.WriteLine("2. Вычисть");
//    Console.WriteLine("3. Перемножить");
//    Console.WriteLine("4. Поделить");
//    Console.WriteLine("0. Завершить");

//    Console.Write("Ваш выбор: ");
//    menu = Console.ReadLine();

//    switch (menu)
//    {
//        case "1": result = left + right; break;
//        case "2": result = left - right; break;
//        case "3": result = left * right; break;
//        case "4": result = left / right; break;
//    }

//    Console.WriteLine($"Результат: {result}");
//} while (menu != "0");

//int result = 0;
//int n = 1000;
//for(int i = 1; i <= n; i++)
//{
//    if (i % 2 == 0)
//        result += i;
//}
//for(int i = 2; i <= n; i += 2)
//    result += i;
//Console.WriteLine($"Сумма четных чисел = {result}");

//Random random = new Random();
//int randomNumber = random.Next(1, 101);

//Console.WriteLine("Я загадал число от 1 до 100.");
//Console.WriteLine("Попытайся угадать");

//int playerNumber;
//int steps = 0;
//do
//{
//    Console.Write("Введите ваше число: ");
//    playerNumber = Convert.ToInt32(Console.ReadLine());
//    steps++;

//    if (playerNumber < randomNumber)
//        Console.WriteLine($"Ваше число {playerNumber} меньше");
//    else if (playerNumber > randomNumber)
//        Console.WriteLine($"Ваше число {playerNumber} больше");

//} while (randomNumber != playerNumber);

//Console.WriteLine($"Поздравляем вы угадали число за {steps} попыток");

//int summa = 0;
//int number;

//do
//{
//    Console.Write("Введите число (0 - завершить)");
//    number = Convert.ToInt32(Console.ReadLine());

//    summa += number;

//} while(number != 0);

//Console.WriteLine($"Сумма введеных чисел = {summa}");


for(int i = 0; i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"i = {i}, j = {j}");
    }
}

