using TPGestionGarage;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

// Créer un jeu de test
Moteur D5Awd = new Moteur("D5Awd", 158, TypeMoteur.Diesel);
Moteur D4Awd = new Moteur("D4Awd", 133, TypeMoteur.Diesel);

Voiture kangoo = new Voiture(5, 5, 5, 1, "Kangoo", 14300m, D4Awd, Marque.RENAULT);
Moto supersport = new Moto(4, "Supersport 10R", 16500m, D5Awd, Marque.AUDI);
Camion typeH = new Camion(10, 1500, 15, "Type H", 21000m, D5Awd, Marque.CITROEN);

Garage garage = new Garage("Le Garage de Julie");

// Ajout des véhicules au garage 
garage.AjouterVehicule(typeH);
garage.AjouterVehicule(kangoo);
garage.AjouterVehicule(supersport);

// Affichage de la liste des véhicules avant et après tri
// garage.Afficher();
// garage.TrierVehicule();
// garage.Afficher();

// Affichage de la liste filtrée par type de véhicule
// garage.AfficherVoiture();
// garage.AfficherMoto();

Menu menu = new Menu(garage);
menu.Start();
