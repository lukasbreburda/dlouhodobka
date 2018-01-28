using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreboard_dlouhodobka.classes
{
    public class db_race_values
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int db_race_content {get; set;}
        public string name { get; set; }
        public int vlaue { get; set; }
    }
}
