using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hus
    {
        private int m2;
        private int byggeÅr;
        private Adresse adressen = new Adresse();

        public void setM2(int m2)
        {
            if (m2 < 0)
            {
                this.m2 = m2;
            }

        }
        public int getM2()
        {
            return m2;
        }

        public void setAdresse(Adresse minAdresse)
        {
            if (minAdresse !=null)
            {
                this.adressen = minAdresse;
            }
        }

        public void printInfoOmHus()
        {
          
            Console.WriteLine("Størrelsen på mit hus er på: " + m2 + " og adressen er: " + adressen.getVej() + " " + adressen.getNummer() );
        }

    }
}
