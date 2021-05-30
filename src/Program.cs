using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_ciklus_gyak1
{
    class Program
    {
        static void Main(string[] args)
        {
            //03.17.Készítsen konzolos alkalmazást, amely mezőgazdasági jóslást végez.A program kérje be a rozs mennyiségét tonnában. 
            //Ez alapján számolja ki egy véletlenszerűen generált szorzóval(3 - 20) a várható hozamot, majd írja ki illetve a következő sorba a mennyiségét is.
            //A szorzó(hozam) alapján elemezze és írja ki, hogy milyen év várható:
            //átlag alatti(3 - 8), átlagos év(9 - 15), átlag feletti(15 - 20)

            Console.WriteLine("Ez a program mezőgazdasági jóslást végez.");
            Console.WriteLine("Kérem adja meg a rozs mennyiséget tonnában!");
            int rozs = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int hozam = rnd.Next(3, 20);
            Console.WriteLine("A hozam rátája: " + hozam);
            double evvhozaml1 = (double)hozam / 100;
            double evvhozam1 = rozs * evvhozaml1;
            double hozamLvege = rozs + evvhozam1;
            if (hozam <= 8)
            {
                Console.WriteLine("A hozamunk: " + hozam + "%" + " ezért átlag alatti hozamunk lesz az éven.");
                Console.WriteLine("A várható hozam mennyisége: " + evvhozam1 + " tonna rozs.");
                Console.WriteLine("A összmennyiség az év végén a hozammal együtt: " + hozamLvege + " tonna rozs.");

            }
            else if (hozam > 8&&hozam<16)
            {
                Console.WriteLine("A hozamunk: "+ hozam+"%" +" ezért átlagos hozamunk lesz az éven.");
                Console.WriteLine("A várható hozam mennyisége: " + evvhozam1 + " tonna rozs.");
                Console.WriteLine("A összmennyiség az év végén a hozammal együtt: " + hozamLvege + " tonna rozs.");

            }
            else if (hozam> 15)
            {

                Console.WriteLine("A hozamunk: " + hozam + "%" + " ezért átlag feletti hozamunk lesz az év végén.");
                Console.WriteLine("A várható hozam mennyisége: " + evvhozam1 + " tonna rozs.");
                Console.WriteLine("A összmennyiség az év végén a hozammal együtt: " + hozamLvege + " tonna rozs.");

            }








            Console.ReadLine();
            
        
        
        
        
        
        }
    }
}
