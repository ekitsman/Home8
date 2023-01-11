// К Д.з. 1,2,3.

// int[,] CreatRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int colums=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue=Convert.ToInt32(Console.ReadLine());

//     int[,] array=new int[rows, colums];

//     for(int i=0; i<rows; i++)
//         for(int j =0; j<colums; j++)
//             array [i,j] = new Random().Next(minValue, maxValue+1);

//     return array;
// }

// void Show2dArray (int[,] array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//             Console.Write(array [i,j] + " ");

//         Console.WriteLine( );
//     }
//     Console.WriteLine( );
// }

// int[,] myArray = CreatRandom2dArray();
// Show2dArray(myArray);

// ДЗ.1
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void Decreasing(int[,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Decreasing (myArray);
// Show2dArray(myArray);

// Д.з.2 Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка


// int SumRowsElements(int[,] array, int i)
// {
//   int sumRows = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumRows += array[i,j];
//   }
//   return sumRows;
// }

// int rowsMin = 0;
// int sumRows = SumRowsElements(myArray, 0);
// for (int i = 1; i < myArray.GetLength(0); i++)
// {
//   int temp = SumRowsElements(myArray, i);
//   if (temp<sumRows)
//   {
//     sumRows = temp;
//     rowsMin = i;
//   }
// }

// Console.WriteLine($"{rowsMin+1}-the row with the smallest sum of elements ");

// Д.з.3 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 1. Умножение матриц осуществляется путем умножения строки на столбец
// 2. если число столбцов первой матрицы совпадает с числом строк второй матрицы, то выполнять умножение
// int[,] CreatRandom2dArraySecond()
// {
//     Console.Write("Input a number of rows for the second matrix, the same as the number of columns of the first matrix: ");
//     int rows=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns the second matrix: ");
//     int colums=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue=Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue=Convert.ToInt32(Console.ReadLine());

//     int[,] array=new int[rows, colums];

//     for(int i=0; i<rows; i++)
//         for(int j =0; j<colums; j++)
//             array [i,j] = new Random().Next(minValue, maxValue+1);

//     return array;
// }


// int[,] myArraySecond = CreatRandom2dArraySecond();
// Show2dArray(myArraySecond);

// int[,] MultiArray(int[,] myArray, int[,] myArraySecond)
// { 
//     int [,]resultArray = new int[myArray.GetLength(0),myArraySecond.GetLength(1)];
//     if (myArray.GetLength(1) == myArraySecond.GetLength(0))

//     for (int i = 0; i < resultArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultArray.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < myArray.GetLength(1); k++)
//       {
//         sum += myArray[i,k] * myArraySecond[k,j];
//       }
//       resultArray[i,j] = sum;
//     }  
//   }
//   return resultArray;
// }

// int[,] multinewArray= MultiArray(myArray,myArraySecond);
// Console.WriteLine($"The product of the first and second matrices::");
// Show2dArray(multinewArray);

// Д.з.4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreatRandom3dArray()
{   Console.Write("Input coordinate x for a three-dimensional array: ");
    int x=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input coordinate y for a three-dimensional array: ");
    int y=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input coordinate z for a three-dimensional array: ");
    int z=Convert.ToInt32(Console.ReadLine());

    int[,,] array=new int[x,y,z];

    for(int i=0; i<x; i++)
        for(int j =0; j<y; j++)
            for(int k =0; k<z; k++)
            array [i,j,k] = new Random().Next(10, 99);


    return array;
}

void Show3dArray (int[,,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
  {
        for(int j=0; j<array.GetLength(1); j++)
           {
            
            for(int k =0; k<array.GetLength(2); k++)
            {
             Console.Write( $"X({i}) Y({j}) Z({k})={array[i,j,k]}; ");
             Console.WriteLine( );
            }
    }
  
    Console.WriteLine( );
  }
}

int[,,] myArray = CreatRandom3dArray();
Show3dArray(myArray);