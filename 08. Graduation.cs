string studentName = Console.ReadLine(); // Четем името на ученика
int grade = 1; // Започваме от 1-ви клас
int failCount = 0; // Брояч на неуспешните години
double totalGrades = 0.0; // Общо сумиране на оценките

while (grade <= 12)
{
    double yearlyGrade = double.Parse(Console.ReadLine()); // Четем оценката за годината

    if (yearlyGrade < 4.00)
    {
        failCount++; // Увеличаваме броя на неуспешните години
        if (failCount > 1)
        {
            Console.WriteLine($"{studentName} has been excluded at {grade} grade");
            return; // Прекратяваме програмата
        }
        continue; // Пропускаме увеличението на класа, ако ученикът е скъсан
    }

    totalGrades += yearlyGrade; // Добавяме оценката към общата сума
    grade++; // Преминаваме в следващия клас
}

double averageGrade = totalGrades / 12; // Изчисляваме средната оценка
Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
