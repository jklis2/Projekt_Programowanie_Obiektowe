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
    /// Interaction logic for Edytowanie_producenta.xaml
    /// </summary>
    public partial class Edytowanie_producenta : ThemedWindow
    {
        ProducentService service = new ProducentService();

        private int ProducentID { get; set; }

        public Edytowanie_producenta()
        {
            InitializeComponent();
            ComboBox_wybierz_producenta.ItemsSource = service.GetAll();
        }

        private void Edit()
        {
            Producent producent = new Producent()
            {
                id_producenta = ProducentID,
                nazwa_producenta = Nowa_nazwa_producenta_Text.Text
            };
            service.Edit(producent);
        }

        private void ComboBox_wybierz_producenta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedValue = ComboBox_wybierz_producenta.SelectedValue as Producent;

            if (selectedValue != null)
            {

                Nowa_nazwa_producenta_Text.Text = selectedValue.nazwa_producenta;
                ProducentID = selectedValue.id_producenta;
            }
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Edit();
            this.Close();
        }
    }
}
