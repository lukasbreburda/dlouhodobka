using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreboard_dlouhodobka.classes
{
    public class Database
    {
        private SQLiteAsyncConnection database;

        public Database(string dbPath) //inicializace tabulek databáze 
        {
            
            Debug.WriteLine(dbPath);
        }
    }
}
