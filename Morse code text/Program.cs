string text;
string morse = "";
here:
Console.WriteLine("To decrypt press 1");
Console.WriteLine("To encrypt press 2");
Console.Write("Choice=");
text=Console.ReadLine();

if (text == "1")
{
    Dictionary<string, string> dictionary = DictionaryData.DecryptDictionary();
    text = Console.ReadLine();
    decrypt(text,dictionary);
}

else if (text == "2")
{
    Dictionary<string, string> dictionary = DictionaryData.EncryptDictionary();
    text = Console.ReadLine().ToUpper();
    encrypt(text,dictionary);
}
else
{
    Console.Clear();
    Console.WriteLine("INVALID CHOICE, TRY AGAIN");
    Console.WriteLine(" ");
  
    goto here;
}

Console.WriteLine(morse);

string decrypt(string input,Dictionary<string,string> dictionary)
{
    string part=String.Empty;
    
    for(int i=0;i<input.Length;i++)
    {
        if(input[i] =='.'|input[i]=='-')
        {
            part=part+input.Substring(i,1);
        }
        if(input[i]==' ')
        {
            morse = morse + dictionary[part.ToString()];
            part = String.Empty;
        }
        if(input[i]=='/')
        {
            morse = morse + " ";
        }
    }
    morse = morse + dictionary[part.ToString()] + " ";
    return morse;
}

string encrypt(string input,Dictionary<string,string> dictionary)
{
    foreach (var letter in input)
    {
        if (letter == ' ')
        {
            morse = morse + '/' + " ";
        }
        else
            morse = morse + dictionary[letter.ToString()] + " ";
    }
    return morse;
}