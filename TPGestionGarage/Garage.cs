namespace TPGestionGarage;

[Serializable]
public class Garage
{
    private string nom;
    private List<Vehicule> vehicules;
    private List<Moteur> moteurs;
    private List<Option> options;
    private Vehicule? vehiculeSelectionne;
    

    public string Nom
    {
        get => nom;
        init => nom = value;
    }
    
    public List<Vehicule> Vehicules { get => vehicules; set => vehicules = value; }
    public List<Moteur> Moteurs { get => moteurs; set => moteurs = value; }
    public List<Option> Options { get => options; set => options = value; }
    public Vehicule? VehiculeSelectionne { get => vehiculeSelectionne; set => vehiculeSelectionne = value; }
    

    public Garage(string nom)
    {
        this.nom = nom;
        vehicules = new List<Vehicule>();
        moteurs = new List<Moteur>();
        options = new List<Option>();
    }

    public void AjouterVehicule(Vehicule vehicule)
    {
        vehicules.Add(vehicule);
    }

    public void SupprimerVehicule(Vehicule vehicule)
    {
        vehicules.Remove(vehicule);
    }

    public void Afficher()
    {
        TerminalUI.EncadrerTexte($"{this.nom.ToUpper()} - {vehicules.Count} véhicules :");
        TerminalUI.EncadrerTexte("");
        foreach (Vehicule vehicule in vehicules)
        {
            vehicule.Afficher();
            TerminalUI.AfficherSeparateur();
        }

    }

    public void AfficherVoiture()
    {
        List<Voiture> voitures = vehicules.Where(n => n.GetType() == typeof(Voiture)).Cast<Voiture>().ToList();
        TerminalUI.EncadrerTexte($"{this.nom.ToUpper()} - Liste des {voitures.Count} voitures :");
        TerminalUI.EncadrerTexte("");
        foreach (Voiture voiture in voitures)
        {
            voiture.Afficher();
            TerminalUI.AfficherSeparateur();
        }
    }

    public void AfficherCamion()
    {
        List<Camion> camions = vehicules.Where(n => n.GetType() == typeof(Camion)).Cast<Camion>().ToList();
        TerminalUI.EncadrerTexte($"{this.nom.ToUpper()} - Liste des {camions.Count} camions :");
        TerminalUI.EncadrerTexte("");
        foreach (Camion camion in camions)
        {
            camion.Afficher();
            TerminalUI.AfficherSeparateur();
        }
    }

    public void AfficherMoto()
    {
        List<Moto> motos = vehicules.Where(n => n.GetType() == typeof(Moto)).Cast<Moto>().ToList();
        TerminalUI.EncadrerTexte($"{this.nom.ToUpper()} - Liste des {motos.Count()} motos :");
        TerminalUI.EncadrerTexte("");
        foreach (Moto moto in motos)
        {
            moto.Afficher();
            TerminalUI.AfficherSeparateur();
        }
    }

    public void AjouterMoteur(Moteur moteur)
    {
        moteurs.Add(moteur);
    }

    public void AfficherMoteur()
    {
        foreach (Moteur moteur in moteurs)
        {
            moteur.Afficher();
        }
    }

    public void AjouterOption(Option option)
    {
        options.Add(option);
    }

    public void AfficherOption()
    {
        foreach (Option option in options)
        {
            option.Afficher();
        }
    }

    public void AfficherMarque()
    {
        foreach (Marque marque in Enum.GetValues<Marque>())
        {
            TerminalUI.EncadrerTexte($"{marque}");
        }
    }

    public void TrierVehicule()
    {
        vehicules.Sort();
    }
}
