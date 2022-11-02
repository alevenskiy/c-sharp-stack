using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParsingCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //.csv file directory - *ParsingCSV\ParsingCSV\bin\Debug
            string[] lines = File.ReadAllLines("Top100ChessPlayers.csv");
            List<ChessPlayer> cpList = new List<ChessPlayer>();

            for(int i = 1; i < lines.Length; i++)
            {
                ChessPlayer cp = new ChessPlayer(lines[i]);
                cpList.Add(cp);
            }

            //log.txt file directory - *ParsingCSV\ParsingCSV\bin\Debug
            using (StreamWriter sw = new StreamWriter("log.txt", false))
            {
                sw.WriteLine("");
            }

            int counter = 0;
            for(int i = 0; i < cpList.Count; i++)
            {
                if (counter < 10)
                {
                    if (cpList[i].b_year > 1980)
                    {
                        counter++;
                        using (StreamWriter sw = new StreamWriter("log.txt", true))
                        {
                            sw.WriteLine(cpList[i].ToString());
                        }
                    }
                }
                else 
                    break;
            }
        }
    }
}
