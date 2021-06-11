using System;

namespace SendAndStore.Models
{
    public class Festival
    {

        public string Beschrijving { get;  set; }
        public string Naam { get; set; }
        public DateTime Datum { get; set; }
        public int Id { get; set; }
        public decimal Prijs { get; set; }
        public string Logo { get; set; }
    }
}