// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "Я думаю, - сказал князь, улыбаясь, - что,"
+ "рылорва ываывла ввв вввкк ол -аа аыаб ";


string Replace(string textinside, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = textinside.Length; //узнали кол-во символов в строке
    for (int i = 0; i < length; i++)//от 0 символа до конца строки
    {
        if (textinside[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{textinside[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');//тут долго разбирался с скобками, НУЖНЫ ОДИНАРНЫЕ
Console.WriteLine(newText);
Console.WriteLine();

// далее пишем остальные правила

newText = Replace(newText, 'к', 'К');//тут долго разбирался с скобками, НУЖНЫ ОДИНАРНЫЕ
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'а', 'А');//тут долго разбирался с скобками, НУЖНЫ ОДИНАРНЫЕ
Console.WriteLine(newText);
Console.WriteLine();