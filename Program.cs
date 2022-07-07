// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
double [,] GenerateArray(int row, int column, int min, int max)
{
    var array = new double [row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next (min, max + 1);
        }
    }
    return array;
}
void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
double [] FindArithmeticmeanOfColumn (double [,] array)
{
    double [] AvarageArray = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
        {
            double temp = 0;
            for (int i = 0; i < array.GetLength(0); i++) 
            {
            temp = temp + array[i,j];
            AvarageArray[j] = temp / array.GetLength(0);
            }
            
        }
        return AvarageArray;
}
void PrintArray1(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

int row = Prompt("Введите количество строк: ");
int column = Prompt("Введите количество столбцов: ");
int min = 1;
int max = 10;
double [,] myarray = GenerateArray(row, column, min, max);
PrintArray(myarray);
double[] AvarageArray = FindArithmeticmeanOfColumn(myarray);
System.Console.WriteLine($"Среднее арифмитическое каждого столбца:");
PrintArray1(AvarageArray);
