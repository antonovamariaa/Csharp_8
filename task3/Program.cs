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

int[,] Multiply(int[,] matrix1, int[,] matrix2)
{
    int length = 0;
    if (matrix1.GetLength(1) < matrix1.GetLength(0))
    {
        length = matrix1.GetLength(1);
    }
    else
    {
        length = matrix1.GetLength(0);
    }

    int[,] result = new int[length, length];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                if (length == matrix1.GetLength(1)) {result[i, j] = result[i, j] + (matrix1[i, k] * matrix2[k, j]);}
                else if (length == matrix1.GetLength(0)) {result[i, j] = result[i, j] + (matrix1[j, k] * matrix2[k, i]);}
            }
        }
    }

    return result;
}


//----------------------------------------------------------------------

int columns = Input("input columns: ");
int rows = Input("input rows: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
System.Console.WriteLine();
int[,] matrix1 = Fillmatrix(rows, columns, minnum, maxnum);
System.Console.WriteLine("matrix 1: ");
Printmatrix(matrix1);
System.Console.WriteLine();
int[,] matrix2 = Fillmatrix(columns, rows, minnum, maxnum);
System.Console.WriteLine("matrix 2: ");
Printmatrix(matrix2);
System.Console.WriteLine();
System.Console.WriteLine("result: ");
Printmatrix(Multiply(matrix1, matrix2));
