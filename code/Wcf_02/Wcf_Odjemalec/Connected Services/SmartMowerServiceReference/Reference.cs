﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wcf_Odjemalec.SmartMowerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SmartMower", Namespace="http://schemas.datacontract.org/2004/07/SmartMowerServiceLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class SmartMower : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BatteryAutoChargeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BatteryLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CuttingLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsChargingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsMovingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Wcf_Odjemalec.SmartMowerServiceReference.LightSensor LightSensorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Wcf_Odjemalec.SmartMowerServiceReference.MotionSensor MotionSensorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoiseLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PowerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProducerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Wcf_Odjemalec.SmartMowerServiceReference.RainSensor RainSensorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SerialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Wcf_Odjemalec.SmartMowerServiceReference.TemperatureSensor TemperatureSensorField;
        
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
        public bool BatteryAutoCharge {
            get {
                return this.BatteryAutoChargeField;
            }
            set {
                if ((this.BatteryAutoChargeField.Equals(value) != true)) {
                    this.BatteryAutoChargeField = value;
                    this.RaisePropertyChanged("BatteryAutoCharge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BatteryLevel {
            get {
                return this.BatteryLevelField;
            }
            set {
                if ((this.BatteryLevelField.Equals(value) != true)) {
                    this.BatteryLevelField = value;
                    this.RaisePropertyChanged("BatteryLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CuttingLevel {
            get {
                return this.CuttingLevelField;
            }
            set {
                if ((this.CuttingLevelField.Equals(value) != true)) {
                    this.CuttingLevelField = value;
                    this.RaisePropertyChanged("CuttingLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCharging {
            get {
                return this.IsChargingField;
            }
            set {
                if ((this.IsChargingField.Equals(value) != true)) {
                    this.IsChargingField = value;
                    this.RaisePropertyChanged("IsCharging");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsMoving {
            get {
                return this.IsMovingField;
            }
            set {
                if ((this.IsMovingField.Equals(value) != true)) {
                    this.IsMovingField = value;
                    this.RaisePropertyChanged("IsMoving");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Wcf_Odjemalec.SmartMowerServiceReference.LightSensor LightSensor {
            get {
                return this.LightSensorField;
            }
            set {
                if ((object.ReferenceEquals(this.LightSensorField, value) != true)) {
                    this.LightSensorField = value;
                    this.RaisePropertyChanged("LightSensor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Wcf_Odjemalec.SmartMowerServiceReference.MotionSensor MotionSensor {
            get {
                return this.MotionSensorField;
            }
            set {
                if ((object.ReferenceEquals(this.MotionSensorField, value) != true)) {
                    this.MotionSensorField = value;
                    this.RaisePropertyChanged("MotionSensor");
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
        public int NoiseLevel {
            get {
                return this.NoiseLevelField;
            }
            set {
                if ((this.NoiseLevelField.Equals(value) != true)) {
                    this.NoiseLevelField = value;
                    this.RaisePropertyChanged("NoiseLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Power {
            get {
                return this.PowerField;
            }
            set {
                if ((this.PowerField.Equals(value) != true)) {
                    this.PowerField = value;
                    this.RaisePropertyChanged("Power");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Producer {
            get {
                return this.ProducerField;
            }
            set {
                if ((object.ReferenceEquals(this.ProducerField, value) != true)) {
                    this.ProducerField = value;
                    this.RaisePropertyChanged("Producer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Wcf_Odjemalec.SmartMowerServiceReference.RainSensor RainSensor {
            get {
                return this.RainSensorField;
            }
            set {
                if ((object.ReferenceEquals(this.RainSensorField, value) != true)) {
                    this.RainSensorField = value;
                    this.RaisePropertyChanged("RainSensor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Serial {
            get {
                return this.SerialField;
            }
            set {
                if ((object.ReferenceEquals(this.SerialField, value) != true)) {
                    this.SerialField = value;
                    this.RaisePropertyChanged("Serial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Wcf_Odjemalec.SmartMowerServiceReference.TemperatureSensor TemperatureSensor {
            get {
                return this.TemperatureSensorField;
            }
            set {
                if ((object.ReferenceEquals(this.TemperatureSensorField, value) != true)) {
                    this.TemperatureSensorField = value;
                    this.RaisePropertyChanged("TemperatureSensor");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LightSensor", Namespace="http://schemas.datacontract.org/2004/07/SmartMowerServiceLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class LightSensor : Wcf_Odjemalec.SmartMowerServiceReference.Sensor {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsLightField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsLight {
            get {
                return this.IsLightField;
            }
            set {
                if ((this.IsLightField.Equals(value) != true)) {
                    this.IsLightField = value;
                    this.RaisePropertyChanged("IsLight");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MotionSensor", Namespace="http://schemas.datacontract.org/2004/07/SmartMowerServiceLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class MotionSensor : Wcf_Odjemalec.SmartMowerServiceReference.Sensor {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsObstacleOnFrontField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsObstacleOnFront {
            get {
                return this.IsObstacleOnFrontField;
            }
            set {
                if ((this.IsObstacleOnFrontField.Equals(value) != true)) {
                    this.IsObstacleOnFrontField = value;
                    this.RaisePropertyChanged("IsObstacleOnFront");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RainSensor", Namespace="http://schemas.datacontract.org/2004/07/SmartMowerServiceLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class RainSensor : Wcf_Odjemalec.SmartMowerServiceReference.Sensor {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsRainField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsRain {
            get {
                return this.IsRainField;
            }
            set {
                if ((this.IsRainField.Equals(value) != true)) {
                    this.IsRainField = value;
                    this.RaisePropertyChanged("IsRain");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TemperatureSensor", Namespace="http://schemas.datacontract.org/2004/07/SmartMowerServiceLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class TemperatureSensor : Wcf_Odjemalec.SmartMowerServiceReference.Sensor {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TemperatureField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Temperature {
            get {
                return this.TemperatureField;
            }
            set {
                if ((this.TemperatureField.Equals(value) != true)) {
                    this.TemperatureField = value;
                    this.RaisePropertyChanged("Temperature");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sensor", Namespace="http://schemas.datacontract.org/2004/07/SmartMowerServiceLibrary.DataContracts")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wcf_Odjemalec.SmartMowerServiceReference.MotionSensor))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wcf_Odjemalec.SmartMowerServiceReference.RainSensor))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wcf_Odjemalec.SmartMowerServiceReference.TemperatureSensor))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wcf_Odjemalec.SmartMowerServiceReference.LightSensor))]
    public partial class Sensor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimestampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public System.DateTime Timestamp {
            get {
                return this.TimestampField;
            }
            set {
                if ((this.TimestampField.Equals(value) != true)) {
                    this.TimestampField = value;
                    this.RaisePropertyChanged("Timestamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseMessage", Namespace="http://schemas.datacontract.org/2004/07/SmartMowerServiceLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class ResponseMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public bool IsSuccessStatus {
            get {
                return this.IsSuccessStatusField;
            }
            set {
                if ((this.IsSuccessStatusField.Equals(value) != true)) {
                    this.IsSuccessStatusField = value;
                    this.RaisePropertyChanged("IsSuccessStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InvalidData", Namespace="http://schemas.datacontract.org/2004/07/SmartMowerServiceLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class InvalidData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErrorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public int ErrorCode {
            get {
                return this.ErrorCodeField;
            }
            set {
                if ((this.ErrorCodeField.Equals(value) != true)) {
                    this.ErrorCodeField = value;
                    this.RaisePropertyChanged("ErrorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(Name="SmartMower", ConfigurationName="SmartMowerServiceReference.SmartMower1", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface SmartMower1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetState", ReplyAction="http://tempuri.org/SmartMower/GetStateResponse")]
        Wcf_Odjemalec.SmartMowerServiceReference.SmartMower GetState();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetState", ReplyAction="http://tempuri.org/SmartMower/GetStateResponse")]
        System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.SmartMower> GetStateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetMowerRunningStatus", ReplyAction="http://tempuri.org/SmartMower/GetMowerRunningStatusResponse")]
        Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage GetMowerRunningStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetMowerRunningStatus", ReplyAction="http://tempuri.org/SmartMower/GetMowerRunningStatusResponse")]
        System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage> GetMowerRunningStatusAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/RaiseCuttingLevel", ReplyAction="http://tempuri.org/SmartMower/RaiseCuttingLevelResponse")]
        Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage RaiseCuttingLevel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/RaiseCuttingLevel", ReplyAction="http://tempuri.org/SmartMower/RaiseCuttingLevelResponse")]
        System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage> RaiseCuttingLevelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/LowerCuttingLevel", ReplyAction="http://tempuri.org/SmartMower/LowerCuttingLevelResponse")]
        Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage LowerCuttingLevel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/LowerCuttingLevel", ReplyAction="http://tempuri.org/SmartMower/LowerCuttingLevelResponse")]
        System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage> LowerCuttingLevelAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/SmartMower/SetPowerOnOff")]
        void SetPowerOnOff();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/SmartMower/SetPowerOnOff")]
        System.Threading.Tasks.Task SetPowerOnOffAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/SmartMower/SetBatteryAutoChargeOnOff")]
        void SetBatteryAutoChargeOnOff();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/SmartMower/SetBatteryAutoChargeOnOff")]
        System.Threading.Tasks.Task SetBatteryAutoChargeOnOffAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetMotionSensorData", ReplyAction="http://tempuri.org/SmartMower/GetMotionSensorDataResponse")]
        Wcf_Odjemalec.SmartMowerServiceReference.MotionSensor GetMotionSensorData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetMotionSensorData", ReplyAction="http://tempuri.org/SmartMower/GetMotionSensorDataResponse")]
        System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.MotionSensor> GetMotionSensorDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetTemperatureSensorData", ReplyAction="http://tempuri.org/SmartMower/GetTemperatureSensorDataResponse")]
        Wcf_Odjemalec.SmartMowerServiceReference.TemperatureSensor GetTemperatureSensorData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetTemperatureSensorData", ReplyAction="http://tempuri.org/SmartMower/GetTemperatureSensorDataResponse")]
        System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.TemperatureSensor> GetTemperatureSensorDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetLightSensorData", ReplyAction="http://tempuri.org/SmartMower/GetLightSensorDataResponse")]
        Wcf_Odjemalec.SmartMowerServiceReference.LightSensor GetLightSensorData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetLightSensorData", ReplyAction="http://tempuri.org/SmartMower/GetLightSensorDataResponse")]
        System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.LightSensor> GetLightSensorDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetRainSensorData", ReplyAction="http://tempuri.org/SmartMower/GetRainSensorDataResponse")]
        Wcf_Odjemalec.SmartMowerServiceReference.RainSensor GetRainSensorData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/GetRainSensorData", ReplyAction="http://tempuri.org/SmartMower/GetRainSensorDataResponse")]
        System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.RainSensor> GetRainSensorDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/SendError", ReplyAction="http://tempuri.org/SmartMower/SendErrorResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Wcf_Odjemalec.SmartMowerServiceReference.InvalidData), Action="http://tempuri.org/SmartMower/SendErrorInvalidDataFault", Name="InvalidData", Namespace="http://schemas.datacontract.org/2004/07/SmartMowerServiceLibrary.DataContracts")]
        string SendError(string verified);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartMower/SendError", ReplyAction="http://tempuri.org/SmartMower/SendErrorResponse")]
        System.Threading.Tasks.Task<string> SendErrorAsync(string verified);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SmartMower1Channel : Wcf_Odjemalec.SmartMowerServiceReference.SmartMower1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SmartMower1Client : System.ServiceModel.ClientBase<Wcf_Odjemalec.SmartMowerServiceReference.SmartMower1>, Wcf_Odjemalec.SmartMowerServiceReference.SmartMower1 {
        
        public SmartMower1Client() {
        }
        
        public SmartMower1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SmartMower1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmartMower1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmartMower1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Wcf_Odjemalec.SmartMowerServiceReference.SmartMower GetState() {
            return base.Channel.GetState();
        }
        
        public System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.SmartMower> GetStateAsync() {
            return base.Channel.GetStateAsync();
        }
        
        public Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage GetMowerRunningStatus() {
            return base.Channel.GetMowerRunningStatus();
        }
        
        public System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage> GetMowerRunningStatusAsync() {
            return base.Channel.GetMowerRunningStatusAsync();
        }
        
        public Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage RaiseCuttingLevel() {
            return base.Channel.RaiseCuttingLevel();
        }
        
        public System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage> RaiseCuttingLevelAsync() {
            return base.Channel.RaiseCuttingLevelAsync();
        }
        
        public Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage LowerCuttingLevel() {
            return base.Channel.LowerCuttingLevel();
        }
        
        public System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.ResponseMessage> LowerCuttingLevelAsync() {
            return base.Channel.LowerCuttingLevelAsync();
        }
        
        public void SetPowerOnOff() {
            base.Channel.SetPowerOnOff();
        }
        
        public System.Threading.Tasks.Task SetPowerOnOffAsync() {
            return base.Channel.SetPowerOnOffAsync();
        }
        
        public void SetBatteryAutoChargeOnOff() {
            base.Channel.SetBatteryAutoChargeOnOff();
        }
        
        public System.Threading.Tasks.Task SetBatteryAutoChargeOnOffAsync() {
            return base.Channel.SetBatteryAutoChargeOnOffAsync();
        }
        
        public Wcf_Odjemalec.SmartMowerServiceReference.MotionSensor GetMotionSensorData() {
            return base.Channel.GetMotionSensorData();
        }
        
        public System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.MotionSensor> GetMotionSensorDataAsync() {
            return base.Channel.GetMotionSensorDataAsync();
        }
        
        public Wcf_Odjemalec.SmartMowerServiceReference.TemperatureSensor GetTemperatureSensorData() {
            return base.Channel.GetTemperatureSensorData();
        }
        
        public System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.TemperatureSensor> GetTemperatureSensorDataAsync() {
            return base.Channel.GetTemperatureSensorDataAsync();
        }
        
        public Wcf_Odjemalec.SmartMowerServiceReference.LightSensor GetLightSensorData() {
            return base.Channel.GetLightSensorData();
        }
        
        public System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.LightSensor> GetLightSensorDataAsync() {
            return base.Channel.GetLightSensorDataAsync();
        }
        
        public Wcf_Odjemalec.SmartMowerServiceReference.RainSensor GetRainSensorData() {
            return base.Channel.GetRainSensorData();
        }
        
        public System.Threading.Tasks.Task<Wcf_Odjemalec.SmartMowerServiceReference.RainSensor> GetRainSensorDataAsync() {
            return base.Channel.GetRainSensorDataAsync();
        }
        
        public string SendError(string verified) {
            return base.Channel.SendError(verified);
        }
        
        public System.Threading.Tasks.Task<string> SendErrorAsync(string verified) {
            return base.Channel.SendErrorAsync(verified);
        }
    }
}
