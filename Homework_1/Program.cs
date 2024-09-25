//Задание #1

Console.WriteLine("Введите имя");
string name = Console.ReadLine();

Console.WriteLine("Введите фамилию");
string secondname = Console.ReadLine();

Console.WriteLine("Введите отчество");
string patronymic = Console.ReadLine();

Console.WriteLine($"{name} {secondname} {patronymic}");

//Задание #2

Console.WriteLine("Калькулятор:");

Console.WriteLine("Введите первое значение");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе значение");
int second = int.Parse(Console.ReadLine());

Console.WriteLine("Выберете оператор");
string operation = Console.ReadLine();

if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
{
    switch (operation)
    {
        case "+":
            int equal = first + second;
            Console.WriteLine($"{first} {operation} {second} = {equal}");
            break;
        case "-":
            int equal1 = first - second;
            Console.WriteLine($"{first} {operation} {second} = {equal1}");
            break;
        case "*":
            int equal2 = first * second;
            Console.WriteLine($"{first} {operation} {second} = {equal2}");
            break;
        case "/":
            int equal3 = first / second;
            Console.WriteLine($"{first} {operation} {second} = {equal3}");
            break;
    }
}
else if (operation == null)
{
    Console.WriteLine("Оператор не введен");
}
else
{
    Console.WriteLine("Введен неверный оператор");
}

