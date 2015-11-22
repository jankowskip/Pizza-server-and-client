using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections;

namespace KontraktServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITablica
    {
        [OperationContract]
        List<Pizza> ListaPizz();
        [OperationContract]
        void Usun(string produkt);
        [OperationContract]
        void Dodaj(Pizza student);
        [OperationContract]
        Pizza ZwrocPizza(string produkt);
        [OperationContract]
        void wypisz();
        [OperationContract]
        void Wyslij();
        [OperationContract]
        List<Pizza> ListaPizz2();
        [OperationContract]
        void WriteToConsole();

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "KontraktServer.ContractType".
    [DataContract]
    public class Pizza
    {
        string produkt;
        string skladniki;
        int cena;

        [DataMember]
        public string Produkt
        {
            get { return produkt; }
            set { produkt = value; }
        }
        [DataMember]
        public string Skladniki
        {
            get { return skladniki; }
            set { skladniki = value; }
        }



        [DataMember]
        public int Cena
        {
            get { return cena; }
            set { cena = value; }
        }
    }
}
  
 

