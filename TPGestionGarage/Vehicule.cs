using System.Text.Json.Serialization;

namespace TPGestionGarage;

[Serializable]
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(Voiture), "voiture")]
[JsonDerivedType(typeof(Moto), "moto")]
[JsonDerivedType(typeof(Camion), "camion")]
public abstract class Vehicule : IComparable<Vehicule>
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
    public int Id { get => id; init => id = value; }
    public string Nom { get => nom; init => nom = value; }
    public decimal PrixHt { get => prixHt; init => prixHt = value; }
    public List<Option> Options { get => options; init => options = value; }
    public Moteur Moteur { get => moteur; init => moteur = value; }
    public Marque Marque { get => marque; init => marque = value; }
    #endregion
    
    #region constructors

    public Vehicule()
    {
        
    }
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
        foreach (Option option in Options)
        {
            option.Afficher();
            TerminalUI.AfficherSeparateur();
        }
    }

    public virtual void Afficher()
    {
        moteur.Afficher();
        if (options.Count > 0)
        {
            TerminalUI.EncadrerTexte("Options : ");
            AfficherOptions();
        }
        else
        {
            TerminalUI.EncadrerTexte("Pas d'options sélectionnées.");
        }
        TerminalUI.EncadrerTexte($"Prix : {prixHt:C} H.T - {PrixTotal():C} T.T.C");
    }

    public void AjouterOption(Option option)
    {
        options.Add(option);
    }
    public abstract decimal CalculerTaxe();

    public decimal PrixTotal()
    {
        return prixHt + CalculerTaxe() + options.Sum(option => option.Prix);
    }
    
    public int CompareTo(Vehicule? other)
    {
        if (other == null) return 1;
        return this.PrixTotal().CompareTo(other.PrixTotal());
    }
    #endregion
    
}
