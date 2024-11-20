char[,] matrix = new char[5, 5];
Random rand = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matrix[i, j] = (char)(rand.Next('A', 'Z' + 1));
    }
}
Console.WriteLine("Исходная матрица");
for (int i = 0;i < 5; i++)
{
   
}
Console.WriteLine("Упорядоченная матрица");
char[] rowArray = new char[matrix.GetLength(1)];
for (int j = 0;j < matrix.GetLength(1);j++)
{
    rowArray[j] = matrix[5,j];

}
Array.Sort(rowArray);
for (int j = 0; j < matrix.GetLength(1); j++)
{
    matrix[5, j] = rowArray[j];
} 
{ 

}
for (int i = 0;i<matrix.GetLength(0);i++)
{
    for(int j = 0; j< matrix.GetLength(1); i++)
    {
        Console.WriteLine(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}