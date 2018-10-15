﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Product
    {
        int Id;
        String Name { get; set; }
        String Description { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        double Price { get; set; }
        double VAT { get; set; }
    

       
        public bool IsValid()
        {
            if (this.StartDate > this.EndDate)
            {
                return false;
            }
            return true;
        }

        public void ComputeVat()
        {
            this.VAT = 0.24 * this.Price;
        }
       

    }
   
}



