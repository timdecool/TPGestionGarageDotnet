namespace TPGestionGarage;

using System;

public class TerminalUI
{
    static readonly int _width = 120;
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
}