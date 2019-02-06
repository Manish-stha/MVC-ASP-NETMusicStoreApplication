using System.Collections.Generic;
using MusicApplication.Models;

namespace MusicApplication.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}