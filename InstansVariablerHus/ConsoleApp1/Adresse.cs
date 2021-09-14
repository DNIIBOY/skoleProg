using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Adresse
    {
        private string vej;
        private int nummer;
        private string by;
        private int postnummer;

        public void setVej(string vej)
        {
            if(vej != null)
            {
            this.vej = vej;
            }

        }
        public string getVej()
        {
            return vej;
        }
        public void setNummer(int nummer)
        {
            if (nummer > 0)
            {
                this.nummer = nummer;
            }

        }
        public int getNummer()
        {
            return nummer;
        }
        public void setBy(string by)
        {
            if (by != null)
            {
                this.by = by;
            }

        }
        public string getBy()
        {
            return by;
        }
        public void setPostnummer(int postnummer)
        {
            if (postnummer > 0)
            {
                this.postnummer = postnummer;
            }
        }
        public int getPostnummer()
        {
            return postnummer;
        }
    }
}
