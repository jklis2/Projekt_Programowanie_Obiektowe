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
    /// Interaction logic for Usuwanie_kategorii.xaml
    /// </summary>
    public partial class Usuwanie_kategorii : ThemedWindow
    {
        KategoriaService kategoriaService = new KategoriaService();

        public Usuwanie_kategorii()
        {
            InitializeComponent();

            ComboBox_Kategoria.ItemsSource = kategoriaService.GetAll();
        }

        private void Remove()
        {
            var nazwa_kategorii_przyjscie = ComboBox_Kategoria.SelectedItem as Kategoria;
            kategoriaService.Remove(nazwa_kategorii_przyjscie.id_kategorii);
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}