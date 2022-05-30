using Sklep.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Services
{
    public class DostawcaService
    {
        Asortyment_sklepuEntities dbContext = new Asortyment_sklepuEntities();

        public void Add(Dostawca dostawca)
        {
            dbContext.Dostawca.Add(dostawca);
            dbContext.SaveChanges();
        }

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

        public void Remove(int DostawcaID)
        {
            var dostawca = dbContext.Dostawca.Find(DostawcaID);
            dbContext.Dostawca.Remove(dostawca);
            dbContext.SaveChanges();
        }

        public List<Dostawca> GetAll()
        {
            return dbContext.Dostawca.ToList();
        }
    }
}
