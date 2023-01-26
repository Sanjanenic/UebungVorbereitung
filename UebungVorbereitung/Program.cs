using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungVorbereitung  //als pakage in java 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen in usere Fuhrpark!");
            string input="";
            while(!input.Equals("exit"))
            {
                Console.WriteLine("Welches Fahrzeug möchten Sie fahren? (Optionen: a - Auto, m - motor, s - print)");
                 input = Console.ReadLine();

                if (input.Equals("a", StringComparison.CurrentCultureIgnoreCase)) { //Comparsion ->enum für Case Insensitive
                    
                    // Autos
                    string autos = "";
                    foreach(string auto in Fuhrpark.AutoNames) // Audi Mercedes VW
                    {
                        autos += (auto + ",");  // -> "Audi, Mercedes, VW,"
                    }

                    while (true)
                    {
                        // Trim löcht letzte ,
                        Console.WriteLine("Welches Auto wollen Sie fahren [" + autos.Trim(',') + "]");
                        string autoInput = Console.ReadLine();

                        if(Fuhrpark.AutoNames.Contains(autoInput))
                        {
                            Console.WriteLine("Wie lang ist Strecke in km die Sie fahren wollen? : ");
                            string km = Console.ReadLine();

                            if(int.TryParse(km, out int kmStand)) //tryParse lifert zurück true/false
                            {
                                Auto a = new Auto(autoInput);
                                a.Kilometerstand = kmStand;

                                Console.WriteLine("Fahre die Strecke von: " + a.Kilometerstand);
                                Console.WriteLine("Auto fuhr bisher insgesamt: " + Fuhrpark.getKmStand(a));

                                Fuhrpark.setKmStand(a);



                                Console.WriteLine("Fuhrpark: " + Fuhrpark.getKmStand(a));

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Falshe km Wert!");
                            }

                        } else
                        {
                            Console.WriteLine("Das auto existiert nicht!");
                            Console.WriteLine("Drücken Sie Eingabetaste um fortzufahren!");

                        }

                    }
                }
                else if (input.Equals("m", StringComparison.CurrentCultureIgnoreCase)) {
                   
                    string motorrad = "";
                    foreach (string m in Fuhrpark.MotorradNames) // "Kawasaki", "Suzuki" 
                    {
                        motorrad += (m + ",");  // -> "Kawasaki, Suzuki," 
                    }

                    while (true)
                    {
                        // Trim löscht , am ende 
                        Console.WriteLine("Wähhen Motorrad: [" + motorrad.Trim(',') + "]");
                        string motorradInput = " ";
                            Console.ReadLine();

                        if (Fuhrpark.MotorradNames.Contains(motorradInput))
                        {
                            Console.WriteLine("KM? : ");
                            string km = Console.ReadLine();

                            if (int.TryParse(km, out int kmStand))
                            {
                                Motorrad m = new Motorrad(motorradInput);
                                m.Kilometerstand = kmStand;

                                Console.WriteLine("Fahre die strance: " + m.Kilometerstand);
                                Console.WriteLine("Auto fush: " + Fuhrpark.getKmStand(m));

                                Fuhrpark.setKmStand(m);

                                Console.WriteLine("Fuhrpark: " + Fuhrpark.getKmStand(m));

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Falsh km Wert!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Das auto existiert nicht!");
                            Console.WriteLine("Drücken Sie Eingabetaste um fortzufahren!");
                        }

                    }
                }
                else if (input.Equals("s", StringComparison.CurrentCultureIgnoreCase)) {
                    Fuhrpark.SchreibeKilometerStaende();
                }
                else
                {
                    Console.WriteLine("Drücken Sie Eingabetaste um fortzufahren!");
                }
            }
        }
    }
}
