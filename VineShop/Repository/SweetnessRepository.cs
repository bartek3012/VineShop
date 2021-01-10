using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineShop.Models.Entities;

namespace VineShop.Repository
{
    public class SweetnessRepository : Repository
    {
        /// <summary>
        /// Zwrócenie Id na podstawie podanej nazwy
        /// </summary>
        /// <param name="name">Nazwa</param>
        /// <returns></returns>
        public int GetIdSweetnessByName(string name)
        {
            Sweetness sweetness = DbContext.Sweetnesses.SingleOrDefault(b => b.Name == name);
            return sweetness.Id;
        }

        /// <summary>
        /// Zwrócenie listy ze słodkościami win
        /// </summary>
        /// <returns></returns>
        public List<Sweetness> GetSweetness()
        {
            return DbContext.Sweetnesses.ToList();
        }
    }
}
