using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace tarea2_4.models
{
    public class videorecord
    {
       
            [PrimaryKey, AutoIncrement]
            public int id { get; set; }

            public string uri { get; set; }

            public string descripcion { get; set; }
        
    }
}
