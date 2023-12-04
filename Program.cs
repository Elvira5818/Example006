// Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double b1 = UserNumber("Введите число b1: ", "Ошибка ввода! ");
double k1 = UserNumber("Введите число k1: ", "Ошибка ввода! ");
double b2 = UserNumber("Введите число b2: ", "Ошибка ввода! ");
double k2 = UserNumber("Введите число k2: ", "Ошибка ввода! ");
int UserNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.Write(errormessage);
    }
}
   double x = (b2 - b1)/(k1-k2);
   double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения -> ({x};{y})");

// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int num = UserNumber("Введите количество чисел, которые хотите видеть в массиве: ", "Ошибка ввода! ");
int result = Itog(num);
Console.WriteLine($"Колличество ваших цифр, которые больше нуля составляют {result}");


int UserNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.Write(errormessage);
    }
}
int Itog(int count1)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        int result = GetUserNumber($"Введите {i + 1} число массива: ", "Ошибка ввода! ");
        if (result > 0) count++;

        int GetUserNumber(string message, string errormessage)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int num))
                    return num;
                Console.Write(errormessage);
            }

        }
    }
    return count;
}


