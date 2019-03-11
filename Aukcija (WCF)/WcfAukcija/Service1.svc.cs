using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAukcija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }






        public List<Klijent> VratiKlijente()
        {
            return ListaKlijenata.Instance.klijenti.ToList();
        }

        public Klijent LogIn(string ime, string prezime)
        {
            Klijent k = ListaKlijenata.Instance.klijenti
                .Where(x => x.Ime.Equals(ime) && x.Prezime.Equals(prezime))
                .FirstOrDefault();

            return k;
        }

        public List<Eksponat> VratiEksponate()
        {
            return ListaEksponata.Instance.eksponati.ToList();
        }

        public Eksponat VratiPrviEksponat()
        {
            return ListaEksponata.Instance.eksponati[0];
        }

        public void DodajPonudu(string cena, Klijent klijent, int trenutniBrojEksponata)
        {
            Eksponat eksponat = VratiTrenutniEksponat(trenutniBrojEksponata);
            eksponat.Cena = cena;
            eksponat.IdKlijenta = klijent.Id;
        }

        public Eksponat VratiTrenutniEksponat(int broj)
        {
            if(ListaEksponata.Instance.eksponati.Count>broj)
                return ListaEksponata.Instance.eksponati[broj];
            return null;
        }
    }
}
