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
    /// Interaction logic for Dodawanie_producenta.xaml
    /// </summary>
    public partial class Dodawanie_producenta : ThemedWindow
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public Dodawanie_producenta()
        {
            InitializeComponent();
        }

        private void Save()
        {
            Producent producent = new Producent()
            { 
                nazwa_producenta = Nazwa_producenta_Text.Text,
            };

            dbContext.Producent.Add(producent);
            dbContext.SaveChanges();

        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Save();
            this.Close();
        }
    }
}
