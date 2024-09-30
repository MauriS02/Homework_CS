string[] massiv = new string[10];
string[] insurance;
int y = 0;
try
{
    for (int i = 0; i <= massiv.Length; i++)
    {
        Console.WriteLine(massiv[i]);
        var vvod = Console.ReadLine();
        var parse = int.TryParse(vvod, out int q);

        if (i == massiv.Length)
        {
            insurance = massiv;
            massiv = new string[massiv.Length + 1];

            for (int x = 0; x < massiv.Length; x++)
            {
                massiv[x] = insurance[x];
            }

        }
        if (vvod == "q")
        {
            Console.WriteLine($"Список ошибок:{massiv[0]}");

            for (y = 1; y == massiv.Length; y++)
            {
                Console.WriteLine(massiv[y]);
            }
            break;
        }
        else
        {
            Console.WriteLine("Выберете действие:");
            Console.WriteLine("1.Продолжить");
            Console.WriteLine("2.Очистить");
            Console.WriteLine("3.Выйти");

            switch (vvod)
            {
                case ("1"):
                    Console.WriteLine("Продолжаем");
                    break;

                case ("2"):
                    y = 0;
                    massiv[y] = massiv[y];
                    Console.WriteLine("Очищаем");
                    break;

                case ("3"):
                    Console.WriteLine("Выходим");
                    Console.WriteLine($"Список ошибок:{massiv[0]}");
                    break;
            }
        }
    }
}
catch
    {
    Console.WriteLine("Ошибка ввода");
    }
