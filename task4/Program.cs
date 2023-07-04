int[,,] Fillmatrix(int x, int y, int z, int min, int max)
{
    int[,,] matrix = new int[x, y, z];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int f = 0; f < matrix.GetLength(2); f++)
            {
                matrix[i, j, f] = rand.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void Printmatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int f = 0; f < matrix.GetLength(2); f++)
            {
                System.Console.Write(matrix[i, j, f] + "[ " + i + " " + j + " " + f + " ]" + "\t");
            }
            
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

int x = Input("input x: "); // columns
int y = Input("input y: "); // rows
int z = Input("input z: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
int[,,] matrix = Fillmatrix(x, y, z, minnum, maxnum);
Printmatrix(matrix);
System.Console.WriteLine();
