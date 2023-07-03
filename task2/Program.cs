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

int MinRowNumber(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    int counter = 0;
    int num = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[counter] = sum[counter] + matrix[i, j];
        }
        counter++;
    }

    System.Console.WriteLine(string.Join(" ", sum));

    int min = sum[0];
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            num = i + 1;
        }

    }


    return num;
}

//----------------------------------------------------------------------

int columns = Input("input columns: ");
int rows = Input("input rows: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
int[,] matrix = Fillmatrix(rows, columns, minnum, maxnum);
Printmatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine(MinRowNumber(matrix));