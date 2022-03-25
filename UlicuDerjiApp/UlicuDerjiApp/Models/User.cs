using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace UlicuDerjiApp.Models
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int StreetID { get; set; }
    }
}
