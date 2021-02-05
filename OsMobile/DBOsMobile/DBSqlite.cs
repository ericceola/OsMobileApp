using System;
using OsMobile.DBOsMobile.Models;
using SQLite;

namespace OsMobile.DBOsMobile
{
    public class DBSqlite
    {

       SQLiteConnection Connetion { get; }

        public static string Root { get; set; } = string.Empty;



        public DBSqlite()
        {
            var location = "DBOSmobile.db3";
            location = System.IO.Path.Combine(Root, location);
            Connetion = new SQLiteConnection(location);

            Connetion.CreateTable<Usuario>();
            Connetion.CreateTable<AssistenciaTecnica>();


        }
    }
}
