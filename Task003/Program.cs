// Задача НЕГАФИБОНАЧЧИ. Задайте число. 
// Составьте массив чисел НегаФибоначчи, 
// в том числе для отрицательных индексов.
// *Пример:*
// - для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


int MessageToUser(string message)
{
    System.Console.Write(message);
    string userInput = System.Console.ReadLine();
    int result = int.Parse(userInput);
    return result;
}


void Fibonacci(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }
}

void Fibonacci2(int[] array, int [] array2)
{
    for (int i = 0; i<array2.Length; i++)
    {
        array2[i] -= array[array.Length-1-i];
    }
    for (int i = 1; i<array2.Length;i+=2)
    {
        array2[i]*=-1;
    }
}


    void PrintArray(int[] array, int []array2)
    {
        foreach (int item in array2)
        {
            Console.Write($"{item} ");
        }
        Console.Write("");
        foreach (int item in array)
        {   
            if (item!=0)
                Console.Write($"{item} ");
        }
    }




    int num = MessageToUser("Введите целое число: ");
    int[] array = new int[num];
    int[] array2 = new int[num];
    Fibonacci(array);
    Fibonacci2(array, array2);
    PrintArray(array, array2);