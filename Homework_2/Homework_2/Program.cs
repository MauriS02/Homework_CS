using System.Diagnostics;
using System.Numerics;

int[] massiv = new int[5];
int error = 0;

try
{
    Console.WriteLine("Введите первое значение в массив");
    massiv[0] = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе значение в массив");
    massiv[1] = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите третье значение в массив");
    massiv[2] = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите четвертое значение в массив");
    massiv[3] = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите пятое значение в массив");
    massiv[4] = int.Parse(Console.ReadLine());

    if (massiv[0] < 0 || massiv[1] < 0 || massiv[2] < 0 || massiv[3] < 0 || massiv[4] < 0)
    {
        throw new Exception("Значение не может быть отрицательным");
        error = 1;
    }
}
catch
{
    Console.WriteLine("Ошибка ввода");
    error = 1;
}

if (error == 0)
{
    Console.WriteLine($"Значения вашего массива по порядку:{massiv[0]}, {massiv[1]}, {massiv[2]}, {massiv[3]}, {massiv[4]}");

    int count = 5;
    double arif = (massiv[0] + massiv[1] + massiv[2] + massiv[3] + massiv[4]) / count;
    Console.WriteLine($"Среднее арифметическое вашего массива: {arif}");
}
else
{
    Console.WriteLine("Программа приостановлена");
}