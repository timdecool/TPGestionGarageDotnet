namespace TPGestionGarage;

public class Garage : IComparable<Vehicule>
{
    private string nom;
    private List<Vehicule> vehicules;
    
    public string Nom { get => nom; init => nom = value; }
    public List<Vehicule> Vehicules { get => vehicules; }

    public Garage(string nom)
    {
        this.nom = nom;
        vehicules = new List<Vehicule>();
    }

    public void AjouterVehicule(Vehicule vehicule)
    {
        vehicules.Add(vehicule);
    }

    public void Afficher()
    {
        
    }

    public void AfficherVoiture()
    {
        
    }

    public void AfficherCamion()
    {
        
    }

    public void AfficherMoto()
    {
        
    }

    public void TrierVehicule()
    {
        vehicules.Sort();
    }
    
    
    public int CompareTo(Vehicule? other)
    {
        
        
        throw new NotImplementedException();
    }
}