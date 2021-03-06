﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOCProject1.ArtsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Art", Namespace="http://schemas.datacontract.org/2004/07/LoginService")]
    [System.SerializableAttribute()]
    public partial class Art : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int artidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string authornameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
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
        public int artid {
            get {
                return this.artidField;
            }
            set {
                if ((this.artidField.Equals(value) != true)) {
                    this.artidField = value;
                    this.RaisePropertyChanged("artid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string authorname {
            get {
                return this.authornameField;
            }
            set {
                if ((object.ReferenceEquals(this.authornameField, value) != true)) {
                    this.authornameField = value;
                    this.RaisePropertyChanged("authorname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content {
            get {
                return this.contentField;
            }
            set {
                if ((object.ReferenceEquals(this.contentField, value) != true)) {
                    this.contentField = value;
                    this.RaisePropertyChanged("content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ArtsService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetArts", ReplyAction="http://tempuri.org/IService1/GetArtsResponse")]
        SOCProject1.ArtsService.Art[] GetArts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetArts", ReplyAction="http://tempuri.org/IService1/GetArtsResponse")]
        System.Threading.Tasks.Task<SOCProject1.ArtsService.Art[]> GetArtsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertArt", ReplyAction="http://tempuri.org/IService1/insertArtResponse")]
        void insertArt(SOCProject1.ArtsService.Art aobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertArt", ReplyAction="http://tempuri.org/IService1/insertArtResponse")]
        System.Threading.Tasks.Task insertArtAsync(SOCProject1.ArtsService.Art aobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateArt", ReplyAction="http://tempuri.org/IService1/updateArtResponse")]
        void updateArt(SOCProject1.ArtsService.Art aobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateArt", ReplyAction="http://tempuri.org/IService1/updateArtResponse")]
        System.Threading.Tasks.Task updateArtAsync(SOCProject1.ArtsService.Art aobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteArt", ReplyAction="http://tempuri.org/IService1/deleteArtResponse")]
        void deleteArt(int artid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteArt", ReplyAction="http://tempuri.org/IService1/deleteArtResponse")]
        System.Threading.Tasks.Task deleteArtAsync(int artid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonalArts", ReplyAction="http://tempuri.org/IService1/GetPersonalArtsResponse")]
        SOCProject1.ArtsService.Art[] GetPersonalArts(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonalArts", ReplyAction="http://tempuri.org/IService1/GetPersonalArtsResponse")]
        System.Threading.Tasks.Task<SOCProject1.ArtsService.Art[]> GetPersonalArtsAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetArt", ReplyAction="http://tempuri.org/IService1/GetArtResponse")]
        SOCProject1.ArtsService.Art GetArt(int artid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetArt", ReplyAction="http://tempuri.org/IService1/GetArtResponse")]
        System.Threading.Tasks.Task<SOCProject1.ArtsService.Art> GetArtAsync(int artid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SOCProject1.ArtsService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SOCProject1.ArtsService.IService1>, SOCProject1.ArtsService.IService1 {
        
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
        
        public SOCProject1.ArtsService.Art[] GetArts() {
            return base.Channel.GetArts();
        }
        
        public System.Threading.Tasks.Task<SOCProject1.ArtsService.Art[]> GetArtsAsync() {
            return base.Channel.GetArtsAsync();
        }
        
        public void insertArt(SOCProject1.ArtsService.Art aobj) {
            base.Channel.insertArt(aobj);
        }
        
        public System.Threading.Tasks.Task insertArtAsync(SOCProject1.ArtsService.Art aobj) {
            return base.Channel.insertArtAsync(aobj);
        }
        
        public void updateArt(SOCProject1.ArtsService.Art aobj) {
            base.Channel.updateArt(aobj);
        }
        
        public System.Threading.Tasks.Task updateArtAsync(SOCProject1.ArtsService.Art aobj) {
            return base.Channel.updateArtAsync(aobj);
        }
        
        public void deleteArt(int artid) {
            base.Channel.deleteArt(artid);
        }
        
        public System.Threading.Tasks.Task deleteArtAsync(int artid) {
            return base.Channel.deleteArtAsync(artid);
        }
        
        public SOCProject1.ArtsService.Art[] GetPersonalArts(string name) {
            return base.Channel.GetPersonalArts(name);
        }
        
        public System.Threading.Tasks.Task<SOCProject1.ArtsService.Art[]> GetPersonalArtsAsync(string name) {
            return base.Channel.GetPersonalArtsAsync(name);
        }
        
        public SOCProject1.ArtsService.Art GetArt(int artid) {
            return base.Channel.GetArt(artid);
        }
        
        public System.Threading.Tasks.Task<SOCProject1.ArtsService.Art> GetArtAsync(int artid) {
            return base.Channel.GetArtAsync(artid);
        }
    }
}
