# Задача 3

Программа получает строку, состоящую из цифр ("123456789"), и проверяет каждую цифру на чётность. Если цифра является чётной, она добавляется в объект StringBuilder. В конце программа выводит все найденные чётные цифры.

    string str = "123456789";

## Как запустить программу

Для запуска программы необходимо:

1. Открыть файл проекта в среде разработки Visual Studio или другой IDE, поддерживающей C#.
2. Скомпилировать проект.
3. Запустить исполняемый файл.


## Действия в программе

1. Создаем объект StringBuilder:
    Используем класс System.Text.StringBuilder, чтобы собирать результаты проверки цифр.

        StringBuilder sb = new StringBuilder();

2. Перебираем цифры в строке:
   В цикле происходит:
   - Преобразование символа в целое число.

            int num = ch-'0';

   - Проверка, делится ли полученное число на 2 без остатка.
   - Если цифра чётная, добавление её в StringBuilder.

3. Вывод результата:
   После завершения цикла выводим собранные чётные цифры на консоль.

## Пример вывода

    Четные числа: 2468


Таким образом программа нашла и собрала все чётные цифры из исходной строки "123456789".