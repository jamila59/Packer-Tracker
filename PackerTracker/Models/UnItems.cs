using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace PackerTracker.Models
{
    public class UnPacked
    {
        public string Item { get; set; }
        private static List<UnPacked> _instances = new List<UnPacked> { };

        public UnPacked(string item)
        {
            Item = item;
            _instances.Add(this);
        }

        public static List<UnPacked> GetAll()
        {
            return _instances;
        }
    }
}