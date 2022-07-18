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

//Задача Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9, 9]. Найдите сумму 
//положительных элементов массива.

//метод генерируется автоматически:
int[] CreateRandomArray(int size, int minValue, int maxValue) // квадратные скобки [] нужны всегда при работе массива
{
    int[] newArray = new int[size]; // инициалиирует массив new Array

    for(int i = 0; i< size; i++)
        newArray[i] = new Random().Next(minValue, maxValue+1);// всегда ставится +1, т.к. в массиве сокращается количество на 1

    return newArray;
}

// метод, который подойдет для чисел, которые вводит пользователь
int[] CreateArray(int size)
{
    int[] newArray = new int [size];

    Console.WriteLine("Creating array here: ");
    for(int i = 0; i< size; i++)
    {
        Console.Write($"Input{i + 1} element: "); // i+1 - чтоб визуально для пользователя выглядело аккуратно. с т.з интерфейса
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

//массив который ничего не отображает
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) // array.Length - длина массива
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array [i];

    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumOfPositive = FindPositiveSum(array);
Console.WriteLine("Sum of positive elements in current array is " + sumOfPositive);


//Задача 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

int[] Otric(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    newArray[i] = newArray[i] * -1;

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int[] otric2 = Otric(array);
ShowArray(otric2);

*/

//Задача 2. Задайте одномерный массив из 20 случайных чисел. 
//Найдите количество элементов массива, значения которых 
//лежат в отрезке [10,99].

int FindTwoDigits(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] >= 10 && array[i] <= 99) count++;

    return count;
}

int size = 20;
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Count of two-digit elements is" + FindTwoDigits(array));
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

Семинар 4

//1. Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.

 /*int FindSum(int a)
{
    int sum = 0;

    for(int current = 1; current <=a; current++)
        sum += current; //sum = sum + current
        
        return sum; 

}

Console.Write("Input positive integer number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}"); //$ - форматирование, модернизировать формат. 
Берет все что в фигурных скобках и воспроизводит в качестве чисел*/




//2. Напишите программу, которая принимает на вход число и выдаёт 
//количество цифр в числе.
/*int Numbers(int a)
{
    int current = 0;
    if(current <= a)
    {
        while(a > 0)
        {
        a = a / 10;
        current++;
        }
    }
    return current;

}

Console.WriteLine("Введите число: ");
int numkol = Convert.ToInt32(Console.ReadLine());
int numb = Numbers(numkol);
Console.WriteLine(numb);*/

//3.Напишите программу, которая принимает на вход число N и выдаёт 
//произведение чисел от 1 до N.
/* void Factorial(int num) 
{

     int current = 1;
     int fact = 1;
     while (current <= num) 
     {
        int a = current; 
        fact = fact * a;
        current++;      
     }
     Console.WriteLine(fact);
} 

Console.WriteLine("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
Factorial(number);*/

//4. Напишите программу, которая принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int Step(int num1, int num2)
{ 
     int result = 1;
     for(int i = 1; i <= num2; i++)
        result = result * num1;
     return result;
} 

Console.Write("Введите первое число: "); 
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: "); 
int number2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(Step(number1, number2));


Семинар 5
    //Задача Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9, 9]. Найдите сумму 
//положительных элементов массива.

//метод генерируется автоматически:
/*int[] CreateRandomArray(int size, int minValue, int maxValue) // квадратные скобки [] нужны всегда при работе массива
{
    int[] newArray = new int[size]; // инициалиирует массив new Array

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue+1);// всегда ставится +1, т.к. в массиве сокращается количество на 1

    return newArray;
}

// метод, который подойдет для чисел, которые вводит пользователь
int[] CreateArray(int size)
{
    int[] newArray = new int [size];

    Console.WriteLine("Creating array here: ");
    for(int i = 0; i< size; i++)
    {
        Console.Write($"Input{i + 1} element: "); // i+1 - чтоб визуально для пользователя выглядело аккуратно. с т.з интерфейса
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

//массив который ничего не отображает
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) // array.Length - длина массива
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array [i];

    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumOfPositive = FindPositiveSum(array);
Console.WriteLine("Sum of positive elements in current array is " + sumOfPositive);
*/

//Задача 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие 
//отрицательные, и наоборот.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

