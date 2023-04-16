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

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}