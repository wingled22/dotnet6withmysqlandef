using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sampleMVC.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Name { get; set; } = null!;
        public string Units { get; set; } = null!;
        public int Stocks { get; set; }
        public string? Status { get; set; } = null;
    }
}
