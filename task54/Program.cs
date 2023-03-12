// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
int ReadNumber(string messageToUser)     //метод считывания целых чисел
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int colums, int leftBorder = 0, int rightBorder = 10) // создает матрицу
{
 
    int[,] matrix = new int[rows, colums];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder +1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)  // выводит матрицу на консоль
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}

void SelectionSortminmax(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
          
            for ( int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i,k])
                {
                int tmp = matrix[i, j];
                matrix[i, j] = matrix[i,k];
                matrix[i, k] = tmp;
                }
            }
        }
    }
}


int m = ReadNumber("Введите кол-во строк");
int n = ReadNumber("Введите кол-во столбцов");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
SelectionSortminmax(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);