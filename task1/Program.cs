
int[,] Fillmatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max + 1); ;
        }
    }
    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int Input(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int[,] Sorted(int[,] matrix)
{
    int temp = 0;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[m, i] < matrix[m, j])
                {
                    temp = matrix[m, i];
                    matrix[m, i] = matrix[m, j];
                    matrix[m, j] = temp;
                }
            }
        }
    }
    return matrix;
}

//----------------------------------------------------------------------

int columns = Input("input columns: ");
int rows = Input("input rows: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
int[,] matrix = Fillmatrix(rows, columns, minnum, maxnum);
Printmatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine("sorted matrix: ");
System.Console.WriteLine();
Printmatrix(Sorted(matrix));


