// See https://aka.ms/new-console-template for more information

using api;

Console.WriteLine("Hello, World!");


MathOperations mathOperations = new MathOperations();

Console.WriteLine("Enter two numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum: {mathOperations.Add(a, b)}");
Console.WriteLine($"Difference: {mathOperations.Subtract(a, b)}");
Console.WriteLine($"Product: {mathOperations.Multiply(a, b)}");

try
{
    Console.WriteLine($"Quotient: {mathOperations.Divide(a, b)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}