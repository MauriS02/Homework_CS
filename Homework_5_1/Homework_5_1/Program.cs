using System.Threading.Tasks.Sources;

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
var parse = int.TryParse(vvod, out int q);
int number = 0;
int count = 1;
int score = 0;
int final = 0;
int j = 0;

if (parse == true)
{
    for (int i = 1; i <= q; i++)
    {
        for (j = 1; i <= j; j++)
        {
            if (i % j == 0)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        if (count == 2)
        {
            score++;
            if (score == q)
            {
                Console.WriteLine($"Ваше простое число: {41} ");
                break;
            }
        }
    }
}


