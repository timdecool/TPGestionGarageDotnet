using System.Text.Json;

namespace TPGestionGarage;

public class Menu
{
    private Garage garage;
    private List<String> optionMenu = new List<string>(
        ["1. Afficher les véhicules", 
            "2. Ajouter un véhicule", 
            "3. Supprimer un véhicule", 
            "4. Sélectionner un véhicule", 
            "5. Afficher les options d'un véhicule",
            "6. Ajouter des options à un véhicule",
            "7. Supprimer des options d'un véhicules",
            "8. Afficher les options disponibles",
            "9. Afficher les marques disponibles",
            "10. Afficher les moteurs disponibles",
            "11. Charger le garage",
            "12. Sauvegarder le garage",
            "13. Quitter l'application"]
    );
    
    public Menu(Garage garage)
    {
        this.garage = garage;
    }

    public void Start()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            TerminalUI.AfficherTitre($"outil de gestion de garage : {garage.Nom}");
            TerminalUI.EncadrerTexte("menu", true);
            foreach (String option in optionMenu)
            {
                TerminalUI.EncadrerTexte(option);
            }
            
            AfficherVehiculeSelectionne();
            TerminalUI.AfficherPied("Veuillez choisir une action du menu en entrant son numéro.", false);
            int userOption = 0;
            try
            {
                userOption = GetChoixMenu(optionMenu.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
            switch (userOption)
            {
                case 1:
                    AfficherVehicules();
                    break;
                case 2:
                    AjouterVehicule();
                    break;
                case 3:
                    SupprimerVehicule();
                    break;
                case 4:
                    SelectionnerVehicule();
                    break;
                case 5:
                    AfficherOptionsVehicule();
                    break;
                case 6:
                    AjouterOptionsVehicule();
                    break;
                case 7:
                    SupprimerOptionsVehicule();
                    break;
                case 8:
                    AfficherOptions();
                    break;
                case 9:
                    AfficherMarques();
                    break;
                case 10:
                    AfficherTypesMoteur();
                    break;
                case 11:
                    ChargerGarage();
                    break;
                case 12:
                    SauvegarderGarage();
                    break;
                case 13:
                    continueProgram = false;
                    break;
            }

        }
    }

    public void AfficherVehicules()
    {
        TerminalUI.AfficherTitre("liste des véhicules");
        garage.Afficher();
        TerminalUI.AfficherPied();
    }

