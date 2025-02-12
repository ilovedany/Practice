# Программа сортировки двумерного массива на c#

Программа берет заполненный числами двумерный массив, сортирует и выводит его на консоль.

        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

## Как запустить программу

Для запуска программы необходимо:

1. Открыть файл проекта в среде разработки Visual Studio или другой IDE, поддерживающей C#.
2. Скомпилировать проект.
3. Запустить исполняемый файл.

## Действия в программе

 1. Для сортировки двумерный массив переводим в одномерный используя методы Cast (LINQ) и ToArray(). 

        int[] a2 = a.Cast<int>().ToArray();

 2. Пользуясь методом Sort класса Array мы сортируем массив.

        Array.Sort(a2);

 3. C помощью метода GetLength мы узнаем количество строк и столбцов двумерного массива для перевода одномерного массива обратно в одномерный.

        int r = a.GetLength(0); //узнаем количество строк
        int c = a.GetLength(1); //узнаем количество столбцов

4. Далее мы переводим отсортированный одномерный массив в двумерный используя цикл for.

5. Выводим отсортированный двумерный массив.

## Пример вывода

        Отсортированный двумерный массив:
        1 2 3 
        4 5 6 
        7 8 9 

Таким образом, программа успешно сортирует элементы двумерного массива и выводит их в упорядоченном виде.