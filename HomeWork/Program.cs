internal class HomeWork
{
    static int[] array = InitializeArray(10);
    static void Main(string[] args)
    {
        Console.WriteLine("Масив:");
        ShowArray(array);
        Console.WriteLine("Сума та добуток елементiв:");
        Console.WriteLine(CalculateSumAndProduct(array));
        Console.WriteLine("Обчислення максимального та мiнiмального елементу в масивi та замiна мiсцями мiнiмального та максимального елементу:");
        Console.WriteLine(MinimumMaximumElementAndSwap(array));
        ShowArray(array);
        Console.WriteLine("Визначення першого позитивного/негативного елемента в масивi:");
        ShowArray(array);
        Console.WriteLine(PositiveNegativeElement(array, true));
        Console.WriteLine(PositiveNegativeElement(array, false));
    }

    static int[] InitializeArray(int length)
    {
        int[] array = new int[length];
        Random randomNumber = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomNumber.Next(-10, 11);
        }
        return array;
    }

    static void ShowArray(int[] array)
    {
        CheckArray(array);
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static (int sum, int product) CalculateSumAndProduct(int[] array)
    {
        CheckArray(array);
        int sum = 0;
        int product = 1;
        foreach (int i in array)
        {
            sum += i;
            product *= i;
        }
        return (sum, product);
    }
    static (int min, int max) MinimumMaximumElementAndSwap(int[] array)
    {
        CheckArray(array);
        int min = array[0];
        int minPosition = 0;
        int max = array[0];
        int maxPosition = 0;
        int temp;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (min > array[i + 1])
            {
                min = array[i + 1];
                minPosition = i + 1;
            }
            if (max < array[i + 1])
            {
                max = array[i + 1];
                maxPosition = i + 1;
            }
        }
        temp = array[minPosition];
        array[minPosition] = array[maxPosition];
        array[maxPosition] = temp;
        return (min, max);
    }

    static int? PositiveNegativeElement(int[] array, bool positive = true)
    {
        CheckArray(array);

        foreach (int number in array)
        {
            if (positive && number > 0)
            {
                return number;
            }
            if (!positive && number < 0)
            {
                return number;
            }
        }
        return null;
    }

    static void CheckArray(int[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException("Масив не створено");
        }
        if (array.Length == 0)
        {
            throw new ArgumentException("Масив порожній");
        }
    }
}
