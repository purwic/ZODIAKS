using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ZODIAKS.Models
{
    public class Zodiak
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Symbol { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }

    }
}
