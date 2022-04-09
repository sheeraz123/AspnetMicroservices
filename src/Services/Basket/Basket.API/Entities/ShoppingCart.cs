namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string Username { get; set; }

        public ShoppingCart(string username)
        {
            Username = username;
        }

        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
        public decimal TotalPrice
        {

            get
            {
                decimal totalPrice = 0;
                foreach (ShoppingCartItem item in Items)
                {
                    totalPrice = item.Price * item.Quantity;
                }
                return totalPrice;
            }
        }
    }
}
