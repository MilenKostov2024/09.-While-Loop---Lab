string input;
int minNumber = int.MaxValue; 

while ((input = Console.ReadLine()) != "Stop")
{
    int number = int.Parse(input); 
    if (number < minNumber)
    {
        minNumber = number; 
    }
}

Console.WriteLine(minNumber);