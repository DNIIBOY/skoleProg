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
            
            Adresse husAdresse = new Adresse();
            husAdresse.setVej(vej);
            
            Hus mitHus = new Hus();
            mitHus.setM2(m2);



            mitHus.setAdresse(husAdresse);
            
            mitHus.printInfoOmHus();


            Console.ReadLine();
        }
    }
}
