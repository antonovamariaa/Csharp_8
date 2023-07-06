
int[,] Fillmatrix(int row, int col, int startNum)
{
    int[,] matrix = new int[row, col];
    int x = 1;
    int y = 1;
    int m = matrix.GetLength(1);
    int n = matrix.GetLength(0);
    int dx = 1;
    int dy = 1;
    int counter = 0;
    int num = startNum;

    while (m + n > 2)
    {
        for (int i = 1; i < m + n - 1; i++)
        {
            System.Console.Write("m=" + m + " n=" + n + "   dx=" + dx + " dy=" + dy + "   x=" + x + " y=" + y + " num=" + num + " i=" + i + "c=" + counter);
            matrix[x - 1, y - 1] = num;
            num++;

        
                if (i < n) { x = x + dx; }
                else { y = y + dy; }
            

            System.Console.WriteLine("   x=" + x + " y=" + y + " num=" + num );

        }
        if (m > 1) { m--; }
        if (n > 1) { n--; }
        dx = -dx;
        dy = -dy;
        if (dx == 1) { counter++; }
        //System.Console.WriteLine(" ");
    }

    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[j, i] + "\t");
        }
        System.Console.WriteLine();
    }
}

int Input(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}



//----------------------------------------------------------------------

int columns = Input("input columns: ");
int rows = Input("input rows: ");
int startNum = Input("input start number: ");
int[,] matrix = Fillmatrix(rows, columns, startNum);
Printmatrix(matrix);



