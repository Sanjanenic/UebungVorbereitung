using System;
using System.Collections.Generic;

namespace UebungVorbereitung
{
    public static class Fuhrpark
    {
        public static  string[] AutoNames { get;  } = new string[] { "Audi", "Ford", "VW", "Mercedes" };  //read only?
        public static int[] AutosStaende { get; set; } = new int[4];
        public static string[] MotorradNames { get; } = new string[] { "Kawasaki", "Suzuki" };
        public static int[] MotorradsStaende { get; set; } = new int[2];

        public static readonly List<Auto> Autos = new List<Auto>();
        public static readonly List<Motorrad> Motorrads = new List<Motorrad>();

        //  public static List<Motorrad> Motorrads { get; }  //read onli imaju samo get, svi ostali get i set

        public static bool setKmStand(Fahrzeug fahrzeug)
        {
            if(fahrzeug is Auto)
            {
                var a = fahrzeug as Auto; //ako je auto auto je
                Autos.Add(a);
                var index = Array.FindIndex(AutoNames, row => row == a.Marke); //ovaj red vraca index marke auta koju ima var a 
                AutosStaende[index] += a.Kilometerstand; //stavlja na odgovarajuci index u listu kilometara
            }
            else if(fahrzeug is Motorrad)
            {
                //TODO
                var m = fahrzeug as Motorrad;
                var index = Array.FindIndex(MotorradNames, row => row == m.Marke);
                MotorradsStaende[index] += m.Kilometerstand;
            }

            return true;
        }

        public static int getKmStand(Fahrzeug fahrzeug)
        {
            if (fahrzeug is Auto)
            {
                var a = fahrzeug as Auto; //ako je auto auto je
                Autos.Add(a);
                var index = Array.FindIndex(AutoNames, row => row == a.Marke); //ovaj red vraca index marke auta koju ima var a 
                return AutosStaende[index]; //vraca sa odgovarajuceg indexa
            }
            else if (fahrzeug is Motorrad)
            {
                //TODO
                var m = fahrzeug as Motorrad;
                var index = Array.FindIndex(MotorradNames, row => row == m.Marke);
                return MotorradsStaende[index];
            }

            return fahrzeug.Kilometerstand;
        }

        public static void SchreibeKilometerStaende()
        {
            for (int i = 0; i < AutoNames.Length; i++)
            {
                Console.WriteLine("Auta marke: " + AutoNames[i] + " su presla : " + AutosStaende[i] + "km");
            }

            for (int i = 0; i < MotorradNames.Length; i++)
            {
                Console.WriteLine("Motori marke: " + MotorradNames[i] + " su presla : " + MotorradsStaende[i] + "km");
            }
        }
    }
}
