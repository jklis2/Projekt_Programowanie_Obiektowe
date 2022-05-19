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
    /// Interaction logic for Usuwanie_producenta.xaml
    /// </summary>
    public partial class Usuwanie_producenta : ThemedWindow
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();
        public Usuwanie_producenta()
        {
            InitializeComponent();

            ComboBox_Producent.ItemsSource = dbContext.Producent.ToList();
        }

        public void Remove()
        {
            var nazwa_producenta_przyjscie = ComboBox_Producent.SelectedItem as Producent;

            var producent = dbContext.Producent.Find(nazwa_producenta_przyjscie.id_producenta);
            dbContext.Producent.Remove(producent);
            dbContext.SaveChanges();
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}
