using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineShop.Models.Entities;
using VineShop.ViewModel;

namespace VineShop.Repository
{
    public class VinesRepository : Repository
    {
        /// <summary>
        /// Pobranie wszytskich win z bazy i mapowanie na model do wyświetlenia
        /// </summary>
        /// <returns></returns>
        public List<VineViewModel> GetVines()
        {
            List<Vine> vines = DbContext.Vines.ToList();
            return Mapper.Map<List<Vine>, List<VineViewModel>>(vines);
        }
        /// <summary>
        /// Zwrócenie nazwy pliku zdjecia
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetImageNameById(int id)
        {
            try
            {
                Vine selectedVine = DbContext.Vines.SingleOrDefault(v => v.Id == id);
                return selectedVine.Image;
            }
            catch //jeśli wartość nie ejst proawidłowa, zwracany jest domyślny obrazek
            {
                return "Default.png";
            }
        }

        /// <summary>
        /// Dodanie wina do bazy
        /// </summary>
        /// <param name="vine"></param>
        /// <returns></returns>
        public int AddVine(Vine vine)
        {
            DbContext.Vines.Add(vine);
            return DbContext.SaveChanges();
        }

        /// <summary>
        /// Usunięcie wina z bazy
        /// </summary>
        /// <param name="id"></param>
        public void DeleteVine(int id)
        {
            Vine vineToRemove = DbContext.Vines.SingleOrDefault(v => v.Id == id);
            DbContext.Vines.Remove(vineToRemove);
            DbContext.SaveChanges();
        }

        /// <summary>
        /// Modyfikacja zanzaczonego wina
        /// </summary>
        /// <param name="id">Id wina do edycji</param>
        /// <param name="vine">Wino z nowymi danymi do wprowadzenia</param>
        /// <returns></returns>
        public int ModifyVine(int id, Vine vine)
        {
            Vine vineToEdit = DbContext.Vines.SingleOrDefault(v => v.Id == id); //Pobranie wina o danym id
            vineToEdit.BrandId = vine.BrandId;
            vineToEdit.SizeId = vine.SizeId;
            vineToEdit.TypeId = vine.TypeId;
            vineToEdit.SweetnessId = vine.SweetnessId;
            vineToEdit.Name = vine.Name;
            vineToEdit.Image = vine.Image;
            vineToEdit.Price = vine.Price;
            vineToEdit.YearOfProduction = vine.YearOfProduction;
            return DbContext.SaveChanges();
        }
    }
}
