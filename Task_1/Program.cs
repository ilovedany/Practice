class Task_1
{
    static void Main(string[] args)
    {
        double num1 = Convert.ToDouble(args[0]);
        char symbol = Convert.ToChar(args[1]);
        double num2 = Convert.ToDouble(args[2]);

        double result;

        switch (symbol) {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"{num1} {symbol} {num2} = {result}");

                Console.WriteLine($"В результате операции сложения чисел {num1} и {num2} получился ответ {result}.");

                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine($"{num1} {symbol} {num2} = {result}");

                Console.WriteLine($"В результате операции вычитания чисел {num1} и {num2} получился ответ {result}.");

                break;

            case '/':
                result = num1 / num2;
                if(num2 == 0)
                {
                    Console.WriteLine("Деление на ноль невозможно!");
                }
                else
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {result}");

                    Console.WriteLine($"В результате операции деления чисел {num1} и {num2} получился ответ {result}.");
                }                
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine($"{num1} {symbol} {num2} = {result}");

                Console.WriteLine($"В результате операции умножения чисел {num1} и {num2} получился ответ {result}.");

                break;

            default: Console.WriteLine("Такого выражения нет!");
                break;
        }
        
    }
}