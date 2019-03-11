using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfAukcija
{
    [DataContract]
    [Serializable]
    public class Eksponat
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Naziv { get; set; }
        [DataMember]
        public string Cena { get; set; }
        [DataMember]
        public string IdKlijenta { get; set; }

        public Eksponat()
        {
        }
        public Eksponat(string id, string naziv, string cena)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Cena = cena;
        }
        public override string ToString()
        {
            return Naziv + ", " + Cena + ", " + IdKlijenta;
        }
    }
}