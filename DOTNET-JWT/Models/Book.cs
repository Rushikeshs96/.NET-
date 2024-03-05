﻿using System;
using System.Collections.Generic;

namespace DOTNET_JWT.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public int? Price { get; set; }
        public string? BookType { get; set; }
        public DateOnly? CreateDate { get; set; }
    }
}
