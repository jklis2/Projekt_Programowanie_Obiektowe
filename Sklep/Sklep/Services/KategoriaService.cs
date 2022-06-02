using Sklep.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Services
{
    /// <summary>
    /// Serwis do obsługi modelu Kategoria
    /// </summary>
    public class KategoriaService
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        /// <summary>
        /// Metoda dodaje kategorię do bazy danych
        /// </summary>
        /// <param name="kategoria"></param>
        public void Add(Kategoria kategoria)
        {
            dbContext.Kategoria.Add(kategoria);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda szuka w badzie danych kategorię po id, a następnie ją edytuje
        /// </summary>
        /// <param name="kategoria"></param>
        public void Edit(Kategoria kategoria)
        {
            if (kategoria != null)
            {
                var item = dbContext.Kategoria.Find(kategoria.id_kategorii);

                if (item.nazwa_kategorii != null)
                {
                    item.nazwa_kategorii = kategoria.nazwa_kategorii;
                }

                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Metoda szuka w bazie danych kategorię po id, a nastepnie ją usuwa
        /// </summary>
        /// <param name="KategoriaID"></param>
        public void Remove(int KategoriaID)
        {
            var kategoria = dbContext.Kategoria.Find(KategoriaID);
            dbContext.Kategoria.Remove(kategoria);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda pobiera z bazy danych wszystkie kategorie
        /// </summary>
        /// <returns></returns>
        public List<Kategoria> GetAll()
        {
            return dbContext.Kategoria.ToList();
        }

        /// <summary>
        /// Metoda szuka kategorię po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Kategoria Find(int id)
        {
            return dbContext.Kategoria.Find(id);
        }
    }
}
