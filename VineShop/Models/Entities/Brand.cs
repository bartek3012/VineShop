using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineShop.Models.Entities
{
    /// <summary>
    /// Marka wina
    /// </summary>
    public class Brand
    {
        [Key]
        public int Id { get; set; } //Id marki
        [Required]
        public string Name { get; set; } //Nazwa marki
        public virtual ICollection<Vine> Vines { get; set; }
    }
}
