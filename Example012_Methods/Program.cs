// Первая группа - методы, которые не принимают никаких аргументов и ничего не возвращают

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();



// Вторая группа - методы, которые могут принимать аргументы, но ничего не возвращать

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }

// }
// // Method21("Текст сообщения", 4);
// Method21(count: 4, msg: "Новый текст"); // Можем присвоить именованные аргументы, т.е. порядок не важен



// Третья группа - методы, которые не принимают никаких аргументов, но могут что-то возвращать

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);



// Четвертая группа - методы, которые принимают какие-то аргументы и что-то возвращают для дальнейшей работы

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);



// Цикл for

// string Method4(int count, string text)
// {
//     string result = string.Empty;

//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);



// Цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }




// Работа с текстом
// Дан текст. В тексте нужно заменить все проблелы черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

// string text = "– Я думаю, – сказал князь, улыбаясь, – что, " + "ежели бы вас послали вместо нашего милого Винценгероде, " + "вы бы взяли приступом согласие прусского короля. " + "Вы так красноречивы. Вы дадите мне чаю?";
//// string s = "qwerty"
////   012345
//// s[3]//r 
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue)
//         {
//             result = result + $"{newValue}";
//         }
//         else
//         {
//             result = result + $"{text[i]}";
//         };
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'с', 'С');
// System.Console.WriteLine(newText);




// Упорядочить массив от минимального к максимальному

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
void SelectionSort2(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
Console.WriteLine();

SelectionSort(arr);
PrintArray(arr);
Console.WriteLine();

SelectionSort2(arr);
PrintArray(arr);