// 21. Программа проверяет пятизначное число на палиндромом.


int x = 12821;

int oneone = 0, onetwo = 0, twoone = 0, twotwo = 0;

oneone = x % 100000 / 10000;
onetwo = x % 10000 / 1000;

twoone = x % 100 / 10;
twotwo = x % 10;

Console.WriteLine(oneone);
Console.WriteLine(twotwo);
Console.WriteLine(twoone);
Console.WriteLine(onetwo);

int a, b;

a = oneone + ;
b = onetwo + ;

if(a == b){
    Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}