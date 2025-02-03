string input;
int minNumber = int.MinValue;

while ((input = Console.ReadLine()) != "Stop")
{
    int number = int.Parse(input);
    if (number > minNumber)
    {
        minNumber = number;
    }
}

Console.WriteLine(minNumber);