using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineShop.Models.Entities;

namespace VineShop.Repository
{
    public class BrandRepository : Repository
    {
        /// <summary>
        /// Zwrócenie dostępnych marek win
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetBrands()
        {
            return DbContext.Brands.ToList();
        }

        /// <summary>
        /// Zwrócenie Id na podstawie podanej nazwy
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetIdBrandByName(string name)
        {
            Brand brand = DbContext.Brands.First(b => b.Name == name);
            return brand.Id;
        }

        /// <summary>
        /// Dodanie marki wina
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int AddBrand(string name)
        {
            //Stworzenie marki
            Brand brandToAdd = new Brand()
            {
                Name = name
            };
            //Dodanie marki i zapisanie zmian
            DbContext.Brands.Add(brandToAdd);
            return DbContext.SaveChanges();
        }

        /// <summary>
        /// Edycja wybranej marki
        /// </summary>
        /// <param name="nameBrandToEdit">Nazwa marki do edycji</param>
        /// <param name="newNameBrand">Nowa nazwa marki</param>
        /// <returns></returns>
        public int EditBrand(string nameBrandToEdit, string newNameBrand)
        {
            Brand brandToEdit = DbContext.Brands.SingleOrDefault(b => b.Name == nameBrandToEdit); //Pobranie marki o danej nazwie
            brandToEdit.Name = newNameBrand; //Zaminan nazwy
            return DbContext.SaveChanges(); //Zapisanie zmian
        }
    }
}
