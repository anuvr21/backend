﻿using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class model3
    {
        [Key]
        public string? MEMBERNUMBER { get; set; }
        public string? PROVIDERID { get; set; }

        public string? RXFILLDATA { get; set; }

        public string? RXDAYSSUPPLY { get; set; }

        public string? QUANTITY { get; set; }

        public string? UNITSOFMEASURE { get; set; }
    }
}