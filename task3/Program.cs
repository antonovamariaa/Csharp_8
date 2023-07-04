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
        length =  matrix1.GetLength(1);
    }
    else
    {
        length = matrix1.GetLength(0);
    }

    int[,] result = new int [length, length];

    for (int m = 0; m < result.GetLength(0); m++)
    {
        for (int n = 0; n < result.GetLength(1); n++)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[m,n] = matrix1[i,j]*matrix2[j,i];
                }

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
int[,] matrix1 = Fillmatrix(rows, columns, minnum, maxnum);
Printmatrix(matrix1);
System.Console.WriteLine();
int[,] matrix2 = Fillmatrix(columns, rows, minnum, maxnum);
Printmatrix(matrix2);
System.Console.WriteLine();
Printmatrix(Multiply(matrix1, matrix2));
