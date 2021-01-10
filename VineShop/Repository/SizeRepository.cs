using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineShop.Models.Entities;

namespace VineShop.Repository
{
    public class SizeRepository : Repository
    {
        /// <summary>
        /// Zwrócenie Id na podstawie podanej nazwy
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int GetIdSizeByName(double value)
        {
            Size size = DbContext.Sizes.SingleOrDefault(b => b.Value == value);
            return size.Id;
        }

        /// <summary>
        /// Zwrócenie dostępnych wielkości win
        /// </summary>
        /// <returns></returns>
        public List<Size> GetSize()
        {
            return DbContext.Sizes.ToList();
        }
    }
}
