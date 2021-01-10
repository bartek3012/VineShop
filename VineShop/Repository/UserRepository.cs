using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VineShop.Models.Entities;

namespace VineShop.Repository
{
    public class UserRepository : Repository
    {
        /// <summary>
        /// Sprawdzenie logowanie
        /// </summary>
        /// <param name="login">Login użytkownika</param>
        /// <param name="password">Hasło użytkownika</param>
        /// <returns></returns>
        public bool LoginCheck(string login, string password)
        {
            User loggedUser = DbContext.Users.FirstOrDefault(u => u.Login == login && u.Password == password); //Pobranie użytkownika z bazy

            if (loggedUser == null) //jeśli użytkownik nie znajdue się w bazie
            {
                MessageBox.Show("Wrong login or password! Try again", "Wrong login or password", MessageBoxButton.OK, MessageBoxImage.Warning); //Komunikat o błędzie
                return false;
            }
            else
            {
                Role role = DbContext.Roles.FirstOrDefault(r => r.Id == loggedUser.RoleId); //Pobranie role użytkownika user lub administrator
                if(String.IsNullOrEmpty(role.Name))
                {
                    MessageBox.Show("Wrong user role", "Error", MessageBoxButton.OK, MessageBoxImage.Error); //Wyświetlenie kounikatu o błędzie
                    return false;
                }
                Program.IsLogged = role.Name; //Ustawienie zmiennej sprawdzajacej kot jest zalogowany user czy administrator
                return true;
            }
            
        }
    }
}
