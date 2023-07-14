using TicketFlix.Data.Cart;

namespace TicketFlix.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart? ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}