﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{

    [Table("publishers")]
    public class Publisher
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }


        
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
