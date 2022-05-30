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
    /// Interaction logic for Dodawanie_produktu.xaml
    /// </summary>
    public partial class Dodawanie_produktu : ThemedWindow
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();
        DostawcaService dostawcaService = new DostawcaService();
        ProduktService produktService = new ProduktService();
        KategoriaService kategoriaService = new KategoriaService();

        public Dodawanie_produktu()
        {
            InitializeComponent();
            SetCheckBoxes();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SetCheckBoxes()
        {
            Kategoria_produktu_Text.ItemsSource = kategoriaService.GetAll();
            Nazwa_producenta_Text.ItemsSource = dbContext.Producent.ToList();
            Nazwa_dostawcy_Text.ItemsSource = dostawcaService.GetAll();
        }

        private void Save()
        {
            string cena_przyjscie = Cena_produktu_Text.Text;
            var cena = decimal.Parse(cena_przyjscie);

            string ilosc_sztuk_w_sklepie_przyjscie = Ilosc_sztuk_w_sklepie_Text.Text;
            var ilosc_sztuk_w_sklepie = int.Parse(ilosc_sztuk_w_sklepie_przyjscie);

            var kategoria_produktu_przyjscie = Kategoria_produktu_Text.SelectedItem as Kategoria;

            var nazwa_producenta_przyjscie = Nazwa_producenta_Text.SelectedItem as Producent;

            var nazwa_dostawcy_przyjscie = Nazwa_dostawcy_Text.SelectedItem as Dostawca;

            Produkt produkt = new Produkt()
            {
                nazwa_produktu = Nazwa_produktu_Text.Text,
                opis_produktu = Opis_produktu_Text.Text,
                id_kategorii = kategoria_produktu_przyjscie.id_kategorii,
                id_dostawcy = nazwa_dostawcy_przyjscie.id_dostawcy,
                id_producenta = nazwa_producenta_przyjscie.id_producenta,
                cena = cena,
                ilosc_sztuk_w_sklepie =ilosc_sztuk_w_sklepie,
                data_kolejnej_dostawy = Data_kolejnej_dostawy_Text.DateTime,
            };

            produktService.Add(produkt);
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Save();
            this.Close();
        }
    }
}