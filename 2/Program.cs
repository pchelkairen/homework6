// Показать числа Фибоначчи
Console.Write("Enter a number: ");
var input = int.Parse(Console.ReadLine());
Console.Write($"Fibonacci numbers up to {input}: ");
var (first, second) = (0, 1);
while (first <= input)
{
    Console.Write($"{first}, ");
    (first, second) = (second, first + second);
}