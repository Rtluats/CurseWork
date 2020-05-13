﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseWork
{
    public class Order
    {
        [Key, Column(Order = 1)]
        public int FoodId { get; set; }

        [Key, Column(Order = 2)]
        public int IdOrderList { get; set; }

        public decimal PriceBoughtFor { get; set; }

        public int Count { get; set; }

        public virtual Food Food { get; set; }

        public virtual OrderList OrderList { get; set; }
    }
}
