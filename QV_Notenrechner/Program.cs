using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QV_Notenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Noten = new double[24];
            string[] ModulNr = new string[24];
            bool isValid = false;

            do
            {
                try
                {
                    for (int i = 0; i <= 24; i++)
                    {
                        Console.Write("Geben Sie die Modulnummer ein: ");
                        ModulNr[i] = Console.ReadLine();

                        Console.Write("Geben Sie ihre Note für Modul " + ModulNr + " ein: ");
                        Noten[i] = Convert.ToDouble(Console.ReadLine());

                        if (Noten[i] < 1 || Noten[i] > 6)
                        {
                            throw new Exception();
                        }
                    }
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Leider ist ein Fehler bei der Eingabe vorgelaufen");
                }

            } while (!isValid);

            Console.WriteLine("!");
            
        }
    }
}
