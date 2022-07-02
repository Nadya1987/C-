/* Task1
int num1, num2, quad;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32 (Console.ReadLine ());

quad = num2 * num2;

if (quad == num1)
{
    Console.WriteLine ("First number is a quad of second number");
}
else
{
    Console.WriteLine ("First number is not a quad of second number");
}
*/





/* Task 2
int day;

Console.Write("Добрый день! Введите номер дня недели: ");
day = Convert.ToInt32 (Console.ReadLine ());

if (day == 1)
{
    Console.WriteLine ("Понедельник");
}

if (day == 2)
{
    Console.WriteLine ("Вторник");
}

if (day == 3)
{
    Console.WriteLine ("Среда");
}

if (day == 4)
{
    Console.WriteLine ("Четверг");
}

if (day == 5)
{
    Console.WriteLine ("Пятница");
}

if (day == 6)
{
    Console.WriteLine ("Суббота");
}

if (day == 7)
{
    Console.WriteLine ("Воскресенье");
}

if (day >7 || day < 1)
{
    Console.WriteLine ("Некорректно введен номер");
}
*/

/* Task3
int number, quad;

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine ());

quad = number * number;

Console.Write("Квадрат числа равен " + quad);
*/

Семинар2

/*int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni * 10 + ed;
    return result;
}


int number = CutNumber();
Console.WriteLine ("Result number is " + number);


void CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni * 10 + ed;
    Console.WriteLine ("Result number is " + result);
    }

CutNumberVoid (num) */

//2
/*int MaxNumber()
{
    int num = new Random().Next(10,100);
    Console.WriteLine("Current random number is: " + num);

    int dec = num % 10;
    int ed = num / 10;

    if (dec > ed)
        return dec;
    else
        return ed;
}

int res = MaxNumber();
Console.Write(res);
*/

//3
/*void Crat()
{
    int num = new Random().Next();
    Console.WriteLine("Current random number is: " + num);

    if(num % 7 == 0)
    {
        if(num % 23 == 0)
        {
            Console.WriteLine("Число является кратным 7 и 23");
        }
    }
    else
    {
        Console.WriteLine("Число не является кратным 7 и 23");
    }
}
Crat();*/

//4
/*void IsQuad(int num1, num2)
{
   int quad2 = num2 * num2;
   int quad1 = num1 * num1;

    if (num1 == quad2)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}*/


    
    


Семинар 3
    
    Task 1 
    void ShowArea(int quart)

{
    if(quart >= 1 && quart <= 4)
    {
        if(quart == 1) Console.WriteLine("In this quart x > 0 and y > 0");
        if(quart == 2) Console.WriteLine("In this quart x < 0 and y > 0");
        if(quart == 3) Console.WriteLine("In this quart x < 0 and y < 0");
        if(quart == 4) Console.WriteLine("In this quart x > 0 and y < 0");
    }
    else
        Console.WriteLine("This number is uncorrect");
}

Console.Write("Input number of quart: ");
int numQuart = Convert.ToInt32(Console.ReadLine());

ShowArea(numQuart);
    
    Task2
    /* int ShowQuart (int x, int y) 
{ 
        int result = -1; 

        if (x > 0 && y > 0) result = 1; 
        if (x < 0 && y > 0) result = 2; 
        if (x < 0 && y < 0) result = 3; 
        if (x > 0 && y < 0) result = 4; 
        return result; 
}   

Console.WriteLine("Введите координату x: "); 
int x0 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату y: "); 
int y0 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(ShowQuart(x0, y0));  

*/  Task 3

void Quad(int x) 
{ 
     int current = 1; 
     while (current <= x) 
     { 
        int quad = current * current; 
        Console.Write(quad + " "); 
        current++; 
     } 
} 

Console.WriteLine("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Quad(n); 
