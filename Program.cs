Console.WriteLine("Write a number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write a number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
//double num1 = 0.1;
//double num2 = 10.1;
int random = new Random().Next(0, 10);
double [,] matrix = new double [rows, columns];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
matrix [i, j] = new Random().NextDouble(); 
matrix [i, j] *= random;
}
}
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
Console.Write(Math.Round((matrix[i, j]), 2) + "\t");
}
Console.WriteLine();
}