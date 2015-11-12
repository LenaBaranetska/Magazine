using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magazine.Infrastructure
{
    public class Product
    {
        public string Nmae { get; set; } // i dont like this property name
        public int Id { get; set; }
        public double Price { get; set; }
		
		public string Description {get;set;}

    }
}