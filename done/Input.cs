
class Input
{

    public void StartProgram()
    {
        int size = InputMessage("Введите длинну массива: ");
        string[] arrStr = new string[size];
        string[] arrRes = new string[arrStr.Length];
        Console.WriteLine("Заполните массив:");
        FillArray(arrStr);
        Console.WriteLine("***Ваш массив:");
        PrintArray(arrStr);
        SortedLenghtElements(arrStr, arrRes);
        Console.WriteLine("***Результат:");
        PrintArray(arrRes);
    }

    private void FillArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine()!;
        }
        Console.WriteLine();
    }

    private void PrintArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    private int InputMessage(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    private void SortedLenghtElements(string[] arrStr, string[] arrRes)
    {
        int count = 0;
        for (int i = 0; i < arrStr.Length; i++)
        {
            if (arrStr[i].Length <= 3)
            {
                arrRes[count] = arrStr[i];
                count++;
            }
        }
    }
}