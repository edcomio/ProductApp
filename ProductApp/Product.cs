namespace ProductApp
{
    public class Product
    {
        
        public int Id;
        public string Name;
        public double Price;
        public double DiscountPercentage;

       
        public double GetDiscountedPrice()
        {
            double discountAmount = (Price * DiscountPercentage) / 100;
            return Price - discountAmount;
        }
    }
}
