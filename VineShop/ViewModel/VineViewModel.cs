using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineShop.ViewModel
{
    /// <summary>
    /// Model w wiświetlania wina
    /// </summary>
    public class VineViewModel
    {
        public int Id { get; set; } //Id wina
        public int Price { get; set; } //Cena wina
        public int YearOfProduction { get; set; } //Rok produkcji wina
        public string Name { get; set; } //Nazwa wina

        public string Type { get; set; } //Typ wina 
        public string Sweetness { get; set; } //Słodkość wina
        public string Brand { get; set; } //Marka wina
        public double Size { get; set; } //Rozmiar (objętośc w litrach) wina
    }
}
