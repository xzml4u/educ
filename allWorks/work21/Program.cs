// 21. Программа проверяет пятизначное число на палиндромом.


int x=22222, y=x, r=0;
while(y>10)
{
r+=y%10;
y/=10;
}
r+=y;
if(x==r) {Console.WriteLine("Yes");}
else  {Console.WriteLine("No");}