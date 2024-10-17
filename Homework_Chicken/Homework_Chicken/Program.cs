/*немного развлекательное, но на кодирование:
Имеется 1 курица в клетке. Курицу необходимо кормить зерном и после она высиживает яйцо.
Возможные действия за один ход: 
-покормить курицу
- забрать яйцо
- ничего не делать
Если курица не накормлена, то она умирает. За раз положить допускает 3-5 зерен(на вашу фантазию.
При условии если курица накормлена, то яйцо высиживается в этот ход и только одно*/

using System.Security.Cryptography;
using System;

class Program
{
    static void Main(string[] args)
    {
        int cipa = 0;
        int FoodW = 0;
        int FoodB = 0;
        int FoodY = 0;

        Console.WriteLine("У вас три голодные курицы.");

        while (FoodW <= 0 || FoodB <=0 || FoodY <= 0)
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

                    Console.WriteLine("Выберите курицу которую хотите покормить:");
                    Console.WriteLine($"1. Белая курица \n 2. Черная курица \n 3. Желтая курица");

                    var ChooseChicken = Console.ReadLine();
                    var ChooseChickenParse = int.TryParse(vvod, out int y);

                    var CipaY = (Chicken)y;

                    switch (CipaY)
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

                    break;
                case 3:

                    break;

            }
        }


        void Food(Chicken cipa)
        {
            Console.WriteLine($"Вы выбрали {cipa}.");
            Console.WriteLine("Сколько зерен давать курице? \n (Введите значение от 1 до 5)");
            int Food = int.Parse(Console.ReadLine());
            
            switch (cipa)
            {
                case Chicken.WhiteChicken:
                    FoodW = FoodW + Food;
                    Console.WriteLine($"У курицы {cipa}, {Food} зерен");
                    break;

                case Chicken.BlackChicken:
                    FoodB = FoodB + Food;
                    Console.WriteLine($"У курицы {cipa}, {Food} зерен");
                    break;

                case Chicken.YellowChicken:
                    Food = FoodY + Food;
                    Console.WriteLine($"У курицы {cipa}, {Food} зерен");
                    break;
            }
            Console.WriteLine("Кормим курицу");

        }
    }
    enum Chicken
    {
        WhiteChicken = 0,
        BlackChicken = 1,
        YellowChicken = 2
    }

    enum Action
    {
    Feed = 1,
    TakeEgg = 2,
    Nothing = 3
    }
}