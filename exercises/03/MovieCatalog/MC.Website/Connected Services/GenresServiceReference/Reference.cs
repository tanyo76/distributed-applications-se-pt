﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MC.Website.GenresServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenreDto", Namespace="http://schemas.datacontract.org/2004/07/MC.ApplicationServices.DTOs")]
    [System.SerializableAttribute()]
    public partial class GenreDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GenresServiceReference.IGenres")]
    public interface IGenres {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/GetVersion", ReplyAction="http://tempuri.org/IGenres/GetVersionResponse")]
        string GetVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/GetVersion", ReplyAction="http://tempuri.org/IGenres/GetVersionResponse")]
        System.Threading.Tasks.Task<string> GetVersionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/GetGenres", ReplyAction="http://tempuri.org/IGenres/GetGenresResponse")]
        MC.Website.GenresServiceReference.GenreDto[] GetGenres();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/GetGenres", ReplyAction="http://tempuri.org/IGenres/GetGenresResponse")]
        System.Threading.Tasks.Task<MC.Website.GenresServiceReference.GenreDto[]> GetGenresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/GetById", ReplyAction="http://tempuri.org/IGenres/GetByIdResponse")]
        MC.Website.GenresServiceReference.GenreDto GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/GetById", ReplyAction="http://tempuri.org/IGenres/GetByIdResponse")]
        System.Threading.Tasks.Task<MC.Website.GenresServiceReference.GenreDto> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/Save", ReplyAction="http://tempuri.org/IGenres/SaveResponse")]
        int Save(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/Save", ReplyAction="http://tempuri.org/IGenres/SaveResponse")]
        System.Threading.Tasks.Task<int> SaveAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/Delete", ReplyAction="http://tempuri.org/IGenres/DeleteResponse")]
        int Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenres/Delete", ReplyAction="http://tempuri.org/IGenres/DeleteResponse")]
        System.Threading.Tasks.Task<int> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGenresChannel : MC.Website.GenresServiceReference.IGenres, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GenresClient : System.ServiceModel.ClientBase<MC.Website.GenresServiceReference.IGenres>, MC.Website.GenresServiceReference.IGenres {
        
        public GenresClient() {
        }
        
        public GenresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GenresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GenresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GenresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetVersion() {
            return base.Channel.GetVersion();
        }
        
        public System.Threading.Tasks.Task<string> GetVersionAsync() {
            return base.Channel.GetVersionAsync();
        }
        
        public MC.Website.GenresServiceReference.GenreDto[] GetGenres() {
            return base.Channel.GetGenres();
        }
        
        public System.Threading.Tasks.Task<MC.Website.GenresServiceReference.GenreDto[]> GetGenresAsync() {
            return base.Channel.GetGenresAsync();
        }
        
        public MC.Website.GenresServiceReference.GenreDto GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<MC.Website.GenresServiceReference.GenreDto> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public int Save(string title) {
            return base.Channel.Save(title);
        }
        
        public System.Threading.Tasks.Task<int> SaveAsync(string title) {
            return base.Channel.SaveAsync(title);
        }
        
        public int Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
