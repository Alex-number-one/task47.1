Console.WriteLine("Write a number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write a number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write a position of the element");
int position1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the second position of the element");
int position2 = Convert.ToInt32(Console.ReadLine());
if (position1 < rows || position1 > rows)
{
    Console.WriteLine("This number is not exist");
    return;
}
else if (position2 < columns || position2 > columns)
{
    Console.WriteLine("This number is not exist");
    return;
}

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

    if (position1 == i)
    {
        position1 = i;
    }

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
        if (position2 == j)
        {
            position2 = j;

        }

    }

    Console.WriteLine();

}
Console.WriteLine("->  " + matrix[position1, position2]);