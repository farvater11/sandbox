using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Custmer
    {
        private string adress;
        private int userId;
        private string name;

        public Custmer(string name, int userId)
        {
            SetName(name);
            SetUserId(userId);
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

 
        public string GetAdress()
        {
            return adress;
        }

        public void SetAdress(string value)
        {
            adress = value;
        }


        public int GetUserId()
        {
            return userId;
        }

        public void SetUserId(int value)
        {
            userId = value;
        }
    }
}