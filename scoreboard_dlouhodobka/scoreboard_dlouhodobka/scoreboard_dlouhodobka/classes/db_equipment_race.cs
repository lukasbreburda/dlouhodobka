using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreboard_dlouhodobka.classes
{
    public class db_equipment_race
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int db_equipment { get; set; }
        public int db_race { get; set; }
    }
}
