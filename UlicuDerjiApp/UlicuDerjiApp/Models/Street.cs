using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace UlicuDerjiApp.Models
{
    [Table("Street")]
    public class Street
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public decimal Obshyak { get; set; }
    }
}
