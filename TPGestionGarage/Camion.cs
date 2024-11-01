﻿namespace TPGestionGarage;

[Serializable]
public class Camion : Vehicule
{
    private int nbEssieu;
    private int poids;
    private int volume;
    
    public int NbEssieu { get => nbEssieu; init => nbEssieu = value; }
    public int Poids { get => poids; init => poids = value; }
    public int Volume { get => volume; init => volume = value; }

    public Camion()
    {
        
    }
    public Camion(int nbEssieu, int poids, int volume, string nom, decimal prixHt, Moteur moteur, Marque marque) : base(
        nom, prixHt, moteur, marque)
    {
        this.nbEssieu = nbEssieu;
        this.poids = poids;
        this.volume = volume;
    }

    public override decimal CalculerTaxe()
    {
        return NbEssieu * 50m;
    }

    public override void Afficher()
    {
        TerminalUI.EncadrerTexte($"ID N°{Id} - CAMION : {Marque} {Nom.ToUpper()}");
        TerminalUI.EncadrerTexte($"Nombre d'essieux : {nbEssieu}");
        TerminalUI.EncadrerTexte($"Poids : {poids:2} kg");
        TerminalUI.EncadrerTexte($"Volume : {volume:2} m3");
        base.Afficher();
    }
    

}