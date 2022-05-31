using Sklep.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Services
{
    public class ProducentService
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public void Add(Producent producent)
        {
            dbContext.Producent.Add(producent);
            dbContext.SaveChanges();
        }

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

        public void Remove(int ProducentID)
        {
            var producent = dbContext.Producent.Find(ProducentID);
            dbContext.Producent.Remove(producent);
            dbContext.SaveChanges();
        }

        public List<Producent> GetAll()
        {
            return dbContext.Producent.ToList();
        }

        public Producent Find(int id)
        {
            return dbContext.Producent.Find(id);
        }
    }
}
