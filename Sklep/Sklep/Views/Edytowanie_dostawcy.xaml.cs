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
    /// Interaction logic for Edytowanie_dostawcy.xaml
    /// </summary>
    public partial class Edytowanie_dostawcy : ThemedWindow
    {
        DostawcaService service = new DostawcaService();

        private int DostawcaID { get; set; }

        public Edytowanie_dostawcy()
        {
            InitializeComponent();
            ComboBox_wybierz_dostawce.ItemsSource = service.GetAll();
        }

        private void Edit()
        {
            Dostawca dostawca = new Dostawca()
            {
                id_dostawcy = DostawcaID,
                nazwa_dostawcy = Nowa_nazwa_dostawcy_Text.Text
            };
            service.Edit(dostawca);
        }

        private void ComboBox_wybierz_dostawce_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedValue = ComboBox_wybierz_dostawce.SelectedValue as Dostawca;

            if(selectedValue != null){

                Nowa_nazwa_dostawcy_Text.Text = selectedValue.nazwa_dostawcy;
                DostawcaID = selectedValue.id_dostawcy;
            }
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Edit();
            this.Close();
        }
    }
}
