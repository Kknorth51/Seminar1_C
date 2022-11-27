Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num*num;
//Console.WriteLine("Квадрат введённого числа равен "+ square);
Console.WriteLine($"Квадрат введённого числа равен {square}");

if (num > 9)
{
    Console.WriteLine("Вы ввели число больше девяти");
}
else
{
    Console.WriteLine("Вы ввели число меньше десяти"); 
}

while (num<=25) // Цикл выводит все числа от введенные до 25
{
    Console.WriteLine($" {num} ");
    num++;
}