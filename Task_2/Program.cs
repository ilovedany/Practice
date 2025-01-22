class Task_2{
    static void Main(string[] args){

        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        int[] a2 = a.Cast<int>().ToArray(); //приводим массив к одномерному
        Array.Sort(a2); //сортировка
        

        int r = a.GetLength(0); //узнаем количество строк
        int c = a.GetLength(1); //узнаем количество столбцов

        int[,] a3 = new int[r, c];
        int k = 0;
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                a3[i, j] = a2[k++];
            }
        }

        Console.WriteLine("отсортированный двумерный массив:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(a3[i, j] + " ");
            }
            Console.WriteLine();
        }        
    }
}