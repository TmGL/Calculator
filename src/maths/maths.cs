namespace Calculator
{
    class Maths
    {
        public decimal addNums(decimal dec1, decimal dec2)
        {
            return decimal.Add(dec1, dec2);
        }

        public decimal divNums(decimal dec1, decimal dec2)
        {
            return decimal.Divide(dec1, dec2);
        }

        public decimal mulNums(decimal dec1, decimal dec2)
        {
            return decimal.Multiply(dec1, dec2);
        }

        public decimal subNums(decimal dec1, decimal dec2)
        {
            return decimal.Subtract(dec1, dec2);
        }
    }
}