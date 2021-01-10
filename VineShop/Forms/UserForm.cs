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
using VineShop.ViewModel;

namespace VineShop.Forms
{
    public partial class UserForm : Form
    {
        private readonly CartsRepository CartsRepository = new CartsRepository();
        private double totalToPay = 0;
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            userControlToBuy.LoadGrid(); //Załadowanie tabeli z winami do zakupu
            loginCartDataGrid(); //Załadowanie tabeli (koszyka)
        }

        /// <summary>
        /// Meotda rozszeżajaca odświeżenie dataGrida o ustawienia stylistyczne tabeli
        /// </summary>
        private void loginCartDataGrid()
        {
            RefreshCartDataGrid();
            dataGridViewCart.Columns["Id"].Width = 40;
            dataGridViewCart.Columns["Price"].Width = 90;
            dataGridViewCart.Columns["Price"].HeaderText = "Price [$]";
            dataGridViewCart.Columns["YearOfProduction"].Width = 80;
            dataGridViewCart.Columns["YearOfProduction"].HeaderText = "Vintage";
            dataGridViewCart.Columns["Name"].Width = 180;
            dataGridViewCart.Columns["Type"].Width = 80;
            dataGridViewCart.Columns["Brand"].Width = 180;
            dataGridViewCart.Columns["Size"].Width = 80;
            dataGridViewCart.Columns["Size"].HeaderText = "Size [l]";
            dataGridViewCart.Columns["Quantity"].Width = 80;

            dataGridViewCart.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen; //Kolor nagłówków na zielony
            dataGridViewCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; //Kolor czcionki na biały
            dataGridViewCart.EnableHeadersVisualStyles = false;
        }

        /// <summary>
        /// Odświeżenie dataGrida
        /// </summary>
        private void RefreshCartDataGrid()
        {
            dataGridViewCart.DataSource = CartsRepository.GetVineFromCart();
        }

        /// <summary>
        /// Zwiększenie ilości win do zamównienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIncrese_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(labelQuantity.Text);
            if(quantity < 99)
            {
                quantity++;
                labelQuantity.Text = quantity.ToString();
            }
        }

        /// <summary>
        /// Zmniejszenie ilości win do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDecrase_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(labelQuantity.Text);
            if (quantity > 1)
            {
                quantity--;
                labelQuantity.Text = quantity.ToString();
            }
        }

        /// <summary>
        /// Przycisk dodania wina do karty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            VineViewModel selectedVineViewModel = userControlToBuy.GetSelectedVine(); //Pobranie zanaczoengo wina
            if (CartsRepository.AddVineToCart(selectedVineViewModel, Int32.Parse(labelQuantity.Text))) //Jesli dodanie wina zakończy się pomyślnie
            {
                //Zatualizacja ceny do zapłaty i odświeżenie tabeli
                double price = selectedVineViewModel.Price;
                totalToPay = totalToPay + price * Int32.Parse(labelQuantity.Text);
                labelTotalToPayValue.Text = totalToPay.ToString() + " $";
                RefreshCartDataGrid();
                labelQuantity.Text = "1";
            }
            else
            {
                MessageBox.Show("Wrong values", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Wyświetlenie konunikatu o błędzie
            }
            
        }

        /// <summary>
        /// Przycisk do usunięcia wina z koszyka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CartViewModel selectedVine = (CartViewModel)dataGridViewCart.CurrentRow.DataBoundItem; //Pobranie zaznaczonego elementu z koszyka
            CartsRepository.DeleteByViewModel(selectedVine); //Wywołanie matody do jej usunięcia

            //Aktualizacja kwoty do zapłaty i odwieżenie dataGrida
            double price = selectedVine.Price;
            double quantity = selectedVine.Quantity;
            totalToPay = totalToPay - price * quantity;
            labelTotalToPayValue.Text = totalToPay.ToString() + " $";
            RefreshCartDataGrid();
        }

        /// <summary>
        /// Przycisk do zakupu wina z karty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            //Zapytanie użytkownika czy na pewno chce złożyć zamówienie na podaną kwotę
            var answer = MessageBox.Show($"Do you want to make an order for {totalToPay} $?", "Confirm your order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                //Jeśli tak - przyjęcie zmaówienia i usuniecie wina z koszyka
                MessageBox.Show("You have created your order successful!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CartsRepository.DeleteAllFromCart();
                totalToPay = 0;
                labelTotalToPayValue.Text = "0 $";
                RefreshCartDataGrid();
            }
            
        }

        /// <summary>
        /// Usunięcia danych z koszyka gdy apliakcja jest zamykana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CartsRepository.DeleteAllFromCart();
        }
    }
}
