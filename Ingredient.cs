﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseWork
{
    public  class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public decimal? Price { get; set; }
        
        public virtual ICollection<Structure> Structures { get; set; }

        public virtual ICollection<PurchaseIngredient> purchaseIngredients { get; set; }
    }
}