namespace TPGestionGarage;

public class Voiture : Vehicule
{
    private int chevauxFiscaux;
    private int nbPorte;
    private int nbSiege;
    private int tailleCoffre;
    
    public int ChevauxFiscaux { get => chevauxFiscaux; init => chevauxFiscaux = value; }
    public int NbPorte { get => nbPorte; init => nbPorte = value; }
    public int NbSiege { get => nbSiege; init => nbSiege = value; }
    public int TailleCoffre { get => tailleCoffre; set => tailleCoffre = value; }

    public Voiture(int chevauxFiscaux, int nbPorte, int nbSiege, int tailleCoffre, string nom, decimal prixHt,
        Moteur moteur, Marque marque) : base(nom, prixHt, moteur, marque)
    {
        this.chevauxFiscaux = chevauxFiscaux;
        this.nbPorte = nbPorte;
        this.nbSiege = nbSiege;
        this.tailleCoffre = tailleCoffre;
    }

    public override decimal CalculerTaxe()
    {
        return chevauxFiscaux * 10m;
    }

    public override void Afficher()
    {
        
    }
}