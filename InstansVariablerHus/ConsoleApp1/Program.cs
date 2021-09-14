using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast nogle oplysninger om dit hus");
            Console.Write("Hvor mange m2 er dit hus : ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Hvad år er dit hus bygget: ");
            int år = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Hvad hedder vejen dit hus ligger på:");
            string vej = Console.ReadLine();

            Console.Write("Hvad hedder vejen dit hus ligger på:");
            int husNummer = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Hvilken by bor du i?: ");
            string by = Console.ReadLine();

            Console.Write("Hvad er dit postnummer?: ");
            int postNummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------\n");

            Adresse husAdresse = new Adresse();
            husAdresse.setVej(vej);
            husAdresse.setNummer(husNummer);
            husAdresse.setBy(by);
            husAdresse.setPostnummer(postNummer);
            
            Hus mitHus = new Hus();
            mitHus.setM2(m2);
            mitHus.setAge(år);

            mitHus.setAdresse(husAdresse);
            
            mitHus.printInfoOmHus();

            Console.ReadLine();
        }
    }
}
