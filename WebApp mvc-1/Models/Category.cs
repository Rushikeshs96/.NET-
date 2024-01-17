﻿using System.ComponentModel.DataAnnotations;

namespace WebApp_mvc_1.Models
{
    public class Category
    {
        public Int64 Id { get; set; }
       
        public string? Name { get; set; }
        
        public string? Description { get; set; }
    }
}
