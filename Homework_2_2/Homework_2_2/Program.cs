using System.Net.Http.Headers;
try
{
    string[,] massiv = new string[3, 4];

       Console.WriteLine("Введите имя первого пользователя");
    string name0_0 = Console.ReadLine();

       Console.WriteLine("Введите фамилию первого пользователя");
    string secondname0_1 = Console.ReadLine();

       Console.WriteLine("Введите должность первого пользователя");
    string post0_2 = Console.ReadLine();

    massiv[0, 0] = name0_0;
    massiv[0, 1] = secondname0_1;
    massiv[0, 2] = post0_2;

       Console.WriteLine("Введите имя второго пользователя");
    string name1_0 = Console.ReadLine();

       Console.WriteLine("Введите фамилию второго пользователя");
    string secondname1_1 = Console.ReadLine();

       Console.WriteLine("Введите должность второго пользователя");
    string post1_2 = Console.ReadLine();

    massiv[1, 0] = name1_0;
    massiv[1, 1] = secondname1_1;
    massiv[1, 2] = post1_2;

       Console.WriteLine("Введите имя третьего пользователя");
    string name2_0 = Console.ReadLine();

       Console.WriteLine("Введите фамилию третьего пользователя");
    string secondname2_1 = Console.ReadLine();

       Console.WriteLine("Введите должность третьего пользователя");
    string post2_2 = Console.ReadLine();

    massiv[2, 0] = name2_0;
    massiv[2, 1] = secondname2_1;
    massiv[2, 2] = post2_2;

       //Console.WriteLine($"Количество пользователей:{massiv[0,0].Length}");

       Console.WriteLine($"Выберете имя пользователя, данные которого хотите вывести на экран: {name0_0}, {name1_0}, {name2_0}");
    string showinfo = Console.ReadLine();
       Console.WriteLine($"Данные выбранного пользователя:");

    if (showinfo == name0_0)
    {
       Console.WriteLine($"Имя:{name0_0}");
       Console.WriteLine($"Фамилия:{secondname0_1}");
       Console.WriteLine($"Должность:{post0_2}");
    }
    else if (showinfo == name1_0)
    {
       Console.WriteLine($"Имя:{name1_0}");
       Console.WriteLine($"Фамилия:{secondname1_1}");
       Console.WriteLine($"Должность:{post1_2}");
    }
    else if (showinfo == name2_0) 
    {
       Console.WriteLine($"Имя:{name2_0}");
       Console.WriteLine($"Фамилия:{secondname2_1}");
       Console.WriteLine($"Должность:{post2_2}");
    }
    else
    {
       Console.WriteLine("Некорректное имя пользователя");
    }

}
catch (Exception ex)
{
       Console.WriteLine($"Произошла ошибка: {ex.Message}");
    throw ex;
}
    