int[] Otric(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    newArray[i] = newArray[i] * -1;

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int[] otric2 = Otric(array);
ShowArray(otric2);



//Задача 2. Задайте одномерный массив из 20 случайных чисел. 
//Найдите количество элементов массива, значения которых 
//лежат в отрезке [10,99].

/*int FindTwoDigits(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] >= 10 && array[i] <= 99) count++;

    return count;
}

int size = 20;
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Count of two-digit elements is" + FindTwoDigits(array));*/


СЕМИНАР 6
    //Напишите программу, которая перевернёт 
//одномерный массив (последний элемент 
//будет на первом месте, а первый - на последнем 
//и т.д.)

/*int[] ReverseArray(int[] array)

{   // с циклом for
    for(int i = 0, j = array.Length - 1;  i < array.Length / 2; i++, j--)
    {
      int temp = array[i]; 
      array[i] = array[j];
        array[j] = temp;
    }*/
    //c циклом while

    /*int i = 0, j = array.Length - 1;
    while(i < j)
    {
        int temp = array[i]; 
        array[i] = array[j];
        array[j] = temp;
        
        i++;
        j--;
    }*/
    /*return array;
}

int[] myArray = {3, 5, 1, 8, 2, 9, 4};
myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
    Console.Write(myArray[i] + " ");*/

//Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное. 
/*18/2=9 0
9/2=4 1
4/2=2 0
2/2=1 0
1/2=0 1   18 10010*/
/*
string ChangeDigitSystem(int num)
{
    string resultNumber = string.Empty;

    while(num > 0)
    {
        resultNumber = num % 2 + resultNumber;
        num /=2; // то же самое, что и  num = num/2;
    }
    return resultNumber;
}
Console.WriteLine(ChangeDigitSystem(18));*/

// 1 Напишите программу, которая принимает на вход 
//три числа и проверяет, может ли существовать треугольник 
//с сторонами такой длины. a < b + c
/*
void Triangle(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < b + a)
        Console.WriteLine("Треугольник существует! ");
    else
        Console.WriteLine("Это не треугольник");
}

int a = 1;
int b = 2;
int c = 3;

Triangle(a,b,c);*/

// тип bool
/*
bool Triangle(int a, int b, int c) // c 1.28
{
    return a < b + c && b < a + c && c < b + a;
}
bool isTriangle = false;
isTriangle = Triangle(1,2,2);

Console.WriteLine(isTriangle);*/



// 2 Не используя рекурсию, выведите первые N чисел 
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) // array.Length - длина массива
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] Fibonacci(int num)
{
    int[] newArray = new int[num];
    Console.WriteLine("Create array here: ");
    newArray[0] = 0;
    newArray[1] = 1;
    for(int i = 2; i < num; i++)
    {
        newArray[i] = (newArray[i - 1]) + (newArray[i -2]);
    }
    return newArray;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibonacci(num));


СЕМИНАР 7
    //Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) //строка и аргумент
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
    
    Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);*/


//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: 
//Aij = i+j. Выведите полученный массив на экран.

 int[,] CreateRandom2DArray1(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
            newArray[i,j] = i + j;

    return newArray;     
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
    
    Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray1(m,n);
Show2dArray(myArray);




//Задайте двумерный массив. Найдите элементы, у 
//которых оба индекса чётные, и замените эти элементы 
//на их квадраты.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

int[,] FindEvenChange(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
        for(int j=0; j < array.GetLength(1); j++)
            if(i % 2 == 0 && j % 2 == 0)
                array[i,j] = array[i,j] * array[i,j];

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
    
    Console.WriteLine();
    }
} 

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray123 = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray123);
Console.WriteLine();
myArray123 = FindEvenChange(myArray123);
Show2dArray(myArray123);*/

//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); 
//(1;1) и т.д.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) //строка и аргумент
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
    
    Console.WriteLine();
    }
}

int FindDiagSum(int[,] array)
{
    int sum = 0;
    if(array.GetLength(0) == array.GetLength(1))
        for(int i = 0; i < array.GetLength(0); i++)
        sum += array[i,i];
    
    return sum;
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine("Sum of main diagonal is " + FindDiagSum(myArray));*/


//1 Задайте двумерный массив. Напишите программу, которая поменяет 
//местами первую и последнюю строку массива.
/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 1; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

}
int[,] ChangeArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
    return array;
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxpossible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(m, n, min, max);

Show2dArray(myArray);
Show2dArray(ChangeArray(myArray));*/

//2 Задайте двумерный массив. Напишите программу, которая заменяет 
//строки на столбцы. В случае, если это невозможно, программа должна 
//вывести сообщение для пользователя.
//создать матрицу
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) //строка и аргумент
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

//  получить результат в виде матрицы
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

// метод, который будет переворачивать матрицу

int[,] Reverse2dArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Number of rows and columns is not the same");
        return array;
    }

    for (int i = 0; i < array.GetLength(0) - 1; i++)
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }

    return array;
}

//2 5 1
//3 7 4
//9 6 8

//2 3 9
//5 7 6
//1 4 8

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);

Show2dArray(myArray);
Show2dArray(Reverse2dArray(myArray));*/

//3 Из двумерного массива целых чисел удалить строку и 
//столбец, а пересечении которых расположен наименьший 
//элемент

//создать матрицу
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) //строка и аргумент
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

//  получить результат в виде матрицы
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}


int[,] Cut2dArray(int[,] array)
{
    int iMin = 0, jMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    for (int j = 0; j < array.GetLength(1); j++)
        array[iMin, j] = 0;

    for (int i = 0; iMin < array.GetLength(0); i++)
        array[iMin, jMin] = 0;

    return array;
}

//7 4 2 3
//5 3 6 2
//6 7 1 3
//3 2 5 4

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);

/*Show2dArray(myArray);*/
Show2dArray(Cut2dArray(myArray));

