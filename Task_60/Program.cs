// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int [,,] GetCube(int x, int y, int z, int min, int max)
{
    int[,,] cube = new int[x, y, z];
    int[] numArray = new int[x*y*z];
    int numIndex = 0;

    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j< cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                  cube[i, j, k] = GetUniqNum(numArray, numIndex, min, max);
                  numArray[numIndex++] = cube[i, j, k];
            }
        }
    }
    return cube;
}

int GetUniqNum(int[] numArray, int numIndex, int min, int max)
{
    Random rnd = new Random();
    Boolean find = true;
    int num = 0;

    while (find)
    {
        num = rnd.Next(min, max);
        find = false;

        for (int i = 0; i <= numIndex; i++)
        {
            if (num == numArray[i])
            {
                find = true;
                break;
            }
        }
    }
    return num;
}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(1); k++)
            {
                Console.Write($"{cube[i, j, k], 5} ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
int[,,] cube = GetCube(3, 3, 3, 10, 100);
PrintCube(cube);