using Sklep.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Services
{
    /// <summary>
    /// Serwis do obsługi modelu Produtk
    /// </summary>
    public class ProduktService
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        /// <summary>
        /// Metoda dodaje produkt do bazy danych
        /// </summary>
        /// <param name="produkt"></param>
        public void Add(Produkt produkt)
        {
            dbContext.Produkt.Add(produkt);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda szuka w badzie danych produkt po id, a następnie go edytuje
        /// </summary>
        /// <param name="produkt"></param>
        public void Edit(Produkt produkt)
        {
            if (produkt != null)
            {
                var item = dbContext.Produkt.Find(produkt.id_produktu);

                if (item.nazwa_produktu != null)
                {
                    item.nazwa_produktu = produkt.nazwa_produktu;
                }

                if (item.opis_produktu != null)
                {
                    item.opis_produktu = produkt.opis_produktu;
                }

                if (item.cena != null)
                {
                    item.cena = produkt.cena;
                }

                if (item.ilosc_sztuk_w_sklepie != null)
                {
                    item.ilosc_sztuk_w_sklepie = produkt.ilosc_sztuk_w_sklepie;
                }

                if (item.data_kolejnej_dostawy != null)
                {
                    item.data_kolejnej_dostawy = produkt.data_kolejnej_dostawy;
                }

                if (item.id_dostawcy != null)
                {
                    item.id_dostawcy = produkt.id_dostawcy;
                }

                if (item.id_producenta != null)
                {
                    item.id_producenta = produkt.id_producenta;
                }

                if (item.id_kategorii != null)
                {
                    item.id_kategorii = produkt.id_kategorii;
                }

                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Metoda szuka w bazie danych produkt po id, a nastepnie go usuwa
        /// </summary>
        /// <param name="ProduktID"></param>
        public void Remove(int ProduktID)
        {
            var produkt = dbContext.Produkt.Find(ProduktID);
            dbContext.Produkt.Remove(produkt);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda pobiera z bazy danych wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> GetAll()
        {
            return dbContext.Produkt.ToList();
        }
    }
}
