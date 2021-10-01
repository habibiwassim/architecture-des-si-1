﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Product: Concept
    {
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Category MyProperty { get; set; }
        public IList<Provider> Providers { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Name: " + Name + "Price: " + Price);
        }
    }
}