namespace TPGestionGarage;

[Serializable]
public class Option
{
    private static int _i;
    private int id;
    private string nom;
    private decimal prix;
    
    public int Id { get => id; init => id = value; }
    public string Nom { get => nom; init => nom = value; }
    public decimal Prix { get => prix; init => prix = value; }

    public Option(string nom, decimal prix)
    {
        id = ++_i;
        this.nom = nom;
        this.prix = prix;
    }

    public void Afficher()
    {
        TerminalUI.EncadrerTexte($"Nom: {nom} - Prix: {prix:C}");
    }
}