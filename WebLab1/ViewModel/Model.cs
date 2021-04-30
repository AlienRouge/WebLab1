using System;

namespace WebLab1.ViewModel
{
    public class Operations
    {
        public Operations()
        {
            var rand = new Random();
            First = rand.Next(0, 10);
            Second = rand.Next(0, 10);
        }
        public int First { get; set; }
        public int Second { get; set; }
        public string Sum()
        {
            return First +" + "+Second+" = "+(First + Second);
        }
        public string Sub()
        {
            return First + " - " + Second + " = " + (First - Second);
        }
        public string Mult()
        {
            return First + " * " + Second + " = " + (First * Second);
        }
        public string Div()
        {
            if (Second == 0)
            {
                return "Division by 0";
            }
            return First + " / " + Second + " = " + (First / Second);
        }
    }
}
