using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineShop.Models.Entities;
using VineShop.ViewModel;

namespace VineShop.Repository
{
    public class CartsRepository : Repository
    {
        /// <summary>
        /// Zwrócenie win z koszyka
        /// </summary>
        /// <returns></returns>
        public List<CartViewModel> GetVineFromCart()
        {
            List<Cart> carts = DbContext.Carts.ToList();
            return Mapper.Map<List<Cart>, List<CartViewModel>>(carts);
        }

        /// <summary>
        /// Dodanie wina do koszyka
        /// </summary>
        /// <param name="vineViewModel">Wino do dodania</param>
        /// <param name="quantity">Ilość</param>
        /// <returns></returns>
        public bool AddVineToCart(VineViewModel vineViewModel, int quantity)
        {
            Vine vine = DbContext.Vines.SingleOrDefault(v => v.Id == vineViewModel.Id);
            Cart cart = new Cart()
            {
                VineId = vineViewModel.Id,
                Quantity = quantity,
                Vine = vine
            };
            DbContext.Carts.Add(cart);
            int result = DbContext.SaveChanges();
            if(result > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Usunięcia wina z koszuka
        /// </summary>
        /// <param name="selectedVine"></param>
        public void DeleteByViewModel(CartViewModel selectedVine)
        {
            Cart selectedCart = DbContext.Carts.SingleOrDefault(v => v.Id == selectedVine.Id);
            DbContext.Carts.Remove(selectedCart);
            DbContext.SaveChanges();
        }

        /// <summary>
        /// Usunięcie wszytskich wina z koszyka
        /// </summary>
        public void DeleteAllFromCart()
        {
            List<Cart> allVineInCart = DbContext.Carts.ToList();
            foreach(Cart cart in allVineInCart)
            {
                DbContext.Carts.Remove(cart);
            }
            DbContext.SaveChanges();
        }
    }
}
