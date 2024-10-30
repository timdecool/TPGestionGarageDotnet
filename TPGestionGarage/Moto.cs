using System.ComponentModel.DataAnnotations.Schema;

namespace TPGestionGarage;

[Serializable]
public class Moto : Vehicule
{
    private int cylindree;
    public int Cylindree { get => cylindree; init => cylindree = value; }


    public Moto()
    {
        
    }
    public Moto(int cylindree, string nom, decimal prixHt, Moteur moteur, Marque marque) : base(nom, prixHt, moteur, marque)
    {
        this.cylindree = cylindree;
    }

    public override decimal CalculerTaxe()
    {
        return Math.Floor(cylindree * 0.3m);
    }

    public override void Afficher()
    {
        TerminalUI.EncadrerTexte($"MOTO : {Marque} {Nom.ToUpper()}");
        TerminalUI.EncadrerTexte($"Nombre de cylindrées : {cylindree}");
        base.Afficher();
    }

}