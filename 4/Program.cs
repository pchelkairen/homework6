// Написать программу масштабирования фигуры
int[] arr = { 0, 0, 2, 0, 2, 2, 0, 2 };

int[] copy = new int[arr.Length];

Console.WriteLine("Введите коэффициент масштабирования: ");
int k = int.Parse(Console.ReadLine() ?? "0");

for (int i = 0; i < arr.Length; i++)
{
    copy[i] = arr[i] * k;
}

Console.WriteLine(String.Join(", ", copy));

