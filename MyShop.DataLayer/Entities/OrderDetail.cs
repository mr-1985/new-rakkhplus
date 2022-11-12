﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataLayer.Entities
{
    public class OrderDetail
    {
        [Key]
        public int DetailId { get; set; }

        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Price { get; set; }

        [Required]
        public int Count { get; set; }


        public Order Order { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
