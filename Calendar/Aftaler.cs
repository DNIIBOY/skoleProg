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

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.GetEncoding("iso-8859-1"))){
                String s = "";
                while ((s = sr.ReadLine()) != null){
                    if (s.Split(";")[0] == date.ToString("dd-MM-yyyy")){
                        aftaler += s + "\n";
                    }
                }
                return aftaler;
            }
        }

        public string LoadDagbog(DateTime date){
            string dateString = date.ToString("dd-MM-yyyy");
            if (!(File.Exists(dateString + ".txt"))){
                return "Kære Dagbog";
            }
            else{
                return File.ReadAllText(dateString + ".txt");
            }
        }

        public void Save(DateTime date, string tidspunkt, string aftale, string dagbog){
            String path = @"aftaler.csv";
            using (StreamWriter sw = File.AppendText(path)){
                sw.WriteLine($"{date.ToString("dd-MM-yyyy")};{tidspunkt};{aftale}");
            }
            
            string dateString = date.ToString("dd-MM-yyyy") + ".txt";
            using (StreamWriter sw = File.CreateText(dateString)){
                sw.WriteLine(dagbog);
            }
        }
    }
}
