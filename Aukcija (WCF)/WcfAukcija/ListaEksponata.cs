using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfAukcija
{

    public class ListaEksponata
    {
        public List<Eksponat> eksponati;

        private static ListaEksponata instance = null;

        private static object locker = true;
        public static ListaEksponata Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new ListaEksponata();
                }
                return instance;
            }
        }

        protected ListaEksponata()
        {


            eksponati = new List<Eksponat>(){
                new Eksponat()
                {
                    Id = "1",
                    Naziv = "Slika",
                    Cena = "2000"
                },
                new Eksponat()
                {
                    Id = "2",
                    Naziv = "Sat",
                    Cena = "500"
                }
            };
        }
    }
}
