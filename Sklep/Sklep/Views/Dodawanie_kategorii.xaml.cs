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
    /// Interaction logic for Dodawanie_kategorii.xaml
    /// </summary>
    public partial class Dodawanie_kategorii : ThemedWindow
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public Dodawanie_kategorii()
        {
            InitializeComponent();
        }

        private void Save()
        {
            Kategoria kategoria = new Kategoria()
            {
                nazwa_kategorii = Nazwa_kategorii_Text.Text,
            };

            dbContext.Kategoria.Add(kategoria);
            dbContext.SaveChanges();

        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Save();
            this.Close();
        }
    }
}
