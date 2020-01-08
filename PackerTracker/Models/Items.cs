using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace PackerTracker.Models
{
    public class Packed
    {
        public string Item { get; set; }
        private static List<Packed> _instances = new List<Packed> { };

        public Packed(string item)
        {
            Item = item;
            _instances.Add(this);
        }

        public static List<Packed> GetAll()
        {
            return _instances;
        }
    }
}