using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections;
namespace KontraktServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Tablica : ITablica
    {
        string adresik;
        string nazwa;
        string nrtelefonu;
        List<Pizza> tab = new List<Pizza>();
        List<Pizza> tab2 = new List<Pizza>();
        public Tablica()
        {
            Pizza pizza = new Pizza();
            pizza.Produkt = "Salami";
            pizza.Skladniki = "Salami, Ser, Sos pomidorowy";
            pizza.Cena = 23;
            tab.Add(pizza);

            Pizza pizza1 = new Pizza();
            pizza1.Produkt = "Margherita";
            pizza1.Skladniki = "Ser, Sos pomidorowy";
            pizza1.Cena = 23;
            tab.Add(pizza1);

            Pizza pizza2 = new Pizza();
            pizza2.Produkt = "Vegetariana";
            pizza2.Skladniki = "Pieczarki, Ser, Sos pomidorowy, Papryka, cebula";
            pizza2.Cena = 23;
            tab.Add(pizza2);

            Pizza pizza3 = new Pizza();
            pizza3.Produkt = "Polska";
            pizza3.Skladniki = "Kielbasa, Ser, Sos pomidorowy, cebula";
            pizza3.Cena = 23;
            tab.Add(pizza3);

            Pizza pizza4 = new Pizza();
            pizza4.Produkt = "Pepperoni";
            pizza4.Skladniki = "Pepperoni, Ser, Sos pomidorowy";
            pizza4.Cena = 23;
            tab.Add(pizza4);

            Pizza pizza5 = new Pizza();
            pizza5.Produkt = "Hawajska";
            pizza5.Skladniki = "Ananas, Ser, Sos pomidorowy, Szynka";
            pizza5.Cena = 23;
            tab.Add(pizza5);
        }
        public List<Pizza> ListaPizz()
        {

            return tab;


        }

        public List<Pizza> ListaPizz2()
        {

            return tab2;


        }
        public void Usun(string produkt)
        {

            int pozycja = Wyszukaj(produkt);            // sprawdzic czy wyszkuiwanie dizala
            if (pozycja > -1)
            {
                tab2.RemoveAt(pozycja);                 // tutaj pozycja cyz dizala
            }
  
        }
        public void Dodaj(Pizza pizza)
        {
            tab2.Add(pizza);                                // sprawdizc dzialanie tego w aplikacji i czmeu to nie dziala

        }

        public void Zmien(Pizza pizza)   // zostwaic poki co
        {
            int pozycja = Wyszukaj(pizza.Produkt);
            if (pozycja > -1)
            {
                tab2.ElementAt(pozycja).Produkt = pizza.Produkt;
                tab2.ElementAt(pozycja).Produkt = pizza.Skladniki;


       

            }
        }

        private int Wyszukaj(string produkt)
        {
            int pozycja = -1;
            for (int i = 0; i < tab2.Count; i++)
            {
                if (produkt == tab2.ElementAt(i).Produkt)
                {
                    pozycja = i;
                }

            }
            return pozycja;
        }


        public Pizza ZwrocPizza(string produkt)   //
        {
            int pozycja = Wyszukaj(produkt);
        
            return tab.ElementAt(pozycja);  // zmieniamy chwilowo na tab1
        }
        public void wypisz()
        {
            Console.WriteLine("Polaczyles sie z serverem");
        }

        public void Wyslij()
            
        {
            Console.WriteLine("Nowe zamowienie");
        }
        public void WriteToConsole()
        {
            foreach (Pizza p in tab2)
            {
               
                Console.WriteLine(p.Produkt.ToString());
            }
         



        }
    }
}