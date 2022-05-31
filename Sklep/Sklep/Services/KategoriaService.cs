using Sklep.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Services
{
    public class KategoriaService
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public void Add(Kategoria kategoria)
        {
            dbContext.Kategoria.Add(kategoria);
            dbContext.SaveChanges();
        }

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

        public void Remove(int KategoriaID)
        {
            var kategoria = dbContext.Kategoria.Find(KategoriaID);
            dbContext.Kategoria.Remove(kategoria);
            dbContext.SaveChanges();
        }

        public List<Kategoria> GetAll()
        {
            return dbContext.Kategoria.ToList();
        }

        public Kategoria Find(int id)
        {
            return dbContext.Kategoria.Find(id);
        }
    }
}
