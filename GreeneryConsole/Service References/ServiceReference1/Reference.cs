﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreeneryConsole.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Greenery", Namespace="http://schemas.datacontract.org/2004/07/Greenery")]
    [System.SerializableAttribute()]
    public partial class Greenery : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AverageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HumidityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TemperatureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimeStampField;
        
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
        public string Average {
            get {
                return this.AverageField;
            }
            set {
                if ((object.ReferenceEquals(this.AverageField, value) != true)) {
                    this.AverageField = value;
                    this.RaisePropertyChanged("Average");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Humidity {
            get {
                return this.HumidityField;
            }
            set {
                if ((object.ReferenceEquals(this.HumidityField, value) != true)) {
                    this.HumidityField = value;
                    this.RaisePropertyChanged("Humidity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Temperature {
            get {
                return this.TemperatureField;
            }
            set {
                if ((object.ReferenceEquals(this.TemperatureField, value) != true)) {
                    this.TemperatureField = value;
                    this.RaisePropertyChanged("Temperature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeStampField, value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddGreeneryData", ReplyAction="http://tempuri.org/IService1/AddGreeneryDataResponse")]
        void AddGreeneryData(GreeneryConsole.ServiceReference1.Greenery greeneryDb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddGreeneryData", ReplyAction="http://tempuri.org/IService1/AddGreeneryDataResponse")]
        System.Threading.Tasks.Task AddGreeneryDataAsync(GreeneryConsole.ServiceReference1.Greenery greeneryDb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllData", ReplyAction="http://tempuri.org/IService1/GetAllDataResponse")]
        GreeneryConsole.ServiceReference1.Greenery[] GetAllData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllData", ReplyAction="http://tempuri.org/IService1/GetAllDataResponse")]
        System.Threading.Tasks.Task<GreeneryConsole.ServiceReference1.Greenery[]> GetAllDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : GreeneryConsole.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<GreeneryConsole.ServiceReference1.IService1>, GreeneryConsole.ServiceReference1.IService1 {
        
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
        
        public void AddGreeneryData(GreeneryConsole.ServiceReference1.Greenery greeneryDb) {
            base.Channel.AddGreeneryData(greeneryDb);
        }
        
        public System.Threading.Tasks.Task AddGreeneryDataAsync(GreeneryConsole.ServiceReference1.Greenery greeneryDb) {
            return base.Channel.AddGreeneryDataAsync(greeneryDb);
        }
        
        public GreeneryConsole.ServiceReference1.Greenery[] GetAllData() {
            return base.Channel.GetAllData();
        }
        
        public System.Threading.Tasks.Task<GreeneryConsole.ServiceReference1.Greenery[]> GetAllDataAsync() {
            return base.Channel.GetAllDataAsync();
        }
    }
}
