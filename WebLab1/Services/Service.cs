using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLab1.Services
{
    public class Service
    {
        public Service()
        {
            Random rand = new Random();
            First = rand.Next(0, 10);
            Second = rand.Next(0, 10);
        }

        public int First { get; set; }
        public int Second { get; set; }

        public string Sum()
        {
            return $"{First} + {Second} = {First + Second}";
        }

        public string Sub()
        {
            return $"{First} - {Second} = {First - Second}";
        }

        public string Mult()
        {
            return $"{First} * {Second} = {First * Second}";
        }

        public string Div()
        {

            return Second != 0 ? $"{First} / {Second} = {First / Second}" : "Division by 0";
        }
    }
}