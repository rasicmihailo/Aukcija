﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfAukcija")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Klijent", Namespace="http://schemas.datacontract.org/2004/07/WcfAukcija")]
    [System.SerializableAttribute()]
    public partial class Klijent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrezimeField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ime {
            get {
                return this.ImeField;
            }
            set {
                if ((object.ReferenceEquals(this.ImeField, value) != true)) {
                    this.ImeField = value;
                    this.RaisePropertyChanged("Ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prezime {
            get {
                return this.PrezimeField;
            }
            set {
                if ((object.ReferenceEquals(this.PrezimeField, value) != true)) {
                    this.PrezimeField = value;
                    this.RaisePropertyChanged("Prezime");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Eksponat", Namespace="http://schemas.datacontract.org/2004/07/WcfAukcija")]
    [System.SerializableAttribute()]
    public partial class Eksponat : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdKlijentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivField;
        
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
        public string Cena {
            get {
                return this.CenaField;
            }
            set {
                if ((object.ReferenceEquals(this.CenaField, value) != true)) {
                    this.CenaField = value;
                    this.RaisePropertyChanged("Cena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdKlijenta {
            get {
                return this.IdKlijentaField;
            }
            set {
                if ((object.ReferenceEquals(this.IdKlijentaField, value) != true)) {
                    this.IdKlijentaField = value;
                    this.RaisePropertyChanged("IdKlijenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naziv {
            get {
                return this.NazivField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivField, value) != true)) {
                    this.NazivField = value;
                    this.RaisePropertyChanged("Naziv");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Client.ServiceReference1.CompositeType GetDataUsingDataContract(Client.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Client.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VratiKlijente", ReplyAction="http://tempuri.org/IService1/VratiKlijenteResponse")]
        Client.ServiceReference1.Klijent[] VratiKlijente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VratiKlijente", ReplyAction="http://tempuri.org/IService1/VratiKlijenteResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Klijent[]> VratiKlijenteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LogIn", ReplyAction="http://tempuri.org/IService1/LogInResponse")]
        Client.ServiceReference1.Klijent LogIn(string ime, string prezime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LogIn", ReplyAction="http://tempuri.org/IService1/LogInResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Klijent> LogInAsync(string ime, string prezime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VratiEksponate", ReplyAction="http://tempuri.org/IService1/VratiEksponateResponse")]
        Client.ServiceReference1.Eksponat[] VratiEksponate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VratiEksponate", ReplyAction="http://tempuri.org/IService1/VratiEksponateResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Eksponat[]> VratiEksponateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VratiPrviEksponat", ReplyAction="http://tempuri.org/IService1/VratiPrviEksponatResponse")]
        Client.ServiceReference1.Eksponat VratiPrviEksponat();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VratiPrviEksponat", ReplyAction="http://tempuri.org/IService1/VratiPrviEksponatResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Eksponat> VratiPrviEksponatAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajPonudu", ReplyAction="http://tempuri.org/IService1/DodajPonuduResponse")]
        void DodajPonudu(string cena, Client.ServiceReference1.Klijent klijent, int trenutniBrojEksponata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajPonudu", ReplyAction="http://tempuri.org/IService1/DodajPonuduResponse")]
        System.Threading.Tasks.Task DodajPonuduAsync(string cena, Client.ServiceReference1.Klijent klijent, int trenutniBrojEksponata);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VratiTrenutniEksponat", ReplyAction="http://tempuri.org/IService1/VratiTrenutniEksponatResponse")]
        Client.ServiceReference1.Eksponat VratiTrenutniEksponat(int broj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VratiTrenutniEksponat", ReplyAction="http://tempuri.org/IService1/VratiTrenutniEksponatResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Eksponat> VratiTrenutniEksponatAsync(int broj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Client.ServiceReference1.CompositeType GetDataUsingDataContract(Client.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Client.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public Client.ServiceReference1.Klijent[] VratiKlijente() {
            return base.Channel.VratiKlijente();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Klijent[]> VratiKlijenteAsync() {
            return base.Channel.VratiKlijenteAsync();
        }
        
        public Client.ServiceReference1.Klijent LogIn(string ime, string prezime) {
            return base.Channel.LogIn(ime, prezime);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Klijent> LogInAsync(string ime, string prezime) {
            return base.Channel.LogInAsync(ime, prezime);
        }
        
        public Client.ServiceReference1.Eksponat[] VratiEksponate() {
            return base.Channel.VratiEksponate();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Eksponat[]> VratiEksponateAsync() {
            return base.Channel.VratiEksponateAsync();
        }
        
        public Client.ServiceReference1.Eksponat VratiPrviEksponat() {
            return base.Channel.VratiPrviEksponat();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Eksponat> VratiPrviEksponatAsync() {
            return base.Channel.VratiPrviEksponatAsync();
        }
        
        public void DodajPonudu(string cena, Client.ServiceReference1.Klijent klijent, int trenutniBrojEksponata) {
            base.Channel.DodajPonudu(cena, klijent, trenutniBrojEksponata);
        }
        
        public System.Threading.Tasks.Task DodajPonuduAsync(string cena, Client.ServiceReference1.Klijent klijent, int trenutniBrojEksponata) {
            return base.Channel.DodajPonuduAsync(cena, klijent, trenutniBrojEksponata);
        }
        
        public Client.ServiceReference1.Eksponat VratiTrenutniEksponat(int broj) {
            return base.Channel.VratiTrenutniEksponat(broj);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Eksponat> VratiTrenutniEksponatAsync(int broj) {
            return base.Channel.VratiTrenutniEksponatAsync(broj);
        }
    }
}
