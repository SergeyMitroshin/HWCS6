/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetValue (string message)
{
    Console.WriteLine (message);
    return int.Parse(Console.ReadLine());
}

void PrintCrossPoint()
{
    double x=0.01;
    double y=0.01;
    double b1 = GetValue ("Введите b1");
    double k1 = GetValue ("Введите k1");
    double b2 = GetValue ("Введите b2");
    double k2 = GetValue ("Введите k2");
    if (k1==k2) Console.WriteLine("Прямые параллельны и не пересекаются");
    else
    {
        x = (b2-b1) / (k1-k2);
        y = k1 * x + b1;
        Console.WriteLine ("(" + x +"; "+ y +")");
    }

}

PrintCrossPoint();