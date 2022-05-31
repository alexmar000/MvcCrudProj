﻿using System.ComponentModel.DataAnnotations;

namespace Lab4MVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public long ISBNNumber { get; set; }
    }
}
