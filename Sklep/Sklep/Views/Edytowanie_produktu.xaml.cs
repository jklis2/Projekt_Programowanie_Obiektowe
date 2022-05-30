using DevExpress.Xpf.Core;
using Sklep.DataBase;
using Sklep.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Sklep.Views
{
    /// <summary>
    /// Interaction logic for Edytowanie_produktu.xaml
    /// </summary>
    public partial class Edytowanie_produktu : ThemedWindow
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();
        DostawcaService dostawcaService = new DostawcaService();
        ProduktService produktService = new ProduktService();
        KategoriaService kategoriaService = new KategoriaService();

        public Edytowanie_produktu()
        {
            InitializeComponent();

            SetCheckBoxes();
        }

        private void SetCheckBoxes()
        {
            Nazwa_produktu_Text1.ItemsSource = produktService.GetAll();
            Kategoria_produktu_Text.ItemsSource = dostawcaService.GetAll();
            Nazwa_producenta_Text.ItemsSource = dbContext.Producent.ToList();
            Nazwa_dostawcy_Text.ItemsSource = dostawcaService.GetAll();
        }

        private void Edit()
        {
            string cena_przyjscie = Cena_produktu_Text.Text;
            var cena = decimal.Parse(cena_przyjscie);

            string ilosc_sztuk_w_sklepie_przyjscie = Ilosc_sztuk_w_sklepie_Text.Text;
            var ilosc_sztuk_w_sklepie = int.Parse(ilosc_sztuk_w_sklepie_przyjscie);

            var kategoria_produktu_przyjscie = Kategoria_produktu_Text.SelectedItem as Kategoria;

            var nazwa_producenta_przyjscie = Nazwa_producenta_Text.SelectedItem as Producent;

            var nazwa_dostawcy_przyjscie = Nazwa_dostawcy_Text.SelectedItem as Dostawca;

            var nazwa_produktu_przyjscie = Nazwa_produktu_Text1.SelectedItem as Produkt;

            Produkt produkt = new Produkt()
            {
                id_produktu = nazwa_produktu_przyjscie.id_produktu,
                nazwa_produktu = Nazwa_produktu_Text.Text,
                opis_produktu = Opis_produktu_Text.Text,
                id_kategorii = kategoria_produktu_przyjscie.id_kategorii,
                id_dostawcy = nazwa_dostawcy_przyjscie.id_dostawcy,
                id_producenta = nazwa_producenta_przyjscie.id_producenta,
                cena = cena,
                ilosc_sztuk_w_sklepie = ilosc_sztuk_w_sklepie,
                data_kolejnej_dostawy = Data_kolejnej_dostawy_Text.DateTime,
            };

            produktService.Edit(produkt);
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Edit();
            this.Close();
        }

        private void Nazwa_produktu_Text1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = Nazwa_produktu_Text1.SelectedItem as Produkt;

            if(item != null)
            {
                Nazwa_produktu_Text.Text = item.nazwa_produktu;
                Opis_produktu_Text.Text = item.opis_produktu;
                Cena_produktu_Text.Text = item.cena.ToString();
                Ilosc_sztuk_w_sklepie_Text.Text = item.ilosc_sztuk_w_sklepie.ToString();
                Data_kolejnej_dostawy_Text.Text = item.data_kolejnej_dostawy.ToString();
            }
        }
    }
}
