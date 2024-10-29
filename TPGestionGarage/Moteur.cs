namespace TPGestionGarage;

[Serializable]
public class Moteur
{
    private static int _i;
    private int id;
    private string nom;
    private int puissance;
    private TypeMoteur typeMoteur;
    
    public int Id { get => id; }
    public string Nom { get => nom; init => nom = value; }
    public int Puissance { get => puissance; init => puissance = value; }
    public TypeMoteur TypeMoteur { get => typeMoteur; init => typeMoteur = value; }

    public Moteur(string nom, int puissance, TypeMoteur typeMoteur)
    {
        id = ++_i;
        this.nom = nom;
        this.puissance = puissance;
        this.typeMoteur = typeMoteur;
    }

    public void Afficher()
    {
        TerminalUI.EncadrerTexte($"Moteur: {nom}, puissance: {puissance}, type: {typeMoteur}");
    }

}