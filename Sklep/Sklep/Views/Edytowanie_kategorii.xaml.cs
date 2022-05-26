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
    /// Interaction logic for Edytowanie_kategorii.xaml
    /// </summary>
    public partial class Edytowanie_kategorii : ThemedWindow
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public Edytowanie_kategorii()
        {
            InitializeComponent();
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
