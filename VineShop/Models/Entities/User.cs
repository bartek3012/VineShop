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
    /// Klasa reprezentująca użytkowników
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; } //Id użytkownika
        [Required]
        [MaxLength(20)]
        public string Login { get; set; } //Login użytkownika
        [Required]
        [MaxLength(20)]
        public string Password { get; set; } //Hasło użytkownika
        [Required]
        public int RoleId { get; set; } //Id roli użytkownika
        [ForeignKey ("RoleId")]
        public virtual Role Role { get; set; } //Rola użytkownika
    }
}
