Console.WriteLine("Введите номер простого числа");



var vvod = Console.ReadLine();
var parse = int.TryParse(vvod, out int q);
int count = 1;
var number = 0;

if (parse == true)
{
    for (int i = 1; i <= q; i++)
    {
        number = count / 1;

        if (number == count)
        {
            number = count / count;
            if (number == 1)
            {
                for (int y = 1; y == i; y++)
                {
                    number = count % y;
                    if (number == 0)
                    {
                        count++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Введено не простое число");
                        break;
                    }
                    count++;
                }
            }
        }
        
    }
    Console.WriteLine($"Порядковый номер вашего простого числа: {count - 1}");
}
else 
{
    Console.WriteLine("Введено не число");
}






