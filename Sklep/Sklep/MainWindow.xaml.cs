using DevExpress.Xpf.Core;
using Sklep.DataBase;
using Sklep.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sklep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public MainWindow()
        {
            InitializeComponent();

            GridControlProdukty.ItemsSource = dbContext.Produkt.ToList();
            GridControlProducenci.ItemsSource = dbContext.Producent.ToList();
            GridControlDostawcy.ItemsSource = dbContext.Dostawca.ToList();
            GridControlKategorie.ItemsSource = dbContext.Kategoria.ToList();
        }

        private void Dodawanie_produktu_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Dodawanie_produktu okno = new Dodawanie_produktu();
            okno.ShowDialog();
        }

        private void Edytowanie_produktu_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Edytowanie_produktu okno = new Edytowanie_produktu();
            okno.ShowDialog();
        }

        private void Usuwanie_produktu_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Usuwanie_produktu okno = new Usuwanie_produktu();
            okno.ShowDialog();
        }

        private void Dodaj_dostawce_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Dodawanie_dostawcy okno = new Dodawanie_dostawcy();
            okno.ShowDialog();
        }

        private void Edytuj_dostawcę_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Edytowanie_dostawcy okno = new Edytowanie_dostawcy();
            okno.ShowDialog();
        }

        private void Usun_dostawce_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Usuwanie_dostawcy okno = new Usuwanie_dostawcy();
            okno.ShowDialog();
        }

        private void Dodaj_producenta_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Dodawanie_producenta okno = new Dodawanie_producenta();
            okno.ShowDialog();
        }

        private void Edytuj_producenta_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Edytowanie_producenta okno = new Edytowanie_producenta();
            okno.ShowDialog();
        }

        private void Usun_producenta_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Usuwanie_producenta okno = new Usuwanie_producenta();
            okno.ShowDialog();
        }

        private void Dodaj_kategorie_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Dodawanie_kategorii okno = new Dodawanie_kategorii();
            okno.ShowDialog();
        }

        private void Edytuj_kategorie_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Edytowanie_kategorii okno = new Edytowanie_kategorii();
            okno.ShowDialog();
        }

        private void Usun_kategorie_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Usuwanie_kategorii okno = new Usuwanie_kategorii();
            okno.ShowDialog();
        }

        private void Odśwież_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            GridControlProdukty.ItemsSource = dbContext.Produkt.ToList();
            GridControlProducenci.ItemsSource = dbContext.Producent.ToList();
            GridControlDostawcy.ItemsSource = dbContext.Dostawca.ToList();
            GridControlKategorie.ItemsSource = dbContext.Kategoria.ToList();

            GridControlProdukty.RefreshData();
            GridControlProducenci.RefreshData();
            GridControlDostawcy.RefreshData();
            GridControlKategorie.RefreshData();
        }
    }
}
