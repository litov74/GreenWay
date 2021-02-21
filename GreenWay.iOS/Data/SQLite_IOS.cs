using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using GreenWay.Data;
using System.IO;
using GreenWay.iOS.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace GreenWay.iOS.Data
{
    public class SQLite_IOS: ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection() 
        {
            var fileName = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }


    }
}