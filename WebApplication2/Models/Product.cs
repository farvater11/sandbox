using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        private string name;
        private int id;

        public Product(string name, int id)
        {
            SetName(name);
            SetId(id);
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int value)
        {
            id = value;
        }
    }
}