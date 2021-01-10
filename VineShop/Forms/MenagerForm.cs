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
using VineShop.Models.Entities;
using VineShop.Repository;
using VineShop.ViewModel;

namespace VineShop.Forms
{
    
    public partial class MenagerForm : Form
    {
        private readonly VinesRepository VinesRepository = new VinesRepository();
        private readonly TypeRepository TypeRepository = new TypeRepository();
        private readonly SizeRepository SizeRepository = new SizeRepository();
        private readonly SweetnessRepository SweetnessRepository = new SweetnessRepository();
        private readonly BrandRepository BrandRepository = new BrandRepository();
        public MenagerForm()
        {
            InitializeComponent();
            RefreshComboBoxType();
            RefreshComboBoxBrand();
            RefreshComboBoxSweetness();
            RefreshComboBoxSize();
            RefreshPictureBox();
        }

        private void MenagerForm_Load(object sender, EventArgs e)
        {
            userControlToBuy.LoadGrid(); //Załadowanie dataGrida z ofertami win
            Program.ReloadWindow = false; //Ustawienie braku powtórnego załadowania okna (ustawiane jest na true w przypadku edycji rekordu)
        }            

        /// <summary>
        /// Odświeżenie ComboBoxa reprezentującego typy wina poprzez pobranie z bazy ich listy i wpisanie nazw jako item comboBoxa
        /// </summary>
        private void RefreshComboBoxType()
        {
            List<Models.Entities.Type> allTypes = TypeRepository.GetVineType();
            foreach (Models.Entities.Type type in allTypes)
            {
                comboBoxType.Items.Add(type.Name);
            }
        }

        /// <summary>
        /// Odświeżenie ComboBoxa reprezentującego marki wina poprzez pobranie z bazy ich listy i wpisanie nazw jako item comboBoxa
        /// </summary>
        private void RefreshComboBoxBrand()
        {
            List<Brand> allBrands = BrandRepository.GetBrands();
            foreach (Brand brand in allBrands)
            {
                comboBoxBrand.Items.Add(brand.Name);
            }
        }

        /// <summary>
        /// Odświeżenie ComboBoxa reprezentującego słodkości wina poprzez pobranie z bazy ich listy i wpisanie nazw jako item comboBoxa
        /// </summary>
        private void RefreshComboBoxSweetness()
        {
            List<Models.Entities.Sweetness> allSeeetness = SweetnessRepository.GetSweetness();
            foreach (Models.Entities.Sweetness sweetness in allSeeetness)
            {
                comboBoxSweetness.Items.Add(sweetness.Name);
            }
        }

        /// <summary>
        /// Odświeżenie ComboBoxa reprezentującego rozmiary wina poprzez pobranie z bazy ich listy i wpisanie nazw jako item comboBoxa
        /// </summary>
        private void RefreshComboBoxSize()
        {
            List<Models.Entities.Size> allSize = SizeRepository.GetSize();
            foreach (Models.Entities.Size type in allSize)
            {
                comboBoxSize.Items.Add(type.Value);
            }
        }

