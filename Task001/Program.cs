// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 5
// 1, -7, 567, 89, 223-> 3


int MessageToUser(string message)
{
    System.Console.Write(message);
    string userInput = Console.ReadLine();
    int result = int.Parse(userInput);
    return result;
}

int[] InputArray(int lenght)
{
    int [] array = new int [lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = MessageToUser($"Введите {i+1}-й элемент ");
    }
    return array;    
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumPositiveElements(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            sum++;
        }
    }
    return sum;
}



int lenght = MessageToUser("Введите количество элементов: ");
int [] array;
array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Количество цифр больше 0: {SumPositiveElements(array)}");