using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VineShop.Forms;

namespace VineShop
{
    
    static class Program
    {
        public static string IsLogged = ""; //informacje czy logowanie jest poprawne i kto jest zalogowany
        public static bool ReloadWindow = false; //informacja o potrzebie ponownego załadowania okna
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Następuje sprawdzenia czy zalogował się użytkownik czy administrator
            if(IsLogged == "Client")
            {
                Application.Run(new UserForm()); //Wyświetlenie panela użytkownika
            }
            else if(IsLogged == "Admin")
            {
                Application.Run(new MenagerForm()); //Wyświetlenie panela admninistratora

                //Następuje zamknięcie i otworzenie na nowo okna, ponieważ dataGrid jest w kontrolecu userControl i po edycji rekordu z ofertą wina pobierane dane nie są aktualne
                //Wywołanie analogicznej metody w DataGridzie który, nie znajduje się w kontrolce userControl (tylko w oknie) działa poprawinie bez ponowango załadowania okna
                //Ze wzgleu na ponieczność sporego kopiowania kodu w przypadku rezygnacji z dataGrida zastosowałem ponowne załadowanie okna
                while (ReloadWindow == true)
                {
                    Application.Run(new MenagerForm()); //Wyświetlenie panela admninistratora
                }

            }
        }
    }
}
