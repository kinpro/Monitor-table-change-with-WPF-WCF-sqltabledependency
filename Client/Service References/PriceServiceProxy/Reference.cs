﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataGridSample.PriceServiceProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Stock", Namespace="http://schemas.datacontract.org/2004/07/ConsoleApplicationServer.Models")]
    [System.SerializableAttribute()]
    public partial class Stock : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
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
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PriceServiceProxy.IPriceTicker", CallbackContract=typeof(DataGridSample.PriceServiceProxy.IPriceTickerCallback))]
    public interface IPriceTicker {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceTicker/Subscribe", ReplyAction="http://tempuri.org/IPriceTicker/SubscribeResponse")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceTicker/Subscribe", ReplyAction="http://tempuri.org/IPriceTicker/SubscribeResponse")]
        System.Threading.Tasks.Task SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceTicker/Unsubscribe", ReplyAction="http://tempuri.org/IPriceTicker/UnsubscribeResponse")]
        void Unsubscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceTicker/Unsubscribe", ReplyAction="http://tempuri.org/IPriceTicker/UnsubscribeResponse")]
        System.Threading.Tasks.Task UnsubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceTicker/GetAllStocks", ReplyAction="http://tempuri.org/IPriceTicker/GetAllStocksResponse")]
        DataGridSample.PriceServiceProxy.Stock[] GetAllStocks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceTicker/GetAllStocks", ReplyAction="http://tempuri.org/IPriceTicker/GetAllStocksResponse")]
        System.Threading.Tasks.Task<DataGridSample.PriceServiceProxy.Stock[]> GetAllStocksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceTicker/PublishPriceChange", ReplyAction="http://tempuri.org/IPriceTicker/PublishPriceChangeResponse")]
        void PublishPriceChange(string item, string name, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceTicker/PublishPriceChange", ReplyAction="http://tempuri.org/IPriceTicker/PublishPriceChangeResponse")]
        System.Threading.Tasks.Task PublishPriceChangeAsync(string item, string name, decimal price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPriceTickerCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPriceTicker/PriceChange", ReplyAction="http://tempuri.org/IPriceTicker/PriceChangeResponse")]
        void PriceChange(string code, string name, decimal price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPriceTickerChannel : DataGridSample.PriceServiceProxy.IPriceTicker, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PriceTickerClient : System.ServiceModel.DuplexClientBase<DataGridSample.PriceServiceProxy.IPriceTicker>, DataGridSample.PriceServiceProxy.IPriceTicker {
        
        public PriceTickerClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PriceTickerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PriceTickerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PriceTickerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PriceTickerClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscribe() {
            base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public void Unsubscribe() {
            base.Channel.Unsubscribe();
        }
        
        public System.Threading.Tasks.Task UnsubscribeAsync() {
            return base.Channel.UnsubscribeAsync();
        }
        
        public DataGridSample.PriceServiceProxy.Stock[] GetAllStocks() {
            return base.Channel.GetAllStocks();
        }
        
        public System.Threading.Tasks.Task<DataGridSample.PriceServiceProxy.Stock[]> GetAllStocksAsync() {
            return base.Channel.GetAllStocksAsync();
        }
        
        public void PublishPriceChange(string item, string name, decimal price) {
            base.Channel.PublishPriceChange(item, name, price);
        }
        
        public System.Threading.Tasks.Task PublishPriceChangeAsync(string item, string name, decimal price) {
            return base.Channel.PublishPriceChangeAsync(item, name, price);
        }
    }
}
