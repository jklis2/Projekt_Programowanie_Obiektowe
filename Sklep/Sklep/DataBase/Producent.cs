//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklep.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producent
    {
        public Producent()
        {
            this.Produkt = new HashSet<Produkt>();
        }
    
        public int id_producenta { get; set; }
        public string nazwa_producenta { get; set; }
    
        public virtual ICollection<Produkt> Produkt { get; set; }
    }
}
