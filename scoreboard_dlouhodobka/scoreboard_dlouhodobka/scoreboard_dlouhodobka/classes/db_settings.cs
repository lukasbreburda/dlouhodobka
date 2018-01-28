using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreboard_dlouhodobka.classes
{
    public class db_settings
    {
        [PrimaryKey]
        public string ID { get; set; }
        public string value { get; set; }
    }
}
