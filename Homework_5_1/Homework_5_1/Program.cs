﻿using System.Threading.Tasks.Sources;

/*Console.WriteLine("Введите номер простого числа");

var vvod = Console.ReadLine();
var parse = int.TryParse(vvod, out int q);
int count = 1;
int score = 0;
int final = 1;

if (parse == true)
{
    for (int i = 1; i <= q; i++)
    {
        if (score == 2)
        {
            final++;
        }
        count = 1;

        for (int y = 1; y <= i; y++)
        {
            if (i % y == 0)
            {
                count++;
                score = count - 1;
                continue;
            }

        }

    }
    Console.WriteLine($"Порядковый номер вашего простого числа: {final}");
}

else
{
    Console.WriteLine("Введено не число");
}*/

Console.WriteLine("Введите номер простого числа");

var vvod = Console.ReadLine();
var parse = int.TryParse(vvod, out int n);
bool flag = false;
int count = 0;

while (count < n)
{
    for (int i = 2; i <= n; i++)
    {
        if (n % i == 0)
        {
            count++;
        }
        else
        {
            flag = false;
        }
    }
}