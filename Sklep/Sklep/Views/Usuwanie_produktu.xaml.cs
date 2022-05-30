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
    /// Interaction logic for Usuwanie_produktu.xaml
    /// </summary>
    public partial class Usuwanie_produktu : ThemedWindow
    {
        ProduktService produktService = new ProduktService();

        public Usuwanie_produktu()
        {
            InitializeComponent();

            ComboBox_Produkt.ItemsSource = produktService.GetAll();
        }

        public void Remove()
        {
            var nazwa_produktu_przyjscie = ComboBox_Produkt.SelectedItem as Produkt;
            produktService.Remove(nazwa_produktu_przyjscie.id_produktu);
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}