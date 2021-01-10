using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineShop.Models.Entities
{
    /// <summary>
    /// Przechowuje role użytkownika (user lub admin)
    /// </summary>
    public class Role
    {
        [Key]
        public int Id { get; set; } //Id roli

        [Required]
        public string Name { get; set; } //Nazwa roli
        public virtual ICollection<User> Users { get; set; }
    }
}
