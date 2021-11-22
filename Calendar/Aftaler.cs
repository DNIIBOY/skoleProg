using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Dato
{
    public class Aftaler
    {
        public string Load(DateTime date)
        {
            String path = @"aftaler.csv";
            String aftaler = "";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.GetEncoding("iso-8859-1")))
            {
                String s = "";
                aftaler += sr.ReadLine();

                while ((s = sr.ReadLine()) != null)
                {
                    aftaler += "\n" + s;
                }
            }
            return aftaler;
        }

        public void Save(DateTime date)
        {
            //Din kode skal stå her.
        }
    }
}
