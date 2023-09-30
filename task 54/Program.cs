





// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] matrix = GetArray(3, 4, 1, 10);
PrintArray(matrix);
int[] minElement = MinArray(matrix);
Console.WriteLine();
int[,] newMatrix = DeleteRowColumn(matrix, minElement);
PrintArray(newMatrix);




int[,] GetArray(int row, int column, int minValue, int maxValue)
{
int[,] res = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < row; i++)
{
for (int j = 0; j < column; j++)
{
res[i, j] = rnd.Next(minValue, maxValue + 1);
}
}
return res;
}
void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + "\t");
}
Console.WriteLine();
}
}

int[] MinArray(int[,] matrix)
{
int min = matrix[0, 0];
int[] result = new int[2];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (matrix[i, j] < min)
{
min = matrix[i, j];
result[0] = i;
result[1] = j;
}
}
}
return result;
}

int[,] DeleteRowColumn(int[,] matrix, int[] coord)
{
int[,] newMatrix = new int[matrix.GetLength(0) -1, matrix.GetLength(1) - 1];
int rowIndex = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
if (i == coord[0]) continue;

int columnIndex = 0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j == coord[1]) continue;

newMatrix[rowIndex, columnIndex] = matrix[i, j];
columnIndex++;

}

rowIndex++;
}
return newMatrix;
}