using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingCSV
{
    public class ChessPlayer
    {
        public int rank { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string country { get; set; }
        public int rating { get; set; }
        public int games { get; set; }
        public int b_year { get; set; }

        public ChessPlayer(string line)
        {
            string[] words = line.Split(';');
            rank = int.Parse(words[0]);
            name = words[1];
            title = words[2];
            country = words[3];
            rating = int.Parse(words[4]);
            games = int.Parse(words[5]);
            b_year = int.Parse(words[6]);
        }

        override public string ToString()
        {
            return $"{rank};{name};{title};{country};{rating};{games};{b_year}";
        }
        
    }
}
