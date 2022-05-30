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
    /// Interaction logic for Edytowanie_kategorii.xaml
    /// </summary>
    public partial class Edytowanie_kategorii : ThemedWindow
    {
        KategoriaService kategoriaService = new KategoriaService();

        private int KategoriaID { get; set; }

        public Edytowanie_kategorii()
        {
            InitializeComponent();
            ComboBox_wybierz_kategorie.ItemsSource = kategoriaService.GetAll();
        }

        private void Edit()
        {
            Kategoria kategoria = new Kategoria()
            {
                id_kategorii = KategoriaID,
                nazwa_kategorii = Nowa_nazwa_kategorii_Text.Text
            };
            kategoriaService.Edit(kategoria);
        }

        private void ComboBox_wybierz_kategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedValue = ComboBox_wybierz_kategorie.SelectedValue as Kategoria;

            if (selectedValue != null)
            {

                Nowa_nazwa_kategorii_Text.Text = selectedValue.nazwa_kategorii;
                KategoriaID = selectedValue.id_kategorii;
            }
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Edit();
            this.Close();
        }
    }
}
