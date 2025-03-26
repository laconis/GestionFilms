

class Display
{


    public static void getBanner()
    {
        Console.WriteLine("  ______ _ _                 _   _ _           _           \r\n |  ____(_) |               | \\ | (_)         | |          \r\n | |__   _| |_ __ ___  ___  |  \\| |_  ___ ___ | | __ _ ___ \r\n |  __| | | | '_ ` _ \\/ __| | . ` | |/ __/ _ \\| |/ _` / __|\r\n | |    | | | | | | | \\__ \\ | |\\  | | (_| (_) | | (_| \\__ \\\r\n |_|    |_|_|_| |_| |_|___/ |_| \\_|_|\\___\\___/|_|\\__,_|___/");
    }



    
    /***
     * Affiche le menu pour la gestion des Films
     */ 
      public static void getMenu()
    {
        Console.WriteLine("Menu : ");
        Console.WriteLine("1. Ajouter Films");
        Console.WriteLine("2. Maintenance Films");

        Console.WriteLine("Enter votre choix : ");
        int ch = Convert.ToInt32(Console.ReadLine());

        switch (ch)
        {
            case 1: Console.WriteLine("Ajout de films depuis D:\\FilmsSeriesAtrier ");

                break;
            case 2: Console.WriteLine("2.Maintenance");
                break;
            default:
                Console.WriteLine("Mauvais choix selectionné");  
                break;
        }

    }


}