    public void AjouterVehicule()
    {
        TerminalUI.AfficherTitre("Ajouter un véhicule");
        // Type de véhicule ?
        TerminalUI.EncadrerTexte("Choisissez un type de véhicule : Voiture (1), Moto (2) ou Camion (3)");

        int choixTypeVehicule = 0;
        try
        {
            choixTypeVehicule = GetChoixMenu(3);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        Vehicule nouveauVehicule;
        switch (choixTypeVehicule)
        {
            case 1:
                nouveauVehicule = new Voiture();
                break;
            case 2:
                nouveauVehicule = new Moto();
                break;
            case 3:
                nouveauVehicule = new Camion();
                break;
        }
        
        // PersonnaliserVehicule(nouveauVehicule);
        // En fonction du type, différentes infos nécessaires

        // Nom du véhicule

        // Choisir marque dans la liste

        // Entrer prix hors taxe

    }

    public void PersonnaliserVehicule(Moto moto)
    {
        TerminalUI.EncadrerTexte("Indiquez le nombre de cylindrées : ");
        
    }

    public void PersonnaliserVehicule(Voiture voiture)
    {
        
    }

    public void PersonnaliserVehicule(Camion camion)
    {
        
    }

    public void SupprimerVehicule()
    {
        TerminalUI.AfficherTitre("Supprimer un véhicule");
        garage.Afficher();
        TerminalUI.AfficherPied("Indiquez le numéro du véhicule à supprimer : ", false);
        int choix = -1;
        try
        {
            choix = GetChoixMenu(garage.Vehicules.Count) - 1;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }

        if (choix > -1)
        {
            garage.SupprimerVehicule(garage.Vehicules[choix]);
        }
    }

    public void SelectionnerVehicule()
    {
        TerminalUI.AfficherTitre("Sélectionner un véhicule");
        garage.Afficher();
        TerminalUI.AfficherPied("Indiquez le numéro du véhicule à sélectionner : ", false);
        int choix = -1;
        try
        {
            choix = GetChoixMenu(garage.Vehicules.Count) - 1;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }

        if (choix > -1)
        {
            garage.VehiculeSelectionne = garage.Vehicules[choix];
        }

    }

    public void AfficherVehiculeSelectionne()
    {
        if(garage.VehiculeSelectionne != null) TerminalUI.EncadrerTexte($"(Véhicule sélectionné : {garage.VehiculeSelectionne.Marque} {garage.VehiculeSelectionne.Nom.ToUpper()})");
    }

    public void AfficherOptionsVehicule()
    {
        TerminalUI.AfficherTitre("Options du véhicule");
        if (garage.VehiculeSelectionne != null)
        {
            AfficherVehiculeSelectionne();
            garage.VehiculeSelectionne.AfficherOptions();
            TerminalUI.AfficherPied();
        }
        else
        {
            TerminalUI.AfficherPied("Veuillez sélectionner un véhicule pour afficher ses options.");
        }

    }

    public void AjouterOptionsVehicule()
    {
        TerminalUI.AfficherTitre("Nouvelle option du véhicule");
        if (garage.VehiculeSelectionne != null)
        {
            AfficherVehiculeSelectionne();
            
        }
        else
        {
            TerminalUI.AfficherPied("Veuillez sélectionner un véhicule.");
        }

        
    }

    public void SupprimerOptionsVehicule()
    {
        TerminalUI.AfficherTitre("Supprimer une option du véhicule");
        if (garage.VehiculeSelectionne != null)
        {
            AfficherVehiculeSelectionne();
        }
        else
        {
            TerminalUI.AfficherPied("Veuillez sélectionner un véhicule.");
        }
    }

    public void AfficherOptions()
    {
        TerminalUI.AfficherTitre("Options disponibles");
        garage.AfficherOption();
        TerminalUI.AfficherPied();
    }

    public void AfficherMarques()
    {
        TerminalUI.AfficherTitre("Marques disponibles");
        garage.AfficherMarque();
        TerminalUI.AfficherPied();

    }

    public void AfficherTypesMoteur()
    {
        TerminalUI.AfficherTitre("Types de moteur disponibles");
        garage.AfficherMoteur();
        TerminalUI.AfficherPied();
    }

    public void ChargerGarage()
    {
        TerminalUI.AfficherTitre("Charger garage");
        string jsonString = File.ReadAllText("garage.json");
        Garage garage = JsonSerializer.Deserialize<Garage>(jsonString);
        this.garage = garage;
        TerminalUI.EncadrerTexte("Garage chargé.");
        TerminalUI.AfficherPied();
    }

    public void SauvegarderGarage()
    {
        TerminalUI.AfficherTitre("Sauvegarder");
        TerminalUI.EncadrerTexte(Directory.GetCurrentDirectory());
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(garage, options);
        File.WriteAllTextAsync("garage.json", jsonString);
        TerminalUI.AfficherPied();
        
    }

    public int GetChoix()
    {
        int res = 0;
        try
        {
            String? input = Console.ReadLine();
            res = int.Parse(input);
        }
        catch(FormatException e)
        {
            throw new FormatException("Le choix saisi n'est pas un nombre.");
        }

        return res;
    }

    public int GetChoixMenu(int max)
    {
        int choix = GetChoix();
        if (choix > 0 && choix < max+1)
        {
            return choix;
        }
        else
        {
            throw new MenuException(max);
        }
    }
    
}

class MenuException : Exception
{
    public MenuException() : base("Cette option n'est pas disponible dans ce menu.")
    {
    }

    public MenuException(int max) : base($"Le choix n'est pas compris entre 1 et {max}.")
    {
        
    }
}