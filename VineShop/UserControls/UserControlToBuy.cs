using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VineShop.Repository;
using VineShop.ViewModel;

namespace VineShop.UserControls
{
    public partial class UserControlToBuy : UserControl
    {
        private readonly VinesRepository VinesRepository = new VinesRepository();
        public UserControlToBuy()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ustawienie obrazka w zależności od nazwy pliku
        /// </summary>
        /// <param name="fileName"></param>
        public void SetPicture(string fileName)
        {
            //Zapis następuje na ścieżce bazowej w folderze Images
            fileName = @"Images\" + fileName;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName); //Ścieżka do odczytu pliku na podstawie ściążeki bazowej i nazwy pliku
            try
            {
            Image image = Image.FromFile(path);
            pictureBoxVine.Image = image;
            pictureBoxVine.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception)
            {
                //jeśli załadowanie nie jest prawidłowe wyświetlany jest error
                MessageBox.Show("File open error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Załadowanie tabeli (wywołanie metody do odświeżania oraz kod styluzujący tabele)
        /// </summary>
        public void LoadGrid()
        {
            RefreshVineDataGrid();
            dataGridViewToBuy.Columns["Id"].Width = 40;
            dataGridViewToBuy.Columns["Price"].Width = 90;
            dataGridViewToBuy.Columns["Price"].HeaderText = "Price [$]";
            dataGridViewToBuy.Columns["YearOfProduction"].Width = 80;
            dataGridViewToBuy.Columns["YearOfProduction"].HeaderText = "Vintage";
            dataGridViewToBuy.Columns["Name"].Width = 180;
            dataGridViewToBuy.Columns["Type"].Width = 80;
            dataGridViewToBuy.Columns["Brand"].Width = 180;
            dataGridViewToBuy.Columns["Size"].Width = 80;
            dataGridViewToBuy.Columns["Size"].HeaderText = "Size [l]";

            dataGridViewToBuy.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dataGridViewToBuy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewToBuy.EnableHeadersVisualStyles = false;
        }

        /// <summary>
        /// Odświeżenia danych w tabeli
        /// </summary>
        public void RefreshVineDataGrid()
        {
            dataGridViewToBuy.DataSource = VinesRepository.GetVines();
        }

        /// <summary>
        /// Zmiana zaznaczonego elementu w tabeli z winami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewToBuy_SelectionChanged(object sender, EventArgs e)
        {
            VineViewModel vine = (VineViewModel)dataGridViewToBuy.CurrentRow.DataBoundItem;

            if (vine == null)
                return;

            //Następuje przypisanie wartości zanzaczonego wina do kontrolek
            labelBrand.Text = vine.Brand;
            labelName.Text = vine.Name;
            labelPrice.Text = vine.Price.ToString() + " $";
            labelSweetness.Text = vine.Sweetness;
            labelType.Text = vine.Type;
            labelYear.Text = vine.YearOfProduction.ToString();
            labelSize.Text = vine.Size.ToString()+ " l";
            //Ustawienie obrazka wina
            SetPicture(VinesRepository.GetImageNameById(vine.Id));
        }
        /// <summary>
        /// Zwrócenie aktualnie zaznaczonego wina
        /// </summary>
        /// <returns></returns>
        public VineViewModel GetSelectedVine()
        {
            return (VineViewModel)dataGridViewToBuy.CurrentRow.DataBoundItem;
        }
    }
}
