// вид метода 1
// ничего не принимает, ничего не выдает
void Method1()
{
    Console.WriteLine("by Legezo Oleg");
}
//Method1();

void CopyRight()
{
    Console.WriteLine("by Legezo Oleg");
}
//CopyRight();

// вид метода 2
// ничего не принимает, ничего не выдает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("метод 2");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("метод 2.1", 4);
//Method21(count:4, msg: "метод 2.1"); //при указании переменных порядок их расположения не важен

// вид метода 3
// ничего не принимает, но выдает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// вид метода 4
// принимает и выдает
// int Method4(int count, string text)
// {
//     int i = 0;
//     string result="";
//     //string result12=String.Empty; //string result=""; просто пусто
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwer");
// Console.WriteLine(result);
//  бред какой-то не понимаю что не так бред какой-то

