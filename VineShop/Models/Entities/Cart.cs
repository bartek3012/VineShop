using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineShop.Models.Entities
{
    /// <summary>
    /// Koszyk na zakupione wina
    /// </summary>
    public class Cart
    {
        [Key]
        public int Id { get; set; } //Id zamówiennia
        [Required]
        public int Quantity { get; set; } //Ilość wina w zamówieniu
        [Required]
        public int VineId { get; set; } //Id Vina z zamówienia
        [ForeignKey ("VineId")]
        public virtual Vine Vine { get; set; } //Zamawiane wino
    }
}
