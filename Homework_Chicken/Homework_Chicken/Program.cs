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
        Console.WriteLine("У вас три голодные курицы.");
        Console.WriteLine("Выберите номер действия, которое хотите выполнить:");
        Console.WriteLine("1. Покормить курицу");
        Console.WriteLine("2. Забрать яйцо");
        Console.WriteLine("3. Ничего не делать");

        var vvod = Console.ReadLine();
        var parse = int.TryParse(vvod, out int q);

        switch (q)
        {
            case 1:
                Console.WriteLine("");
                Food(Chicken.WhiteChicken);
                break;
            case 2:
                Console.WriteLine("");
                Food(Chicken.BlackChicken);
                break;
            case 3:
                Console.WriteLine("");
                Food(Chicken.YellowChicken);
                break;

        }


        void Food(Chicken cipa)
        {
            Console.WriteLine("Выберите курицу которую хотите покормить:");
            Console.WriteLine($"1.{cipa}");
            Console.WriteLine("Кормим курицу");

        }
    }


    /* void CollectEgg()
     {

     }

     void DoNothing()
     {
     }*/

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

    int hungry = 0;
    int satiety = 0;
    int eggs = 0;

 
}

/*enum Chicken
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

int hungry = 0;
int satiety = 0;
int eggs = 0;

Console.WriteLine("У вас три голодные курицы.");
Console.WriteLine("Выберите номер действия, которое хотите выполнить:");
Console.WriteLine("1. Покормить курицу");
Console.WriteLine("2. Забрать яйцо");
Console.WriteLine("3. Ничего не делать");

var vvod = Console.ReadLine();
var parse = int.TryParse(vvod, out int q);

switch (q)
{
    case 1:
        Console.WriteLine("");
        break;
    case 2:
        Console.WriteLine("");
        break;
    case 3:
        Console.WriteLine("");
        break;

}


void Food()
{
    Console.WriteLine("Выберите курицу которую хотите покормить:");
    Console.WriteLine($"1.{Chicken}");
    Console.WriteLine("Кормим курицу");

}


void CollectEgg()
{

}

void DoNothing()
{

}*/

