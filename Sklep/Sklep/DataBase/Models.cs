using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.DataBase
{
    public class Models : ViewModelBase
    {
        Asortyment_sklepuEntities sklepEntities;

        public ObservableCollection<Dostawca> Dostawcy
        {
            get => GetValue<ObservableCollection<Dostawca>>();
            set => SetValue(value);
        }

        public ObservableCollection<Kategoria> Kategorie
        {
            get => GetValue<ObservableCollection<Kategoria>>();
            set => SetValue(value);
        }
        public ObservableCollection<Producent> Producenci
        {
            get => GetValue<ObservableCollection<Producent>>();
            set => SetValue(value);
        }
        public ObservableCollection<Produkt> Produkty
        {
            get => GetValue<ObservableCollection<Produkt>>();
            set => SetValue(value);
        }

        public Models()
        {
            sklepEntities = new Asortyment_sklepuEntities();

            if (IsInDesignMode)
            {
                Dostawcy = new ObservableCollection<Dostawca>();
                Kategorie = new ObservableCollection<Kategoria>();
                Producenci = new ObservableCollection<Producent>();
                Produkty = new ObservableCollection<Produkt>();
            }
            else
            {
                sklepEntities.Dostawca.Load();
                Dostawcy = sklepEntities.Dostawca.Local;
                sklepEntities.Kategoria.Load();
                Kategorie = sklepEntities.Kategoria.Local;
                sklepEntities.Producent.Load();
                Producenci = sklepEntities.Producent.Local;
                sklepEntities.Produkt.Load();
                Produkty = sklepEntities.Produkt.Local;
            }


        }
    }
}
