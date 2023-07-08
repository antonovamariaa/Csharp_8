int[,] Fillmatrix(int size)
{
    int[,] matrix = new int[size, size]; // массив пока квадратный  
    int wx = size; //размеры массива
    int wy = size;

    int x = 0; // текущие координаты
    int y = 0;

    int xstart = 0;     //левый отступ текущего прямоугольника от исходного
    int xend = 0;       //правый отступ
    int ystart = 0;     //верхний отступ
    int yend = 0;       //нижний отступ

    int num = 1;        //значение для заполнения (можно легко менять, поэтому отдельно)
    int counter = 1;    //счетчик заполненных ячеек(для выхода при достижении х*у)


    while (counter <= wx * wy)
    {
        matrix[x, y] = num;

        if (y == ystart && x < wx - xend - 1) { x++; }      // идем вправо
        else if (y == wy - yend - 1 && x > xstart) { x--; } //идем влево
        else if (x == xstart && y > ystart) { y--; }        //идем вверх
        else { y++; }                                       //идем вниз
        // else if (ix == wx - xend -1 && iy < wy - yend -1) //условие похода вниз - для понимания

        // условия перехода на внутренний круг: позиция [xstart, ystart + 1]
        // возможно для прямоугольника(не квадрата) сломается
        if (y == ystart + 1 && x == xstart)
        {
            xstart++;
            xend++;
            ystart++;
            yend++;
        }
        num++;
        counter++;
    }
    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for (int y = 0; y < matrix.GetLength(1); y++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            System.Console.Write(matrix[x, y] + "\t");
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

int size = Input("input size: ");
int[,] matrix = Fillmatrix(size);
Printmatrix(matrix);



