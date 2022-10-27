//Написать программу копирования массива
int[] arr = { 11, 6, 1, 6, 5 };
 
int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++) 
    {
        copy[i] = arr[i];
    }
 
    Console.WriteLine(String.Join(", ", copy));        

