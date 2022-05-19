using DevExpress.Xpf.Core;
using Sklep.DataBase;
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
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public Usuwanie_produktu()
        {
            InitializeComponent();

            ComboBox_Produkt.ItemsSource = dbContext.Produkt.ToList();
        }

        public void Remove()
        {
            var nazwa_produktu_przyjscie = ComboBox_Produkt.SelectedItem as Produkt;
            var produkt = dbContext.Produkt.Find(nazwa_produktu_przyjscie.id_produktu);
            dbContext.Produkt.Remove(produkt);
            dbContext.SaveChanges();
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}