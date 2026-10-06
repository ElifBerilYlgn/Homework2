Console.Write("Enter your celsius value: ");
double celsius = double.Parse(Console.ReadLine());

double kelvin = celsius + 273.15;
double fahrenheit = celsius * 9.0 / 5.0 + 32;

Console.WriteLine($"Kelvin: {kelvin:F2}");
Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");







Console.WriteLine();
Console.Write("Enter your first exam grade: ");
int grade1 = int.Parse(Console.ReadLine());
Console.Write("Enter your second exams grade: ");
int grade2 = int.Parse(Console.ReadLine());
Console.Write("Enter your third exams grade: ");
int grade3 = int.Parse(Console.ReadLine());

int sum = grade1 + grade2 + grade3;
double average = (double)sum / 3;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");

if (average >= 60)
{
    Console.WriteLine("Average is 60 or above 60");
}

else
{
    Console.WriteLine("Average is below 60");
}




Console.WriteLine();
Console.Write("Enter 3 digit number: ");
int number = int.Parse(Console.ReadLine());

int hundreds = number / 100;
int tens = (number / 10) % 10;
int units = number % 10;

Console.WriteLine($"Hundreds: {hundreds}");
Console.WriteLine($"Tens: {tens}");
Console.WriteLine($"Units: {units}");














