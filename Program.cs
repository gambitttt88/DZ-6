/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

// -------------Метод----------------------------
double[,] GetArray(int m, int n, int minValue, int maxValue){
    double[,] result = new double[m,n];
    Random rand = new Random();
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = rand.Next(minValue, maxValue - minValue) + rand.NextDouble();
            
        }
    }
    return result;
}

void PrintArray(Double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{Math.Round(array[i,j], 2)} ");
        }
        Console.WriteLine();
    }
}
*/
/*Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, 
что оно найдено или же указание, что такого элемента нет.
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите искомое число: ");
int a = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 5);
PrintArray(array);

if(findElement(array, a)){ 
    Console.WriteLine("Данный элемент в массиве есть"); 
} 
else{ 
    Console.WriteLine("Данный элемент в массиве не существует"); 
} 

// -------------Метод----------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

bool findElement(int[,] array, int a){ 
    foreach (int el in array){ 
    if(el == a){ 
        return true; 
    } 
} 
return false;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 5);
PrintArray1(array);
PrintArray(array);

// -------------Метод----------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ Math.Round(sum / array.GetLength(0), 2)} ");
}
Console.ReadLine();
}
void PrintArray1(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
