using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineShop.Models.Entities
{
    //Klasa reprezentująca wina
    public class Vine
    {

        [Key]
        public int Id { get; set; } //Id wina
        [Required]
        public int Price { get; set; } //Cena wina
        [Required]
        public int YearOfProduction { get; set; } //Rok produkacji wina
        [Required]
        public string Image { get; set; } //Nazwa pliku z grafiką wina

        [Required]
        public string Name { get; set; } //Nazwa wina

        [Required]
        public int TypeId { get; set; } //Id typu wina
        [ForeignKey ("TypeId")]
        public virtual Type Type { get; set; } //Typ wina

        [Required]
        public int SweetnessId { get; set; } //Id słodkosci wina
        [ForeignKey ("SweetnessId")]
        public virtual Sweetness Sweetness { get; set; } //Słodkosć wina

        [Required]
        public int BrandId { get; set; } //Id marki wina
        [ForeignKey ("BrandId")]
        public virtual Brand Brand { get; set; } //Marka wina

        [Required]
        public int SizeId { get; set; } //Id rozmiaru (objętości) wina
        [ForeignKey("SizeId")]
        public virtual Size Size { get; set; } //Rozmiar (objętość w litrach) wina

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
