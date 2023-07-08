
int[] Fillarray(string message)
{
    int[] array = new int[90];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 10;
    }
    Random rand = new Random();
    for (int i = array.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(0, i + 1);
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }

    return array;
}

int[,,] Fillmatrix(int x, int y, int z, int[] numbers)
{
    int[,,] matrix = new int[x, y, z];
    Random rand = new Random();
    int counter = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int f = 0; f < matrix.GetLength(2); f++)
            {
                matrix[i, j, f] = numbers[counter];
                counter++;
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


int x = Input("input x: ");
int y = Input("input y: ");
int z = Input("input z: ");


if (x * y * z > 99)
{
    System.Console.WriteLine("error. more indexes than unrepetitive numbers. try again");
}
else
{
    int[] numList = Fillarray("generate random number");
    int[,,] matrix = Fillmatrix(x, y, z, numList);
    Printmatrix(matrix);
    System.Console.WriteLine();
}


