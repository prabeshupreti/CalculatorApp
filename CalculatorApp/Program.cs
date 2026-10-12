
using CalculatorApp;

int A, B, Result = 0;

Console.WriteLine("Enter the first number:");
A = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
B = int.Parse(Console.ReadLine());

Add adder = new Add();
Result = adder.AddNumbers(A, B);

Console.WriteLine("The sum is: {0}", Result);