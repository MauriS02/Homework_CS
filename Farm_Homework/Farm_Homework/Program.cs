using System;

namespace FarmHomework;

class Farm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Добро пожалловать на ферму!");

        int DaysCount = 0;
        Cow cow = new Cow();
        Chicken chicken = new Chicken();
        Goat goat = new Goat();


        while (cow.starve >= 0 && chicken.starve >= 0 && goat.starve >= 0)
        {
            Console.WriteLine("Новый день! Выберите номер действия, которое хотите выполнить:");
            Console.WriteLine("1. Покормить животное");
            Console.WriteLine("2. Забрать продукцию");
            Console.WriteLine("3. Купить животное");
            Console.WriteLine("4. Продать продукцию");

            var vvod = Console.ReadLine();
            var parse = int.TryParse(vvod, out int q);

            switch (q)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("Выберите животное, которое хотите покормить:");
                    Console.WriteLine("1. Корова");
                    Console.WriteLine("2. Курица");
                    Console.WriteLine("3. Коза");

                    vvod = Console.ReadLine();
                    parse = int.TryParse(vvod, out q);

                    switch (q)
                    {
                        case 1:
                            Console.WriteLine("Кормим Коров...");
                            cow.Feeding();
                            break;

                        case 2:
                            Console.WriteLine("Кормим Куриц...");
                            chicken.Feeding();
                            break;

                        case 3:
                            Console.WriteLine("Кормим Коз...");
                            goat.Feeding();
                            break;
                    }
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("Выберите животное, у которого хотите забрать продукцию:");
                    Console.WriteLine("1. Корова");
                    Console.WriteLine("2. Курица");
                    Console.WriteLine("3. Коза");

                    vvod = Console.ReadLine();
                    parse = int.TryParse(vvod, out q);

                    switch (q)
                    {
                        case 1:
                            Console.WriteLine("Собираем молоко у коров");
                            cow.Collecting();
                            break;
                        case 2:
                            Console.WriteLine("Собираем яйца у куриц");
                            chicken.Collecting();
                            break;
                        case 3:
                            Console.WriteLine("Собираем молоко у коз");
                            cow.Collecting();
                            break;
                    }
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("Выберите животное, которое хотите купить:");
                    Console.WriteLine("1. Корова");
                    Console.WriteLine("2. Курица");
                    Console.WriteLine("3. Коза");

                    vvod = Console.ReadLine();
                    parse = int.TryParse(vvod, out q);

                    switch (q)
                    {
                        case 1:
                            Console.WriteLine("Покупаем Корову");
                            cow.Buying();
                            break;

                        case 2:
                            Console.WriteLine("Покупаем Курицу");
                            chicken.Buying();
                            break;

                        case 3:
                            Console.WriteLine("Покупаем Козу");
                            goat.Buying();
                            break;
                    }

                    break;

                case 4:

                    break;
            }

            DaysCount++;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("День закончился!");
            Console.WriteLine($"Вы держитесь уже {DaysCount} дней!");
            Console.ResetColor();

            cow.starve--; chicken.starve--; goat.starve--;
            
            for (int i = 0; i < cow.count_animal.Length; i++)
            {
                cow.resource++;
            }
            for (int i = 0; i < chicken.count_animal.Length; i++)
            {
                chicken.resource++;
            }
            for (int i = 0; i < goat.count_animal.Length; i++)
            {
                goat.resource++;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Показатели Вашей фермы:");
            Console.WriteLine($" Коровы:\n Кол-во коров - {cow.count_animal} \n Уровень голода - {cow.starve}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("..........");
            Console.ResetColor();
            Console.WriteLine($" Курицы:\n Кол-во куриц- {chicken.count_animal} \n Уровень голода - {chicken.starve}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("..........");
            Console.ResetColor();
            Console.WriteLine($" Козы:\n Кол-во коз- {goat.count_animal} \n Уровень голода - {goat.starve}");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Кол-во ресурсов у животных:");
            Console.WriteLine($" Коровье молоко {cow.resource} \n Куриные яйца {chicken.resource} \n Козье молоко {goat.resource}");

            Console.WriteLine("Кол-во ресурсов на складе:");
            Console.WriteLine($" Коровье молоко {cow.storage} \n Куриные яйца {chicken.storage} \n Козье молоко {goat.storage}");
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Одно из ваших животных умерло. \n GameOver");
        Console.ResetColor();
    }
}

class Cow
{
    public int starve = 3;
    public int[] count_animal = new int[2];
    public int resource = 0;
    public int storage = 0;

    public void Feeding()
    {
        starve = 10;
        Console.WriteLine("Коровы покормлены");
        Console.WriteLine($"Текущий уровень голода: {starve}");

    }
    public void Buying()
    {
        count_animal = new int[count_animal.Length + 1];
        Console.WriteLine("Корова куплена");
        Console.WriteLine($"Сейчас у вас {count_animal.Length}");
    }
    public void Collecting()
    {
        storage = storage + resource;
        resource = 0;
        Console.WriteLine("Молоко собрано");
        Console.WriteLine($"Сейчас у вас {resource} коровьего молока");
    }
    public void NextDay()
    {
        starve--;
        for (int i = 0; i < count_animal.Length; i++)
        {
            resource++;
        }
    }
}

class Chicken
{
    public int starve = 3;
    public int[] count_animal = new int[2];
    public int resource = 0;
    public int storage = 0;

    public void Feeding()
    {
        starve = 10;
        Console.WriteLine("Курицы покормлены");
        Console.WriteLine($"Текущий уровень голода: {starve}");

    }
    public void Buying()
    {
        count_animal = new int[count_animal.Length + 1];
        Console.WriteLine("Курица куплена");
        Console.WriteLine($"Сейчас у вас {count_animal.Length}");
    }
    public void Collecting()
    {
        storage = storage + resource;
        resource = 0;
        Console.WriteLine("Яйца собраны");
        Console.WriteLine($"Сейчас у вас {resource} яиц");
    }
    public void NextDay()
    {
        starve--;
        for (int i = 0; i < count_animal.Length; i++)
        {
            resource++;
        }
    }
}

class Goat
{
    public int starve = 3;
    public int[] count_animal = new int[2];
    public int resource = 0;
    public int storage = 0;

    public void Feeding()
    {
        starve = 10;
        Console.WriteLine("Козы покормлены");
        Console.WriteLine($"Текущий уровень голода: {starve}");

    }
    public void Buying()
    {
        count_animal = new int[count_animal.Length + 1];
        Console.WriteLine("Коза куплена");
        Console.WriteLine($"Сейчас у вас {count_animal.Length}");
    }
    public void Collecting()
    {
        storage = storage + resource;
        resource = 0;
        Console.WriteLine("Молоко собрано");
        Console.WriteLine($"Сейчас у вас {resource} козьего молока");
    }
    public void NextDay()
    {
        starve--;
        for (int i = 0; i < count_animal.Length; i++)
        {
            resource++;
        }
    }
}