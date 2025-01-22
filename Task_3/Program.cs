using System.Text;

class Task3{
    static void Main(string[] args){

        StringBuilder sb = new StringBuilder();

        string str = "123456789";

        foreach(char ch in str){

            int num = ch-'0'; //преобразование символа в число 

            if (num % 2 == 0) //проверка числа на четность
                {
                    sb.Append(num); //добавляем число в объект stringbuilder
                }
        }
        Console.Write($"Четные числа: {sb}");
    }
}

//обычные строки в c# - неизменяемые объекты, а строки класса stringbuilder наоборот.
//при использовании stringbuilder при добавлении нового элемента не создаются новые обьекты.
//это существенно повышает производительность при работе с большими текстами