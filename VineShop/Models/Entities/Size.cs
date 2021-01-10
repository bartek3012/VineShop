using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineShop.Models.Entities
{
    /// <summary>
    /// Przechowuje rozmiary win
    /// </summary>
    public class Size
    {
        [Key]
        public int Id { get; set; } //Id rozmairu
        [Required]
        public double Value { get; set; } //Objętość wina w litrach
        public virtual ICollection<Vine> Vines { get; set; }
    }
}
