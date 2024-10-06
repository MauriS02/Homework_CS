string[] massiv = new string[10];
string[] insurance;
int y = 0;
try
{
    for (int i = 0; i <= massiv.Length; i++)
    {
        Console.WriteLine("Ожидание ввода...");

        var vvod = Console.ReadLine();
        var parse = int.TryParse(vvod, out int q);
        Console.WriteLine(massiv[i]);

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
            Console.WriteLine($"Список ошибок:{massiv[i]}");

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
            string vvod1 = Console.ReadLine();

            switch (vvod1)
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
                    Console.WriteLine($"Список ошибок:{massiv[i]}");
                    break;
            }
        }
    }
}
catch
    {
    Console.WriteLine("Ошибка ввода");
    }
