//Сгенерируйте массив из n чисел. Число n вводит пользователь

// void InputArray(double[] array){
//     for (int i = 0; i < array.Length; i++){
//         array[i] = Math.Round(20 * new Random().NextDouble() - 10, 2); //(-10; 10)
//         // NextDouble() - генерирует число в диапвзоне (0; 1)
//         // Math.Round (число, кол-во знаков после запятой)
//         // x (0; 10)
//         // 20 * x (0; 20)
//         // 20 * x - 10 (-10; 10)
//     }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double [] array = new double [n]; // [0.0, 0.0, ..., 0.0]
// InputArray (array);
// System.Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// Задача 1
//Задайте двумерный массив. Найдите элементы, у которых оба
//индекса чётные, и замените эти элементы на их квадраты

using System.Globalization;
using System.Runtime.Serialization.Json;

// void inputMatrix(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             matrix [i, j] = new Random().Next(1, 11); // [50, 150]
//         }
//     }
// }

// void printMatrix(int[,] matrix){
//     // matrix.GetLength(0) - кол-во строк
//     // matrix.GetLength(1) - кол-во столбцов
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i, j]} \t");
//             // \n - переход на новую строку
//             // \t - табуляция
//         }
//         Console.WriteLine();
//     }
// }

// void replaceElements(int [,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i += 2){ // i = i +2
//         for (int j = 0; j < matrix.GetLength(1); j += 2){
//         matrix [i, j] *= matrix[i, j]; // matrix [i, j] = matrix [i, j] * matrix [i, j]
//         } 
//     }
// }

// Console.Clear();
// Console.Write("Введите размер 2D массива: ");
// int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix =new int[size[0], size[1]];
// inputMatrix(matrix);
// Console.WriteLine("Начальный массива: ");
// printMatrix(matrix);
// replaceElements(matrix);
// Console.WriteLine("\nКонечный массива: ");
// printMatrix(matrix);

// Задание 2:
//

void inputMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix [i, j] = new Random().Next(1, 11);
        }
    }
}
void printMatrix(int[,] matrix){
        for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} \t");
                }
        Console.WriteLine();
    }
}
int sumElements(int [,] matrix){
    int x = matrix.GetLength(0), y = matrix.GetLength(1);
    int result = 0;
    if (x < y){
        for (int i = 0; i < x; i++)
            result += matrix[i, i];
    }
    else{
        for (int i = 0; i < y; i++)
            result += matrix[i, i];
    }
    return result;
}
Console.Clear();
Console.Write("Введите размер 2D массива: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix =new int[size[0], size[1]];
inputMatrix(matrix);
Console.WriteLine("Начальный массива: ");
printMatrix(matrix);
Console.WriteLine($"Сумма элементов главной диагонали равно: {sumElements(matrix)}");