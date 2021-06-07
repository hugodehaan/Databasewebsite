using System;

namespace SendAndStore.Models
{
    public class Festival
    {

        public string Beschrijving { get; internal set; }
        public string Naam { get; internal set; }
        public DateTime Datum { get; internal set; }
        public int Id { get; internal set; }
        public decimal Prijs { get; set; }
        public string Logo { get; set; }
    }
}