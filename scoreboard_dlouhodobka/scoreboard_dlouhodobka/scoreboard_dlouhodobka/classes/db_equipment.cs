using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreboard_dlouhodobka.classes
{
    public class db_equipment
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int db_spors { get; set; }
        public string name { get; set;}
        public int date { get; set; }
        public string keep { get; set; }

    }
}
