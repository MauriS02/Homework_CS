/*немного развлекательное, но на кодирование:
Имеется 1 курица в клетке. Курицу необходимо кормить зерном и после она высиживает яйцо.
Возможные действия за один ход: 
-покормить курицу
- забрать яйцо
- ничего не делать
Если курица не накормлена, то она умирает. За раз положить допускает 3-5 зерен(на вашу фантазию.
При условии если курица накормлена, то яйцо высиживается в этот ход и только одно*/

using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int FoodW = 3;
        int FoodB = 3;
        int FoodY = 3;
        int EggW = 0;
        int EggB = 0;
        int EggY = 0;
        int EggCount = 0;
        int DaysCount = 0;

        Console.WriteLine("У вас три курицы. Необходимо кормить их и собирать яйца");
        try
        {
            while (FoodW >= 0 && FoodB >= 0 && FoodY >= 0)
            {
                Console.WriteLine("Новый день! Выберите номер действия, которое хотите выполнить:");
                Console.WriteLine("1. Покормить курицу");
                Console.WriteLine("2. Забрать яйцо");
                Console.WriteLine("3. Ничего не делать");

                var vvod = Console.ReadLine();
                var parse = int.TryParse(vvod, out int q);

                switch (q)
                {
                    case 1:
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Выберите курицу которую хотите покормить:");
                        Console.WriteLine($"1. Белая курица \n2. Черная курица \n3. Желтая курица");

                        var ChooseChicken = Console.ReadLine();
                        var ChooseChickenParse = int.TryParse(ChooseChicken, out int x);

                        var CipaX = (Chicken)x;

                        switch (CipaX)
                        {
                            case Chicken.WhiteChicken:
                                Food(Chicken.WhiteChicken);
                                break;

                            case Chicken.BlackChicken:
                                Food(Chicken.BlackChicken);

                                break;

                            case Chicken.YellowChicken:
                                Food(Chicken.YellowChicken);

                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Выберите курицу у которой мы собираем яйца");
                        Console.WriteLine($"1. Белая курица \n 2. Черная курица \n 3. Желтая курица");

                        ChooseChicken = Console.ReadLine();
                        ChooseChickenParse = int.TryParse(ChooseChicken, out int y);

                        var CipaY = (Chicken)y;

                        switch (CipaY)
                        {
                            case Chicken.WhiteChicken:
                                Egg(Chicken.WhiteChicken);

                                break;
                            case Chicken.BlackChicken:
                                Egg(Chicken.BlackChicken);

                                break;
                            case Chicken.YellowChicken:
                                Egg(Chicken.YellowChicken);

                                break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Пропуск хода");
                        break;
                }
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("День закончился!");
                FoodW--;
                FoodB--;
                FoodY--;
                EggW++;
                EggB++;
                EggY++;
                DaysCount++;
                Console.WriteLine($"Вы держитесь уже {DaysCount} дней!");
                Console.WriteLine($"Показатели:\n WhiteChicken: {FoodW} - зерен. {EggW} - яиц \n BlackChicken: {FoodB} - зерен. {EggB} - яиц \n YellowChicken: {FoodY} - зерен. {EggY} - яиц");
                Console.WriteLine($"Всего вы собрали: {EggCount} яиц");
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Одна из ваших куриц умерла. \n GameOver");
            Console.ResetColor();


            void Food(Chicken cipa)
            {
                Console.WriteLine($"Вы выбрали {cipa}.");
                Console.WriteLine("Сколько зерен давать курице? \n (Введите значение от 1 до 5)");
                int Food = int.Parse(Console.ReadLine());

                switch (cipa)
                {
                    case Chicken.WhiteChicken:
                        FoodW = FoodW + Food;
                        Console.WriteLine($"Теперь у курицы {cipa}, {FoodW} зерен");
                        break;

                    case Chicken.BlackChicken:
                        FoodB = FoodB + Food;
                        Console.WriteLine($"Теперь у курицы {cipa}, {FoodB} зерен");
                        break;
                    case Chicken.YellowChicken:
                        FoodY = FoodY + Food;
                        Console.WriteLine($"Теперь у курицы {cipa}, {FoodY} зерен");
                        break;
                }
                Console.WriteLine("Кормим курицу");
            }

            void Egg(Chicken cipa)
            {
                Console.WriteLine($"Вы выбрали {cipa}.");


                switch (cipa)
                {
                    case Chicken.WhiteChicken:
                        Console.WriteLine($"Сейчас у {cipa}, {EggW} яиц");
                        EggCount += EggW;
                        EggW = 0;
                        break;
                    case Chicken.BlackChicken:
                        Console.WriteLine($"Сейчас у {cipa}, {EggB} яиц");
                        EggCount += EggB;
                        EggB = 0;

                        break;
                    case Chicken.YellowChicken:
                        Console.WriteLine($"Сейчас у {cipa}, {EggY} яиц");

                        EggCount += EggY;
                        EggY = 0;

                        break;
                }
                Console.WriteLine("Собираем яйца...");
            }
        }
        catch
        {
            Console.WriteLine("Непредвиденная ошибка");
        }
    }


    enum Chicken
    {
        WhiteChicken = 1,
        BlackChicken = 2,
        YellowChicken = 3
    }
}