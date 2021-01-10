using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineShop.Models.Entities
{
    /// <summary>
    /// Przechowuje typ (kolor) wina
    /// </summary>
    public class Type
    {
        [Key]
        public int Id { get; set; } //Id typu
        [Required]
        public string Name { get; set; } //Typ wina (czerwone, różowe, białe)
        public virtual ICollection<Vine> Vines { get; set; }
    }
}
