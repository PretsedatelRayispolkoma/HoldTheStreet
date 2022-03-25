using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace UlicuDerjiApp.Models
{
    [Table("Shodnyak")]
    public class Shodnyak
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateOfMeeting { get; set; }
        public string UserId { get; set; }
    }
}
