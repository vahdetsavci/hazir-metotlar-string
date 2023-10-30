using System;

namespace hazir_metotlar_string;

class Program
{
    static void Main(string[] args)
    {
        string degisken1 = "Dersimiz CSharp, Hoşgeldiniz!";
        string degisken2 = "CSharp";

        // Length
        Console.WriteLine(degisken1.Length);

        // ToUpper - ToLower
        Console.WriteLine(degisken1.ToUpper());
        Console.WriteLine(degisken1.ToLower());

        // Concat
        Console.WriteLine(string.Concat(degisken1, " Merhaba"));

        // Compare - CompareTo
        Console.WriteLine(degisken1.CompareTo(degisken2));
        Console.WriteLine(string.Compare(degisken1, degisken2, true));
        Console.WriteLine(string.Compare(degisken1, degisken2, false));

        // Contains
        Console.WriteLine(degisken1.Contains(degisken2));

        // StartsWith - EnsWith
        Console.WriteLine(degisken1.EndsWith("Hoşgeldiniz!"));
        Console.WriteLine(degisken1.StartsWith("Merhaba, "));

        // IndexOf - LastIndexOf
        Console.WriteLine(degisken1.IndexOf("CS"));
        Console.WriteLine(degisken1.LastIndexOf("i"));

        // Insert
        Console.WriteLine(degisken1.Insert(0,"Merhaba! "));

        // PadLeft - PadRight
        Console.WriteLine(degisken1 + degisken2.PadLeft(30));
        Console.WriteLine(degisken1 + degisken2.PadLeft(30, '*'));
        Console.WriteLine(degisken1.PadRight(50) + degisken2);
        Console.WriteLine(degisken1.PadRight(50, '-') + degisken2);

        // Remove
        Console.WriteLine(degisken1.Remove(10));
        Console.WriteLine(degisken1.Remove(5, 3));
        Console.WriteLine(degisken1.Remove(0, 1));
        
        // Replace
        Console.WriteLine(degisken1.Replace("CSharp", "C#"));

        // Split
        Console.WriteLine(degisken1.Split(' ')[1]);

        // Substring
        Console.WriteLine(degisken1.Substring(4));
        Console.WriteLine(degisken1.Substring(4,6));
    }
}
