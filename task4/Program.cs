int[,,] Fillmatrix(int x, int y, int z, int min, int max)
{
    int[] array = new int [90];
    for (int i = 0; i<array.Length; i++){
        array[i] = i+10;
    }

    int[,,] matrix = new int[x, y, z];
    int temp = 0;
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int f = 0; f < matrix.GetLength(2); f++)
            {
                temp = rand.Next(0, array.Length);
                matrix[i, j, f] = array[temp];
                array = array.Except(new int[] { temp }).ToArray();

                //matrix[i, j, f] = rand.Next(min, max + 1);//не придумала, как поменять генерацию на неповторяющуюся
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



if (x * y * z > 99)
{
    System.Console.WriteLine("error. more indexes than unrepetitive numbers. try again");
}
else
{
    int minnum = Input("input minimal number: ");
    int maxnum = Input("input maximum number: ");
    int[,,] matrix = Fillmatrix(x, y, z, minnum, maxnum);
    Printmatrix(matrix);
    System.Console.WriteLine();
}



