
var vvod = (Console.ReadLine());
int znachenie = int.Parse(vvod);
int[] massiv = {znachenie};

if (vvod != "q")
{
    for (int i = 0;; i++)
    {
        Console.WriteLine($"Значение массива i: {massiv[i]}");
        
        vvod = Console.ReadLine();
        znachenie = int.Parse(vvod);
        massiv[i] = znachenie;

        Console.WriteLine($"Длина массива:{massiv.Length}");
    }
}
else
{
    
}




/* Вводим значение в массив. Если значение Q заканчиваем программу
 * Если значение - число - увеличиваем массив и записываем туда значение
 * 
*/