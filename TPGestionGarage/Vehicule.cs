namespace TPGestionGarage;

public abstract class Vehicule
{
    
    #region attributes
    static int _i;
    private int id;
    private string nom;
    private decimal prixHt;
    private List<Option> options;
    private Moteur moteur;
    private Marque marque;
    #endregion
    
    #region properties
    public int Id { get => id; }
    public string Nom { get => nom; init => nom = value; }
    public decimal PrixHt { get => prixHt; init => prixHt = value; }
    public List<Option> Options { get => options; }
    public Moteur Moteur { get => moteur; init => moteur = value; }
    public Marque Marque { get => marque; init => marque = value; }
    #endregion
    
    #region constructors
    public Vehicule(string nom, decimal prixHt, Moteur moteur, Marque marque)
    {
        options = new List<Option>();
        this.nom = nom;
        this.prixHt = prixHt;
        this.moteur = moteur;
        this.marque = marque;
    }
    #endregion
    
    
    #region method

    public void AfficherOptions()
    {
        
    }

    public virtual void Afficher()
    {
        Console.WriteLine($"{marque} {nom.ToUpper()}");
        Console.WriteLine("=================");
        moteur.Afficher();
        Console.WriteLine("Options : ");
        foreach (Option option in options)
        {
            option.Afficher();
        }
        Console.WriteLine($"Prix : {prixHt:C} H.T - {PrixTotal():C} T.T.C");
    }

    public void AjouterOption(Option option)
    {
        options.Add(option);
    }
    public abstract decimal CalculerTaxe();

    public decimal PrixTotal()
    {
        return prixHt + CalculerTaxe();
    }

    #endregion




}