using System;
using System.Collections.Generic;

public static class DictionaryData
{
    public static Dictionary<string, string> EncryptDictionary()
    {
        var dictionary = new Dictionary<string, string>();
        dictionary.Add(" ", " ");
        dictionary.Add("A", ".-");
        dictionary.Add("B", "-...");
        dictionary.Add("C", "-.-.");
        dictionary.Add("D", "-..");
        dictionary.Add("E", ".");
        dictionary.Add("F", "..-.");
        dictionary.Add("G", "--.");
        dictionary.Add("H", "....");
        dictionary.Add("I", "..");
        dictionary.Add("J", ".---");
        dictionary.Add("K", "-.-");
        dictionary.Add("L", ".-..");
        dictionary.Add("M", "--");
        dictionary.Add("N", "-.");
        dictionary.Add("O", "---");
        dictionary.Add("P", ".--.");
        dictionary.Add("Q", "--.-");
        dictionary.Add("R", ".-.");
        dictionary.Add("S", "...");
        dictionary.Add("T", "-");
        dictionary.Add("U", "..-");
        dictionary.Add("V", "...-");
        dictionary.Add("W", ".--");
        dictionary.Add("X", "-..-");
        dictionary.Add("Y", "-.--");
        dictionary.Add("Z", "--..");
        dictionary.Add("1", ".----");
        dictionary.Add("2", "..---");
        dictionary.Add("3", "...--");
        dictionary.Add("4", "....-");
        dictionary.Add("5", ".....");
        dictionary.Add("6", "-....");
        dictionary.Add("7", "--...");
        dictionary.Add("8", "---..");
        dictionary.Add("9", "----.");
        dictionary.Add("0", "-----");


        return dictionary;
    }
    public static Dictionary<string, string> DecryptDictionary()
    {
        var dictionary = new Dictionary<string, string>();
        dictionary.Add("", "");
        dictionary.Add(" ", "");
        dictionary.Add("/", " ");
        dictionary.Add(".-", "A");
        dictionary.Add("-...", "B");
        dictionary.Add("-.-.", "C");
        dictionary.Add("-..", "D");
        dictionary.Add(".", "E");
        dictionary.Add("..-.", "F");
        dictionary.Add("--.", "G");
        dictionary.Add("....", "H");
        dictionary.Add("..", "I");
        dictionary.Add(".---", "J");
        dictionary.Add("-.-", "K");
        dictionary.Add(".-..", "L");
        dictionary.Add("--", "M");
        dictionary.Add("-.", "N");
        dictionary.Add("---", "O");
        dictionary.Add(".--.", "P");
        dictionary.Add("--.-", "Q");
        dictionary.Add(".-.", "R");
        dictionary.Add("...", "S");
        dictionary.Add("-", "T");
        dictionary.Add("..-", "U");
        dictionary.Add("...-", "V");
        dictionary.Add(".--", "W");
        dictionary.Add("-..-", "X");
        dictionary.Add("-.--", "Y");
        dictionary.Add("--..", "Z");
        dictionary.Add(".----", "1");
        dictionary.Add("..---", "2");
        dictionary.Add("...--", "3");
        dictionary.Add("....-", "4");
        dictionary.Add(".....", "5");
        dictionary.Add("-....", "6");
        dictionary.Add("--...", "7");
        dictionary.Add("---..", "8");
        dictionary.Add("----.", "9");
        dictionary.Add("-----", "0");
        return dictionary;
    }
}

