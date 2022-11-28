/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int GetValue (string message)
{
    Console.WriteLine (message);
    return int.Parse(Console.ReadLine());
}

int GetPositiveCount()
{
    int result = 0;
    int amount = GetValue("Введите количество чисел");
    for (int i = 1; i <= amount; i++)
        if (GetValue("Введите число "+i) > 0) result++;
    return result;
}

Console.WriteLine("Результат: " + GetPositiveCount());
