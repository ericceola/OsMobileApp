using System;
using SQLite;

namespace OsMobile.DBOsMobile
{
    public class DBConnection
    {
        
        public static SQLiteConnection Conexao()
        {
            var location = "DBOSmobile.db3";
            location = System.IO.Path.Combine(DBSqlite.Root, location);
            SQLiteConnection connect = new SQLiteConnection(location);

            return connect;
        }
    }
}
