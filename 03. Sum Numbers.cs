int numberSum = int.Parse(Console.ReadLine()); // Четем първоначалното число
int currentSum = 0;

while (currentSum < numberSum)
{
    int number = int.Parse(Console.ReadLine()); // Четем следващо число
    currentSum += number; // Добавяме към текущата сума
}
Console.WriteLine(currentSum); // Отпечатваме крайната сума