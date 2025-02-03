using System;

class Program
{
    static void Main()
    {
        double totalSum = 0.0; // Общата сума в сметката

        while (true)
        {
            string input = Console.ReadLine(); // Четем входа

            if (input == "NoMoreMoney")
            {
                break; // Прекратяваме програмата, ако командата е "NoMoreMoney"
            }

            double amount = double.Parse(input); // Преобразуваме входа в число

            if (amount < 0)
            {
                Console.WriteLine("Invalid operation!");
                break; // Прекратяваме програмата при отрицателна стойност
            }

            totalSum += amount; // Добавяме сумата към общата сметка
            Console.WriteLine($"Increase: {amount:F2}"); // Отпечатваме увеличението
        }

        Console.WriteLine($"Total: {totalSum:F2}"); // Отпечатваме общата сума
    }
}
