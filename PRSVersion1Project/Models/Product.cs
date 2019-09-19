﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSVersion1Project.Models
{
    public partial class Product
    {
        public Product()
        {            
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string PartNbr { get; set; }
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(30)]
        public string Unit { get; set; }
        [MaxLength(255)]
        public string PhotoPath { get; set; }
        [Required]
        public int VendorId { get; set; }

        public virtual Vendor Vendor { get; set; }

        

    }
}
