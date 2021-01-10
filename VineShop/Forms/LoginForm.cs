using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VineShop.Repository;

namespace VineShop
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Zmienna do komunikacji z bazą danych
        /// </summary>
        private readonly UserRepository UserRepository = new UserRepository();
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Po kliknięciu w textBox następuje wykazowanie w nich danych, aby użytkownik mógł od razu je wprowadzić
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";
        }

        /// <summary>
        /// Przycisk logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(UserRepository.LoginCheck(textBoxLogin.Text, textBoxPassword.Text) == true) //Jeśli dane są porpawne następuje zamknięcie karty do logowania
            {
                this.Close();
            }
        }
    }
}
