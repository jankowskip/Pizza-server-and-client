﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFTablicaAplikacja.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pizza", Namespace="http://schemas.datacontract.org/2004/07/KontraktServer")]
    [System.SerializableAttribute()]
    public partial class Pizza : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProduktField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkladnikiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cena {
            get {
                return this.CenaField;
            }
            set {
                if ((this.CenaField.Equals(value) != true)) {
                    this.CenaField = value;
                    this.RaisePropertyChanged("Cena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Produkt {
            get {
                return this.ProduktField;
            }
            set {
                if ((object.ReferenceEquals(this.ProduktField, value) != true)) {
                    this.ProduktField = value;
                    this.RaisePropertyChanged("Produkt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Skladniki {
            get {
                return this.SkladnikiField;
            }
            set {
                if ((object.ReferenceEquals(this.SkladnikiField, value) != true)) {
                    this.SkladnikiField = value;
                    this.RaisePropertyChanged("Skladniki");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITablica")]
    public interface ITablica {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/ListaPizz", ReplyAction="http://tempuri.org/ITablica/ListaPizzResponse")]
        WPFTablicaAplikacja.ServiceReference1.Pizza[] ListaPizz();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/ListaPizz", ReplyAction="http://tempuri.org/ITablica/ListaPizzResponse")]
        System.Threading.Tasks.Task<WPFTablicaAplikacja.ServiceReference1.Pizza[]> ListaPizzAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/Usun", ReplyAction="http://tempuri.org/ITablica/UsunResponse")]
        void Usun(string produkt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/Usun", ReplyAction="http://tempuri.org/ITablica/UsunResponse")]
        System.Threading.Tasks.Task UsunAsync(string produkt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/Dodaj", ReplyAction="http://tempuri.org/ITablica/DodajResponse")]
        void Dodaj(WPFTablicaAplikacja.ServiceReference1.Pizza student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/Dodaj", ReplyAction="http://tempuri.org/ITablica/DodajResponse")]
        System.Threading.Tasks.Task DodajAsync(WPFTablicaAplikacja.ServiceReference1.Pizza student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/ZwrocPizza", ReplyAction="http://tempuri.org/ITablica/ZwrocPizzaResponse")]
        WPFTablicaAplikacja.ServiceReference1.Pizza ZwrocPizza(string produkt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/ZwrocPizza", ReplyAction="http://tempuri.org/ITablica/ZwrocPizzaResponse")]
        System.Threading.Tasks.Task<WPFTablicaAplikacja.ServiceReference1.Pizza> ZwrocPizzaAsync(string produkt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/wypisz", ReplyAction="http://tempuri.org/ITablica/wypiszResponse")]
        void wypisz();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/wypisz", ReplyAction="http://tempuri.org/ITablica/wypiszResponse")]
        System.Threading.Tasks.Task wypiszAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/Wyslij", ReplyAction="http://tempuri.org/ITablica/WyslijResponse")]
        void Wyslij();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/Wyslij", ReplyAction="http://tempuri.org/ITablica/WyslijResponse")]
        System.Threading.Tasks.Task WyslijAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/ListaPizz2", ReplyAction="http://tempuri.org/ITablica/ListaPizz2Response")]
        WPFTablicaAplikacja.ServiceReference1.Pizza[] ListaPizz2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/ListaPizz2", ReplyAction="http://tempuri.org/ITablica/ListaPizz2Response")]
        System.Threading.Tasks.Task<WPFTablicaAplikacja.ServiceReference1.Pizza[]> ListaPizz2Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/WriteToConsole", ReplyAction="http://tempuri.org/ITablica/WriteToConsoleResponse")]
        void WriteToConsole();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITablica/WriteToConsole", ReplyAction="http://tempuri.org/ITablica/WriteToConsoleResponse")]
        System.Threading.Tasks.Task WriteToConsoleAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITablicaChannel : WPFTablicaAplikacja.ServiceReference1.ITablica, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TablicaClient : System.ServiceModel.ClientBase<WPFTablicaAplikacja.ServiceReference1.ITablica>, WPFTablicaAplikacja.ServiceReference1.ITablica {
        
        public TablicaClient() {
        }
        
        public TablicaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TablicaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TablicaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TablicaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WPFTablicaAplikacja.ServiceReference1.Pizza[] ListaPizz() {
            return base.Channel.ListaPizz();
        }
        
        public System.Threading.Tasks.Task<WPFTablicaAplikacja.ServiceReference1.Pizza[]> ListaPizzAsync() {
            return base.Channel.ListaPizzAsync();
        }
        
        public void Usun(string produkt) {
            base.Channel.Usun(produkt);
        }
        
        public System.Threading.Tasks.Task UsunAsync(string produkt) {
            return base.Channel.UsunAsync(produkt);
        }
        
        public void Dodaj(WPFTablicaAplikacja.ServiceReference1.Pizza student) {
            base.Channel.Dodaj(student);
        }
        
        public System.Threading.Tasks.Task DodajAsync(WPFTablicaAplikacja.ServiceReference1.Pizza student) {
            return base.Channel.DodajAsync(student);
        }
        
        public WPFTablicaAplikacja.ServiceReference1.Pizza ZwrocPizza(string produkt) {
            return base.Channel.ZwrocPizza(produkt);
        }
        
        public System.Threading.Tasks.Task<WPFTablicaAplikacja.ServiceReference1.Pizza> ZwrocPizzaAsync(string produkt) {
            return base.Channel.ZwrocPizzaAsync(produkt);
        }
        
        public void wypisz() {
            base.Channel.wypisz();
        }
        
        public System.Threading.Tasks.Task wypiszAsync() {
            return base.Channel.wypiszAsync();
        }
        
        public void Wyslij() {
            base.Channel.Wyslij();
        }
        
        public System.Threading.Tasks.Task WyslijAsync() {
            return base.Channel.WyslijAsync();
        }
        
        public WPFTablicaAplikacja.ServiceReference1.Pizza[] ListaPizz2() {
            return base.Channel.ListaPizz2();
        }
        
        public System.Threading.Tasks.Task<WPFTablicaAplikacja.ServiceReference1.Pizza[]> ListaPizz2Async() {
            return base.Channel.ListaPizz2Async();
        }
        
        public void WriteToConsole() {
            base.Channel.WriteToConsole();
        }
        
        public System.Threading.Tasks.Task WriteToConsoleAsync() {
            return base.Channel.WriteToConsoleAsync();
        }
    }
}
