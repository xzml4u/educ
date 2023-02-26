// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int number = 64;
int result;

if(number > 100){
    int a = number % 100;
    result = a % 10;

    Console.WriteLine(result);
}
else{
    Console.WriteLine("третьей цифры нет");
}