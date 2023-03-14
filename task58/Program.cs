// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
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

int m = ReadNumber("Введите кол-во строк и столбцов");
int n = m;
int[,] myMatrix = GetRandomMatrix(m, n);
int[,] myMatrix2 = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix2);
Console.WriteLine();
int[,] resultMatrix = new int[m,n];

MultiplyMatrix(myMatrix, myMatrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);

void MultiplyMatrix(int[,] myMartrix, int[,] myMatrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
  
        sum += myMatrix[i,j] * myMatrix2[i,j];
  
      resultMatrix[i,j] = sum;
    }
  }
}

