// Принимает позицию элемента в двумерном массиве и выводит значение этого элемента.



int m = 3, n = 4;
int[,] array = new int[m,n];

Console.WriteLine("Введите индекс элемента в двумерном масиве по Х");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс элемента в двумерном масиве по Y");
int y = int.Parse(Console.ReadLine());

if (x <= array.GetLength(0) - 1 && y <= array.GetLength(1) - 1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
       {
            array[i,j] = new Random().Next(-99,100);
            Console.Write(array[i,j] + " ");
       }
      Console.WriteLine();
    }

Console.WriteLine("________________");
Console.WriteLine(array[x,y]);
}

else
{
    Console.WriteLine("Такого элемента в массиве нет");
}