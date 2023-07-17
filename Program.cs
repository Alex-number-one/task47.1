Console.WriteLine("Write a number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write a number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
int k = 0;
int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + "\t");
    }
     Console.WriteLine(); 
}


for (int i = 0; i < matrix.GetLength(1); i++)
{
    double columnsum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
    columnsum += matrix[j, i];
    }
Console.WriteLine($"summ of the elements {i} = {Math.Round(columnsum / matrix.GetLength(0), 2)}");
}