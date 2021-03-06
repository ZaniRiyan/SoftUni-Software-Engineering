﻿using System;

namespace HTTPServer.Server.Models
{
    public class Cake
    {
        public Cake(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }


        public override string ToString()
        {
            string result = $"<div>name:{this.Name}</div><div>price:{this.Price:F2}</div>";

            return result;
        }
    }
}
