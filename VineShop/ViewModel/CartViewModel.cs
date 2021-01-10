using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineShop.Models.Entities;

namespace VineShop.ViewModel
{
    /// <summary>
    /// Model do wyświetlania kszyka, który rozszeża model do wyświeltania wina o ilość
    /// </summary>
    public class CartViewModel : VineViewModel
    {
        public int Quantity { get; set; } //Ilosć sztuk wina

    }
}
