﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pfw.UI.Win.EntityServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityRequest", Namespace="http://schemas.datacontract.org/2004/07/pfw.SDK.DataContracts")]
    [System.SerializableAttribute()]
    public partial class EntityRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long EntityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private pfw.UI.Win.EntityServiceReference.EntityManager EntityManagerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private pfw.UI.Win.EntityServiceReference.EntityTypeName EntityTypeNameField;
        
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
        public long EntityId {
            get {
                return this.EntityIdField;
            }
            set {
                if ((this.EntityIdField.Equals(value) != true)) {
                    this.EntityIdField = value;
                    this.RaisePropertyChanged("EntityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public pfw.UI.Win.EntityServiceReference.EntityManager EntityManager {
            get {
                return this.EntityManagerField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityManagerField, value) != true)) {
                    this.EntityManagerField = value;
                    this.RaisePropertyChanged("EntityManager");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public pfw.UI.Win.EntityServiceReference.EntityTypeName EntityTypeName {
            get {
                return this.EntityTypeNameField;
            }
            set {
                if ((this.EntityTypeNameField.Equals(value) != true)) {
                    this.EntityTypeNameField = value;
                    this.RaisePropertyChanged("EntityTypeName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityManager", Namespace="http://schemas.datacontract.org/2004/07/pfw.Controller.Manager")]
    [System.SerializableAttribute()]
    public partial class EntityManager : pfw.UI.Win.EntityServiceReference.Manager {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityTypeName", Namespace="http://schemas.datacontract.org/2004/07/pfw.Controller.Base")]
    public enum EntityTypeName : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Item = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Manager", Namespace="http://schemas.datacontract.org/2004/07/pfw.Controller.Manager")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(pfw.UI.Win.EntityServiceReference.EntityManager))]
    public partial class Manager : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private pfw.UI.Win.EntityServiceReference.EntityTypeName EntityTypeNamek__BackingFieldField;
        
        private System.Guid ManagerGuidk__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<EntityTypeName>k__BackingField", IsRequired=true)]
        public pfw.UI.Win.EntityServiceReference.EntityTypeName EntityTypeNamek__BackingField {
            get {
                return this.EntityTypeNamek__BackingFieldField;
            }
            set {
                if ((this.EntityTypeNamek__BackingFieldField.Equals(value) != true)) {
                    this.EntityTypeNamek__BackingFieldField = value;
                    this.RaisePropertyChanged("EntityTypeNamek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ManagerGuid>k__BackingField", IsRequired=true)]
        public System.Guid ManagerGuidk__BackingField {
            get {
                return this.ManagerGuidk__BackingFieldField;
            }
            set {
                if ((this.ManagerGuidk__BackingFieldField.Equals(value) != true)) {
                    this.ManagerGuidk__BackingFieldField = value;
                    this.RaisePropertyChanged("ManagerGuidk__BackingField");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityResponse", Namespace="http://schemas.datacontract.org/2004/07/pfw.SDK.DataContracts")]
    [System.SerializableAttribute()]
    public partial class EntityResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long EntityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private pfw.UI.Win.EntityServiceReference.EntityTypeName EntityTypeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsRequestSuccessfulField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ManagerGuidField;
        
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
        public long EntityId {
            get {
                return this.EntityIdField;
            }
            set {
                if ((this.EntityIdField.Equals(value) != true)) {
                    this.EntityIdField = value;
                    this.RaisePropertyChanged("EntityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public pfw.UI.Win.EntityServiceReference.EntityTypeName EntityTypeName {
            get {
                return this.EntityTypeNameField;
            }
            set {
                if ((this.EntityTypeNameField.Equals(value) != true)) {
                    this.EntityTypeNameField = value;
                    this.RaisePropertyChanged("EntityTypeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsRequestSuccessful {
            get {
                return this.IsRequestSuccessfulField;
            }
            set {
                if ((this.IsRequestSuccessfulField.Equals(value) != true)) {
                    this.IsRequestSuccessfulField = value;
                    this.RaisePropertyChanged("IsRequestSuccessful");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ManagerGuid {
            get {
                return this.ManagerGuidField;
            }
            set {
                if ((this.ManagerGuidField.Equals(value) != true)) {
                    this.ManagerGuidField = value;
                    this.RaisePropertyChanged("ManagerGuid");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EntityServiceReference.IEntityService")]
    public interface IEntityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityService/DoWork", ReplyAction="http://tempuri.org/IEntityService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityService/Entity", ReplyAction="http://tempuri.org/IEntityService/EntityResponse")]
        pfw.UI.Win.EntityServiceReference.EntityResponse Entity(pfw.UI.Win.EntityServiceReference.EntityRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEntityServiceChannel : pfw.UI.Win.EntityServiceReference.IEntityService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EntityServiceClient : System.ServiceModel.ClientBase<pfw.UI.Win.EntityServiceReference.IEntityService>, pfw.UI.Win.EntityServiceReference.IEntityService {
        
        public EntityServiceClient() {
        }
        
        public EntityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EntityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public pfw.UI.Win.EntityServiceReference.EntityResponse Entity(pfw.UI.Win.EntityServiceReference.EntityRequest request) {
            return base.Channel.Entity(request);
        }
    }
}
