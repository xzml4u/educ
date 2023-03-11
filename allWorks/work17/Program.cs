// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X / Y == Y) {
    Console.WriteLine("Yes");
}

else {
    Console.WriteLine("No");
}