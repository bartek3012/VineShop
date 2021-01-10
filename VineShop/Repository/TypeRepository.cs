using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineShop.Repository
{
    public class TypeRepository : Repository
    {
        /// <summary>
        /// Zwrócenie Id na podstawie podanej nazwy
        /// </summary>
        /// <param name="name">nazwa</param>
        /// <returns></returns>
        public int GetIdTypeByName(string name)
        {
            Models.Entities.Type type = DbContext.Types.SingleOrDefault(b => b.Name == name);
            return type.Id;
        }

        /// <summary>
        /// Zwrócenie listy z typami
        /// </summary>
        /// <returns></returns>
        public List<Models.Entities.Type> GetVineType()
        {
            return DbContext.Types.ToList();
        }
    }
}
