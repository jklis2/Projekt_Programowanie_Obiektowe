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
    /// Interaction logic for Usuwanie_dostawcy.xaml
    /// </summary>
    public partial class Usuwanie_dostawcy : ThemedWindow
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public Usuwanie_dostawcy()
        {
            InitializeComponent();

            ComboBox_Dostawca.ItemsSource = dbContext.Dostawca.ToList();
        }

        public void Remove()
        {
            var nazwa_dostawcy_przyjscie = ComboBox_Dostawca.SelectedItem as Dostawca;
            var dostawca = dbContext.Dostawca.Find(nazwa_dostawcy_przyjscie.id_dostawcy);
            dbContext.Dostawca.Remove(dostawca);
            dbContext.SaveChanges();
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}