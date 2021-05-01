namespace WebLab1.ViewModels
{
    public class Calculation
    {
        public int First;
        public int Second;
        public string Sum;
        public string Sub;
        public string Mult;
        public string Div;

        public Calculation(int first, int second, string sum, string sub, string mult, string div)
        {
            First = first;
            Second = second;
            Sum = sum;
            Sub = sub;
            Mult = mult;
            Div = div;
        }
    }
}
