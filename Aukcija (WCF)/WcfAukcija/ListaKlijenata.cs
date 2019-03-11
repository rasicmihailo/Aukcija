using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfAukcija
{
    public class ListaKlijenata
    {

        public List<Klijent> klijenti;

        private static ListaKlijenata instance = null;

        private static object locker = true;
        public static ListaKlijenata Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new ListaKlijenata();
                }
                return instance;
            }
        }

        protected ListaKlijenata()
        {


            klijenti = new List<Klijent>(){
                new Klijent()
                {
                    Id = "1",
                    Ime = "Joca",
                    Prezime = "Jovanovic"
                },
                new Klijent()
                {
                    Id = "2",
                    Ime = "Mitar",
                    Prezime = "Mitrovic"
                },
                new Klijent()
                {
                    Id = "3",
                    Ime = "Petar",
                    Prezime = "Petrovic"
                }
            };
        }
    }
}