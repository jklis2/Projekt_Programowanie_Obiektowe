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
    /// Interaction logic for Dodawanie_dostawcy.xaml
    /// </summary>
    public partial class Dodawanie_dostawcy : ThemedWindow
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public Dodawanie_dostawcy()
        {
            InitializeComponent();
        }

        private void Save()
        {
            Dostawca dostawca = new Dostawca()
            {
                nazwa_dostawcy = Nazwa_dostawcy_Text.Text,
            };

            dbContext.Dostawca.Add(dostawca);
            dbContext.SaveChanges();

        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Save();
            this.Close();
        }
    }
}
