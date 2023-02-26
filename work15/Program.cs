// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int day = 8;
int maxPos = 8;

if(maxPos > day){
    if(day >= 7){
        Console.WriteLine("Yes");
    }
    else{
        Console.WriteLine("No");
    }
}
else{
    Console.WriteLine("Error");
}