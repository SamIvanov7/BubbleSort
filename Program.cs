using System;

class Program
{
    static void Main()
    {
        // Створити масив з 30 цілих чисел
        int[] numbers = new int[30];

        // Ініціалізація генератора випадкових чисел
        Random random = new Random();

        // Заповнити масив випадковими числами від 1 до 100
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101); // Випадкове число від 1 до 100
        }

        // Бульбашкове сортування масиву
        BubbleSort(numbers);

        // Вивести відсортований масив
        Console.WriteLine("Sorted Array:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    static void BubbleSort(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                // Порівнюэмо сусідні елементи
                if (array[j] > array[j + 1])
                {
                    // Міняємо місцями, якщо елемент зліва більший за елемент справа
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