        /// <summary>
        /// Odświeżenie pictureBoxa z grafiką wina do dodania
        /// </summary>
        private void RefreshPictureBox()
        {
            string fileName = @"Images\" + textBoxFileName.Text; //nazwa pliku + folderu w ścieżce bazowej 
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName); //Ścieżka do odczytu pliku na podstawie ściążeki bazowej i nazwy pliku
            try
            {
                //jeśli otworzono plik poprawnie, następuje jego załadowanie do pictureBoxa
                Image image = Image.FromFile(path);
                pictureBoxNewVine.Image = image;
            }
            catch (Exception)
            {
                //Wyświetlenie okmunikatu o błędzie
                MessageBox.Show("File open error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metoda dodanie oferty wina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Vine vine = CreateVine(); //Pobranie danych wejściowych z kontrolek i utowrzenie na ich podstawie wina
            if(vine == null) //jeśli nie podano wszytskich danych w kontrolkach, otrzymany jest null
            {
                MessageBox.Show("You haven't entered all the data. Try again!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(VinesRepository.AddVine(vine) != 0) //jeśli dodano wino
            {
                //Odświeżenie tabeli i kontrolek wejściowych
                userControlToBuy.RefreshVineDataGrid();
                CleanInputControls();
            }
            else //w przeciwnym razie - komunikat o błędzie
            {
                MessageBox.Show("Wrong value. Try again!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        /// <summary>
        /// Metoda tworząca wino z na podstawie danych z wprowadzonych przez użytkownika
        /// </summary>
        /// <returns></returns>
        private Vine CreateVine()
        {
            if(textBoxName.Text == "")
            {
                return null;
            }
            try //jeśli któraś wartość nie została wprowadzona poprawnie zostanie zwrócony pusty obiekt
            {
                //Pobranie danych z kontrolek
                int price = Int32.Parse(textBoxPrice.Text);
                int year = Int32.Parse(textBoxYear.Text);
                string brand = comboBoxBrand.SelectedItem.ToString();
                string type = comboBoxType.SelectedItem.ToString();
                string sweetness = comboBoxSweetness.SelectedItem.ToString();
                double size = Double.Parse(comboBoxSize.SelectedItem.ToString());

                //Stworzenie obiektu wina
                Vine vine = new Vine()
                {
                    Name = textBoxName.Text,
                    Price = price,
                    YearOfProduction = year,
                    BrandId = BrandRepository.GetIdBrandByName(brand),
                    TypeId = TypeRepository.GetIdTypeByName(type),
                    SweetnessId = SweetnessRepository.GetIdSweetnessByName(sweetness),
                    SizeId = SizeRepository.GetIdSizeByName(size),
                    Image = textBoxFileName.Text
                };
                return vine;
            }
            catch (Exception)
            {
                return null; //W przypadku błędu zwrócenie null
                throw;
            }

        }

        /// <summary>
        /// Przycisk do modyfikacji elementu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModify_Click(object sender, EventArgs e)
        {
            VineViewModel viewModel = userControlToBuy.GetSelectedVine(); //Pobranie elementu do modyfikacji
            Vine vine = CreateVine(); //Stworzenie wina
            if (vine == null) //Otrzymano null, czyli wprowadzone danie nie są poprawne
            {
                MessageBox.Show("You haven't entered all the data correct. Try again!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VinesRepository.ModifyVine(viewModel.Id, vine); //Wywołanie metody do modyfikacji
            userControlToBuy.RefreshVineDataGrid(); //Odświerzenie dataGrida

            //Następuje zamknięcie i otworzenie na nowo okna, ponieważ dataGrid jest w kontrolecu userControl i po edycji rekordu pobierane dane nie są aktualne
            //Wywołanie analogicznej metody w DataGridzie który, nie znajduje się w kontrolce userControl (tylko w oknie) działa poprawinie bez ponowango załadowania okna
            //Ze wzgleu na ponieczność sporego kopiowania kodu w przypadku rezygnacji z dataGrida zastosowałem ponowne załadowanie okna
            Program.ReloadWindow = true;
            this.Close();
        }

        /// <summary>
        /// Metoda wybrania grafiki do oferty wina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUploadPicture_Click(object sender, EventArgs e)
        {
            string pathOpen; //ścieżka wybranego do otwarcia pliku
            string pathSave; //ścieżka stanowiąca Base Directory + folder ze zdjęciami + nazwa pliku

            //Przygotowanie okna dialogowego
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik do otwarcia";
            openFileDialog.Filter = "Images (*.png)|*.png|Images (*.jpg)|*.jpg";
            openFileDialog.FilterIndex = 1;

            //Jeśli użytkownik wybierze ok w oknie dialogowym
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathOpen = openFileDialog.FileName; //ścieżka z otwartym plikiem
                int index = pathOpen.LastIndexOf('\\'); //wyszukanie indeksu po którym znajduje się nazwa pliku
                string filename = pathOpen.Substring(index + 1); //na podstawie indeksu, pobrana jest nazwa pliku
                textBoxFileName.Text = filename; //wpisanie nazwy pliku w textBox
                filename = @"Images\" + filename; //dodanie folderu z grafikami zanjdującego się w baseDirectory
                pathSave = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
                try 
                {
                    File.Copy(pathOpen, pathSave); //Skopiowanie elementu z wybranej ścieżki do ścieżki do zapisu
                }
                catch(IOException) //Jeśli elemnt został już wcześniej dodany, spowoduje to błąd, który jest tutaj wyłapywany
                {
                }
                RefreshPictureBox(); //Odświerzenie podglądu wybranego obrazka
            }
        }
        /// <summary>
        /// Wyczyszczenie kontrolek wejściowych (comoboBoxy i textBoxy) + wyświetlane zdjęcie
        /// </summary>
        private void CleanInputControls()
        {
            comboBoxBrand.SelectedIndex = -1;
            comboBoxSize.SelectedIndex = -1;
            comboBoxSweetness.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
            textBoxFileName.Text = "Default.png";
            textBoxName.Text = "";
            textBoxYear.Text = "";
            textBoxPrice.Text = "";
            RefreshPictureBox();
        }

        /// <summary>
        /// Przycisk do usunięcia wina z listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            VineViewModel vineViewModel = userControlToBuy.GetSelectedVine(); //Obranie zaznaczonego wina (do usunięcia)
            VinesRepository.DeleteVine(vineViewModel.Id); //Wywołanie meotdy do usunięcia wina
            userControlToBuy.RefreshVineDataGrid(); //Odświerzenie tabeli
        }

        /// <summary>
        /// Przycisk do dodania materiału
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            if(textBoxNewBrand.Text == "") //jeśli pole tekstowe jest puste - zignoruj
            {
                return;
            }
            if(BrandRepository.AddBrand(textBoxNewBrand.Text)>0) //jeśli zmiany zostały wprowadzone
            {
                RefreshComboBoxBrand(); //odśwież comboBox z markami
                textBoxNewBrand.Text = ""; //wyczyść tekst
            }
        }
        
        /// <summary>
        /// Wywołanie przycisku do modyfikacji marki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifyBrand_Click(object sender, EventArgs e)
        {
            if(comboBoxBrand.SelectedIndex == -1) //jeśli żadna marka nie jest wybrana - wyświetlenie komunikatu
            {
                MessageBox.Show("Select brand to edit", "Select brand", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(BrandRepository.EditBrand(comboBoxBrand.SelectedItem.ToString(), textBoxNewBrand.Text)>0) //jeśli wprowadzono zmiany
            {
                //Ponowne załadowanie okna, aby zmiana nazwy marki zakutalizowała się w wyświetlanych ofertach win
                Program.ReloadWindow = true;
                this.Close();
            }
        }
    }
}
