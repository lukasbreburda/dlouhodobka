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

        public Database(string dbPath) //inicialization tables in database
        {
            database = new SQLiteAsyncConnection(dbPath);

            database.CreateTableAsync<db_settings>().Wait();
            database.CreateTableAsync<db_sports>().Wait();

            database.CreateTableAsync<db_race>().Wait();
            database.CreateTableAsync<db_race_content>().Wait();
            database.CreateTableAsync<db_race_values>().Wait();
            
            database.CreateTableAsync<db_training>().Wait();
            database.CreateTableAsync<db_training_content>().Wait();
            database.CreateTableAsync<db_training_values>().Wait();

            database.CreateTableAsync<db_equipment>().Wait();
            database.CreateTableAsync<db_equipment_race>().Wait();
            Debug.WriteLine(dbPath);
        }
    }
}
