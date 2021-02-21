using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace GreenWay.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
