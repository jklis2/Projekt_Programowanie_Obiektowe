using Sklep.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Services
{
    /// <summary>
    /// Serwis do obsługi modelu Dostawca
    /// </summary>
    public class DostawcaService
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        /// <summary>
        /// Metoda dodaje dostawce do bazy danych
        /// </summary>
        /// <param name="dostawca"></param>
        public void Add(Dostawca dostawca)
        {
            dbContext.Dostawca.Add(dostawca);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda szuka w badzie danych dostawce po id, a następnie go edytuje
        /// </summary>
        /// <param name="dostawca"></param>
        public void Edit(Dostawca dostawca)
        {
          if(dostawca != null)
            {
                var item = dbContext.Dostawca.Find(dostawca.id_dostawcy);

                if (item.nazwa_dostawcy != null)
                {
                    item.nazwa_dostawcy = dostawca.nazwa_dostawcy;
                }

                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Metoda szuka w bazie danych dostawce po id, a nastepnie go usuwa
        /// </summary>
        /// <param name="DostawcaID"></param>
        public void Remove(int DostawcaID)
        {
            var dostawca = dbContext.Dostawca.Find(DostawcaID);
            dbContext.Dostawca.Remove(dostawca);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda pobiera z bazy danych wszystkich dostawców
        /// </summary>
        /// <returns></returns>
        public List<Dostawca> GetAll()
        {
            return dbContext.Dostawca.ToList();
        }

        /// <summary>
        /// Metoda szuka dostawce po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Dostawca Find(int id)
        {
            return dbContext.Dostawca.Find(id);
        }
    }
}
