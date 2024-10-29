namespace TPGestionGarage;

using System;

public class TerminalUI
{
    static readonly int _width = 80;
    static readonly Char _border = '*';
    private static readonly Char _separator = '-';

    public static void AfficherTitre(String titre)
    {
        Console.Clear();
        AfficherLigne();
        EncadrerTexte(titre, true);
        AfficherSeparateur();
        EncadrerTexte("");
    }

    public static void EncadrerTexte(String text, Boolean upper = false)
    {
        int spaceLength = (int)System.Math.Floor((_width - text.Length - 2)/2m);
        
        String space = new string(' ', spaceLength);
        String newLine = $"{_border}{new string(' ',(_width - text.Length - 2) / 2)}{text}{new string(' ',(_width - text.Length - 1)/2)}{_border}";
        if (upper)
        {
            newLine = newLine.ToUpper();
        }
        Console.WriteLine(newLine);
    }

    public static void AfficherLigne()
    {
        Console.WriteLine(new string(_border, _width));
    }

    public static void AfficherSeparateur()
    {
        EncadrerTexte(new string('-', _width-4));

    }

    public static void AfficherPied(String texte = "Appuyez sur une touche pour retourner au menu.", Boolean pressKey = true)
    {
        EncadrerTexte("");
        EncadrerTexte(texte);
        EncadrerTexte("");
        AfficherLigne();
        if(pressKey) Console.ReadKey();
    }

    // Affiche un texte centré dans une boîte de caractères spécifiques
    public static void PrintBoxedText(string text, char borderChar = '*')
    {
        int consoleWidth = Console.WindowWidth;
        int padding = 4;  // Espaces autour du texte
        int totalWidth = Math.Min(consoleWidth, text.Length + padding * 2);

        string borderLine = new string(borderChar, totalWidth);
        string paddedText = $"{new string(' ', (totalWidth - text.Length) / 2)}{text}{new string(' ', (totalWidth - text.Length + 1) / 2)}";

        Console.WriteLine(borderLine);
        Console.WriteLine($"{borderChar}{paddedText}{borderChar}");
        Console.WriteLine(borderLine);
    }

    // Affiche un titre centré avec des tirets de chaque côté
    public static void PrintHeader(string title)
    {
        int consoleWidth = Console.WindowWidth;
        int titleLength = title.Length;
        int padding = (consoleWidth - titleLength - 2) / 2;

        string header = $"{new string('-', padding)} {title} {new string('-', padding)}";
        Console.WriteLine(header);
    }

    // Affiche une ligne horizontale composée d'un caractère spécifique
    public static void PrintLine(char lineChar = '-')
    {
        Console.WriteLine(new string(lineChar, Console.WindowWidth));
    }

    // Affiche un message simple
    public static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}