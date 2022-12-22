/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double [,] Create2DArray(int rows, int cols, int lim){
    double [,] array = new double [rows, cols];
    int signrnd = 0;
    for(int i=0; i<rows; i++){
        for(int j=0; j<cols; j++){                
l1:         signrnd = new Random().Next(-1,2);
            if (signrnd ==0) goto l1;
                array[i,j]=Math.Round(new Random().NextDouble()*lim*signrnd ,1);
            }
    }
    return array;
}

void ShowArray(double [,] array){
      for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j] + "    "); 
            }
Console.WriteLine();
      }
}
Console.Write("Введите число строк массива: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите предел рандомизации элементов: ");
int lim= Convert.ToInt32(Console.ReadLine());

double [,] array= Create2DArray(m,n,lim);
Console.WriteLine("Массив:"); ShowArray(array);

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в
двумерном массиве, и возвращает значение этого элемента или же указание, что такого
элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет
*/
int [,] Create2DArray(int rows, int cols, int min, int max){
    int [,] array = new int [rows, cols];
    for(int i=0; i<rows; i++){
        for(int j=0; j<cols; j++)
            array[i,j]=new Random().Next(min, max+1);          
    }
    return array;
}
void ShowArray(int [,] array){
      for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
      }
}
void FindElem(int [,] array, int selrow, int selcol){
        if (selrow<(array.GetLength(0))&&selcol<(array.GetLength(1)))
            Console.Write($"Элемент на позиции {selrow},{selcol}: {array[selrow,selcol]}");
            else 
            Console.Write($"Элемент на позиции {selrow},{selcol} отсутствует");
        Console.WriteLine();
}
Console.Write("Введите число строк массива: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элементов: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элементов: ");
int max= Convert.ToInt32(Console.ReadLine());
int [,] array= Create2DArray(m,n,min,max);
Console.WriteLine("Массив:"); ShowArray(array);
    
l1: Console.Write("Ищем элемент? (y/n): ");
    string f=Convert.ToString(Console.ReadLine());
    if (f=="y"){
        Console.Write("Введите строку искомого элемента: ");
        int k= Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите столбец искомого элемента: ");
        int l= Convert.ToInt32(Console.ReadLine());
        FindElem(array, k, l);
    goto l1;
}
    else return;

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/
int [,] Create2DArray(int rows, int cols, int min, int max){
    int [,] array = new int [rows, cols];
    for(int i=0; i<rows; i++){
        for(int j=0; j<cols; j++)
            array[i,j]=new Random().Next(min, max+1);          
    }
    return array;
}
void ShowArray(int [,] array){
      for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
      }
}
void AverageByColumns(int [,] array){
      double sumoffcol, averageoffcol;
      for(int i=0; i<array.GetLength(1); i++){
            sumoffcol=0; averageoffcol=0;
            for(int j=0; j<array.GetLength(0); j++){
                sumoffcol=sumoffcol+array[j,i];
                averageoffcol=Math.Round(sumoffcol/array.GetLength(0),2);
            }
            Console.Write($"{i+1}-го={averageoffcol}; ");
            }
        Console.WriteLine();
}
Console.Write("Введите число строк массива: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элементов: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элементов: ");
int max= Convert.ToInt32(Console.ReadLine());
int [,] array= Create2DArray(m,n,min,max);
Console.WriteLine("Массив:"); ShowArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
AverageByColumns(array);