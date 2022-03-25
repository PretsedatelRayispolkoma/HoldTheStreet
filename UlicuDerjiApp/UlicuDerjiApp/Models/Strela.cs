using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace UlicuDerjiApp.Models
{
    public class Strela
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string StreetId { get; set; }
    }
}
