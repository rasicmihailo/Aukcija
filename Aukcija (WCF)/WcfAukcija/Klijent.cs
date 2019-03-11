using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfAukcija
{
    [DataContract]
    [Serializable]
    public class Klijent
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Ime { get; set; }
        [DataMember]
        public string Prezime { get; set; }
        
        public Klijent()
        {
        }
        public Klijent(string Id, string ime, string prezime)
        {
            this.Id = Id;
            this.Ime = ime;
            this.Prezime = prezime;
        }
        public override string ToString()
        {
            return Id + " " + Ime + " " + Prezime;
        }
    }
}