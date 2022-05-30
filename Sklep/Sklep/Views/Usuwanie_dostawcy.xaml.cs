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
    /// Interaction logic for Usuwanie_dostawcy.xaml
    /// </summary>
    public partial class Usuwanie_dostawcy : ThemedWindow
    {
        DostawcaService service = new DostawcaService();

        public Usuwanie_dostawcy()
        {
            InitializeComponent();

            ComboBox_Dostawca.ItemsSource = service.GetAll();
        }

        public void Remove()
        {
            var nazwa_dostawcy_przyjscie = ComboBox_Dostawca.SelectedItem as Dostawca;

            service.Remove(nazwa_dostawcy_przyjscie.id_dostawcy);
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Remove();
            this.Close();
        }
    }
}