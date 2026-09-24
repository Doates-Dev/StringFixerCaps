using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine() ?? "";

        string fixedText = FixCapitalization(text);

        Console.WriteLine("Fixed text: " + fixedText);

        Clipboard.SetText(fixedText);

        Console.WriteLine();
        Console.WriteLine("Fixed text copied to clipboard!");
        
    }

    static string FixCapitalization(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return input;

        input = input.ToLower();

        return char.ToUpper(input[0]) + input.Substring(1);
    }
}