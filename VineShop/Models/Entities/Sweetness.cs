using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineShop.Models.Entities
{
    /// <summary>
    /// Słodkości wina
    /// </summary>
    public class Sweetness
    {
        [Key]
        public int Id { get; set; } //Id słodkości
        [Required]
        public string Name { get; set; } //Nazwa słodkości
        public virtual ICollection<Vine> Vines { get; set; }
    }
}
