using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreboard_dlouhodobka.classes
{
   public class db_race
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int db_sport { get; set; }
        public string name { get; set; }
        public int competitors { get; set; }
        public int placement { get; set; }
        public int time { get; set; }
        public string time_keep { get; set; }
        public int date { get; set; }
        public string place { get; set; }
    }
}
