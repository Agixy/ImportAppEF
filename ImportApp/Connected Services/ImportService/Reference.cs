﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImportApp.ImportService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/ImportService")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ImportApp.ImportService.Address[] AddressesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ImportApp.ImportService.FinancialState FinancialStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ImportApp.ImportService.IdentityDocument[] IdentityDocumentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalIdentificationNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ImportApp.ImportService.Phone[] PhonesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
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
        public ImportApp.ImportService.Address[] Addresses {
            get {
                return this.AddressesField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressesField, value) != true)) {
                    this.AddressesField = value;
                    this.RaisePropertyChanged("Addresses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ImportApp.ImportService.FinancialState FinancialState {
            get {
                return this.FinancialStateField;
            }
            set {
                if ((object.ReferenceEquals(this.FinancialStateField, value) != true)) {
                    this.FinancialStateField = value;
                    this.RaisePropertyChanged("FinancialState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ImportApp.ImportService.IdentityDocument[] IdentityDocuments {
            get {
                return this.IdentityDocumentsField;
            }
            set {
                if ((object.ReferenceEquals(this.IdentityDocumentsField, value) != true)) {
                    this.IdentityDocumentsField = value;
                    this.RaisePropertyChanged("IdentityDocuments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NationalIdentificationNumber {
            get {
                return this.NationalIdentificationNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NationalIdentificationNumberField, value) != true)) {
                    this.NationalIdentificationNumberField = value;
                    this.RaisePropertyChanged("NationalIdentificationNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ImportApp.ImportService.Phone[] Phones {
            get {
                return this.PhonesField;
            }
            set {
                if ((object.ReferenceEquals(this.PhonesField, value) != true)) {
                    this.PhonesField = value;
                    this.RaisePropertyChanged("Phones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FinancialState", Namespace="http://schemas.datacontract.org/2004/07/ImportService")]
    [System.SerializableAttribute()]
    public partial class FinancialState : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CapitalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CourtFeesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CourtRepresentationFeesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal EnforcementFeesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal EnforcementRepresentationFeesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal FeesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal InterestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PenaltyInterestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PlenipotentiryFeeField;
        
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
        public decimal Capital {
            get {
                return this.CapitalField;
            }
            set {
                if ((this.CapitalField.Equals(value) != true)) {
                    this.CapitalField = value;
                    this.RaisePropertyChanged("Capital");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal CourtFees {
            get {
                return this.CourtFeesField;
            }
            set {
                if ((this.CourtFeesField.Equals(value) != true)) {
                    this.CourtFeesField = value;
                    this.RaisePropertyChanged("CourtFees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal CourtRepresentationFees {
            get {
                return this.CourtRepresentationFeesField;
            }
            set {
                if ((this.CourtRepresentationFeesField.Equals(value) != true)) {
                    this.CourtRepresentationFeesField = value;
                    this.RaisePropertyChanged("CourtRepresentationFees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal EnforcementFees {
            get {
                return this.EnforcementFeesField;
            }
            set {
                if ((this.EnforcementFeesField.Equals(value) != true)) {
                    this.EnforcementFeesField = value;
                    this.RaisePropertyChanged("EnforcementFees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal EnforcementRepresentationFees {
            get {
                return this.EnforcementRepresentationFeesField;
            }
            set {
                if ((this.EnforcementRepresentationFeesField.Equals(value) != true)) {
                    this.EnforcementRepresentationFeesField = value;
                    this.RaisePropertyChanged("EnforcementRepresentationFees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Fees {
            get {
                return this.FeesField;
            }
            set {
                if ((this.FeesField.Equals(value) != true)) {
                    this.FeesField = value;
                    this.RaisePropertyChanged("Fees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Interest {
            get {
                return this.InterestField;
            }
            set {
                if ((this.InterestField.Equals(value) != true)) {
                    this.InterestField = value;
                    this.RaisePropertyChanged("Interest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PenaltyInterest {
            get {
                return this.PenaltyInterestField;
            }
            set {
                if ((this.PenaltyInterestField.Equals(value) != true)) {
                    this.PenaltyInterestField = value;
                    this.RaisePropertyChanged("PenaltyInterest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PlenipotentiryFee {
            get {
                return this.PlenipotentiryFeeField;
            }
            set {
                if ((this.PlenipotentiryFeeField.Equals(value) != true)) {
                    this.PlenipotentiryFeeField = value;
                    this.RaisePropertyChanged("PlenipotentiryFee");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/ImportService")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HouseNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocaleNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string AddressType {
            get {
                return this.AddressTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressTypeField, value) != true)) {
                    this.AddressTypeField = value;
                    this.RaisePropertyChanged("AddressType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HouseNo {
            get {
                return this.HouseNoField;
            }
            set {
                if ((object.ReferenceEquals(this.HouseNoField, value) != true)) {
                    this.HouseNoField = value;
                    this.RaisePropertyChanged("HouseNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LocaleNo {
            get {
                return this.LocaleNoField;
            }
            set {
                if ((object.ReferenceEquals(this.LocaleNoField, value) != true)) {
                    this.LocaleNoField = value;
                    this.RaisePropertyChanged("LocaleNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalCode {
            get {
                return this.PostalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalCodeField, value) != true)) {
                    this.PostalCodeField = value;
                    this.RaisePropertyChanged("PostalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="IdentityDocument", Namespace="http://schemas.datacontract.org/2004/07/ImportService")]
    [System.SerializableAttribute()]
    public partial class IdentityDocument : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ExpirationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public System.DateTime ExpirationDate {
            get {
                return this.ExpirationDateField;
            }
            set {
                if ((this.ExpirationDateField.Equals(value) != true)) {
                    this.ExpirationDateField = value;
                    this.RaisePropertyChanged("ExpirationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Phone", Namespace="http://schemas.datacontract.org/2004/07/ImportService")]
    [System.SerializableAttribute()]
    public partial class Phone : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ImportService.IImportService")]
    public interface IImportService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImportService/DoImport", ReplyAction="http://tempuri.org/IImportService/DoImportResponse")]
        bool DoImport(ImportApp.ImportService.Person personalData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImportService/DoImport", ReplyAction="http://tempuri.org/IImportService/DoImportResponse")]
        System.Threading.Tasks.Task<bool> DoImportAsync(ImportApp.ImportService.Person personalData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImportServiceChannel : ImportApp.ImportService.IImportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImportServiceClient : System.ServiceModel.ClientBase<ImportApp.ImportService.IImportService>, ImportApp.ImportService.IImportService {
        
        public ImportServiceClient() {
        }
        
        public ImportServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImportServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImportServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImportServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool DoImport(ImportApp.ImportService.Person personalData) {
            return base.Channel.DoImport(personalData);
        }
        
        public System.Threading.Tasks.Task<bool> DoImportAsync(ImportApp.ImportService.Person personalData) {
            return base.Channel.DoImportAsync(personalData);
        }
    }
}
