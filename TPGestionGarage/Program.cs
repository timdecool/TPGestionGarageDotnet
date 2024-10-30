using TPGestionGarage;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Garage garage = new Garage("MEGA TURBO");

// Créer un jeu de test
Moteur D5Awd = new Moteur("D5Awd", 158, TypeMoteur.Diesel);
Moteur D4Awd = new Moteur("D4Awd", 133, TypeMoteur.Diesel);
Moteur BigVroom = new Moteur("BigVroom", 200, TypeMoteur.Essence);
Moteur BioDrive = new Moteur("BioDrive", 140, TypeMoteur.Electrique);
Moteur HybridOx = new Moteur("HybridOx", 150, TypeMoteur.Hybride);
garage.AjouterMoteur(D5Awd);
garage.AjouterMoteur(D4Awd);
garage.AjouterMoteur(BigVroom);
garage.AjouterMoteur(BioDrive);
garage.AjouterMoteur(HybridOx);

Voiture kangoo = new Voiture(5, 5, 5, 1, "Kangoo", 14300m, D4Awd, Marque.RENAULT);
Moto supersport = new Moto(4, "Supersport 10R", 16500m, D5Awd, Marque.AUDI);
Camion typeH = new Camion(10, 1500, 15, "Type H", 21000m, D5Awd, Marque.CITROEN);
garage.AjouterVehicule(typeH);
garage.AjouterVehicule(kangoo);
garage.AjouterVehicule(supersport);

Option parkingAuto = new Option("Parking automatique", 930);
Option vitresTeintees = new Option("Vitres Teintées", 800);
Option cameraRecul = new Option("Caméra de recul", 800);
Option bassBoost = new Option("Bass Boost Audio", 450);
Option siegeChauffant = new Option("Sièges Chauffants", 600);
Option fermetureCentralisee = new Option("Fermeture Centralisée", 300);
Option directionAssistee = new Option("Direction Assistée", 1210);
Option regulateurVitesse = new Option("Régulateur de Vitesse", 370);
garage.AjouterOption(parkingAuto);
garage.AjouterOption(vitresTeintees);
garage.AjouterOption(cameraRecul);
garage.AjouterOption(bassBoost);
garage.AjouterOption(siegeChauffant);
garage.AjouterOption(fermetureCentralisee);
garage.AjouterOption(directionAssistee);
garage.AjouterOption(regulateurVitesse);

Menu menu = new Menu(garage);
menu.Start();
