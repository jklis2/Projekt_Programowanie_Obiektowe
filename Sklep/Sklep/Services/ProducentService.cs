using Sklep.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Services
{
    /// <summary>
    /// Serwis do obsługi modelu Producent
    /// </summary>
    public class ProducentService
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        /// <summary>
        /// Metoda dodaje producenta do bazy danych
        /// </summary>
        /// <param name="producent"></param>
        public void Add(Producent producent)
        {
            dbContext.Producent.Add(producent);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda szuka w badzie danych producenta po id, a następnie go edytuje
        /// </summary>
        /// <param name="producent"></param>
        public void Edit(Producent producent)
        {
            if (producent != null)
            {
                var item = dbContext.Producent.Find(producent.id_producenta);

                if (item.nazwa_producenta != null)
                {
                    item.nazwa_producenta = producent.nazwa_producenta;
                }

                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Metoda szuka w bazie danych producenta po id, a nastepnie go usuwa
        /// </summary>
        /// <param name="ProducentID"></param>
        public void Remove(int ProducentID)
        {
            var producent = dbContext.Producent.Find(ProducentID);
            dbContext.Producent.Remove(producent);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda pobiera z bazy danych wszystkich producentów
        /// </summary>
        /// <returns></returns>
        public List<Producent> GetAll()
        {
            return dbContext.Producent.ToList();
        }

        /// <summary>
        /// Metoda szuka producenta po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Producent Find(int id)
        {
            return dbContext.Producent.Find(id);
        }
    }
}
