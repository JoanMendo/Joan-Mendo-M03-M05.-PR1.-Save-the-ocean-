using System;
using System.Net;
using Classes;
using static System.Net.Mime.MediaTypeNames;
namespace Rescat;
public class Program
{
    public static void Main()
    {
        
        Random random = new Random();
        Console.WriteLine("Benvingut a la Fundació CRAM");
        Console.WriteLine("1. Jugar.");
        Console.WriteLine("2. Sortir del Programa");
        bool choice = (Console.ReadLine() == "1");

       if (choice)
       {
            Console.WriteLine("Escull el teu rol: ");
            Console.WriteLine("1. Tècnic");
            Console.WriteLine("2. Veterinari");
            string rol = Console.ReadLine() switch
            {
                "1" => "Tècnic",
                "2" => "Veterinari",
                _ => "Error" //Aquí no tancaré el programa si posa un valor incorrecte perquè el rol no surt a ninguna part del programa.
            };  
            Console.WriteLine("Introdueix el teu nom: ");
            string nom = Console.ReadLine();
            Console.WriteLine($"Hola {nom}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. ");
            Console.WriteLine("Les dades que ens han donat són les següents:");
            Animal animal = random.Next(1,4) switch
            {
                1 => new Cetaci("13-02-2024", 46, 145, "Cetaci", "Badajoz", "Pedro", 143, "Cetacinus Inventadus"),
                2 => new AuMarina("28-01-2024", 37, 123, "Au Marina", "Teruel", "David", 16, "Pajarus Volante"),
                3 => new TortugaMarina("13-02-2024", 67, 387, "Tortuga Marina", "Hospitalet de Llobregat", "Juan", 75, "Tortuga de chill")
            };
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.WriteLine("|                       RESCAT                                |");
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.WriteLine("| # Rescat | Data rescat | Superfamília   | GA | Localització |");
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.WriteLine($"| RES{animal.NombreDeRescat}   | {animal.DataDeRescat}  | {animal.TipusAnimal}         | {animal.GrauDeAfectacio} | {animal.Localitzacio}     |");
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.WriteLine("Aquí tens la seva fitxa, per a més informació:");
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.WriteLine("|                       FITXA                                 |");
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.WriteLine("| # Nom | Superfamília | Espècie        | Pes aproximat       |");
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.WriteLine($"| {animal.NomAnimal} | {animal.TipusAnimal}       | {animal.Especie}   | {animal.Pes}kg              |");
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.WriteLine($"El {animal.TipusAnimal} té un grau d’afectació (GA) del {animal.GrauDeAfectacio}%. Vols curar-la aquí (1) o traslladar-la al centre (2)?");
            int accio = Convert.ToInt32(Console.ReadLine());
            if (animal.Tractament(accio) == -1) //Missatge si no prem 1 o 2, retorna -1 perqué en teoria el valor de les equacions no pot ser negatiu.
            {
                Console.WriteLine("Aquesta no era una opció valida i li ha clavat un bisturi a l'animal, matant-lo. Felicitats.");
            }
            else
            {
                Console.WriteLine($"El tractament aplicat ha reduït el GA fins al {animal.GrauDeAfectacio}%.");
                if (animal.GrauDeAfectacio <= 5)
                {
                    Console.WriteLine("L'exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.");
                }
                else
                {
                    Console.WriteLine("No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                }
            }
            Console.WriteLine("Fins el proper rescat!");



       }
       else //Missatge si surt del programa
       {
           Console.WriteLine("Adeu!");
       }

    }
}
