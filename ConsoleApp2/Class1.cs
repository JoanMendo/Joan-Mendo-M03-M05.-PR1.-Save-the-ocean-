using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class TortugaMarina : Animal
    {
        public TortugaMarina(string dataDeRescat, double grauDeAfectacio, int nombreDeRescat, string tipusAnimal, string localitzacio, string nomAnimal, int pes, string especie) : base(dataDeRescat, grauDeAfectacio, nombreDeRescat, tipusAnimal, localitzacio, nomAnimal, pes, especie)
        {
          
        }
        


        public override double Tractament(int accio)
        {
            int x = accio switch
            {
                1 => 5,
                2 => 5,
                _ => -1
            };
            if (x == -1)
            {
                return -1;
            }
            GrauDeAfectacio = GrauDeAfectacio - ((GrauDeAfectacio - 2) * (2 * GrauDeAfectacio + 3)) - 5;
            GrauDeAfectacio = Math.Floor(GrauDeAfectacio);
            return GrauDeAfectacio;
            

        }
    }

    public class Cetaci : Animal
    {
        public Cetaci(string dataDeRescat, double grauDeAfectacio, int nombreDeRescat, string tipusAnimal, string localitzacio, string nomAnimal, int pes, string especie) : base(dataDeRescat, grauDeAfectacio, nombreDeRescat, tipusAnimal, localitzacio, nomAnimal, pes, especie)
        {
           
        }

        public override double Tractament(int accio)
        {
            int x = accio switch
            {
                1 => 25,
                2 => 0,
                _ => -1
            };
            if (x == -1)
            {
                return -1;
            }

            GrauDeAfectacio = GrauDeAfectacio - (Math.Log10(GrauDeAfectacio)) - x;
            GrauDeAfectacio = Math.Floor(GrauDeAfectacio);
            return GrauDeAfectacio;
        }
    }

    public class AuMarina : Animal
    {
        public AuMarina(string dataDeRescat, double grauDeAfectacio, int nombreDeRescat, string tipusAnimal, string localitzacio, string nomAnimal, int pes, string especie) : base(dataDeRescat, grauDeAfectacio, nombreDeRescat, tipusAnimal, localitzacio, nomAnimal, pes, especie)
        {
            
        }

        public override double Tractament(int accio)
        {
            int x = accio switch
            {
                1 => 5,
                2 => 0,
                _ => -1
            };
            if (x == -1)
            {
                return -1;
            }
            GrauDeAfectacio = GrauDeAfectacio - (GrauDeAfectacio * GrauDeAfectacio + x);
            GrauDeAfectacio = Math.Floor(GrauDeAfectacio);
            return GrauDeAfectacio;
        }
    }

    public abstract class Animal
    {
        public int NombreDeRescat { get; set; }



        public string DataDeRescat { get; set; }



        public double GrauDeAfectacio { get; set; }



        public string TipusAnimal { get; set; }


        public string Localitzacio { get; set; }



        public string NomAnimal { get; set; }


        public int Pes { get; set; }




        public string Especie { get; set; }



        protected Animal(string dataDeRescat, double grauDeAfectacio, int nombreDeRescat, string tipusAnimal, string localitzacio, string nomAnimal, int pes, string especie)
        {
            DataDeRescat = dataDeRescat;
            GrauDeAfectacio = grauDeAfectacio;
            NombreDeRescat = nombreDeRescat;
            TipusAnimal = tipusAnimal;
            Localitzacio = localitzacio;
            NomAnimal = nomAnimal;
            Pes = pes;
            Especie = especie;
            //Aqui he fet només una classe en comptes d'una per animal i un altre per tractament perquè suposem que només hi han animals que necesiten tractament al programa.
        }
        public abstract double Tractament(int accio);
        // Aqui he fet un metode abstracte perquè cada animal té un tractament diferent. Retornarà el grau d'afectació després de fer el tractament.
    }
}